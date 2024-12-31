// SyntaxTree.cs
namespace MiniCompilerApp
{
    public class SyntaxTree
    {
        public SyntaxTreeNode Root { get; set; }

        public SyntaxTree(string rootValue)
        {
            Root = new SyntaxTreeNode(rootValue);
        }
    }
}