using System;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)
        {
            string[] number = new string[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                number[i] = numbers[i].ToString("#.##");
            }
            string output = string.Join(' ', number);
            output = output.Replace(',', '.');
            Console.WriteLine(output);
        }
    }
}
