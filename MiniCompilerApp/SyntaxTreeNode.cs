// SyntaxTreeNode.cs
using System.Collections.Generic;
namespace MiniCompilerApp
{
    public class SyntaxTreeNode
    {
        public string Value { get; set; }
        public List<SyntaxTreeNode> Children { get; set; } = new List<SyntaxTreeNode>();

        public SyntaxTreeNode(string value)
        {
            Value = value;
        }
    }
}