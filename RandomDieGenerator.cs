using System;
using System.Text;

namespace Hello
{
    public class RandomDieGenerator
    {
        private Random rand = new Random();
        private StringBuilder threeBits = new StringBuilder(3);
        public int Roll()
        {
            int num = 0;
            do
            {
                GenerateBinary();
                num = Convert.ToInt32(threeBits.ToString(), 2);
            } while( num < 1 || num > 6);

            return num;
        }
        private void GenerateBinary()
        {
            threeBits.Clear();
            for (int ctr = 0; ctr <= 2; ctr++)
            {   
                var value = (rand.Next(2));
                threeBits.Append(value.ToString());
            }
        }
    }
}