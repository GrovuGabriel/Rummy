using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rummy
{
    class GrupareAcelasiNr : GrupareIndividuala
    {
        public GrupareAcelasiNr(Piesa[] pieseComponente, bool existaJoker, int marimeaGrupei,Joc joc,OperatiiPiese op) : base(pieseComponente, existaJoker, marimeaGrupei,joc,op)
        {
            eGrupaConsecutiva = false;
        }
        public override void Mutare(int pozjoker, Piesa newjk)
        {
            op.TrimiteGrupe("numar " + (marimeaGrupei + (existaJoker ? 1 : 0)));
            if (marimeaGrupei == 3 && !existaJoker)
            {
                pieseComponente[2].caracteristicaPiesaCareSeLipesteDeMine = 6 - pieseComponente[0].culoare - pieseComponente[1].culoare - pieseComponente[2].culoare;
                pieseComponente[2].okConcatenare = true;
                pieseComponente[2].teLipestiDeMineInDreapta = true;
            }
            for (int i = 0; i < marimeaGrupei; i++)
            {
                pieseComponente[i].stateGrupare = 2;
                pieseComponente[i].Left = 950 + i * 51;
                pieseComponente[i].Top = 30 + (joc.PrimaPozitieLaGrupariCuAcelasiNumar) * 76;
                pieseComponente[i].peTabla = false;
                pieseComponente[i].mutabil = false;
                op.TrimitePiesaG(pieseComponente[i]);
            }
            if (existaJoker)
            {
                newjk.stateGrupare = 2;
                newjk.Left = pieseComponente[marimeaGrupei - 1].Left + 51;
                newjk.Top = pieseComponente[marimeaGrupei - 1].Top;
                newjk.mutabil = false;
                newjk.peTabla = false;
                op.TrimitePiesaG(newjk);
            }
            joc.PrimaPozitieLaGrupariCuAcelasiNumar++;
        }
    }
}
