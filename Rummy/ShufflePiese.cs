using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rummy
{
    public class ShufflePiese
    {
        Random rng;
        public void SetRandom(int n)
        {
            rng = new Random(n);
        }
        public void Shuffle<Piese>(Piese[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                Piese temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
        public ShufflePiese() { }

    }
}
