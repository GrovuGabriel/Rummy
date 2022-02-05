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
    public partial class Conectare_Retea : Form
    {
        
        Player player;
        Joc joc;
        Retea retea;
        public Conectare_Retea()
        {
            InitializeComponent();
            player = new Player();
        }

        private void hostButton_Click(object sender, EventArgs e)
        {
            player.host = true;
            labelAlegere.Visible = false;
            hostButton.Visible = false;
            guestButton.Visible = false;
            intrareJocButton.Visible = true;
            retea = new Retea(player.host,this);
            retea.conectare();
        }
        private void guestButton_Click(object sender, EventArgs e)
        {
            player.host = false;
            labelAlegere.Visible = false;
            hostButton.Visible = false;
            guestButton.Visible = false;
            retea = new Retea(player.host,this);
            retea.conectare();
            if (retea.primeste().Equals("start"))
            {
                joc = new Joc(player,retea);
                this.Hide();
                joc.Show();
            }

        }
        private void intrareJocButton_Click(object sender, EventArgs e)
        {
            retea.trimite("start");
            joc = new Joc(player,retea);
            this.Hide();
            joc.Show();
        }
    }
}
