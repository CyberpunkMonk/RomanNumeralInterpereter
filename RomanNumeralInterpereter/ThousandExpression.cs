using System;
namespace RomanNumeralInterpereter {
    class ThousandExpression:Expression {
        public override String Five() {
            return " ";
        }
        public override String Four() {
            return " ";
        }
        public override Int32 Multiplier() {
            return 1000;
        }
        public override String Nine() {
            return " ";
        }
        public override String One() {
            return "M";
        }
    }
}