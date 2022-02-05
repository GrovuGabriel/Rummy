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
    public partial class IncheiereJoc : Form
    {
        Retea retea;
        Player player;
        Joc joc;
        public IncheiereJoc(Player pl, Retea r)
        {
            InitializeComponent();
            this.retea = r;
            this.player = pl;
            scor.Text = "Scor: " + player.scor;
            scorAdversar.Text = "Scor Adversar: " + player.scorFinalAdversar;
            if (player.amCastigat)
            {
                Text = "Ai Castigat!!!";

            }
            else
            {
                Text = "Ai pierdut :(";
                BackgroundImage = System.Drawing.Image.FromFile("Diverse\\aiPierdut.jpg");
            }
            if (!player.host)
            {
                buttonNewGame.Visible = false;
                buttonClose.Visible = false;
                labelGuest.Visible = true;
                retea.trimite("STOP");
            }
            
        }
        private async void AsteaptaComanda() 
        {
            await Task.Delay(200);
            string s = retea.primeste();
            if (s.Equals("GATA")) 
            {
                retea.trimite("OKgata");
                    await Task.Delay(200);
                Environment.Exit(Environment.ExitCode);
            }
            else if (s.Equals("start"))
            {
                joc = new Joc(player, retea);
                this.Hide();
                joc.Show();
            }

        }
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            retea.trimite("start");
            joc = new Joc(player, retea);
            this.Hide();
            joc.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            String s = "";
            while (s != "OKgata")
            {
                retea.trimite("GATA");
                s = retea.primeste();
            }
            Environment.Exit(Environment.ExitCode);
        }

        private async void IncheiereJoc_Shown(object sender, EventArgs e)
        {
            Focus();
            await Task.Delay(100);
            if(!player.host)
            AsteaptaComanda();
        }
    }
}
