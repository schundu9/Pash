using System;
using System.Linq;
using System.Management.Automation.Language;
using System.Reflection;
using Extensions.String;
using Irony.Parsing;
using System.Globalization;
using System.Text.RegularExpressions;
using Irony;

namespace Pash.ParserIntrinsics
{
    ////////
    // PowerShell Language Syntactic Grammar, as presented in the PowerShell Language Specification[1], Appendix B.2
    //
    // [1]: http://www.microsoft.com/en_us/download/details.aspx?id=9706
    ///////

    public partial class PowerShellGrammar : CaseInsensitiveGrammar
    {

        public readonly NonTerminal new_lines_opt = null; // Initialized by reflection.

        #region B.1 Lexical grammar
        #region B.1.8 Literals
        public readonly NonTerminal literal = null; // Initialized by reflection
        public readonly NonTerminal integer_literal = null; // Initialized by reflection
        public readonly NonTerminal string_literal = null; // Initialized by reflection
        #endregion
        #endregion

        #region B.2 Syntactic grammar

        #region B.2.1 Basic concepts
        public readonly NonTerminal script_file = null; // Initialized by reflection.
        public readonly NonTerminal module_file = null; // Initialized by reflection.
        public readonly NonTerminal interactive_input = null; // Initialized by reflection.
        public readonly NonTerminal data_file = null; // Initialized by reflection.
        #endregion

        #region B.2.2 Statements
        public readonly NonTerminal script_block = null; // Initialized by reflection.
        public readonly NonTerminal param_block = null; // Initialized by reflection.
        public readonly NonTerminal parameter_list = null; // Initialized by reflection.
        public readonly NonTerminal script_parameter = null; // Initialized by reflection.
        public readonly NonTerminal script_parameter_default = null; // Initialized by reflection.
        public readonly NonTerminal script_block_body = null; // Initialized by reflection.
        public readonly NonTerminal named_block_list = null; // Initialized by reflection.
        public readonly NonTerminal named_block = null; // Initialized by reflection.
        public readonly NonTerminal block_name = null; // Initialized by reflection.
        public readonly NonTerminal statement_block = null; // Initialized by reflection.
        public readonly NonTerminal statement_list = null; // Initialized by reflection.
        public readonly NonTerminal statement = null; // Initialized by reflection.
        public readonly NonTerminal _statement_labeled_statement = null; // Initialized by reflection.
        public readonly NonTerminal _statement_flow_control_statement = null; // Initialized by reflection.
        public readonly NonTerminal _statement_pipeline = null; // Initialized by reflection.
        public readonly NonTerminal statement_terminator = null; // Initialized by reflection.
        public readonly NonTerminal statement_terminators = null; // Initialized by reflection.
        public readonly NonTerminal if_statement = null; // Initialized by reflection.
        public readonly NonTerminal elseif_clauses = null; // Initialized by reflection.
        public readonly NonTerminal elseif_clause = null; // Initialized by reflection.
        public readonly NonTerminal else_clause = null; // Initialized by reflection.
        public readonly NonTerminal labeled_statement = null; // Initialized by reflection.
        public readonly NonTerminal switch_statement = null; // Initialized by reflection.
        public readonly NonTerminal switch_parameters = null; // Initialized by reflection.
        public readonly NonTerminal switch_parameter = null; // Initialized by reflection.
        public readonly NonTerminal switch_condition = null; // Initialized by reflection.
        public readonly NonTerminal _switch_condition_pipeline = null; // Initialized by reflection.
        public readonly NonTerminal _switch_condition_file = null; // Initialized by reflection.
        public readonly NonTerminal switch_filename = null; // Initialized by reflection.
        public readonly NonTerminal switch_body = null; // Initialized by reflection.
        public readonly NonTerminal switch_clauses = null; // Initialized by reflection.
        public readonly NonTerminal switch_clause = null; // Initialized by reflection.
        public readonly NonTerminal switch_clause_condition = null; // Initialized by reflection.
        public readonly NonTerminal foreach_statement = null; // Initialized by reflection.
        public readonly NonTerminal for_statement = null; // Initialized by reflection.
        public readonly NonTerminal _for_statement_1 = null; // Initialized by reflection.
        public readonly NonTerminal _for_statement_2 = null; // Initialized by reflection.
        public readonly NonTerminal _for_statement_3 = null; // Initialized by reflection.
        public readonly NonTerminal for_initializer = null; // Initialized by reflection.
        public readonly NonTerminal for_condition = null; // Initialized by reflection.
        public readonly NonTerminal for_iterator = null; // Initialized by reflection.
        public readonly NonTerminal while_statement = null; // Initialized by reflection.
        public readonly NonTerminal do_statement = null; // Initialized by reflection.
        public readonly NonTerminal _do_statement_while = null; // Initialized by reflection.
        public readonly NonTerminal _do_statement_until = null; // Initialized by reflection.
        public readonly NonTerminal while_condition = null; // Initialized by reflection.
        public readonly NonTerminal function_statement = null; // Initialized by reflection.
        public readonly NonTerminal function_name = null; // Initialized by reflection.
        public readonly NonTerminal function_parameter_declaration = null; // Initialized by reflection.
        public readonly NonTerminal flow_control_statement = null; // Initialized by reflection.
        public readonly NonTerminal _flow_control_statement_break = null; // Initialized by reflection.
        public readonly NonTerminal _flow_control_statement_continue = null; // Initialized by reflection.
        public readonly NonTerminal _flow_control_statement_throw = null; // Initialized by reflection.
        public readonly NonTerminal _flow_control_statement_return = null; // Initialized by reflection.
        public readonly NonTerminal _flow_control_statement_exit = null; // Initialized by reflection.
        public readonly NonTerminal label_expression = null; // Initialized by reflection.
        public readonly NonTerminal trap_statement = null; // Initialized by reflection.
        public readonly NonTerminal try_statement = null; // Initialized by reflection.
        public readonly NonTerminal _try_statement_catch = null; // Initialized by reflection.
        public readonly NonTerminal _try_statement_finally = null; // Initialized by reflection.
        public readonly NonTerminal _try_statement_catch_finally = null; // Initialized by reflection.
        public readonly NonTerminal catch_clauses = null; // Initialized by reflection.
        public readonly NonTerminal catch_clause = null; // Initialized by reflection.
        public readonly NonTerminal catch_type_list = null; // Initialized by reflection.
        public readonly NonTerminal finally_clause = null; // Initialized by reflection.
        public readonly NonTerminal data_statement = null; // Initialized by reflection.
        public readonly NonTerminal data_name = null; // Initialized by reflection.
        public readonly NonTerminal data_commands_allowed = null; // Initialized by reflection.
        public readonly NonTerminal data_commands_list = null; // Initialized by reflection.
        public readonly NonTerminal data_command = null; // Initialized by reflection.
        public readonly NonTerminal pipeline = null; // Initialized by reflection.
        public readonly NonTerminal _pipeline_expression = null; // Initialized by reflection.
        public readonly NonTerminal _pipeline_command = null; // Initialized by reflection.
        public readonly NonTerminal assignment_expression = null; // Initialized by reflection.
        public readonly NonTerminal pipeline_tail = null; // Initialized by reflection.
        public readonly NonTerminal command = null; // Initialized by reflection.
        public readonly NonTerminal _command_simple = null; // Initialized by reflection.
        public readonly NonTerminal _command_invocation = null; // Initialized by reflection.
        public readonly NonTerminal command_invocation_operator = null; // Initialized by reflection.
        public readonly NonTerminal command_module = null; // Initialized by reflection.
        public readonly NonTerminal command_name = null; // Initialized by reflection.
        public readonly NonTerminal generic_token_with_subexpr = null; // Initialized by reflection.
        public readonly NonTerminal command_name_expr = null; // Initialized by reflection.
        public readonly NonTerminal command_elements = null; // Initialized by reflection.
        public readonly NonTerminal command_elements_opt = null; // Initialized by reflection.
        public readonly NonTerminal command_element = null; // Initialized by reflection.
        public readonly NonTerminal command_argument = null; // Initialized by reflection.
        public readonly NonTerminal redirections = null; // Initialized by reflection.
        public readonly NonTerminal redirection = null; // Initialized by reflection.
        public readonly NonTerminal _redirection_error_to_output = null; // Initialized by reflection.
        public readonly NonTerminal _redirection_reserved = null; // Initialized by reflection.
        public readonly NonTerminal redirected_file_name = null; // Initialized by reflection.
        #endregion

        #region B.2.3 Expressions
        public readonly NonTerminal expression = null; // Initialized by reflection.
        public readonly NonTerminal logical_expression = null; // Initialized by reflection.
        public readonly NonTerminal bitwise_expression = null; // Initialized by reflection.
        public readonly NonTerminal comparison_expression = null; // Initialized by reflection.
        public readonly NonTerminal additive_expression = null; // Initialized by reflection.
        public readonly NonTerminal multiplicative_expression = null; // Initialized by reflection.
        public readonly NonTerminal format_expression = null; // Initialized by reflection.
        public readonly NonTerminal range_expression = null; // Initialized by reflection.
        public readonly NonTerminal array_literal_expression = null; // Initialized by reflection.
        public readonly NonTerminal unary_expression = null; // Initialized by reflection.
        public readonly NonTerminal expression_with_unary_operator = null; // Initialized by reflection.
        public readonly NonTerminal pre_increment_expression = null; // Initialized by reflection.
        public readonly NonTerminal pre_decrement_expression = null; // Initialized by reflection.
        public readonly NonTerminal cast_expression = null; // Initialized by reflection.
        public readonly NonTerminal primary_expression = null; // Initialized by reflection.
        public readonly NonTerminal value = null; // Initialized by reflection.
        public readonly NonTerminal parenthesized_expression = null; // Initialized by reflection.
        public readonly NonTerminal sub_expression = null; // Initialized by reflection.
        public readonly NonTerminal array_expression = null; // Initialized by reflection.
        public readonly NonTerminal script_block_expression = null; // Initialized by reflection.
        public readonly NonTerminal hash_literal_expression = null; // Initialized by reflection.
        public readonly NonTerminal hash_literal_body = null; // Initialized by reflection.
        public readonly NonTerminal hash_entry = null; // Initialized by reflection.
        public readonly NonTerminal key_expression = null; // Initialized by reflection.
        public readonly NonTerminal post_increment_expression = null; // Initialized by reflection.
        public readonly NonTerminal post_decrement_expression = null; // Initialized by reflection.
        public readonly NonTerminal member_access = null; // Initialized by reflection.
        public readonly NonTerminal element_access = null; // Initialized by reflection.
        public readonly NonTerminal invocation_expression = null; // Initialized by reflection.
        public readonly NonTerminal argument_list = null; // Initialized by reflection.
        public readonly NonTerminal argument_expression_list = null; // Initialized by reflection.
        public readonly NonTerminal argument_expression = null; // Initialized by reflection.
        public readonly NonTerminal logical_argument_expression = null; // Initialized by reflection.
        public readonly NonTerminal bitwise_argument_expression = null; // Initialized by reflection.
        public readonly NonTerminal comparison_argument_expression = null; // Initialized by reflection.
        public readonly NonTerminal additive_argument_expression = null; // Initialized by reflection.
        public readonly NonTerminal multiplicative_argument_expression = null; // Initialized by reflection.
        public readonly NonTerminal format_argument_expression = null; // Initialized by reflection.
        public readonly NonTerminal range_argument_expression = null; // Initialized by reflection.
        public readonly NonTerminal member_name = null; // Initialized by reflection.
        public readonly NonTerminal string_literal_with_subexpression = null; // Initialized by reflection.
        public readonly NonTerminal expandable_string_literal_with_subexpr = null; // Initialized by reflection.
        public readonly NonTerminal expandable_string_with_subexpr_characters = null; // Initialized by reflection.
        public readonly NonTerminal expandable_string_with_subexpr_part = null; // Initialized by reflection.
        public readonly NonTerminal expandable_here_string_with_subexpr_characters = null; // Initialized by reflection.
        public readonly NonTerminal expandable_here_string_with_subexpr_part = null; // Initialized by reflection.
        public readonly NonTerminal type_literal = null; // Initialized by reflection.
        public readonly NonTerminal type_spec = null; // Initialized by reflection.
        public readonly NonTerminal _type_spec_array = null; // Initialized by reflection.
        public readonly NonTerminal _type_spec_generic = null; // Initialized by reflection.
        public readonly NonTerminal dimension = null; // Initialized by reflection.
        public readonly NonTerminal generic_type_arguments = null; // Initialized by reflection.
        #endregion

        #region B.2.4 Attributes
        public readonly NonTerminal attribute_list = null; // Initialized by reflection.
        public readonly NonTerminal attribute = null; // Initialized by reflection.
        public readonly NonTerminal attribute_name = null; // Initialized by reflection.
        public readonly NonTerminal attribute_arguments = null; // Initialized by reflection.
        public readonly NonTerminal attribute_argument = null; // Initialized by reflection.
        #endregion
        #endregion

        class ScriptFile : PowerShellGrammar
        {
            public ScriptFile()
            {
                Root = this.script_file;
            }
        }

        class ModuleFile : PowerShellGrammar
        {
            public ModuleFile()
            {
                Root = this.module_file;
            }
        }

        class InteractiveInput : PowerShellGrammar
        {
            public InteractiveInput()
            {
                Root = this.interactive_input;
            }
        }

        class DataFile : PowerShellGrammar
        {
            public DataFile()
            {
                Root = this.data_file;
            }
        }

        PowerShellGrammar()
        {
            InitializeTerminalFields();
            InitializeNonTerminalFields();

            // delegate to a new method, so we don't accidentally overwrite a readonly field.
            BuildProductionRules();
        }

        static Parser parser = new Parser(new InteractiveInput());

        public class ParseException : Exception
        {
            public readonly LogMessage LogMessage;

            public ParseException(LogMessage logMessage)
            {
                this.LogMessage = logMessage;
            }
        }

        public static ScriptBlockAst ParseInteractiveInput(string input)
        {
            var parseTree = parser.Parse(input);

            if (parseTree.HasErrors())
            {
                throw new ParseException(parseTree.ParserMessages.First());
            }

            return new AstBuilder((PowerShellGrammar)parser.Language.Grammar).BuildInteractiveInputAst(parseTree.Root);
        }

        public override void OnLanguageDataConstructed(LanguageData language)
        {
            if (language.ErrorLevel != GrammarErrorLevel.NoError) throw new Exception(language.ErrorLevel.ToString());
        }

        public void BuildProductionRules()
        {
            // convenient `_opt` rules
            new_lines_opt.Rule = new_lines | Empty;
            new_lines_opt.SetFlag(TermFlags.IsTransient);

            #region B.1 Lexical grammar
            // this was presented as part of the lexical grammar, but I'd rather see this as production rules than 
            // as regex patterns.

            #region B.1.8 Literals
            ////        literal:
            ////            integer_literal
            ////            real_literal
            ////            string_literal
            literal.Rule =
                integer_literal
                |
                real_literal
                |
                string_literal
                ;

            ////        integer_literal:
            ////            decimal_integer_literal
            ////            hexadecimal_integer_literal
            integer_literal.Rule =
                decimal_integer_literal
                |
                hexadecimal_integer_literal
                ;

            ////        real-literal:
            ////            decimal-digits   .   decimal-digits   exponent-partopt   decimal-type-suffixopt   numeric-multiplieropt
            ////            .   decimal-digits   exponent-partopt   decimal-type-suffixopt   numeric-multiplieropt
            ////            decimal-digits   exponent-part  decimal-type-suffixopt   numeric-multiplieropt
            ////
            ////            exponent-part:
            ////                "e"   sign_opt   decimal-digits
            ////
            ////            sign:   one of
            ////                "+"
            ////                dash
            ////
            ////            decimal-type-suffix:
            ////                "d"

            ////        string_literal:
            ////            expandable_string_literal
            ////            expandable_here_string_literal
            ////            verbatim_string_literal
            ////            verbatim_here_string_literal
            string_literal.Rule =
                expandable_string_literal
                |
                verbatim_string_literal
                ;
            #endregion
            #endregion

            #region B.2 Syntactic grammar

            #region B.2.1 Basic concepts
            ////        script_file:
            ////            script_block
            ////        module_file:
            ////            script_block

            ////        interactive_input:
            ////            script_block
            interactive_input.Rule =
                script_block;

            ////        data_file:
            ////            statement_list
            #endregion

            #region B.2.2 Statements
            ////        script_block:
            ////            param_block_opt   statement_terminators_opt    script_block_body_opt
            script_block.Rule =
                (param_block | Empty) + (statement_terminators | Empty) + (script_block_body | Empty);

            ////        param_block:
            ////            new_lines_opt   attribute_list_opt   new_lines_opt   param   new_lines_opt
            ////                    (   parameter_list_opt   new_lines_opt   )
            param_block.Rule =
                /* new_lines_opt + TODO: https://github.com/JayBazuzi/Pash2/issues/11 (attribute_list | Empty) + new_lines_opt + */ "param" + new_lines_opt
                        + "(" + (parameter_list | Empty) + new_lines_opt + ")";

            ////        parameter_list:
            ////            script_parameter
            ////            parameter_list   new_lines_opt   ,   script_parameter
            parameter_list.Rule =
                MakePlusRule(parameter_list, (new_lines_opt + ","), script_parameter);

            ////        script_parameter:
            ////            new_lines_opt   attribute_list_opt   new_lines_opt   variable   script_parameter_default_opt
            script_parameter.Rule =
                new_lines_opt + /* TODO: https://github.com/JayBazuzi/Pash2/issues/11 (attribute_list | Empty) + new_lines_opt + */ variable + (script_parameter_default | Empty);

            ////        script_parameter_default:
            ////            new_lines_opt   =   new_lines_opt   expression
            script_parameter_default.Rule =
                new_lines_opt + "=" + new_lines_opt + expression;

            ////        script_block_body:
            ////            named_block_list
            ////            statement_list
            script_block_body.Rule =
                named_block_list
                |
                statement_list
                ;

            ////        named_block_list:
            ////            named_block
            ////            named_block_list   named_block
            named_block_list.Rule =
                MakePlusRule(named_block_list, named_block);

            ////        named_block:
            ////            block_name   statement_block   statement_terminators_opt
            named_block.Rule =
                block_name + statement_block + (statement_terminators | Empty);

            ////        block_name:  one of
            ////            dynamicparam   begin   process   end
            block_name.Rule =
                ToTerm("dynamicparam") | "begin" | "process" | "end";

            ////        statement_block:
            ////            new_lines_opt   {   statement_list_opt   new_lines_opt   }
            statement_block.Rule =
                new_lines_opt + "{" + (statement_list | Empty) + new_lines_opt + "}";

#if false
            ////        statement_list:
            ////            statement
            ////            statement_list   statement
            statement_list.Rule = MakePlusRule(statement_list, statement);
#else
            // There's a bug in the language spec here. See https://github.com/JayBazuzi/Pash2/issues/7
            statement_list.Rule =
                MakeListRule(statement_list, statement_terminators, statement, TermListOptions.AllowTrailingDelimiter | TermListOptions.PlusList);
#endif

            ////        statement:
            ////            if_statement
            ////            label_opt   labeled_statement
            ////            function_statement
            ////            flow_control_statement   statement_terminator
            ////            trap_statement
            ////            try_statement
            ////            data_statement
            ////            pipeline   statement_terminator
            // The spec doesn't define `label`. I'm using `simple_name` for that purpose.
            statement.Rule =
                if_statement
                |
                _statement_labeled_statement
                |
                function_statement
                |
                _statement_flow_control_statement
                |
                trap_statement
                |
                try_statement
                |
                data_statement
                |
                _statement_pipeline
                ;

            _statement_labeled_statement.Rule =
                (label | Empty) + labeled_statement;

            // See https://github.com/JayBazuzi/Pash2/issues/7
            _statement_flow_control_statement.Rule =
                flow_control_statement /*+ (statement_terminator | Empty)*/;

            // See https://github.com/JayBazuzi/Pash2/issues/7
            _statement_pipeline.Rule =
                pipeline /*+ (statement_terminator | Empty)*/;

            ////        statement_terminator:
            ////            ;
            ////            new_line_character
            var semicolon = ToTerm(";");
            semicolon.SetFlag(TermFlags.IsTransient);

            statement_terminator.Rule =
                semicolon
                |
                new_line_character
                ;
            MarkTransient(statement_terminator);

            ////        statement_terminators:
            ////            statement_terminator
            ////            statement_terminators   statement_terminator
            statement_terminators.Rule =
                MakePlusRule(statement_terminators, statement_terminator);

            ////        if_statement:
            ////            if   new_lines_opt   (   new_lines_opt   pipeline   new_lines_opt   )   statement_block elseif_clauses_opt   else_clause_opt
            if_statement.Rule =
                "if" + new_lines_opt + "(" + new_lines_opt + pipeline + new_lines_opt + ")" + statement_block + (elseif_clauses | Empty) + (else_clause + Empty);

            ////        elseif_clauses:
            ////            elseif_clause
            ////            elseif_clauses   elseif_clause
            elseif_clauses.Rule =
                MakePlusRule(elseif_clauses, elseif_clause);

            ////        elseif_clause:
            ////            new_lines_opt   elseif   new_lines_opt   (   new_lines_opt   pipeline   new_lines_opt   )   statement_block
            elseif_clause.Rule =
                new_lines_opt + "elseif" + new_lines_opt + "(" + new_lines_opt + pipeline + new_lines_opt + ")" + statement_block;

            ////        else_clause:
            ////            new_lines_opt   else   statement_block
            else_clause.Rule =
                new_lines_opt + "else" + statement_block;

            ////        labeled_statement:
            ////            switch_statement
            ////            foreach_statement
            ////            for_statement
            ////            while_statement
            ////            do_statement
            labeled_statement.Rule =
                switch_statement
                |
                foreach_statement
                |
                for_statement
                |
                while_statement
                |
                do_statement
                ;

            ////        switch_statement:
            ////            switch   new_lines_opt   switch_parameters_opt   switch_condition   switch_body
            switch_statement.Rule =
                "switch" + new_lines_opt + (switch_parameters | Empty) + switch_condition + switch_body;

            ////        switch_parameters:
            ////            switch_parameter
            ////            switch_parameters   switch_parameter
            switch_parameters.Rule =
                MakePlusRule(switch_parameters, switch_parameter);

            ////        switch_parameter:
            ////            _regex
            ////            _wildcard
            ////            _exact
            ////            _casesensitive
            switch_parameter.Rule =
                ToTerm("-regex")
                |
                "-wildcard"
                |
                "-exact"
                |
                "-casesensitive"
                ;

            ////        switch_condition:
            ////            (   new_lines_opt   pipeline   new_lines_opt   )
            ////            _file   new_lines_opt   switch_filename
            switch_condition.Rule = _switch_condition_pipeline | _switch_condition_file;
            _switch_condition_pipeline.Rule = "(" + new_lines_opt + pipeline + new_lines_opt + ")";
            _switch_condition_file.Rule = "-file" + new_lines_opt + switch_filename;

            ////        switch_filename:
            ////            command_argument
            ////            primary_expression
            switch_filename.Rule =
                command_argument
                |
                primary_expression
                ;

            ////        switch_body:
            ////            new_lines_opt   {   new_lines_opt   switch_clauses   }
            switch_body.Rule =
                new_lines_opt + "{" + new_lines_opt + switch_clauses + "}";

            ////        switch_clauses:
            ////            switch_clause
            ////            switch_clauses   switch_clause
            switch_clauses.Rule =
                MakePlusRule(switch_clauses, switch_clause);

            ////        switch_clause:
            ////            switch_clause_condition   statement_block   statement_terimators_opt [sic]
            switch_clause.Rule =
                switch_clause_condition + statement_block + (statement_terminators | Empty);

            ////        switch_clause_condition:
            ////            command_argument
            ////            primary_expression
            switch_clause_condition.Rule =
                command_argument
                |
                primary_expression
                ;

            ////        foreach_statement:
            ////            foreach   new_lines_opt   (   new_lines_opt   variable   new_lines_opt   in   new_lines_opt   pipeline
            ////                    new_lines_opt   )   statement_block
            foreach_statement.Rule =
                "foreach" + new_lines_opt + "(" + new_lines_opt + variable + new_lines_opt + "in" + new_lines_opt + pipeline +
                    new_lines_opt + ")" + statement_block;

            ////        for_statement:
            ////            for   new_lines_opt   (
            ////                    new_lines_opt   for_initializer_opt   statement_terminator
            ////                    new_lines_opt   for_condition_opt   statement_terminator
            ////                    new_lines_opt   for_iterator_opt
            ////                    new_lines_opt   )   statement_block
            ////            for   new_lines_opt   (
            ////                    new_lines_opt   for_initializer_opt   statement_terminator
            ////                    new_lines_opt   for_condition_opt
            ////                    new_lines_opt   )   statement_block
            ////            for   new_lines_opt   (
            ////                    new_lines_opt   for_initializer_opt
            ////                    new_lines_opt   )   statement_block
            for_statement.Rule = _for_statement_1 | _for_statement_2 | _for_statement_3;
            _for_statement_1.Rule = "for" + new_lines_opt + "(" +
                    new_lines_opt + (for_initializer | Empty) + statement_terminator +
                    new_lines_opt + (for_condition | Empty) + statement_terminator +
                    new_lines_opt + (for_iterator | Empty) +
                    new_lines_opt + ")" + statement_block;

            _for_statement_2.Rule = "for" + new_lines_opt + "(" +
                    new_lines_opt + (for_initializer | Empty) + statement_terminator +
                    new_lines_opt + (for_condition | Empty) + statement_terminator +
                    new_lines_opt + ")" + statement_block;

            _for_statement_3.Rule = "for" + new_lines_opt + "(" +
                    new_lines_opt + (for_initializer | Empty) +
                    new_lines_opt + ")" + statement_block;

            ////        for_initializer:
            ////            pipeline
            for_initializer.Rule =
                pipeline;

            ////        for_condition:
            ////            pipeline
            for_condition.Rule =
                pipeline;

            ////        for_iterator:
            ////            pipeline
            for_iterator.Rule =
                pipeline;

            ////        while_statement:
            ////            while   new_lines_opt   (   new_lines_opt   while_condition   new_lines_opt   )   statement_block
            while_statement.Rule =
                "while" + new_lines_opt + "(" + new_lines_opt + while_condition + new_lines_opt + ")" + statement_block;

            ////        do_statement:
            ////            do   statement_block  new_lines_opt   while   new_lines_opt   (   while_condition   new_lines_opt   )
            ////            do   statement_block   new_lines_opt   until   new_lines_opt   (   while_condition   new_lines_opt   )
            do_statement.Rule = _do_statement_while | _do_statement_until;
            _do_statement_while.Rule = "do" + statement_block + new_lines_opt + "while" + new_lines_opt + "(" + while_condition + new_lines_opt + ")";
            _do_statement_until.Rule = "do" + statement_block + new_lines_opt + "until" + new_lines_opt + "(" + while_condition + new_lines_opt + ")";

            ////        while_condition:
            ////            new_lines_opt   pipeline
            while_condition.Rule =
                new_lines_opt + pipeline;

            ////        function_statement:
            ////            function   new_lines_opt   function_name   function_parameter_declaration_opt   {   script_block   }
            ////            filter   new_lines_opt   function_name   function_parameter_declaration_opt   {   script_block   }
            function_statement.Rule =
                (ToTerm("function") | "filter") + new_lines_opt + function_name + (function_parameter_declaration | Empty) + "{" + script_block + "}";

            ////        function_name:
            ////            command_argument
            function_name.Rule =
                generic_token
                //command_argument // I don't know how this can be anything other than a generic_token
                ;

            ////        function_parameter_declaration:
            ////            new_lines_opt   (   parameter_list   new_lines_opt   )
            function_parameter_declaration.Rule =
                new_lines_opt + "(" + parameter_list + new_lines_opt + ")";

            ////        flow_control_statement:
            ////            break   label_expression_opt
            ////            continue   label_expression_opt
            ////            throw    pipeline_opt
            ////            return   pipeline_opt
            ////            exit   pipeline_opt
            flow_control_statement.Rule = _flow_control_statement_break | _flow_control_statement_continue | _flow_control_statement_throw | _flow_control_statement_return | _flow_control_statement_exit;
            _flow_control_statement_break.Rule = "break" + (label_expression | Empty);
            _flow_control_statement_continue.Rule = "continue" + (label_expression | Empty);
            _flow_control_statement_throw.Rule = "throw" + (pipeline | Empty);
            _flow_control_statement_return.Rule = "return" + (pipeline | Empty);
            _flow_control_statement_exit.Rule = "exit" + (pipeline | Empty);

            ////        label_expression:
            ////            simple_name
            ////            unary_expression
            label_expression.Rule =
                simple_name
                |
                unary_expression
                ;

            ////        trap_statement:
            ////            trap  new_lines_opt   type_literal_opt   new_lines_opt   statement_block
            trap_statement.Rule =
                "trap" + new_lines_opt + ((type_literal + new_lines_opt) | Empty) + statement_block;

            ////        try_statement:
            ////            try   statement_block   catch_clauses
            ////            try   statement_block   finally_clause
            ////            try   statement_block   catch_clauses   finally_clause
            try_statement.Rule =
                _try_statement_catch | _try_statement_finally | _try_statement_catch_finally;
            _try_statement_catch.Rule =
                "try" + statement_block + catch_clauses;
            _try_statement_finally.Rule =
                "try" + statement_block + finally_clause;
            _try_statement_catch_finally.Rule =
                "try" + statement_block + catch_clauses + finally_clause;

            ////        catch_clauses:
            ////            catch_clause
            ////            catch_clauses   catch_clause
            catch_clauses.Rule =
                MakePlusRule(catch_clauses, catch_clause);

            ////        catch_clause:
            ////            new_lines_opt   catch   catch_type_list_opt   statement_block
            catch_clause.Rule =
                new_lines_opt + "catch" + (catch_type_list | Empty) + statement_block;

            ////        catch_type_list:
            ////            new_lines_opt   type_literal
            ////            catch_type_list   new_lines_opt   ,   new_lines_opt   type_literal
            catch_type_list.Rule =
                MakePlusRule(catch_type_list, (new_lines_opt + ","), new_lines_opt + type_literal);

            ////        finally_clause:
            ////            new_lines_opt   finally   statement_block
            finally_clause.Rule =
                new_lines_opt + "finally" + statement_block;

            ////        data_statement:
            ////            data    new_lines_opt   data_name   data_commands_allowed_opt   statement_block
            data_statement.Rule =
                "data" + new_lines_opt + data_name + (data_commands_allowed | Empty) + statement_block;

            ////        data_name:
            ////            simple_name
            data_name.Rule =
                simple_name;

            ////        data_commands_allowed:
            ////            new_lines_opt   _supportedcommand   data_commands_list
            data_commands_allowed.Rule =
                new_lines_opt + "-supportedcommand" + data_commands_list;

            ////        data_commands_list:
            ////            new_lines_opt   data_command
            ////            data_commands_list   ,   new_lines_opt   data_command
            data_commands_list.Rule =
                MakePlusRule(data_commands_list, ToTerm(","), (new_lines_opt + data_command));

            ////        data_command:
            ////            command_name_expr
            data_command.Rule =
                command_name_expr;

            ////        pipeline:
            ////            assignment_expression
            ////            expression   redirections_opt  pipeline_tail_opt
            ////            command   pipeline_tail_opt
            pipeline.Rule = assignment_expression | _pipeline_expression | _pipeline_command;
            _pipeline_expression.Rule = expression + (redirections | Empty) + (pipeline_tail | Empty);
            _pipeline_command.Rule = command + (pipeline_tail | Empty);

            ////        assignment_expression:
            ////            expression   assignment_operator   statement
            //
            // I think the left side should be `primary_expression`, not `expression`.
            assignment_expression.Rule =
                primary_expression + assignment_operator + statement;

            ////        pipeline_tail:
            ////            |   new_lines_opt   command
            ////            |   new_lines_opt   command   pipeline_tail
            pipeline_tail.Rule = MakePlusRule(pipeline_tail, "|" + new_lines_opt + command);

            ////        command:
            ////            command_name   command_elements_opt
            ////            command_invocation_operator   command_module_opt  command_name_expr   command_elements_opt
            command.Rule =
                _command_simple | _command_invocation;

            _command_simple.Rule =
                command_name + command_elements_opt;

            // ISSUE: https://github.com/JayBazuzi/Pash2/issues/8
            _command_invocation.Rule =
                command_invocation_operator + /* (command_module | Empty) + */ command_name_expr + command_elements_opt;

            ////        command_invocation_operator:  one of
            ////            &	.
            command_invocation_operator.Rule =
                ToTerm("&") | ".";

            ////        command_module:
            ////            primary_expression
            // ISSUE: https://github.com/JayBazuzi/Pash2/issues/8
            command_module.Rule =
                primary_expression;

            ////        command_name:
            ////            generic_token
            ////            generic_token_with_subexpr
            command_name.Rule =
                generic_token
                // ISSUE: https://github.com/JayBazuzi/Pash2/issues/9 - need whitespace prohibition
                // |
                // generic_token_with_subexpr
                ;

            ////        generic_token_with_subexpr:
            ////            No whitespace is allowed between ) and command_name.
            ////            generic_token_with_subexpr_start   statement_list_opt   )   command_name
            // ISSUE: https://github.com/JayBazuzi/Pash2/issues/9 - need whitespace prohibition
            generic_token_with_subexpr.Rule =
                generic_token_with_subexpr_start + (statement_list | Empty) + ")" + command_name;

            ////        command_name_expr:
            ////            command_name
            ////            primary_expression
            command_name_expr.Rule =
                command_name
                |
                primary_expression
                ;

            ////        command_elements:
            ////            command_element
            ////            command_elements   command_element
            command_elements.Rule =
                MakePlusRule(command_elements, command_element);
            command_elements_opt.Rule = command_elements | Empty;

            ////        command_element:
            ////            command_parameter
            ////            command_argument
            ////            redirection
            command_element.Rule =
                command_parameter
                |
                command_argument
                |
                redirection
                ;

            ////        command_argument:
            ////            command_name_expr
            command_argument.Rule =
                command_name_expr;

            ////        redirections:
            ////            redirection
            ////            redirections   redirection
            redirections.Rule =
                MakePlusRule(redirections, redirection);

            ////        redirection:
            ////            2>&1
            ////            1>&2
            ////            file_redirection_operator   redirected_file_name
            redirection.Rule = _redirection_error_to_output | _redirection_reserved | (file_redirection_operator + redirected_file_name);
            _redirection_error_to_output.Rule = ToTerm("2>&1");
            _redirection_reserved.Rule = ToTerm("1>&2");

            ////        redirected_file_name:
            ////            command_argument
            ////            primary_expression
            // I think there's a bug here in the grammar, as command_argument already points to primary_expression.
            redirected_file_name.Rule =
                command_argument
                // | primary_expression
                ;
            #endregion

            #region B.2.3 Expressions
            ////        expression:
            ////            logical_expression
            expression.Rule =
                logical_expression;

            ////        logical_expression:
            ////            bitwise_expression
            ////            logical_expression   _and   new_lines_opt   bitwise_expression
            ////            logical_expression   _or   new_lines_opt   bitwise_expression
            ////            logical_expression   _xor   new_lines_opt   bitwise_expression
            logical_expression.Rule =
                bitwise_expression
                |
                (logical_expression + (ToTerm("-and") | "-or" | "-xor") + new_lines_opt + bitwise_expression)
                ;

            ////        bitwise_expression:
            ////            comparison_expression
            ////            bitwise_expression   _band   new_lines_opt   comparison_expression
            ////            bitwise_expression   _bor   new_lines_opt   comparison_expression
            ////            bitwise_expression   _bxor   new_lines_opt   comparison_expression
            bitwise_expression.Rule =
                comparison_expression
                |
                (bitwise_expression + (ToTerm("-band") | "-bor" | "-bxor") + new_lines_opt + comparison_expression)
                ;

            ////        comparison_expression:
            ////            additive_expression
            ////            comparison_expression   comparison_operator   new_lines_opt   additive_expression
            comparison_expression.Rule =
                additive_expression
                |
                (comparison_expression + comparison_operator + new_lines_opt + additive_expression)
                ;

            ////        additive_expression:
            ////            multiplicative_expression
            ////            additive_expression   +   new_lines_opt   multiplicative_expression
            ////            additive_expression   dash   new_lines_opt   multiplicative_expression
            additive_expression.Rule =
                multiplicative_expression
                |
                (additive_expression + ("+" | dash) + new_lines_opt + multiplicative_expression)
                ;

            ////        multiplicative_expression:
            ////            format_expression
            ////            multiplicative_expression   *   new_lines_opt   format_expression
            ////            multiplicative_expression   /   new_lines_opt   format_expression
            ////            multiplicative_expression   %   new_lines_opt   format_expression
            multiplicative_expression.Rule =
                format_expression
                |
                (multiplicative_expression + (ToTerm("*") | ToTerm("/") | ToTerm("%")) + new_lines_opt + format_expression)
                ;

            ////        format_expression:
            ////            range_expression
            ////            format_expression   format_operator    new_lines_opt   range_expression
            format_expression.Rule =
                range_expression
                |
                (format_expression + format_operator + new_lines_opt + range_expression)
                ;

            ////        range_expression:
            ////            array_literal_expression
            ////            range_expression   ..   new_lines_opt   array_literal_expression
            range_expression.Rule =
                array_literal_expression
                |
                (range_expression + ".." + new_lines_opt + array_literal_expression)
                ;

            ////        array_literal_expression:
            ////            unary_expression
            ////            unary_expression   ,    new_lines_opt   array_literal_expression
            array_literal_expression.Rule =
                unary_expression
                |
                (unary_expression + PreferShiftHere() + "," + new_lines_opt + array_literal_expression)
                ;

            ////        unary_expression:
            ////            primary_expression
            ////            expression_with_unary_operator
            unary_expression.Rule =
                primary_expression
                |
                expression_with_unary_operator
                ;

            ////        expression_with_unary_operator:
            ////            ,   new_lines_opt   unary_expression
            ////            -not   new_lines_opt   unary_expression
            ////            !   new_lines_opt   unary_expression
            ////            -bnot   new_lines_opt   unary_expression
            ////            +   new_lines_opt   unary_expression
            ////            dash   new_lines_opt   unary_expression
            ////            pre_increment_expression
            ////            pre_decrement_expression
            ////            cast_expression
            ////            -split   new_lines_opt   unary_expression
            ////            -join   new_lines_opt   unary_expression
            expression_with_unary_operator.Rule =
                ("," + new_lines_opt + unary_expression)
                |
                ("-not" + new_lines_opt + unary_expression)
                |
                ("!" + new_lines_opt + unary_expression)
                |
                ("-bnot" + new_lines_opt + unary_expression)
                |
                ("+" + new_lines_opt + unary_expression)
                |
                (dash + new_lines_opt + unary_expression)
                |
                (pre_increment_expression)
                |
                (pre_decrement_expression)
                |
                (cast_expression)
                |
                ("-split" + new_lines_opt + unary_expression)
                |
                ("-join" + new_lines_opt + unary_expression)
                ;

            ////        pre_increment_expression:
            ////            ++   new_lines_opt   unary_expression
            pre_increment_expression.Rule =
                "++" + new_lines_opt + unary_expression;

            ////        pre_decrement_expression:
            ////            dashdash   new_lines_opt   unary_expression
            pre_decrement_expression.Rule =
                dashdash + new_lines_opt + unary_expression;

            ////        cast_expression:
            ////            type_literal   unary_expression
            cast_expression.Rule =
                type_literal + unary_expression;

            ////        primary_expression:
            ////            value
            ////            member_access
            ////            element_access
            ////            invocation_expression
            ////            post_increment_expression
            ////            post_decrement_expression
            primary_expression.Rule =
                value
                |
                // ISSUE: https://github.com/JayBazuzi/Pash2/issues/9 - need whitespace prohibition
                // member_access
                // |
                // element_access
                // |
                // invocation_expression
                // |
                post_increment_expression
                |
                post_decrement_expression
                ;

            ////        value:
            ////            parenthesized_expression
            ////            sub_expression
            ////            array_expression
            ////            script_block_expression
            ////            hash_literal_expression
            ////            literal
            ////            type_literal
            ////            variable
            value.Rule = parenthesized_expression
                |
                sub_expression
                |
                array_expression
                |
                script_block_expression
                |
                hash_literal_expression
                |
                literal
                |
                type_literal
                |
                variable
                ;

            ////        parenthesized_expression:
            ////            (   new_lines_opt   pipeline   new_lines_opt   )
            parenthesized_expression.Rule =
                ToTerm("(") + new_lines_opt + pipeline + new_lines_opt + ")";

            ////        sub_expression:
            ////            $(   new_lines_opt   statement_list_opt   new_lines_opt   )
            sub_expression.Rule =
                "$(" + new_lines_opt + (statement_list | Empty) + new_lines_opt + ")";

            ////        array_expression:
            ////            @(   new_lines_opt   statement_list_opt   new_lines_opt   )
            array_expression.Rule =
                "@(" + new_lines_opt + (statement_list | Empty) + new_lines_opt + ")";

            ////        script_block_expression:
            ////            {   new_lines_opt   script_block   new_lines_opt   }
            script_block_expression.Rule =
                "{" + new_lines_opt + script_block + new_lines_opt + "}";

            ////        hash_literal_expression:
            ////            @{   new_lines_opt   hash_literal_body_opt   new_lines_opt   }
            hash_literal_expression.Rule =
                ToTerm("@{") + new_lines_opt + (hash_literal_body | Empty) + new_lines_opt + "}";

            ////        hash_literal_body:
            ////            hash_entry
            ////            hash_literal_body   statement_terminators   hash_entry
            hash_literal_body.Rule =
                MakePlusRule(hash_literal_body, ToTerm(";"), hash_entry);

            ////        hash_entry:
            ////            key_expression   =   new_lines_opt   statement
            hash_entry.Rule =
                key_expression + "=" + new_lines_opt + statement;

            ////        key_expression:
            ////            simple_name
            ////            unary_expression
            key_expression.Rule =
                simple_name
                |
                unary_expression
                ;

            ////        post_increment_expression:
            ////            primary_expression   ++
            post_increment_expression.Rule =
                primary_expression + "++";

            ////        post_decrement_expression:
            ////            primary_expression   dashdash
            post_decrement_expression.Rule =
                primary_expression + dashdash;

            ////        member_access: Note no whitespace is allowed between terms in these productions.
            ////            primary_expression   .   member_name
            ////            primary_expression   ::   member_name
            // ISSUE: https://github.com/JayBazuzi/Pash2/issues/9 - need whitespace prohibition
            member_access.Rule =
                primary_expression + (ToTerm(".") | "::") + member_name;

            ////        element_access: Note no whitespace is allowed between primary_expression and [.
            ////            primary_expression   [  new_lines_opt   expression   new_lines_opt   ]
            // ISSUE: https://github.com/JayBazuzi/Pash2/issues/9 - need whitespace prohibition
            element_access.Rule =
                primary_expression + "[" + new_lines_opt + expression + new_lines_opt + "]";

            ////        invocation_expression: Note no whitespace is allowed between terms in these productions.
            ////            primary_expression   .   member_name   argument_list
            ////            primary_expression   ::   member_name   argument_list
            // ISSUE: https://github.com/JayBazuzi/Pash2/issues/9 - need whitespace prohibition
            invocation_expression.Rule =
                primary_expression + (ToTerm(".") | "::") + member_name + argument_expression;

            ////        argument_list:
            ////            (   argument_expression_list_opt   new_lines_opt   )
            argument_list.Rule =
                "(" + (argument_expression_list | Empty) + new_lines_opt + ")";

            ////        argument_expression_list:
            ////            argument_expression
            ////            argument_expression   new_lines_opt   ,   argument_expression_list
            argument_expression_list.Rule =
                MakePlusRule(argument_expression_list, (new_lines_opt + ","), argument_expression);

            ////        argument_expression:
            ////            new_lines_opt   logical_argument_expression
            argument_expression.Rule =
                new_lines_opt + logical_argument_expression;

            ////        logical_argument_expression:
            ////            bitwise_argument_expression
            ////            logical_argument_expression   _and   new_lines_opt   bitwise_argument_expression
            ////            logical_argument_expression   _or   new_lines_opt   bitwise_argument_expression
            ////            logical_argument_expression   _xor   new_lines_opt   bitwise_argument_expression
            logical_argument_expression.Rule =
                bitwise_argument_expression
                |
                logical_argument_expression + (ToTerm("-and") | "-or" | "-xor") + new_lines_opt + bitwise_argument_expression
                ;

            ////        bitwise_argument_expression:
            ////            comparison_argument_expression
            ////            bitwise_argument_expression   _band   new_lines_opt   comparison_argument_expression
            ////            bitwise_argument_expression   _bor   new_lines_opt   comparison_argument_expression
            ////            bitwise_argument_expression   _bxor   new_lines_opt   comparison_argument_expression
            bitwise_argument_expression.Rule =
                comparison_argument_expression
                |
                bitwise_argument_expression + (ToTerm("-band") | "-bor" | "-bxor") + new_lines_opt + comparison_argument_expression
                ;

            ////        comparison_argument_expression:
            ////            additive_argument_expression
            ////            comparison_argument_expression   comparison_operator
            ////                        new_lines_opt   additive_argument_expression
            comparison_argument_expression.Rule =
                additive_argument_expression
                |
                comparison_argument_expression + comparison_operator +
                            new_lines_opt + additive_argument_expression
                            ;

            ////        additive_argument_expression:
            ////            multiplicative_argument_expression
            ////            additive_argument_expression   +   new_lines_opt   multiplicative_argument_expression
            ////            additive_argument_expression   dash   new_lines_opt   multiplicative_argument_expression
            additive_argument_expression.Rule =
                multiplicative_argument_expression
                |
                (additive_argument_expression + ("+" | dash) + new_lines_opt + multiplicative_argument_expression)
                ;

            ////        multiplicative_argument_expression:
            ////            format_argument_expression
            ////            multiplicative_argument_expression   *   new_lines_opt   format_argument_expression
            ////            multiplicative_argument_expression   /   new_lines_opt   format_argument_expression
            ////            multiplicative_argument_expression   %   new_lines_opt   format_argument_expression
            multiplicative_argument_expression.Rule =
                format_argument_expression
                |
                (multiplicative_argument_expression + (ToTerm("*") | "/" | "%") + new_lines_opt + format_argument_expression)
                ;

            ////        format_argument_expression:
            ////            range_argument_expression
            ////            format_argument_expression   format_operator   new_lines_opt   range_argument_expression
            format_argument_expression.Rule =
                range_argument_expression
                |
                (format_argument_expression + format_operator + new_lines_opt + range_argument_expression)
                ;

            ////        range_argument_expression:
            ////            unary_expression
            ////            range_expression   ..   new_lines_opt   unary_expression
            range_argument_expression.Rule =
                unary_expression
                |
                (range_expression + ".." + new_lines_opt + unary_expression)
                ;

            ////        member_name:
            ////            simple_name
            ////            string_literal
            ////            string_literal_with_subexpression
            ////            expression_with_unary_operator
            ////            value
            member_name.Rule =
                simple_name
                |
                string_literal
                |
                string_literal_with_subexpression
                |
                expression_with_unary_operator
                |
                value
                ;

            ////        string_literal_with_subexpression:
            ////            expandable_string_literal_with_subexpr
            ////            expandable_here_string_literal_with_subexpr
            // TODO: expandable_here_string_literal_with_subexpr
            string_literal_with_subexpression.Rule =
                expandable_string_literal_with_subexpr;

            ////        expandable_string_literal_with_subexpr:
            ////            expandable_string_with_subexpr_start   statement_list_opt   )
            ////                    expandable_string_with_subexpr_characters   expandable_string_with_subexpr_end
            ////            expandable_here_string_with_subexpr_start   statement_list_opt   )
            ////                    expandable_here_string_with_subexpr_characters
            ////                    expandable_here_string_with_subexpr_end
            // TODO: expandable_here_string_with_subexpr_start
            expandable_string_literal_with_subexpr.Rule =
                expandable_string_with_subexpr_start + (statement_list | Empty) + ")" +
                    expandable_string_with_subexpr_characters + expandable_string_with_subexpr_end;

            ////        expandable_string_with_subexpr_characters:
            ////            expandable_string_with_subexpr_part
            ////            expandable_string_with_subexpr_characters   expandable_string_with_subexpr_part
            expandable_string_with_subexpr_characters.Rule =
                MakePlusRule(expandable_string_with_subexpr_characters, expandable_string_with_subexpr_part);

            ////        expandable_string_with_subexpr_part:
            ////            sub_expression
            ////            expandable_string_part
            expandable_string_with_subexpr_part.Rule =
                sub_expression
                |
                expandable_string_part
                ;

            ////        expandable_here_string_with_subexpr_characters:
            ////            expandable_here_string_with_subexpr_part
            ////            expandable_here_string_with_subexpr_characters   expandable_here_string_with_subexpr_part
            ////        expandable_here_string_with_subexpr_part:
            ////            sub_expression
            ////            expandable_here_string_part

            ////        type_literal:
            ////            [    type_spec   ]
            type_literal.Rule =
                "[" + type_spec + "]";

            ////        type_spec:
            ////            array_type_name    dimension_opt   ]
            ////            generic_type_name   generic_type_arguments   ]
            ////            type_name
            ////        dimension:
            ////            ,
            ////            dimension   ,
            type_spec.Rule =
                _type_spec_array
                |
                _type_spec_generic
                |
                type_name
                ;

            _type_spec_array.Rule = array_type_name + MakeStarRule(_type_spec_array, ToTerm(",")) + "]";

            _type_spec_generic.Rule = generic_type_name + generic_type_arguments + "]";

            ////        generic_type_arguments:
            ////            type_spec
            ////            generic_type_arguments   ,   type_spec
            generic_type_arguments.Rule = MakePlusRule(generic_type_arguments, ToTerm(","), type_spec);

            #endregion

            #region B.2.4 Attributes
            ////        attribute_list:
            ////            attribute
            ////            attribute_list   new_lines_opt   attribute
            attribute_list.Rule =
                MakePlusRule(attribute_list, new_lines_opt, attribute);

            ////        attribute:
            ////            [   attribute_name   (   attribute_arguments   new_lines_opt   )  new_lines_opt   ]
            ////            type_literal
            attribute.Rule =
                ("[" + attribute_name + "(" + attribute_arguments + new_lines_opt + ")" + new_lines_opt + "]")
                |
                type_literal
                ;

            ////        attribute_name:
            ////            type_spec
            attribute_name.Rule =
                type_spec;

            ////        attribute_arguments:
            ////            attribute_argument
            ////            attribute_argument   new_lines_opt   ,   attribute_arguments
            attribute_arguments.Rule = MakePlusRule(attribute_arguments, (new_lines_opt + ","), attribute_argument);

            ////        attribute_argument:
            ////            new_lines_opt   expression
            ////            new_lines_opt   simple_name   =   new_lines_opt   expression
            attribute_argument.Rule =
                (new_lines_opt + expression)
                |
                (new_lines_opt + simple_name + "=" + new_lines_opt + expression)
                ;
            #endregion
            #endregion
        }

        // returns the number of characters to skip
        int SkipSingleWhitespace(ISourceStream source)
        {
            switch (CharUnicodeInfo.GetUnicodeCategory(source.PreviewChar))
            {
                ////        whitespace:
                ////            Any character with Unicode class Zs, Zl, or Zp
                case UnicodeCategory.SpaceSeparator:        // Zs
                case UnicodeCategory.LineSeparator:         // Zl
                case UnicodeCategory.ParagraphSeparator:    // Zp
                    return 1;
            }

            switch (source.PreviewChar)
            {
                ////            Horizontal tab character (U+0009)
                case '\u0009':
                ////            Vertical tab character (U+000B)
                case '\u000B':
                ////            Form feed character (U+000C)
                case '\u000C':
                    return 1;
            }

            ////            `   (The backtick character U+0060) followed by new_line_character
            ////        new_line_character:
            ////            Carriage return character (U+000D)
            ////            Line feed character (U+000A)
            ////            Carriage return character (U+000D) followed by line feed character (U+000A)
            if (source.PreviewChar == '`')
            {
                // https://github.com/JayBazuzi/Pash2/issues/12
                //if (source.NextPreviewChar == '\u000D' && source.NextNextPreviewChar == '\u000A') return 3;

                if (source.NextPreviewChar == '\u000D') return 2;

                if (source.NextPreviewChar == '\u000A') return 2;
            }

            return 0;
        }

        public override void SkipWhitespace(ISourceStream source)
        {
            while (!source.EOF())
            {
                int count = SkipSingleWhitespace(source);

                if (count == 0) return;

                else source.PreviewPosition += count;
            }
        }

        void InitializeNonTerminalFields()
        {
            foreach (var field in this.GetType().GetFields().Where(f => f.FieldType == typeof(NonTerminal)))
            {
                if (field.GetValue(this) != null) throw new Exception("don't pre-init fields - let us take care of that for you.");

                var nonTerminal = new NonTerminal(field.Name);

                field.SetValue(this, nonTerminal);
            }
        }
    }
}
