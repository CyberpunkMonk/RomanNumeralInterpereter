using System;
namespace RomanNumeralInterpereter {
    class OneExpression:Expression {
        public override String Five() {
            return "V";
        }
        public override String Four() {
            return "IV";
        }
        public override Int32 Multiplier() {
            return 1;
        }
        public override String Nine() {
            return "IX";
        }
        public override String One() {
            return "I";
        }
    }
}