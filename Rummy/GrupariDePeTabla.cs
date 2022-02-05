using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rummy
{
    class GrupariDePeTabla
    {
        Joc joc;
        OperatiiPiese op;
        Queue<Piesa> lista = new Queue<Piesa>();
        Queue<GrupareIndividuala> grupari = new Queue<GrupareIndividuala>();
        GrupareIndividuala grupare;
        bool ok = true;
        bool okconsec = true;
        bool okacelasi = true;
        int pozjoker = -1;
        int s = 0;
        public int sumapuncte=0;
        Piesa[] vect;
        Piesa newjk = new Piesa();
        public void Grupeaza(PictureBox[] a, Piesa[] p)
        {
            sumapuncte = 0;
            for (int j = 0; j < 26; j++)
            {
                ok = false;
                for (int i = 0; i < p.Length; i++)
                {
                    if (p[i].Bounds.IntersectsWith(a[j].Bounds))
                    {
                        lista.Enqueue(p[i]);
                        ok = true;
                        break;
                    }
                }
                if (!ok)
                { okconsec = true;
                    okacelasi = true;
                    s = 0;
                    try
                    {
                        s = lista.Count();
                    }
                    catch (System.ArgumentNullException)
                    { s = 0; }


                    vect = new Piesa[s];

                    if (s > 2)
                    { 
                        bool jk = false;
                        vect = lista.ToArray();
                        for (int i = 0; i < s; i++)
                            if (vect[i].culoare == -1)
                            {

                                newjk = vect[i];
                                pozjoker = i;
                                vect = vect.Where((source, index) => index != pozjoker).ToArray();
                                s--;
                                jk = true;
                            }

                        if (jk)
                        {
                            if (pozjoker > 0 && pozjoker < s)
                            {
                                for (int i = 1; i < pozjoker; i++)
                                {
                                    if (vect[i - 1].numar + 1 != vect[i].numar || vect[i - 1].culoare != vect[i].culoare)
                                        if (!(vect[i - 1].numar == 13 && vect[i].numar == 1) || vect[i - 1].culoare != vect[i].culoare)
                                            okconsec = false;
                                }
                                if (vect[pozjoker - 1].numar + 2 != vect[pozjoker].numar || vect[pozjoker - 1].culoare != vect[pozjoker].culoare)
                                    if (!(vect[pozjoker - 1].numar == 12 && vect[pozjoker].numar == 1) || vect[pozjoker - 1].culoare != vect[pozjoker].culoare)
                                        okconsec = false;
                                for (int i = pozjoker + 1; i < s; i++)
                                {
                                    if (vect[i - 1].numar + 1 != vect[i].numar || vect[i - 1].culoare != vect[i].culoare)
                                        if (!(vect[i - 1].numar == 13 && vect[i].numar == 1) || vect[i - 1].culoare != vect[i].culoare)
                                            okconsec = false;
                                }
                                for (int i = 1; i < s; i++)
                                    if (vect[i - 1].numar != vect[i].numar)
                                        okacelasi = false;
                            }
                            else 
                            {
                                for (int i = 1; i < s; i++)
                                {
                                    if (vect[i - 1].numar + 1 != vect[i].numar || vect[i - 1].culoare != vect[i].culoare)
                                        if (!(vect[i - 1].numar == 13 && vect[i].numar == 1) || vect[i - 1].culoare != vect[i].culoare)
                                            okconsec = false;
                                    if (vect[i - 1].numar != vect[i].numar)
                                        okacelasi = false;
                                    if (!okconsec && !okacelasi)
                                        break;

                                }
                            }

                        }
                        else
                            for (int i = 1; i < s; i++)
                            {
                                if (vect[i - 1].numar + 1 != vect[i].numar || vect[i - 1].culoare != vect[i].culoare)
                                    if (!(vect[i - 1].numar == 13 && vect[i].numar == 1) || vect[i - 1].culoare != vect[i].culoare)
                                        okconsec = false;
                                if (vect[i - 1].numar != vect[i].numar)
                                    okacelasi = false;
                                if (!okconsec && !okacelasi)
                                    break;

                            }
                        if (okacelasi)
                            for (int k = 0; k < s; k++)
                                for (int l = 0; l < s; l++)
                                    if (k != l && vect[k].culoare == vect[l].culoare)
                                    {
                                        okacelasi = false;
                                        break;
                                        
                                    }
                        if (okconsec)
                        { 
                            sumapuncte += CalcularePuncte(jk, vect,pozjoker,false);
                            grupare = new GrupareNrConsec(vect, jk, s,joc,op);
                            grupari.Enqueue(grupare);
                        }
                        if (okacelasi)
                        {
                            sumapuncte += CalcularePuncte(jk, vect, pozjoker, true);
                            grupare = new GrupareAcelasiNr(vect,jk,s,joc,op);
                            grupari.Enqueue(grupare);
                        }
                        if (!(joc.primaetalare && sumapuncte < 45))
                        {
                            while (grupari.Count > 0)
                            {
                                //op.scrieinLOG("Count: " + grupari.Count);
                                grupare = grupari.Dequeue();
                                //if (((GrupareIndividuala)grupari.Peek()).eGrupaConsecutiva)
                                //    grupare = (GrupareNrConsec)grupari.Dequeue();
                                //else 
                                //    grupare = (GrupareAcelasiNr)grupari.Dequeue();
                                grupare.Mutare(pozjoker,newjk);
                            }
                        }
                    }  
                    lista.Clear();
                }
            }
        }

        
        int CalcularePuncte(bool jk,Piesa[]p, int pozjoker,bool acelasinr) 
        {
            int suma=0;
            if (acelasinr && p[0].numar == 1)
                suma = p.Length * 25;
            else
                for (int i = 0; i < p.Length; i++)
                {
                    if (i>0&&p[i].numar == 1 && p[i - 1].numar == 13)
                        suma += 10;
                    else
                    suma += (p[i].numar / 10 + 1) * 5;
                }
            if (jk)
                if (joc.primaetalare == false)
                    suma += 50;
                else
                {
                    try
                    {
                        suma += ((p[pozjoker].numar + 1) / 10 + 1) * 5;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        suma += ((p[pozjoker - 1].numar + 1) / 10 + 1) * 5;
                    }
                }

            return suma;
        }
        public GrupariDePeTabla(Joc j,OperatiiPiese o)
        {
            joc = j;
            op = o;
        }
    }
}
    
