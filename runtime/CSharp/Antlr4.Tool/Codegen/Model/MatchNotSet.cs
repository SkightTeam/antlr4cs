// Copyright (c) Terence Parr, Sam Harwell. All Rights Reserved.
// Licensed under the BSD License. See LICENSE.txt in the project root for license information.

namespace Antlr4.Codegen.Model
{
    using Antlr4.Tool.Ast;

    public class MatchNotSet : MatchSet
    {
        public string varName = "_la";

        public MatchNotSet(OutputModelFactory factory, GrammarAST ast)
            : base(factory, ast)
        {
        }
    }
}
