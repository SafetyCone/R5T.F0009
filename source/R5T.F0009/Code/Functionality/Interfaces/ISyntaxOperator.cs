using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0132;


namespace R5T.F0009 /// <see cref="R5T.F0009.Documentation"/>
{
    [FunctionalityMarker]
    public interface ISyntaxOperator : IFunctionalityMarker
    {
        public CompilationUnitSyntax AddNamespace(
            CompilationUnitSyntax compilationUnit,
            NamespaceDeclarationSyntax @namespace)
        {
            var output = compilationUnit.AddMembers(@namespace);
            return output;
        }

        public CompilationUnitSyntax AddUsingDirective(
            CompilationUnitSyntax compilationUnit,
            UsingDirectiveSyntax usingDirective)
        {
            var output = compilationUnit.AddUsings(usingDirective);
            return output;
        }
    }
}
