using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rummy
{
    class GrupareIndividuala
    {
        protected Joc joc;
        protected OperatiiPiese op;
        protected Piesa[] pieseComponente;
        protected bool existaJoker;
        public bool eGrupaConsecutiva;
        protected int marimeaGrupei;

        public GrupareIndividuala(Piesa[] pieseComponente, bool existaJoker,  int marimeaGrupei,Joc joc,OperatiiPiese op)
        {
            this.pieseComponente = pieseComponente;
            this.existaJoker = existaJoker;
            this.marimeaGrupei = marimeaGrupei;
            this.joc = joc;
            this.op = op;
        }
        public virtual void Mutare(int a,Piesa p) 
        { }

        
    }
}
