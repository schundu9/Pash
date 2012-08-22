﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Irony.Parsing;
using StringExtensions;
using Pash.ParserIntrinsics;

namespace ParserTests
{
    [TestFixture]
    class PowerShellGrammarTests
    {
        [Test]
        public void CreateTest()
        {
            var grammar = new PowerShellGrammar.InteractiveInput();
            // obviously I know it won't be null. That's mostly to 
            // avoid the compiler warning.
            Assert.IsNotNull(grammar);
        }

        [Test]
        public void NonTerminalFieldsInitializedTest()
        {
            // created by reflection (to avoid missing one)
            // but let's make sure the reflection works
            var grammar = new PowerShellGrammar.InteractiveInput();
            Assert.IsNotNull(grammar.interactive_input);
            Assert.AreEqual("interactive_input", grammar.interactive_input.Name);
        }

        [TestFixture]
        class ParseSimpleCommandTest
        {
            ParseTree parseTree;
            PowerShellGrammar grammar;

            public ParseSimpleCommandTest()
            {
                grammar = new PowerShellGrammar.InteractiveInput();
                var parser = new Parser(grammar);

                parseTree = parser.Parse("Get-ChildItem");
            }

            [Test]
            public void SuccessfulParseTest()
            {
                Assert.IsNotNull(parseTree);
                Assert.IsFalse(parseTree.HasErrors, parseTree.ParserMessages.JoinString("\n"));
            }

            [Test]
            public void CorrectNonTerminalsTest()
            {
                var node = VerifyParseTreeSingles(parseTree.Root,
                    grammar.interactive_input,
                    grammar.script_block,
                    grammar.script_block_body,
                    grammar.statement_list,
                    grammar.statement,
                    grammar.pipeline,
                    grammar.command,
                    grammar.command_name
                );

                Assert.AreEqual(0, node.ChildNodes.Count, node.ToString());
            }
        }

        [Test]
        public void TrivialPromptExpressionsTest()
        {
            var grammar = new PowerShellGrammar.InteractiveInput();

            var parser = new Parser(grammar);
            var parseTree = parser.Parse("\"PS> \"");

            Assert.IsNotNull(parseTree);
            Assert.IsFalse(parseTree.HasErrors, parseTree.ParserMessages.JoinString("\n"));

            var node = VerifyParseTreeSingles(parseTree.Root,
                grammar.interactive_input,
                grammar.script_block,
                grammar.script_block_body,
                grammar.statement_list,
                grammar.statement,
                grammar.pipeline,
                grammar.expression,
                grammar.logical_expression,
                grammar.bitwise_expression,
                grammar.comparison_expression,
                grammar.additive_expression,
                grammar.multiplicative_expression,
                grammar.format_expression,
                grammar.array_literal_expression,
                grammar.unary_expression,
                grammar.primary_expression,
                grammar.value
            );

            Assert.AreEqual(0, node.ChildNodes.Count, node.ToString());
            Assert.AreEqual(PowerShellGrammar.Terminals.literal, node.Term);
        }

        static ParseTreeNode VerifyParseTreeSingles(ParseTreeNode node, params NonTerminal[] expected)
        {
            foreach (var rule in expected)
            {
                Assert.AreEqual(rule, node.Term);
                Assert.AreEqual(1, node.ChildNodes.Count, "wrong child count.\n" + FormatNodes(node));
                node = node.ChildNodes.Single();
            }

            return node;
        }

        static string FormatNodes(ParseTreeNode node, int indent = 1)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(new string('\t', indent));
            stringBuilder.AppendLine(node.ToString());

            foreach (var childNode in node.ChildNodes)
            {
                stringBuilder.Append(FormatNodes(childNode, indent + 1));
            }

            return stringBuilder.ToString();
        }

        [Test]
        public void DefaultPromptExpressionsTest()
        {
            var grammar = new PowerShellGrammar.InteractiveInput();

            var parser = new Parser(grammar);
            var parseTree = parser.Parse("\"PS> \" + (Get-Location)");

            Assert.IsNotNull(parseTree);
            Assert.IsFalse(parseTree.HasErrors, parseTree.ParserMessages.JoinString("\n"));

            var node = VerifyParseTreeSingles(parseTree.Root,
                grammar.interactive_input,
                grammar.script_block,
                grammar.script_block_body,
                grammar.statement_list,
                grammar.statement,
                grammar.pipeline,
                grammar.expression,
                grammar.logical_expression,
                grammar.bitwise_expression,
                grammar.comparison_expression
            );

            Assert.AreEqual(grammar.additive_expression, node.Term);
            Assert.AreEqual(3, node.ChildNodes.Count, node.ToString());

            var leftNode = node.ChildNodes[0];
            var operatorNode = node.ChildNodes[1];
            var rightNode = node.ChildNodes[2];

            {
                var leftLiteral = VerifyParseTreeSingles(leftNode,
                    grammar.additive_expression,
                    grammar.multiplicative_expression,
                    grammar.format_expression,
                    grammar.array_literal_expression,
                    grammar.unary_expression,
                    grammar.primary_expression,
                    grammar.value
                );

                Assert.AreEqual(PowerShellGrammar.Terminals.literal, leftLiteral.Term);
            }

            {
                KeywordTerminal keywordTerminal = (KeywordTerminal)operatorNode.Term;
                Assert.AreEqual("+", keywordTerminal.Text);
            }

            {
                var nodeX = VerifyParseTreeSingles(rightNode,
                    grammar.multiplicative_expression,
                    grammar.format_expression,
                    grammar.array_literal_expression,
                    grammar.unary_expression,
                    grammar.primary_expression,
                    grammar.value
                );

                Assert.AreEqual(grammar.parenthesized_expression, nodeX.Term);
                Assert.AreEqual(3, nodeX.ChildNodes.Count);

                KeywordTerminal leftParenTerminal = (KeywordTerminal)nodeX.ChildNodes[0].Term;
                Assert.AreEqual("(", leftParenTerminal.Text);

                KeywordTerminal rightParenTerminal = (KeywordTerminal)nodeX.ChildNodes[2].Term;
                Assert.AreEqual(")", rightParenTerminal.Text);

                var pipelineNode = nodeX.ChildNodes[1];

                var command_name_token = VerifyParseTreeSingles(pipelineNode,
                    grammar.pipeline,
                    grammar.command,
                    grammar.command_name
                );

                Assert.AreEqual(PowerShellGrammar.Terminals.generic_token, command_name_token.Term);
                Assert.AreEqual("Get-Location", command_name_token.FindTokenAndGetText());
            }
        }
    }
}
