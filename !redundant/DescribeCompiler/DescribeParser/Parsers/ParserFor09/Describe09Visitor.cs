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

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="Describe09Parser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public interface IDescribe09Visitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="Describe09Parser.producer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProducer([NotNull] Describe09Parser.ProducerContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Describe09Parser.text_chunk"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitText_chunk([NotNull] Describe09Parser.Text_chunkContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Describe09Parser.item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitItem([NotNull] Describe09Parser.ItemContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Describe09Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] Describe09Parser.ExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Describe09Parser.item_or_expression_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitItem_or_expression_part([NotNull] Describe09Parser.Item_or_expression_partContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Describe09Parser.item_or_expression_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitItem_or_expression_list([NotNull] Describe09Parser.Item_or_expression_listContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Describe09Parser.expression_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression_list([NotNull] Describe09Parser.Expression_listContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Describe09Parser.scripture"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScripture([NotNull] Describe09Parser.ScriptureContext context);
}
