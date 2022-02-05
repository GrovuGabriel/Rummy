using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rummy
{

    public partial class Joc : Form
    {
        public Piesa[] p = new Piesa[106];
        PictureBox[] a = new PictureBox[26];
        ShufflePiese shufflePiese = new ShufflePiese();
        Random random = new Random();
        public Player player;
        eroareetalare eroareEtalare;
        eroarepuncte eroarePuncte;
        public eroareLuatDeJos eroareLuatDeJos;
        public eroarePusJos eroarePusJos;
        Retea retea;
        OperatiiPiese op;

        public bool primaetalare = true;
        public int PrimaPozitieLaGrupariCuAcelasiNumar = 0;
        public int ind = 0;



        public Joc(Player p, Retea r)
        {

            InitializeComponent();
            eroarePuncte = new eroarepuncte();
            eroareEtalare = new eroareetalare();
            eroareLuatDeJos = new eroareLuatDeJos();
            eroarePusJos = new eroarePusJos();
            retea = r;
            player = p;
            if (player.host)
            {
                Text = "Host";
                player.randulMeu = true;
            }
            else
            {
                Text = "Guest";
                player.randulMeu = false;
                eRandulAdversaruluiLabel.Visible = true;
            }

            etaleaza.FlatStyle = FlatStyle.Flat;
            etaleaza.FlatAppearance.BorderSize = 0;
            colliderPuneJos.BackColor = Color.Transparent;

            op = new OperatiiPiese(this, player, retea);
            op.InitializarePiese();
            op.GenerarePictureBoxuri(a);
            op.AranjareTabla();

            IncepeRunda();
            op.PunePeTablaLaInceput();

        }





        private void etaleaza_Click(object sender, EventArgs e)
        {
            GrupariDePeTabla g = new GrupariDePeTabla(this, op);
            g.Grupeaza(a, p);
            Decide(g);
        }


        void IncepeRunda()
        {
            if (player.host)
            {
                int ran = random.Next();
                shufflePiese.SetRandom(ran);
                retea.trimite(ran.ToString());
                shufflePiese.Shuffle(p);
                for (int i = 0; i < p.Length; i++)
                    p[i].indexGenerare = i;
                for (int i = 0; i < 14; i++)
                {
                    this.Controls.Add(p[i]);
                }
            }
            else
            {
                shufflePiese.SetRandom(Int32.Parse(retea.primeste()));
                shufflePiese.Shuffle(p);
                for (int i = 0; i < p.Length; i++)
                    p[i].indexGenerare = i;
                for (int i = 14; i < 28; i++)
                {
                    this.Controls.Add(p[i]);
                }
            }
            scor.Visible = true;
            etaleaza.Visible = true;

        }


        void Decide(GrupariDePeTabla g)
        {
            if (g.sumapuncte == 0)
            {
                eroarePuncte.Show();
                eroarePuncte.Focus();
            }
            else if (primaetalare && g.sumapuncte < 45)
            {
                eroareEtalare.Show();
                eroareEtalare.Focus();
            }
            else if (primaetalare && g.sumapuncte >= 45)
            {
                player.scor += g.sumapuncte;
                primaetalare = false;
                UpdateScor();
            }
            else
            {
                player.scor += g.sumapuncte;
                UpdateScor();
            }
        }
        public void UpdateScor() 
        {
            string[] sc = new string[2];
            sc[0] = "";
            sc[1] = "";
            sc = scor.Text.Split(' ');
            scor.Text = sc[0] + " " + player.scor;
        }
        private void shakiraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = System.Drawing.Image.FromFile("Diverse\\shakira.jpg");
        }

        private void babyYodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = System.Drawing.Image.FromFile("Diverse\\bbyodaSpatiu.jpg");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!player.amLuatPiesaDeJos)
            {
                op.AdaugaPiesaPeTabla();
                player.amLuatPiesaDeJos = true;
            }
            else
            {
                try
                {
                    eroareLuatDeJos.Show();
                    eroareLuatDeJos.Focus();
                }
                finally
                { }
            }
        }

        private async void Joc_Shown(object sender, EventArgs e)
        {
            await Task.Delay(200);
            if (!player.randulMeu)
            {
                op.PrimesteInstructiuni();
                player.randulMeu = true;
            }

            while (true)
            {


                if (player.amTrimis)
                {
                    player.amTrimisScor = false;
                    player.randulMeu = false;
                    player.amTrimis = false;
                    player.amLuatPiesaDeJos = false;
                }
                await Task.Delay(100);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            op.GataJocu();
        }
    }



}



