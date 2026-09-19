namespace BalancedBrackets
{
    public class Program
    {
        static void Main(string[] args)
        {
            BalancedBrackets[] outputs = new BalancedBrackets[2]
            {
                new BalancedBrackets(8),
                new BalancedBrackets(6),
            };

            foreach (var item in outputs)
                item.Sandbox();
        }
    }

    public class BalancedBrackets
    {
        private int _nLines;
        private bool _isBalanced;
        private bool _hasOpeningBracket;

        public BalancedBrackets(int nLines)
        {
            this._nLines = nLines;
            this._isBalanced = true;
            this._hasOpeningBracket = false;
        }

        public void Sandbox()
        {
            for (int i = 0; i < this._nLines; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    // Two consecutive opening brackets
                    if (_hasOpeningBracket)
                    {
                        _isBalanced = false;
                    }

                    _hasOpeningBracket = true;
                }
                else if (input == ")")
                {
                    // Closing bracket without an opening bracket
                    if (!_hasOpeningBracket)
                    {
                        _isBalanced = false;
                    }

                    _hasOpeningBracket = false;
                }
            }

            // An opening bracket is still unclosed
            if (_hasOpeningBracket)
            {
                _isBalanced = false;
            }

            Console.WriteLine(_isBalanced ? "BALANCED" : "UNBALANCED");
        }
    }
}
