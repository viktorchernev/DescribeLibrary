﻿using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using DescribeParser.Visitors;
using System.Diagnostics;

namespace DescribeParser.IntegrationTests
{
    internal class ParserTestsFor06 : ParserTestsBase
    {
        public static string outputDir = @"C:\Users\Viktor Chernev\Desktop\ANTLRd\testing\IntegrationTestingResults\v06";



        /// <summary>
        /// Preprocessor method for 06
        /// </summary>
        static string PredictTerminators(string text)
        {
            AntlrInputStream inputstream = new AntlrInputStream(text);
            Describe06Lexer lexer = new Describe06Lexer(inputstream);
            CommonTokenStream tokenstream = new CommonTokenStream(lexer);
            tokenstream.Fill();

            //auto-closer
            bool wasHyphen = false;
            int counter = 0;
            var tokenList = tokenstream.GetTokens();
            foreach (var token in tokenList)
            {
                int tokenType = token.Type;
                string type = GetTokenType(tokenType);
                if (type == "HYPHEN") wasHyphen = true;
                else
                {
                    if (type == "RIGHT_ARROW" && wasHyphen) counter++;
                    else if (type == "TERMINATOR") counter--;
                    wasHyphen = false;
                }
            }

            //we want to be creating tokens `Antlr4.Runtime.CommonToken` and passing
            //the same token list as token stream or smth, and not having to run the
            //lexer again later on.
            //var li = tokenList[26];
            //Type t = li.GetType();
            //var options = new JsonSerializerOptions { WriteIndented = true };
            //string json = JsonSerializer.Serialize(t, options);
            //var tokenList = tokenstream.GetTokens();
            //int index = GetTokenTypeIndex("TERMINATOR");

            //insert at correct index.
            //we do this because there might be a thrilling comment in our file.
            if (counter < 1) return text;
            string tail = new string(';', counter);
            int insertionIndex = tokenList[tokenList.Count - 2].StopIndex;
            string output = text;
            if (insertionIndex == text.Length - 1) output += tail;
            else output = output.Insert(insertionIndex + 1, tail);
            return output;
        }


        internal static void TestFiles(bool pressKey = true, bool insertMissingTerminators = true)
        {
            //set console
            Console.ForegroundColor = ConsoleColor.White;

            //get result templates
            string outputdir = outputDir;
            string resultTemplateA = getEmbeddedResource(
                "DescribeParser.IntegrationTests.TestFiles.resultTemplates.template_basic_a.md");
            string resultTemplateB = getEmbeddedResource(
                "DescribeParser.IntegrationTests.TestFiles.resultTemplates.template_basic_b.md");

            //delete all ".md" files in the directory
            string[] files = Directory.GetFiles(outputdir, "*.md");
            foreach (string file in files) File.Delete(file);

            //get test files
            var names = getEmbeddedResoucesNames();
            foreach (string name in names)
            {
                if (name.StartsWith("DescribeParser.IntegrationTests.TestFiles.TestFilesFor06") == false) continue;
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Starting a parse operation on '" + name + "'" + Environment.NewLine);

                //get source code to test
                string text = getEmbeddedResource(name);
                if (insertMissingTerminators) text = PredictTerminators(text);

                //construct parser
                AntlrInputStream inputstream = new AntlrInputStream(text);
                Describe06Lexer lexer = new Describe06Lexer(inputstream);
                CommonTokenStream tokenstream = new CommonTokenStream(lexer);
                Describe06Parser parser = new Describe06Parser(tokenstream);

                //set timer
                Stopwatch fullwatch = new Stopwatch();
                fullwatch.Start();

                //parse
                Describe06Parser.ScriptureContext scriptureContext = parser.scripture();
                LogVisitor06 visitor = new LogVisitor06();
                visitor.Visit(scriptureContext);
                string tree = visitor.Log;
                fullwatch.Stop();

                //IDK really why this is
                parser.BuildParseTree = true;
                ParseInfo pinfo = parser.ParseInfo;

                //get text
                string result = resultTemplateA;
                result += text + resultTemplateB;
                result += Environment.NewLine + tree;

                //get save name
                string[] sep = name.Split('.');
                string filename = sep[sep.Length - 2] + ".md";
                if (visitor.LastError != null)
                {
                    filename = "~" + filename;
                }
                filename = Path.Combine(outputdir, filename);
                File.WriteAllText(filename, result);

                Console.WriteLine("-------------------------------------------------");
                if (visitor.LastError == null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    TimeSpan elapsed = fullwatch.Elapsed;
                    string formattedElapsedTime = string.Format("{0:0}.{1:000} seconds", elapsed.TotalSeconds, elapsed.Milliseconds);
                    Console.WriteLine("Success! - took: " + formattedElapsedTime);
                    Console.WriteLine("Press any key to continue.");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (pressKey) Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fail!");
                    Console.WriteLine("Press any key to continue.");
                    Console.ForegroundColor = ConsoleColor.White;
                    if(pressKey) Console.ReadLine();
                }
            }

            //press key to exit
            Console.WriteLine("");
            Console.WriteLine("Tests concluded. Press any key to exit.");
            if (pressKey) Console.ReadLine();
        }
        internal static void TestFile(string embeddedName, bool insertMissingTerminators = true)
        {
            //set console
            Console.ForegroundColor = ConsoleColor.White;

            //get result templates
            string outputdir = outputDir;
            string resultTemplateA = getEmbeddedResource(
                "DescribeParser.IntegrationTests.TestFiles.resultTemplates.template_basic_a.md");
            string resultTemplateB = getEmbeddedResource(
                "DescribeParser.IntegrationTests.TestFiles.resultTemplates.template_basic_b.md");

            //get source code to test 
            string text = getEmbeddedResource(embeddedName);
            if (insertMissingTerminators) text = PredictTerminators(text);

            //construct parser
            AntlrInputStream inputstream = new AntlrInputStream(text);
            Describe06Lexer lexer = new Describe06Lexer(inputstream);
            CommonTokenStream tokenstream = new CommonTokenStream(lexer);

            //test lexer
            tokenstream.Fill();
            foreach (var token in tokenstream.GetTokens())
            {
                int tokenType = token.Type;
                string tokenText = token.Text;
                Console.WriteLine("T(" + GetTokenType(tokenType) + "|'" + ReplaceWhitespaceE(tokenText) + "')");
            }
            Console.WriteLine();

            //construct parser
            inputstream = new AntlrInputStream(text);
            lexer = new Describe06Lexer(inputstream);
            tokenstream = new CommonTokenStream(lexer);
            Describe06Parser parser = new Describe06Parser(tokenstream);

            //parse
            Describe06Parser.ScriptureContext scriptureContext = parser.scripture();
            LogVisitor06 visitor = new LogVisitor06();
            visitor.Visit(scriptureContext);
            string tree = visitor.Log;

            //IDK really why this is
            parser.BuildParseTree = true;
            ParseInfo pinfo = parser.ParseInfo;

            //get text
            string result = resultTemplateA;
            result += text + resultTemplateB;
            result += Environment.NewLine + tree;

            //get save name
            string[] sep = embeddedName.Split('.');
            string filename = sep[sep.Length - 2] + ".md";
            if (visitor.LastError != null)
            {
                filename = "~" + filename;
            }
            filename = Path.Combine(outputdir, filename);
            File.WriteAllText(filename, result);

            Console.WriteLine("-------------------------------------------------");
            if (visitor.LastError == null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Success!");
                Console.WriteLine("Press any key to exit.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fail!");
                Console.WriteLine("Press any key to exit.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
            }
        }


        //embeddedFileName = "DescribeParser.IntegrationTests.TestFiles.TestFilesFor06.A_basic1.ds";
        internal static void TestLexer(string embeddedFileName)
        {
            //get source code to test
            string text = getEmbeddedResource(embeddedFileName);

            //construct lexer
            AntlrInputStream inputstream = new AntlrInputStream(text);
            Describe06Lexer lexer = new Describe06Lexer(inputstream);
            CommonTokenStream tokenstream = new CommonTokenStream(lexer);

            //test lexer
            tokenstream.Fill();
            foreach (var token in tokenstream.GetTokens())
            {
                int tokenType = token.Type;
                string tokenText = token.Text;
                Console.WriteLine("T(" + GetTokenType(tokenType) + "|'" + ReplaceWhitespaceE(tokenText) + "')");
            }
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
            return;
        }
        internal static void TestParser(string embeddedFileName)
        {
            //set console
            Console.ForegroundColor = ConsoleColor.White;

            //get source code to test
            string text = getEmbeddedResource(embeddedFileName);

            //construct parser
            AntlrInputStream inputstream = new AntlrInputStream(text);
            Describe06Lexer lexer = new Describe06Lexer(inputstream);
            CommonTokenStream tokenstream = new CommonTokenStream(lexer);
            Describe06Parser parser = new Describe06Parser(tokenstream);

            //parse
            Describe06Parser.ScriptureContext scriptureContext = parser.scripture();
            LogVisitor06 visitor = new LogVisitor06();
            visitor.Visit(scriptureContext);
            string tree = visitor.Log;

            //IDK really why this is
            parser.BuildParseTree = true;
            ParseInfo pinfo = parser.ParseInfo;

            //press key to exit
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }


        static string GetTokenType(int tokenType)
        {
            //an alternative (possibly slower)
            //another alternative is to manually thanslate those values
            //in a switch statement, with values we can know by looking
            //in the generated lexer source code. However, the problem
            //is that it won't universal like its now.
            return Describe06Lexer.DefaultVocabulary.GetSymbolicName(tokenType);
        }
        static int GetTokenTypeIndex(string tokenName)
        {
            var i = 1;
            while (true)
            {
                var nameIndex = Describe06Lexer.DefaultVocabulary.GetSymbolicName(i);
                if (nameIndex == null) return -1;
                if (nameIndex == tokenName) return i;
                i++;
            }
        }
    }
}