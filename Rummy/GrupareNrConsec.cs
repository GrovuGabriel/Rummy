using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rummy
{
    class GrupareNrConsec : GrupareIndividuala
    {
        public GrupareNrConsec(Piesa[] pieseComponente, bool existaJoker, int marimeaGrupei, Joc joc, OperatiiPiese op) : base(pieseComponente, existaJoker, marimeaGrupei, joc, op)
        {
            eGrupaConsecutiva = true;
        }
      
        public async override void Mutare(int pozjoker, Piesa newjk)
        {
            op.TrimiteGrupe("culoare " + (marimeaGrupei + (existaJoker ? 1 : 0)));
            if (pieseComponente[marimeaGrupei - 1].numar == 1)
                pieseComponente[marimeaGrupei - 1].numar = 14;
            if (existaJoker)
            {
                newjk.stateGrupare = 1;
                newjk.peTabla = false;
                if (pozjoker == 0)
                {
                    newjk.okConcatenare = true;
                    newjk.caracteristicaPiesaCareSeLipesteDeMine = pieseComponente[0].numar - 2;
                    pieseComponente[marimeaGrupei - 1].caracteristicaPiesaCareSeLipesteDeMine = pieseComponente[marimeaGrupei - 1].numar + 1;
                    newjk.Left = 51 * pieseComponente[0].numar - 51;
                    newjk.Top = 30 + (pieseComponente[0].culoare * 2 + pieseComponente[0].prima) * 71;
                    for (int i = 0; i < marimeaGrupei; i++)
                    {
                        pieseComponente[i].Left = 51 * pieseComponente[i].numar;
                        pieseComponente[i].Top = 30 + (pieseComponente[0].culoare * 2 + pieseComponente[0].prima) * 71;

                    }


                }
                else if (pozjoker == marimeaGrupei)
                {
                    newjk.okConcatenare = true;
                    newjk.caracteristicaPiesaCareSeLipesteDeMine = pieseComponente[marimeaGrupei - 1].numar + 2;
                    newjk.teLipestiDeMineInDreapta = true;
                    pieseComponente[0].caracteristicaPiesaCareSeLipesteDeMine = pieseComponente[0].numar - 1;
                    newjk.Left = 51 * pieseComponente[marimeaGrupei - 1].numar + 1;
                    newjk.Top = 30 + (pieseComponente[0].culoare * 2 + pieseComponente[0].prima) * 71;
                    for (int i = 0; i < marimeaGrupei; i++)
                    {
                        pieseComponente[i].Left = 51 * pieseComponente[i].numar - 50;
                        pieseComponente[i].Top = 30 + (pieseComponente[0].culoare * 2 + pieseComponente[0].prima) * 71;

                    }

                }
                else
                {
                    pieseComponente[0].okConcatenare = true;
                    pieseComponente[0].caracteristicaPiesaCareSeLipesteDeMine = pieseComponente[0].numar - 1;
                    pieseComponente[marimeaGrupei - 1].okConcatenare = true;
                    pieseComponente[marimeaGrupei - 1].caracteristicaPiesaCareSeLipesteDeMine = pieseComponente[marimeaGrupei- 1].numar + 1;
                    pieseComponente[marimeaGrupei - 1].teLipestiDeMineInDreapta = true;

                    int lasti = 0;
                    for (int i = 0; i < pozjoker; i++)
                    {
                        pieseComponente[i].Left = 51 * pieseComponente[i].numar - 50;
                        pieseComponente[i].Top = 30 + (pieseComponente[0].culoare * 2 + pieseComponente[0].prima) * 71;

                        lasti = i;
                    }
                    newjk.Left = 51 * pieseComponente[lasti].numar + 1;
                    newjk.Top = 30 + (pieseComponente[0].culoare * 2 + pieseComponente[0].prima) * 71;
                    for (int i = pozjoker; i < marimeaGrupei; i++)
                    {
                        pieseComponente[i].Left = 51 * pieseComponente[i].numar - 50;
                        pieseComponente[i].Top = 30 + (pieseComponente[0].culoare * 2 + pieseComponente[0].prima) * 71;

                    }

                }
                newjk.mutabil = false;
                op.TrimitePiesaG(newjk);
            }
            else
            {
                pieseComponente[0].okConcatenare = true;
                pieseComponente[0].caracteristicaPiesaCareSeLipesteDeMine = pieseComponente[0].numar - 1;
                pieseComponente[marimeaGrupei - 1].okConcatenare = true;
                pieseComponente[marimeaGrupei - 1].caracteristicaPiesaCareSeLipesteDeMine = pieseComponente[marimeaGrupei- 1].numar + 1;
                pieseComponente[marimeaGrupei - 1].teLipestiDeMineInDreapta = true;
                for (int i = 0; i < marimeaGrupei; i++)
                {
                    pieseComponente[i].Left = 51 * pieseComponente[i].numar - 50;
                    pieseComponente[i].Top = 30 + (pieseComponente[0].culoare * 2 + pieseComponente[0].prima) * 71;

                }
            }


            for (int i = 0; i < marimeaGrupei; i++)
            {
                pieseComponente[i].peTabla = false;
                pieseComponente[i].stateGrupare = 1;
                pieseComponente[i].mutabil = false;
                op.TrimitePiesaG(pieseComponente[i]);
            }
            await Task.Delay(100);
        }
    }
}
