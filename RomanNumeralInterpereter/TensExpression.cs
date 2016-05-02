using System;
namespace RomanNumeralInterpereter {
    class TensExpression:Expression {
        public override String Five() {
            return "L";
        }
        public override String Four() {
            return "XL";
        }
        public override Int32 Multiplier() {
            return 10;
        }
        public override String Nine() {
            return "XC";
        }
        public override String One() {
            return "X";
        }
    }
}
