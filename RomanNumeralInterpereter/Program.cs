using System;
using System.Collections.Generic;
namespace RomanNumeralInterpereter {
    class Program {
        static void Main(string[] args) {
            string roman = "MCMXXVIIII";
            Context context = new Context(roman);
            //Build the 'parse tree'
            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TensExpression());
            tree.Add(new OneExpression());

            //Interperet
            foreach(Expression e in tree) {
                e.Interperet(context);
            }

            Console.WriteLine($"{roman} = {context.Output}");

            //Wait for user
            Console.ReadKey();
        }
    }
}