using System;
namespace RomanNumeralInterpereter {
    class HundredExpression:Expression {
        public override String Five() {
            return "D";
        }
        public override String Four() {
            return "CD";
        }
        public override Int32 Multiplier() {
            return 100;
        }
        public override String Nine() {
            return "CM";
        }
        public override String One() {
            return "C";
        }
    }
}