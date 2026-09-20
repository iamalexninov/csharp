namespace ArrayRotation
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayRotation[] outputs = new ArrayRotation[3]
            {
                new ArrayRotation("51 47 32 61 21", 2),
                new ArrayRotation("32 21 61 1", 4),
                new ArrayRotation("2 4 15 31", 5),
            };

            foreach (var item in outputs)
                item.Sandbox();
        }
    }

    public class ArrayRotation
    {
        private int[] _inputArray;
        private int _rotations;

        public ArrayRotation(string inputStr, int rotations)
        {
            this._inputArray = inputStr.Split(' ').Select(int.Parse).ToArray();
            this._rotations = rotations;
        }

        private int[] RotateElementOnArray(int rotations, int[] arr)
        {
            for (int i = 0; i < rotations; i++)
            {
                int firstElement = arr[0];

                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];   // shift left
                }

                arr[arr.Length - 1] = firstElement;   // first goes to the back
            }

            return arr;
        }

        public void Sandbox()
        {
            this._inputArray = this.RotateElementOnArray(this._rotations, this._inputArray);
            Console.WriteLine(this._inputArray[this._inputArray.Length - 1]);
            Console.WriteLine(String.Join(" ", _inputArray));
        }
    }
}

// 2
/*
 [] - start - 51 47 32 61 21
    - 47 32 61 21 51
    - 32 61 21 51 47
*/