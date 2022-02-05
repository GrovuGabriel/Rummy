using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Rummy
{
    public class Piesa : PictureBox
    {   Joc joc;
        OperatiiPiese op;
        Point locatie;
        public int numar;        //1-13
        public int culoare;      //0-negru 1-albastru 2-galben 3-rosu
        public int prima;        //0 daca e prima 1 daca e a 2a
        public int indexGenerare;
        public int stateGrupare; //0-negrupat 1-grupa consecutiva(culoare) 2-grupa acelasi(numar)
        public bool eJoker;
        public bool eJos;
        public bool peTabla;
        public bool okConcatenare;
        public bool mutabil;
        public int indexAranjare;
        public int caracteristicaPiesaCareSeLipesteDeMine;
        public bool teLipestiDeMineInDreapta;

        public void aranjare()
        {
            for (int j = 0; j < 13; j ++)
            {
                int i = j * 65 + 215;
                if (Left > i - 35 && Left < i + 35&&Top<=837&&Top>700)
                { 
                    Left = i;
                    Top = 797;
                    peTabla = true;
                    indexAranjare = joc.ind;
                }
                if (Left > i - 35 && Left < i + 35 && Top <= 950 && Top > 837)
                {
                    Left = i;
                    Top = 885;
                    peTabla = true;
                    indexAranjare = joc.ind;
                }
                
            }
            joc.ind++;
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            locatie = e.Location;
            this.BringToFront();
            if (eJos)
            {
                op.IaPieseDeJos(this);
            }
            base.OnMouseDown(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            aranjare();
            if (this.Bounds.IntersectsWith(joc.colliderPuneJos.Bounds))
            {
                if (joc.player.amLuatPiesaDeJos)
                    op.AdaugaPiesaJos(this);
                else
                {
                    joc.eroarePusJos.Show();
                    Left = 215;
                    Top = 790;
                    aranjare();
                }
            }
            if (Top < 665&&mutabil)
            {
                op.ConcateneazaLaGrupare(this);
            }
            base.OnMouseUp(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left&&mutabil)
            {
                this.Left += e.X - locatie.X;
                this.Top += e.Y - locatie.Y;
            }
            base.OnMouseMove(e);
        }
        public Piesa(Joc j, OperatiiPiese o) {
            Top = 874;
            Left = 12;
            Size = new Size(50, 75);
            peTabla=false;
            indexAranjare = -1;
            eJoker = false;
            joc = j;
            op = o;
            stateGrupare = 0;
            mutabil = true;
            caracteristicaPiesaCareSeLipesteDeMine = -1;
            teLipestiDeMineInDreapta = false;
            eJos = false;
        }
        public Piesa()
        {
            Top = 874;
            Left = 12;
            Size = new Size(50, 75);
            peTabla = false;
            indexAranjare = -1;
            eJoker = false;
            okConcatenare = false;
            eJos = false;
        }
    }
}
