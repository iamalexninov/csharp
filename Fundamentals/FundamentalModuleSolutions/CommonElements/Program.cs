using System.Runtime.CompilerServices;

namespace CommonElements
{
    public class Program
    {
        static void Main(string[] args)
        {
            CommonElements[] outputs = new CommonElements[3]
            {
                new CommonElements("Hey hello 2 4", "10 hey 4 hello"),
                new CommonElements("S of t un i", "of i 10 un"),
                new CommonElements("i love to code", "code i love to"),
            };

            foreach (var item in outputs)
                item.Sandbox();
        }
    }

    public class CommonElements
    {
        private string[] _firstArr;
        private string[] _secondArr;

        public CommonElements(string firstStr, string secondStr)
        {
            this._firstArr = firstStr.Split(' ').ToArray();
            this._secondArr = secondStr.Split(' ').ToArray();
        }

        private string CompareBothArrays(string[] arr1, string[] arr2)
        {
            string result = "";
            for (int i = 0; i < arr2.Length; i++)
            {
                string elementArr2 = arr2[i];

                for (int j = 0; j < arr1.Length; j++)
                {
                    string elementArr1 = arr1[j];

                    if (elementArr2.Equals(elementArr1))
                    {
                        result += elementArr2 + " ";
                    }
                }
            }

            return result;
        }

        public void Sandbox()
        {
            string result = this.CompareBothArrays(this._firstArr, this._secondArr);
            Console.WriteLine(result);
        }
    }
}