using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // simplle shell
            while (true)
            {
                Console.Write("bsharp(beta)>");
                var line = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(line)) 
                {
                    return;
                }
                if (line == "1 + 2 * 3") 
                {
                    Console.WriteLine("9"); 
                }
                else 
                {
                    Console.WriteLine("ERROR!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                }
            }
        }
    }
    //makes litle syntax
    class SyntaxToken
    {
        public SyntaxToken(SyntaxKind kind,int position, string text)
        {
            Kind = kind;
            Position = position;
            Text = text;
        }
        public SyntaxKind Kind { get; }
        public int Position { get; }
        public string Text { get; }
    }

    enum SyntaxKind
    {
    }

    //compiles files or input
    class Lexer
    {
        private readonly string _text;
        private int _position;
        public Lexer(string _text)
        {
            Text = _text;
        }
        private char Current
        {
            get
            {
                if (_position == 0)
                {
                    return '\0';
                }
                return _text[_position];
            }
        }
        private void Next()
        {
            _position++;
        }

        public SyntaxToken NextToken()
        {
            //Main method
            if (char.IsDigit(Current))
            {
                var start = _position;
                while (char.IsDigit(Current))
                {
                    //init next method
                    Next();

                    var length = _position - start;
                    var text = _text.Substring(start, length);
                }
            }
        }
        public string Text { get; }
    }
}
