using System;

namespace KaminoSpace
{
    public class Program
    {
        static void Main(string[] args)
        {
            KaminoSpace[] outputs = new KaminoSpace[2]
            {
                new KaminoSpace(5),
                new KaminoSpace(4),
            };

            foreach (var item in outputs)
                item.Sandbox();
        }
    }

    public class KaminoSpace
    {
        /*
        You will receive the DNA length and until you receive the command "Clone them!",
        you will be receiving a DNA sequence of ones and zeroes, split by '!' (one or several).
        */

        /*
         You should select the sequence with the longest subsequence of ones. - How? 
         [] - Logic
         If there are several sequences with the same length of the subsequence of ones, print the one with the leftmost starting index, 
         [] ------ 
         
         if there are several sequences with the same length and starting index, select the sequence with the greater sum of its elements.
        */
        private int[] _bestSequence;
        private int _bestSequenceIndex;

        public KaminoSpace(int length)
        {
            this._bestSequence = new int[length];
            this._bestSequenceIndex = int.MaxValue;
        }

        public void Sandbox()
        {
            string input;
            while (!(input = Console.ReadLine()).Equals("Clone them!"))
            {
                int[] _arr = input.Split('!').Select(int.Parse).ToArray();

                // You should select the sequence with the longest subsequence of ones.
                // How to check if sequnces are with the same length of ones??
                for (int i = 0; i < _arr.Length; i++)
                {
                    if (i + 1 != _arr.Length)
                    {
                        if (_arr[i] == 1)
                        {
                            if (_arr[i] == _arr[i + 1])
                            {
                                // If there are several sequences with the same length of the subsequence of ones, print the one with the leftmost starting index, 
                                // How to find the leftmost index??
                                if (this._bestSequence.Length == _arr.Length)
                                {
                                    if (this._bestSequenceIndex > i)
                                    {
                                        this._bestSequenceIndex = i + 1;
                                        this._bestSequence = _arr;
                                    }
                                    else if (this._bestSequenceIndex == i)
                                    {
                                        int sumOfCurrentSequence = _arr.Sum();
                                        int sumOfTheBestSequence = this._bestSequence.Sum();

                                        if (sumOfCurrentSequence > sumOfTheBestSequence)
                                        {
                                            this._bestSequence = _arr;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Best DNA sample {this._bestSequenceIndex} with sum: {this._bestSequence.Sum()}.");
            Console.WriteLine(String.Join(" ", this._bestSequence));
        }
    }
}