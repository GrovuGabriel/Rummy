using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rummy
{
    public class OperatiiPiese
    {
        Stack<Piesa> Jos;
        Player player;
        Retea retea;
        Joc joc;
        IncheiereJoc IncheiereJoc;
        Piesa[] p;
        int ind;
        Size pbsize = new Size(7, 7);
        string[] poza = new string[106] { "Piese\\n1.jpg", "Piese\\n2.jpg", "Piese\\n3.jpg", "Piese\\n4.jpg", "Piese\\n5.jpg", "Piese\\n6.jpg", "Piese\\n7.jpg", "Piese\\n8.jpg", "Piese\\n9.jpg", "Piese\\n10.jpg", "Piese\\n11.jpg", "Piese\\n12.jpg", "Piese\\n13.jpg", "Piese\\a1.jpg", "Piese\\a2.jpg", "Piese\\a3.jpg", "Piese\\a4.jpg", "Piese\\a5.jpg", "Piese\\a6.jpg", "Piese\\a7.jpg", "Piese\\a8.jpg", "Piese\\a9.jpg", "Piese\\a10.jpg", "Piese\\a11.jpg", "Piese\\a12.jpg", "Piese\\a13.jpg", "Piese\\g1.jpg", "Piese\\g2.jpg", "Piese\\g3.jpg", "Piese\\g4.jpg", "Piese\\g5.jpg", "Piese\\g6.jpg", "Piese\\g7.jpg", "Piese\\g8.jpg", "Piese\\g9.jpg", "Piese\\g10.jpg", "Piese\\g11.jpg", "Piese\\g12.jpg", "Piese\\g13.jpg", "Piese\\r1.jpg", "Piese\\r2.jpg", "Piese\\r3.jpg", "Piese\\r4.jpg", "Piese\\r5.jpg", "Piese\\r6.jpg", "Piese\\r7.jpg", "Piese\\r8.jpg", "Piese\\r9.jpg", "Piese\\r10.jpg", "Piese\\r11.jpg", "Piese\\r12.jpg", "Piese\\r13.jpg", "Piese\\jk.jpg", "Piese\\n1.jpg", "Piese\\n2.jpg", "Piese\\n3.jpg", "Piese\\n4.jpg", "Piese\\n5.jpg", "Piese\\n6.jpg", "Piese\\n7.jpg", "Piese\\n8.jpg", "Piese\\n9.jpg", "Piese\\n10.jpg", "Piese\\n11.jpg", "Piese\\n12.jpg", "Piese\\n13.jpg", "Piese\\a1.jpg", "Piese\\a2.jpg", "Piese\\a3.jpg", "Piese\\a4.jpg", "Piese\\a5.jpg", "Piese\\a6.jpg", "Piese\\a7.jpg", "Piese\\a8.jpg", "Piese\\a9.jpg", "Piese\\a10.jpg", "Piese\\a11.jpg", "Piese\\a12.jpg", "Piese\\a13.jpg", "Piese\\g1.jpg", "Piese\\g2.jpg", "Piese\\g3.jpg", "Piese\\g4.jpg", "Piese\\g5.jpg", "Piese\\g6.jpg", "Piese\\g7.jpg", "Piese\\g8.jpg", "Piese\\g9.jpg", "Piese\\g10.jpg", "Piese\\g11.jpg", "Piese\\g12.jpg", "Piese\\g13.jpg", "Piese\\r1.jpg", "Piese\\r2.jpg", "Piese\\r3.jpg", "Piese\\r4.jpg", "Piese\\r5.jpg", "Piese\\r6.jpg", "Piese\\r7.jpg", "Piese\\r8.jpg", "Piese\\r9.jpg", "Piese\\r10.jpg", "Piese\\r11.jpg", "Piese\\r12.jpg", "Piese\\r13.jpg", "Piese\\jk.jpg" };
        int urmatoareaPiesa;
        public async void AranjareTabla()
        {
            while (true)
            {
                for (int i = 0; i < p.Length; i++)
                    for (int j = i + 1; j < p.Length; j++)
                    {
                        if (p[i].Left == p[j].Left && p[i].Top == p[j].Top && p[i].peTabla == true && p[j].peTabla == true)
                        {

                            if (p[i].indexAranjare < p[j].indexAranjare)
                            {
                                p[i].Left += 50;
                                ind++;
                                p[i].indexAranjare = ind;
                                p[i].aranjare();
                            }
                            else
                            {
                                p[j].Left += 50;
                                ind++;
                                p[j].indexAranjare = ind;
                                p[j].aranjare();
                            }
                        }
                        if (p[i].peTabla == true && p[i].Left > 1000 && p[i].Top < 860 && p[i].Top > 700)
                        {
                            p[i].Left = 215;
                            p[i].Top = 885;
                        }

                    }

                await Task.Delay(50);
            }
        }

        public void GenerarePictureBoxuri(PictureBox[] a)
        {
            for (int i = 0; i < 13; i++)
            {
                a[i] = new PictureBox();
                a[i + 13] = new PictureBox();
                int j = i * 65 + 220;
                a[i].Left = j;
                a[i + 13].Left = j;
                a[i].Top = 795;
                a[i + 13].Top = 880;
                a[i].Size = pbsize;
                a[i + 13].Size = pbsize;
                a[i].Visible = false;
                a[i + 13].Visible = false;
                joc.Controls.Add(a[i]);
                joc.Controls.Add(a[i + 13]);
            }
        }
        public void PunePeTablaLaInceput()
        {
            if (player.host)
            {
                for (int i = 0; i < 14; i++)
                {
                    p[i].Top = 797;
                    p[i].Left = i * 65 + 215;
                    p[i].peTabla = true;
                    p[i].aranjare();
                }

            }
            else
            {
                for (int i = 0; i < 14; i++)
                {
                    p[i + 14].Top = 797;
                    p[i + 14].Left = i * 65 + 215;
                    p[i + 14].peTabla = true;
                    p[i + 14].aranjare();
                }
            }
        }
        public void AdaugaPiesaPeTabla()
        {
            p[urmatoareaPiesa].Left = 995;
            p[urmatoareaPiesa].Top = 885;
            joc.Controls.Add(p[urmatoareaPiesa]);
            p[urmatoareaPiesa].aranjare();
            LuatDeJos();
            urmatoareaPiesa++;
        }
        public void AdaugaPiesaJos(Piesa piesa)
        {
            piesa.eJos = true;
            piesa.Left = joc.colliderPuneJos.Right + Jos.Count * 51 + 10;
            piesa.Top = joc.colliderPuneJos.Top;
            Jos.Push(piesa);
            PusPeJos(piesa);
        }
        public async void IaPieseDeJos(Piesa piesa)
        {
            if (!player.amLuatPiesaDeJos)
            {
                player.amLuatPiesaDeJos = true;
                retea.trimite("LuatDinStack " + piesa.indexGenerare);
                Piesa p;
                while (Jos.Peek() != piesa)
                {
                    p = Jos.Pop();
                    p.Left = 220;
                    p.Top = 705;
                    p.eJos = false;
                    p.aranjare();
                    p.mutabil = true;
                }
                p = Jos.Pop();
                p.Left = 220;
                p.Top = 705;
                p.eJos = false;
                await Task.Delay(1150);
                p.mutabil = true;
            }
            else
                joc.eroareLuatDeJos.Show();

        }
        public void AdversarIaPieseDeJos(Piesa piesa)
        {
            Piesa p;
            while (Jos.Peek() != piesa)
            {
                p = Jos.Pop();
                p.Visible = false;
                p.eJos = false;
            }
            p = Jos.Pop();
            p.Visible = false;
            p.eJos = false;
        }
        public void TrimitePiesaJos(Piesa piesa)
        {
            piesa.mutabil = false;
            String s = "";
            while (s != "OKpiesa")
            {
                retea.trimite("PiesaJ: " + piesa.indexGenerare + " " + piesa.Left + " " + piesa.Top);
                s = retea.primeste();
            }
        }
        public void TrimitePiesaG(Piesa piesa)
        {
            String s = "";
            while (s != "OKpiesaG")
            {
                retea.trimite("PiesaG: " + piesa.indexGenerare + " " + piesa.Left + " " + piesa.Top + " " + (piesa.okConcatenare ? 1 : 0) + " " + piesa.caracteristicaPiesaCareSeLipesteDeMine + " " + (piesa.teLipestiDeMineInDreapta ? 1 : 0));
                s = retea.primeste();
            }
        }
        public void LuatDeJos()
        {
            String s = "";
            while (s != "OKldj")
            {
                retea.trimite("LuatDeJos");
                s = retea.primeste();
            }
        }
        //public void scrieinLOG(string s)
        //{
        //    retea.toatedatele += s + "\n";
        // }
        public async void PusPeJos(Piesa piesa)
        {
            piesa.peTabla = false;
            TrimitePiesaJos(piesa);
            await Task.Delay(10);
            TrimiteScor();
            await Task.Delay(100);
            DecideDacaSeTerminaJocul();
            if(joc.Visible==true)
            retea.trimite("STOP");
            joc.eRandulAdversaruluiLabel.Visible = true;
            joc.eRandulAdversaruluiLabel.BringToFront();
            player.amTrimis = false;
            player.randulMeu = false;
            player.amTrimisScor = false;
            player.amLuatPiesaDeJos = false;
            await Task.Delay(30);
            PrimesteInstructiuni();
        }
        public void TrimiteScor()
        {
            retea.trimite("Scor: " + player.scor);
        }
        public void TrimiteGrupe(string s)
        {
            retea.trimite("Grupe: " + s + " ");
        }
        public void DecideDacaSeTerminaJocul()
        {
            int suma = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i].peTabla)
                    suma++;
            }
            if (suma <= 1)
                GataJocu();
        }
        public void GataJocu()
        {
            String s = "";
            while (s != "OKgatajoc")
            {
                retea.trimite("GataJocu " + player.scor);
                s = retea.primeste();
            }
            player.amCastigat = true;
            retea.trimite("STOP");
            PrimesteInstructiuni();
            IncheiereJoc = new IncheiereJoc(player, retea);
            joc.Hide();
            IncheiereJoc.Show();
            IncheiereJoc.Focus();
        }
        public void ConcateneazaLaGrupare(Piesa piesaCareSeLipeste)
        {
            bool succes = false;
            Piesa piesaDeCareSeLipeste = new Piesa();
            for (int i = 0; i < p.Length; i++)
                if (p[i] != piesaCareSeLipeste && p[i].okConcatenare && piesaCareSeLipeste.Bounds.IntersectsWith(p[i].Bounds))
                {
                    if (p[i].stateGrupare == 1)
                    {
                        if ((piesaCareSeLipeste.numar + 13 == p[i].caracteristicaPiesaCareSeLipesteDeMine || piesaCareSeLipeste.numar == p[i].caracteristicaPiesaCareSeLipesteDeMine) && piesaCareSeLipeste.culoare == p[i].culoare)
                        {
                            succes = true;
                            piesaDeCareSeLipeste = p[i];
                            piesaDeCareSeLipeste.okConcatenare = false;
                            piesaCareSeLipeste.okConcatenare = true;
                            piesaCareSeLipeste.stateGrupare = 1;
                            piesaCareSeLipeste.peTabla = false;
                            piesaCareSeLipeste.mutabil = false;
                            piesaCareSeLipeste.Top = p[i].Top;
                            if (p[i].teLipestiDeMineInDreapta)
                            {
                                piesaCareSeLipeste.Left = p[i].Left + 51;
                                piesaCareSeLipeste.caracteristicaPiesaCareSeLipesteDeMine = p[i].caracteristicaPiesaCareSeLipesteDeMine + 1;

                            }
                            else
                            {
                                piesaCareSeLipeste.Left = p[i].Left - 51;
                                piesaCareSeLipeste.caracteristicaPiesaCareSeLipesteDeMine = p[i].caracteristicaPiesaCareSeLipesteDeMine - 1;
                            }
                        }
                    }
                    else
                    {
                        if (piesaCareSeLipeste.culoare == p[i].caracteristicaPiesaCareSeLipesteDeMine && piesaCareSeLipeste.numar == p[i].numar)
                        {
                            succes = true;
                            piesaDeCareSeLipeste = p[i];
                            piesaDeCareSeLipeste.okConcatenare = false;
                            piesaCareSeLipeste.okConcatenare = true;
                            piesaCareSeLipeste.stateGrupare = 2;
                            piesaCareSeLipeste.peTabla = false;
                            piesaCareSeLipeste.mutabil = false;
                            piesaCareSeLipeste.Top = p[i].Top;
                            piesaCareSeLipeste.Left = p[i].Left + 51;
                        }
                    }
                }
            if (succes)
            {
                if (piesaCareSeLipeste.numar == 1 && piesaDeCareSeLipeste.numar == 1)
                    player.scor += 25;
                else if (piesaCareSeLipeste.numar == 1 && piesaDeCareSeLipeste.numar == 13)
                    player.scor += 10;
                else
                    player.scor += 5 * (piesaCareSeLipeste.numar / 10) + 5;
                TrimiteConcatenare(piesaCareSeLipeste, piesaDeCareSeLipeste);
                joc.UpdateScor();
            }
            else
            {
                piesaCareSeLipeste.Left = 215;
                piesaCareSeLipeste.Top = 790;
            }
        }
        public void TrimiteConcatenare(Piesa piesaCareSeLipeste, Piesa piesaDeCareSeLipeste)
        {
            String s = "";
            while (s != "OKconcat")
            {
                retea.trimite("Concatenare: " + piesaCareSeLipeste.indexGenerare + " " + piesaCareSeLipeste.Left + " " + piesaCareSeLipeste.Top + " " + (piesaCareSeLipeste.okConcatenare ? 1 : 0) + " " + piesaCareSeLipeste.caracteristicaPiesaCareSeLipesteDeMine + " " + (piesaCareSeLipeste.teLipestiDeMineInDreapta ? 1 : 0) + " " + piesaDeCareSeLipeste.indexGenerare);
                s = retea.primeste();
            }

        }

        public void PrimesteInstructiuni()
        {
            string s = "";
            string[] vectorStr;
            while (!s.Equals("STOP"))
            {
                s = retea.primeste();
                vectorStr = s.Split(' ');
                switch (vectorStr[0])
                {
                    case "LuatDeJos":
                        urmatoareaPiesa++;
                        retea.trimite("OKldj");
                        break;
                    case "LuatDinStack":
                        AdversarIaPieseDeJos(p[Int32.Parse(vectorStr[1])]);
                        break;
                    case "Grupe:":
                        string a = "";
                        string[] vectorA;
                        switch (vectorStr[1])
                        {
                            case "culoare":
                                for (int i = 0; i < Int32.Parse(vectorStr[2]); i++)
                                {
                                    a = retea.primeste();
                                    vectorA = a.Split(' ');
                                    if (vectorA[0] == "PiesaG:")
                                    {
                                        try
                                        {
                                            p[Int32.Parse(vectorA[1])].Left = Int32.Parse(vectorA[2]);
                                            p[Int32.Parse(vectorA[1])].Top = Int32.Parse(vectorA[3]);
                                            p[Int32.Parse(vectorA[1])].stateGrupare = 1;
                                            p[Int32.Parse(vectorA[1])].mutabil = false;
                                            if (Int32.Parse(vectorA[4]) == 1)
                                                p[Int32.Parse(vectorA[1])].okConcatenare = true;
                                            else
                                                p[Int32.Parse(vectorA[1])].okConcatenare = false;
                                            p[Int32.Parse(vectorA[1])].caracteristicaPiesaCareSeLipesteDeMine = Int32.Parse(vectorA[5]);
                                            if (Int32.Parse(vectorA[6]) == 1)
                                                p[Int32.Parse(vectorA[1])].teLipestiDeMineInDreapta = true;
                                            p[Int32.Parse(vectorA[1])].Visible = true;
                                            joc.Controls.Add(p[Int32.Parse(vectorA[1])]);
                                            retea.trimite("OKpiesaG");
                                        }
                                        catch (System.FormatException)
                                        {
                                            i--;
                                        }
                                    }
                                    else i--;
                                    Array.Clear(vectorA, 0, vectorA.Length);
                                }
                                break;
                            case "numar":
                                for (int i = 0; i < Int32.Parse(vectorStr[2]); i++)
                                {
                                    a = retea.primeste();
                                    vectorA = a.Split(' ');
                                    if (vectorA[0] == "PiesaG:")
                                    {
                                        try
                                        {
                                            p[Int32.Parse(vectorA[1])].Left = Int32.Parse(vectorA[2]);
                                            p[Int32.Parse(vectorA[1])].Top = Int32.Parse(vectorA[3]);
                                            p[Int32.Parse(vectorA[1])].stateGrupare = 2;
                                            p[Int32.Parse(vectorA[1])].mutabil = false;
                                            if (Int32.Parse(vectorA[4]) == 1)
                                                p[Int32.Parse(vectorA[1])].okConcatenare = true;
                                            else
                                                p[Int32.Parse(vectorA[1])].okConcatenare = false;
                                            p[Int32.Parse(vectorA[1])].caracteristicaPiesaCareSeLipesteDeMine = Int32.Parse(vectorA[5]);
                                            if (Int32.Parse(vectorA[6]) == 1)
                                                p[Int32.Parse(vectorA[1])].teLipestiDeMineInDreapta = true;
                                            p[Int32.Parse(vectorA[1])].Visible = true;
                                            joc.Controls.Add(p[Int32.Parse(vectorA[1])]);
                                            retea.trimite("OKpiesaG");
                                        }
                                        catch (System.FormatException)
                                        {
                                            i--;
                                        }
                                    }
                                    else i--;
                                    Array.Clear(vectorA, 0, vectorA.Length);
                                }
                                joc.PrimaPozitieLaGrupariCuAcelasiNumar++;
                                break;
                        }
                        break;
                    case "PiesaJ:":
                        try
                        {
                            p[Int32.Parse(vectorStr[1])].Left = Int32.Parse(vectorStr[2]);
                            p[Int32.Parse(vectorStr[1])].Top = Int32.Parse(vectorStr[3]);
                            joc.Controls.Add(p[Int32.Parse(vectorStr[1])]);
                            p[Int32.Parse(vectorStr[1])].eJos = true;
                            p[Int32.Parse(vectorStr[1])].mutabil = false;
                            p[Int32.Parse(vectorStr[1])].Visible = true;
                            Jos.Push(p[Int32.Parse(vectorStr[1])]);
                            retea.trimite("OKpiesa");
                        }
                        catch (Exception) { }
                        break;
                    case "Concatenare:":
                        //try
                        //{
                        p[Int32.Parse(vectorStr[1])].Left = Int32.Parse(vectorStr[2]);
                        p[Int32.Parse(vectorStr[1])].Top = Int32.Parse(vectorStr[3]);
                        p[Int32.Parse(vectorStr[1])].stateGrupare = p[Int32.Parse(vectorStr[7])].stateGrupare;
                        p[Int32.Parse(vectorStr[1])].mutabil = false;
                        p[Int32.Parse(vectorStr[7])].okConcatenare = false;
                        if (Int32.Parse(vectorStr[4]) == 1)
                            p[Int32.Parse(vectorStr[1])].okConcatenare = true;
                        else
                            p[Int32.Parse(vectorStr[1])].okConcatenare = false;
                        p[Int32.Parse(vectorStr[1])].caracteristicaPiesaCareSeLipesteDeMine = Int32.Parse(vectorStr[5]);
                        if (Int32.Parse(vectorStr[6]) == 1)
                            p[Int32.Parse(vectorStr[1])].teLipestiDeMineInDreapta = true;
                        p[Int32.Parse(vectorStr[1])].Visible = true;
                        joc.Controls.Add(p[Int32.Parse(vectorStr[1])]);
                        retea.trimite("OKconcat");
                        //}
                        //catch (Exception) 
                        //{ }
                        break;
                    case "Scor:":
                        joc.scorAdversar.Text = "Scor Adversar: " + vectorStr[1];
                        break;
                    case "GataJocu":
                        player.scorFinalAdversar = Int32.Parse(vectorStr[1]);
                        retea.trimite("OKgatajoc");
                        player.amCastigat = false;
                        CalculareScorFinal();
                        IncheiereJoc = new IncheiereJoc(player, retea);
                        joc.Hide();
                        IncheiereJoc.Show();
                        IncheiereJoc.Focus();
                        break;
                    case "ScorFinal:":
                            player.scorFinalAdversar = Int32.Parse(vectorStr[1]);
                        break;
                    default: break;
                }
                Array.Clear(vectorStr, 0, vectorStr.Length);
                joc.eRandulAdversaruluiLabel.Visible = false;
                //await Task.Delay(50);
            }


        }
        async void CalculareScorFinal()
        {
            for (int i = 0; i < p.Length; i++)
                if (p[i].peTabla)
                    if (p[i].eJoker)
                        player.scor -= 50;
                    else
                        player.scor -= (p[i].numar / 10 + 1) * 5;
            
                retea.trimite("ScorFinal: " + player.scor);
            await Task.Delay(150);
            retea.trimite("STOP");
            
        }
        public void InitializarePiese()
        {
            for (int i = 0; i < p.Length; i++)
            {
                p[i] = new Piesa(joc, this);
                p[i].Image = System.Drawing.Image.FromFile(poza[i]);
                p[i].prima = (i < 53) ? 0 : 1;
                switch (poza[i][6])
                {
                    case 'n':
                        p[i].culoare = 0;
                        break;
                    case 'a':
                        p[i].culoare = 1;
                        break;
                    case 'g':
                        p[i].culoare = 2;
                        break;
                    case 'r':
                        p[i].culoare = 3;
                        break;
                    default:
                        p[i].culoare = -1;
                        p[i].eJoker = true;
                        break;
                }
                switch (poza[i][7])
                {
                    case '1':
                        switch (poza[i][8])
                        {
                            case '.':
                                p[i].numar = 1;
                                break;
                            case '0':
                                p[i].numar = 10;
                                break;
                            case '1':
                                p[i].numar = 11;
                                break;
                            case '2':
                                p[i].numar = 12;
                                break;
                            case '3':
                                p[i].numar = 13;
                                break;
                        }
                        break;
                    case '2':
                        p[i].numar = 2;
                        break;
                    case '3':
                        p[i].numar = 3;
                        break;
                    case '4':
                        p[i].numar = 4;
                        break;
                    case '5':
                        p[i].numar = 5;
                        break;
                    case '6':
                        p[i].numar = 6;
                        break;
                    case '7':
                        p[i].numar = 7;
                        break;
                    case '8':
                        p[i].numar = 8;
                        break;
                    case '9':
                        p[i].numar = 9;
                        break;
                    default:
                        p[i].numar = -1;
                        p[i].eJoker = true;
                        break;
                }

                // p[i].Top -= p[i].numar*70;    //nebunie
            }

        }
        public OperatiiPiese(Joc j, Player pl, Retea r)
        {
            joc = j;
            p = joc.p;
            ind = joc.ind;
            player = pl;
            retea = r;
            urmatoareaPiesa = 28;
            Jos = new Stack<Piesa>();
        }
    }
}
