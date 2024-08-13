//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Describe09.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public partial class Describe09Lexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		LINE_COMMENT=1, BLOCK_COMMENT=2, TAG=3, LINK=4, DECORATOR=5, HYPHEN=6, 
		RIGHT_ARROW=7, LEFT_ARROW=8, RIGHT_SQUARE=9, RIGHT_CURL=10, SEPARATOR=11, 
		TERMINATOR=12, FORWARD_SLASHES=13, FORWARD_SLASH=14, STAR=15, ESCAPE_ESCAPE=16, 
		ESCAPE_HYPHEN=17, ESCAPE_RIGHT_ARROW=18, ESCAPE_LEFT_ARROW=19, ESCAPE_RIGHT_SQUARE=20, 
		ESCAPE_LEFT_SQUARE=21, ESCAPE_RIGHT_CURL=22, ESCAPE_LEFT_CURL=23, ESCAPE_SEPARATOR=24, 
		ESCAPE_TERMINATOR=25, ESCAPE_LCOMMENT=26, ESCAPE_BCOMMENT=27, ESCAPE=28, 
		DATA=29;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"WHITESPACE", "LINESPACE", "LINE_COMMENT", "BLOCK_COMMENT", "TAG", "LINK", 
		"DECORATOR", "HYPHEN", "RIGHT_ARROW", "LEFT_ARROW", "RIGHT_SQUARE", "RIGHT_CURL", 
		"SEPARATOR", "TERMINATOR", "FORWARD_SLASHES", "FORWARD_SLASH", "STAR", 
		"ESCAPE_ESCAPE", "ESCAPE_HYPHEN", "ESCAPE_RIGHT_ARROW", "ESCAPE_LEFT_ARROW", 
		"ESCAPE_RIGHT_SQUARE", "ESCAPE_LEFT_SQUARE", "ESCAPE_RIGHT_CURL", "ESCAPE_LEFT_CURL", 
		"ESCAPE_SEPARATOR", "ESCAPE_TERMINATOR", "ESCAPE_LCOMMENT", "ESCAPE_BCOMMENT", 
		"ESCAPE", "DATA_CHAR", "DATA"
	};


	public Describe09Lexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public Describe09Lexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, null, null, null, "'-'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "LINE_COMMENT", "BLOCK_COMMENT", "TAG", "LINK", "DECORATOR", "HYPHEN", 
		"RIGHT_ARROW", "LEFT_ARROW", "RIGHT_SQUARE", "RIGHT_CURL", "SEPARATOR", 
		"TERMINATOR", "FORWARD_SLASHES", "FORWARD_SLASH", "STAR", "ESCAPE_ESCAPE", 
		"ESCAPE_HYPHEN", "ESCAPE_RIGHT_ARROW", "ESCAPE_LEFT_ARROW", "ESCAPE_RIGHT_SQUARE", 
		"ESCAPE_LEFT_SQUARE", "ESCAPE_RIGHT_CURL", "ESCAPE_LEFT_CURL", "ESCAPE_SEPARATOR", 
		"ESCAPE_TERMINATOR", "ESCAPE_LCOMMENT", "ESCAPE_BCOMMENT", "ESCAPE", "DATA"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Describe09.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static Describe09Lexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,29,349,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,1,0,1,0,1,1,1,1,1,2,1,2,1,2,1,2,1,2,
		5,2,75,8,2,10,2,12,2,78,9,2,1,2,3,2,81,8,2,1,2,1,2,5,2,85,8,2,10,2,12,
		2,88,9,2,1,2,3,2,91,8,2,1,2,1,2,1,3,1,3,1,3,1,3,5,3,99,8,3,10,3,12,3,102,
		9,3,1,3,1,3,1,3,1,3,5,3,108,8,3,10,3,12,3,111,9,3,1,3,3,3,114,8,3,1,3,
		1,3,1,4,1,4,4,4,120,8,4,11,4,12,4,121,1,4,1,4,5,4,126,8,4,10,4,12,4,129,
		9,4,1,5,1,5,5,5,133,8,5,10,5,12,5,136,9,5,1,5,1,5,5,5,140,8,5,10,5,12,
		5,143,9,5,1,6,1,6,5,6,147,8,6,10,6,12,6,150,9,6,1,6,1,6,5,6,154,8,6,10,
		6,12,6,157,9,6,1,7,1,7,1,8,1,8,5,8,163,8,8,10,8,12,8,166,9,8,1,9,1,9,5,
		9,170,8,9,10,9,12,9,173,9,9,1,10,1,10,5,10,177,8,10,10,10,12,10,180,9,
		10,1,11,1,11,5,11,184,8,11,10,11,12,11,187,9,11,1,12,1,12,5,12,191,8,12,
		10,12,12,12,194,9,12,1,13,1,13,5,13,198,8,13,10,13,12,13,201,9,13,1,14,
		1,14,1,14,1,14,5,14,207,8,14,10,14,12,14,210,9,14,1,15,1,15,5,15,214,8,
		15,10,15,12,15,217,9,15,1,16,1,16,5,16,221,8,16,10,16,12,16,224,9,16,1,
		17,1,17,1,17,1,17,5,17,230,8,17,10,17,12,17,233,9,17,1,18,1,18,1,18,1,
		18,5,18,239,8,18,10,18,12,18,242,9,18,1,19,1,19,1,19,1,19,5,19,248,8,19,
		10,19,12,19,251,9,19,1,20,1,20,1,20,1,20,5,20,257,8,20,10,20,12,20,260,
		9,20,1,21,1,21,1,21,1,21,5,21,266,8,21,10,21,12,21,269,9,21,1,22,1,22,
		1,22,1,22,5,22,275,8,22,10,22,12,22,278,9,22,1,23,1,23,1,23,1,23,5,23,
		284,8,23,10,23,12,23,287,9,23,1,24,1,24,1,24,1,24,5,24,293,8,24,10,24,
		12,24,296,9,24,1,25,1,25,1,25,1,25,5,25,302,8,25,10,25,12,25,305,9,25,
		1,26,1,26,1,26,1,26,5,26,311,8,26,10,26,12,26,314,9,26,1,27,1,27,1,27,
		1,27,1,27,5,27,321,8,27,10,27,12,27,324,9,27,1,28,1,28,1,28,1,28,1,28,
		5,28,331,8,28,10,28,12,28,334,9,28,1,29,1,29,5,29,338,8,29,10,29,12,29,
		341,9,29,1,30,1,30,1,31,4,31,346,8,31,11,31,12,31,347,5,76,100,121,134,
		148,0,32,1,0,3,0,5,1,7,2,9,3,11,4,13,5,15,6,17,7,19,8,21,9,23,10,25,11,
		27,12,29,13,31,14,33,15,35,16,37,17,39,18,41,19,43,20,45,21,47,22,49,23,
		51,24,53,25,55,26,57,27,59,28,61,0,63,29,1,0,3,11,0,9,9,11,13,32,32,133,
		133,160,160,5760,5760,8192,8202,8232,8233,8239,8239,8287,8287,12288,12288,
		10,0,9,13,32,32,133,133,160,160,5760,5760,8192,8202,8232,8233,8239,8239,
		8287,8287,12288,12288,8,0,42,42,44,45,47,47,59,60,62,62,91,93,123,123,
		125,125,381,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,
		0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,
		25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,0,31,1,0,0,0,0,33,1,0,0,0,0,35,1,
		0,0,0,0,37,1,0,0,0,0,39,1,0,0,0,0,41,1,0,0,0,0,43,1,0,0,0,0,45,1,0,0,0,
		0,47,1,0,0,0,0,49,1,0,0,0,0,51,1,0,0,0,0,53,1,0,0,0,0,55,1,0,0,0,0,57,
		1,0,0,0,0,59,1,0,0,0,0,63,1,0,0,0,1,65,1,0,0,0,3,67,1,0,0,0,5,69,1,0,0,
		0,7,94,1,0,0,0,9,117,1,0,0,0,11,130,1,0,0,0,13,144,1,0,0,0,15,158,1,0,
		0,0,17,160,1,0,0,0,19,167,1,0,0,0,21,174,1,0,0,0,23,181,1,0,0,0,25,188,
		1,0,0,0,27,195,1,0,0,0,29,202,1,0,0,0,31,211,1,0,0,0,33,218,1,0,0,0,35,
		225,1,0,0,0,37,234,1,0,0,0,39,243,1,0,0,0,41,252,1,0,0,0,43,261,1,0,0,
		0,45,270,1,0,0,0,47,279,1,0,0,0,49,288,1,0,0,0,51,297,1,0,0,0,53,306,1,
		0,0,0,55,315,1,0,0,0,57,325,1,0,0,0,59,335,1,0,0,0,61,342,1,0,0,0,63,345,
		1,0,0,0,65,66,7,0,0,0,66,2,1,0,0,0,67,68,7,1,0,0,68,4,1,0,0,0,69,70,5,
		47,0,0,70,71,5,47,0,0,71,72,5,32,0,0,72,76,1,0,0,0,73,75,9,0,0,0,74,73,
		1,0,0,0,75,78,1,0,0,0,76,77,1,0,0,0,76,74,1,0,0,0,77,90,1,0,0,0,78,76,
		1,0,0,0,79,81,5,13,0,0,80,79,1,0,0,0,80,81,1,0,0,0,81,82,1,0,0,0,82,86,
		5,10,0,0,83,85,3,3,1,0,84,83,1,0,0,0,85,88,1,0,0,0,86,84,1,0,0,0,86,87,
		1,0,0,0,87,91,1,0,0,0,88,86,1,0,0,0,89,91,5,0,0,1,90,80,1,0,0,0,90,89,
		1,0,0,0,91,92,1,0,0,0,92,93,6,2,0,0,93,6,1,0,0,0,94,95,5,47,0,0,95,96,
		5,42,0,0,96,100,1,0,0,0,97,99,9,0,0,0,98,97,1,0,0,0,99,102,1,0,0,0,100,
		101,1,0,0,0,100,98,1,0,0,0,101,113,1,0,0,0,102,100,1,0,0,0,103,104,5,42,
		0,0,104,105,5,47,0,0,105,109,1,0,0,0,106,108,3,3,1,0,107,106,1,0,0,0,108,
		111,1,0,0,0,109,107,1,0,0,0,109,110,1,0,0,0,110,114,1,0,0,0,111,109,1,
		0,0,0,112,114,5,0,0,1,113,103,1,0,0,0,113,112,1,0,0,0,114,115,1,0,0,0,
		115,116,6,3,0,0,116,8,1,0,0,0,117,119,5,60,0,0,118,120,9,0,0,0,119,118,
		1,0,0,0,120,121,1,0,0,0,121,122,1,0,0,0,121,119,1,0,0,0,122,123,1,0,0,
		0,123,127,5,62,0,0,124,126,3,3,1,0,125,124,1,0,0,0,126,129,1,0,0,0,127,
		125,1,0,0,0,127,128,1,0,0,0,128,10,1,0,0,0,129,127,1,0,0,0,130,134,5,91,
		0,0,131,133,9,0,0,0,132,131,1,0,0,0,133,136,1,0,0,0,134,135,1,0,0,0,134,
		132,1,0,0,0,135,137,1,0,0,0,136,134,1,0,0,0,137,141,5,93,0,0,138,140,3,
		3,1,0,139,138,1,0,0,0,140,143,1,0,0,0,141,139,1,0,0,0,141,142,1,0,0,0,
		142,12,1,0,0,0,143,141,1,0,0,0,144,148,5,123,0,0,145,147,9,0,0,0,146,145,
		1,0,0,0,147,150,1,0,0,0,148,149,1,0,0,0,148,146,1,0,0,0,149,151,1,0,0,
		0,150,148,1,0,0,0,151,155,5,125,0,0,152,154,3,3,1,0,153,152,1,0,0,0,154,
		157,1,0,0,0,155,153,1,0,0,0,155,156,1,0,0,0,156,14,1,0,0,0,157,155,1,0,
		0,0,158,159,5,45,0,0,159,16,1,0,0,0,160,164,5,62,0,0,161,163,3,3,1,0,162,
		161,1,0,0,0,163,166,1,0,0,0,164,162,1,0,0,0,164,165,1,0,0,0,165,18,1,0,
		0,0,166,164,1,0,0,0,167,171,5,60,0,0,168,170,3,3,1,0,169,168,1,0,0,0,170,
		173,1,0,0,0,171,169,1,0,0,0,171,172,1,0,0,0,172,20,1,0,0,0,173,171,1,0,
		0,0,174,178,5,93,0,0,175,177,3,3,1,0,176,175,1,0,0,0,177,180,1,0,0,0,178,
		176,1,0,0,0,178,179,1,0,0,0,179,22,1,0,0,0,180,178,1,0,0,0,181,185,5,125,
		0,0,182,184,3,3,1,0,183,182,1,0,0,0,184,187,1,0,0,0,185,183,1,0,0,0,185,
		186,1,0,0,0,186,24,1,0,0,0,187,185,1,0,0,0,188,192,5,44,0,0,189,191,3,
		3,1,0,190,189,1,0,0,0,191,194,1,0,0,0,192,190,1,0,0,0,192,193,1,0,0,0,
		193,26,1,0,0,0,194,192,1,0,0,0,195,199,5,59,0,0,196,198,3,3,1,0,197,196,
		1,0,0,0,198,201,1,0,0,0,199,197,1,0,0,0,199,200,1,0,0,0,200,28,1,0,0,0,
		201,199,1,0,0,0,202,203,5,47,0,0,203,204,5,47,0,0,204,208,1,0,0,0,205,
		207,3,3,1,0,206,205,1,0,0,0,207,210,1,0,0,0,208,206,1,0,0,0,208,209,1,
		0,0,0,209,30,1,0,0,0,210,208,1,0,0,0,211,215,5,47,0,0,212,214,3,3,1,0,
		213,212,1,0,0,0,214,217,1,0,0,0,215,213,1,0,0,0,215,216,1,0,0,0,216,32,
		1,0,0,0,217,215,1,0,0,0,218,222,5,42,0,0,219,221,3,3,1,0,220,219,1,0,0,
		0,221,224,1,0,0,0,222,220,1,0,0,0,222,223,1,0,0,0,223,34,1,0,0,0,224,222,
		1,0,0,0,225,226,5,92,0,0,226,227,5,92,0,0,227,231,1,0,0,0,228,230,3,3,
		1,0,229,228,1,0,0,0,230,233,1,0,0,0,231,229,1,0,0,0,231,232,1,0,0,0,232,
		36,1,0,0,0,233,231,1,0,0,0,234,235,5,92,0,0,235,236,5,45,0,0,236,240,1,
		0,0,0,237,239,3,3,1,0,238,237,1,0,0,0,239,242,1,0,0,0,240,238,1,0,0,0,
		240,241,1,0,0,0,241,38,1,0,0,0,242,240,1,0,0,0,243,244,5,92,0,0,244,245,
		5,62,0,0,245,249,1,0,0,0,246,248,3,3,1,0,247,246,1,0,0,0,248,251,1,0,0,
		0,249,247,1,0,0,0,249,250,1,0,0,0,250,40,1,0,0,0,251,249,1,0,0,0,252,253,
		5,92,0,0,253,254,5,60,0,0,254,258,1,0,0,0,255,257,3,3,1,0,256,255,1,0,
		0,0,257,260,1,0,0,0,258,256,1,0,0,0,258,259,1,0,0,0,259,42,1,0,0,0,260,
		258,1,0,0,0,261,262,5,92,0,0,262,263,5,93,0,0,263,267,1,0,0,0,264,266,
		3,3,1,0,265,264,1,0,0,0,266,269,1,0,0,0,267,265,1,0,0,0,267,268,1,0,0,
		0,268,44,1,0,0,0,269,267,1,0,0,0,270,271,5,92,0,0,271,272,5,91,0,0,272,
		276,1,0,0,0,273,275,3,3,1,0,274,273,1,0,0,0,275,278,1,0,0,0,276,274,1,
		0,0,0,276,277,1,0,0,0,277,46,1,0,0,0,278,276,1,0,0,0,279,280,5,92,0,0,
		280,281,5,125,0,0,281,285,1,0,0,0,282,284,3,3,1,0,283,282,1,0,0,0,284,
		287,1,0,0,0,285,283,1,0,0,0,285,286,1,0,0,0,286,48,1,0,0,0,287,285,1,0,
		0,0,288,289,5,92,0,0,289,290,5,123,0,0,290,294,1,0,0,0,291,293,3,3,1,0,
		292,291,1,0,0,0,293,296,1,0,0,0,294,292,1,0,0,0,294,295,1,0,0,0,295,50,
		1,0,0,0,296,294,1,0,0,0,297,298,5,92,0,0,298,299,5,44,0,0,299,303,1,0,
		0,0,300,302,3,3,1,0,301,300,1,0,0,0,302,305,1,0,0,0,303,301,1,0,0,0,303,
		304,1,0,0,0,304,52,1,0,0,0,305,303,1,0,0,0,306,307,5,92,0,0,307,308,5,
		59,0,0,308,312,1,0,0,0,309,311,3,3,1,0,310,309,1,0,0,0,311,314,1,0,0,0,
		312,310,1,0,0,0,312,313,1,0,0,0,313,54,1,0,0,0,314,312,1,0,0,0,315,316,
		5,92,0,0,316,317,5,47,0,0,317,318,5,47,0,0,318,322,1,0,0,0,319,321,3,3,
		1,0,320,319,1,0,0,0,321,324,1,0,0,0,322,320,1,0,0,0,322,323,1,0,0,0,323,
		56,1,0,0,0,324,322,1,0,0,0,325,326,5,92,0,0,326,327,5,47,0,0,327,328,5,
		42,0,0,328,332,1,0,0,0,329,331,3,3,1,0,330,329,1,0,0,0,331,334,1,0,0,0,
		332,330,1,0,0,0,332,333,1,0,0,0,333,58,1,0,0,0,334,332,1,0,0,0,335,339,
		5,92,0,0,336,338,3,3,1,0,337,336,1,0,0,0,338,341,1,0,0,0,339,337,1,0,0,
		0,339,340,1,0,0,0,340,60,1,0,0,0,341,339,1,0,0,0,342,343,8,2,0,0,343,62,
		1,0,0,0,344,346,3,61,30,0,345,344,1,0,0,0,346,347,1,0,0,0,347,345,1,0,
		0,0,347,348,1,0,0,0,348,64,1,0,0,0,37,0,76,80,86,90,100,109,113,121,127,
		134,141,148,155,164,171,178,185,192,199,208,215,222,231,240,249,258,267,
		276,285,294,303,312,322,332,339,347,1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
