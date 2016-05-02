namespace RomanNumeralInterpereter {
    class Context {
        private string _input;
        private int _output;
        //C'tor
        public Context(string input) { this._input=input; }
        //Gets or Sets input
        public string Input {
            get { return _input; }
            set { _input=value; }
        }
        //Gets or Sets output
        public int Output {
            get { return _output; }
            set { _output=value; }
        }
    }
}