// Lexer.cs
using System.Collections.Generic;

namespace MiniCompilerApp
{
    public class Lexer
    {
        public List<string> Tokenize(string code)
        {
            List<string> tokens = new List<string>();
            string token = "";

            foreach (char c in code)
            {
                if (char.IsWhiteSpace(c) || "=;{}".Contains(c))
                {
                    if (!string.IsNullOrEmpty(token))
                        tokens.Add(token);

                    if ("=;{}".Contains(c))
                        tokens.Add(c.ToString());

                    token = "";
                }
                else
                {
                    token += c;
                }
            }

            if (!string.IsNullOrEmpty(token))
                tokens.Add(token);

            return tokens;
        }
    }
}