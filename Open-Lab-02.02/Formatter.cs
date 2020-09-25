using System;
using System.Linq;
namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)
        {
           
            string text = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                text += Math.Round(numbers[i], 2) + (i +1==numbers.Length ? "" : " ");
            }

            Console.Write(text.Replace(',','.'));
            
        }
    }
}
