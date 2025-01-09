using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PowerballWPF
{
    internal class Winning
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

        public Winning()
        {
            ValueSet = new int[ValueLength];
            MinValue = minValue;
            MaxValue = maxValue;
            MinPowerball = minPowerball;
            MaxPowerball = maxPowerball;
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

            if (Powerball < 10)
            {
                valueString = valueString + $"[0{Powerball}]";
            }
            else
            {
                valueString = valueString + $"[{Powerball}]";
            }

            return $"{valueString}  Your Rank?";
        }
            
    }
}
