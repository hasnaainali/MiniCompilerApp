// Form1.cs
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MiniCompilerApp
{
    public partial class Form1 : Form
    {
        private readonly Lexer lexer = new Lexer();
        private readonly Parser parser = new Parser();

        public Form1()
        {
            InitializeComponent();
        }

        private void compileButton_Click(object sender, EventArgs e)
        {
            string inputCode = codeTextBox.Text;
            List<string> tokens = lexer.Tokenize(inputCode);
            SyntaxTree syntaxTree = parser.Parse(tokens);

            if (syntaxTree == null)
            {
                resultLabel.Text = "Syntax Error.";
            }
            else
            {
                resultLabel.Text = "Compilation Successful.";
            }
        }
        private bool IsValidVariableName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return false;

            // Check that the first character is a letter or underscore
            if (!char.IsLetter(name[0]) && name[0] != '_')
                return false;

            // Check that all characters are letters, digits, or underscores
            if (!name.All(c => char.IsLetterOrDigit(c) || c == '_'))
                return false;

            // Reserved keywords
            string[] reservedKeywords = new string[]
            {
        "int", "class", "namespace", "void", "public", "private", "protected",
        "static", "return", "if", "else", "while", "for", "switch", "case",
        "break", "continue", "default", "new", "this", "base", "null", "true",
        "false", "using", "try", "catch", "finally", "throw", "typeof", "struct",
        "enum", "interface", "override", "virtual", "readonly", "abstract",
        "sealed", "volatile", "const", "event", "delegate", "extern", "out",
        "ref", "params", "sizeof", "stackalloc", "unsafe", "fixed", "lock", "checked",
        "unchecked", "dynamic", "is", "as", "async", "await"
            };

            if (reservedKeywords.Contains(name))
                return false;

            return true;
        }

    }
}