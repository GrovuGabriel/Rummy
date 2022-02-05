using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rummy
{
    public class Player
    {
        public bool host;
        public int scor;
        public bool randulMeu;
        public bool amTrimis;
        public bool amTrimisScor;
        public bool amLuatPiesaDeJos;
        public bool amCastigat;
        public int scorFinalAdversar;

        public Player() 
        {
            scor = 0;
            host = false;
            randulMeu = false;
            amTrimis = false;
            amTrimisScor = false;
        }
    }
}
