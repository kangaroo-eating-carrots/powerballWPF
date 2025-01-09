using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerballWPF
{
    internal class Trial
    {
        private int minValue = 1;
        private int maxValue = 35;
        private int minPowerball = 1;
        private int maxPowerball = 20;

        public static int ValueLength = 7;
 

        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public int MinPowerball { get; set; }
        public int MaxPowerball { get; set; }

        public int[] ValueSet { get; set; }

        public int Powerball { get; set; }
        public int Rank { get; set; }

        public Trial()
        {
            ValueSet = new int[ValueLength];
            MinValue = minValue;
            MaxValue = maxValue;
            MinPowerball = minPowerball;
            MaxPowerball = maxPowerball;
            Rank = -1;

        }

        public void RandomChoice()
        {
            Random rnd = new Random();
            int randomNumber;

            ValueSet = new int[ValueLength];

            for (int i = 0; i < ValueSet.Length; i++)
            {
                while (true)
                {
                    randomNumber = rnd.Next(MinValue, MaxValue);
                    bool isAlready = false;

                    for (int j = 0; j < ValueSet.Length; j++)
                    {
                        if (ValueSet[j] == randomNumber)
                        {
                            isAlready = true;
                            break;
                        }
                    }

                    if (!isAlready)
                    {
                        ValueSet[i] = randomNumber;
                        break;
                    }
                }
            }

            Powerball = rnd.Next(MinPowerball, MaxPowerball);
        }

        public void RankCheck(int[] winningArray, int winningPowerball)
        {
            Array.Sort(winningArray);

            int correctCount = 0;
            for (int i = 0; i < ValueSet.Length; i++)
            {
                int low = 0;
                int high = winningArray.Length - 1;

                while (true)
                {
                    int mid = low + (high - low) / 2;

                    if (high >= low)
                    {
                        if (ValueSet[i] == winningArray[mid])
                        {
                            correctCount++;
                            break;
                        }
                        else if (ValueSet[i] > winningArray[mid])
                        {
                            low = mid + 1;
                        }
                        else
                        {
                            high = mid - 1;
                        }
                    }
                    else break;
                }
            }

            if (Powerball == winningPowerball)
            {
                Rank = (ValueSet.Length - correctCount + 1)*2 - 1;
            }
            else
            {
                Rank = (ValueSet.Length - correctCount + 1)*2;
            }
        }


        public override string ToString()
        {
            string valueString = "";

            foreach (var value in ValueSet)
            {
                if (value < 10)
                {
                    valueString = valueString + $"0{value} ";
                }
                else
                {
                    valueString = valueString + $"{value} ";
                }
            }

            if (ValueSet[ValueSet.Length - 1] != null)
            {
                if (Powerball < 10)
                {
                    valueString = valueString + $"[0{Powerball}]";
                }
                else
                {
                    valueString = valueString + $"[{Powerball}]";
                }

                if (Rank != -1)
                {
                    if (Rank <= 7)
                    {
                        valueString = valueString + $" | RANK 0{Rank}";
                    }
                    else
                    {
                        valueString = valueString + $" | RANK  X";
                    }
                }
                    
            }        
            return valueString;
        }
    }
}
