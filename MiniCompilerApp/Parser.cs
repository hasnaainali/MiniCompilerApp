using System.Collections.Generic;

namespace MiniCompilerApp
{
    public class Parser
    {
        public SyntaxTree Parse(List<string> tokens)
        {
            if (tokens.Count != 5) // Ensure the structure: int a = 10;
                return null;

            if (tokens[0] != "int" || tokens[2] != "=" || tokens[4] != ";")
                return null;

            SyntaxTree tree = new SyntaxTree("Declaration");
            tree.Root.Children.Add(new SyntaxTreeNode(tokens[0])); // Type
            tree.Root.Children.Add(new SyntaxTreeNode(tokens[1])); // Variable Name
            tree.Root.Children.Add(new SyntaxTreeNode(tokens[2])); // Assignment Operator
            tree.Root.Children.Add(new SyntaxTreeNode(tokens[3])); // Value

            return tree;
        }
    }
}
