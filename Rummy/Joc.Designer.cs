
namespace Rummy
{
    partial class Joc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Joc));
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.adversar = new System.Windows.Forms.ToolStripMenuItem();
            this.shakiraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.babyYodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.scor = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.scorAdversar = new System.Windows.Forms.ToolStripLabel();
            this.etaleaza = new System.Windows.Forms.Button();
            this.IaPiesaButton = new System.Windows.Forms.PictureBox();
            this.colliderPuneJos = new System.Windows.Forms.PictureBox();
            this.eRandulAdversaruluiLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IaPiesaButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colliderPuneJos)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.scor,
            this.toolStripButton1,
            this.scorAdversar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adversar});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(60, 22);
            this.toolStripDropDownButton1.Text = "Optiuni";
            // 
            // adversar
            // 
            this.adversar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shakiraToolStripMenuItem,
            this.babyYodaToolStripMenuItem});
            this.adversar.Name = "adversar";
            this.adversar.Size = new System.Drawing.Size(175, 22);
            this.adversar.Text = "Selecteaza adversar";
            // 
            // shakiraToolStripMenuItem
            // 
            this.shakiraToolStripMenuItem.Name = "shakiraToolStripMenuItem";
            this.shakiraToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.shakiraToolStripMenuItem.Text = "Shakira";
            this.shakiraToolStripMenuItem.Click += new System.EventHandler(this.shakiraToolStripMenuItem_Click);
            // 
            // babyYodaToolStripMenuItem
            // 
            this.babyYodaToolStripMenuItem.Name = "babyYodaToolStripMenuItem";
            this.babyYodaToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.babyYodaToolStripMenuItem.Text = "Baby Yoda";
            this.babyYodaToolStripMenuItem.Click += new System.EventHandler(this.babyYodaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // scor
            // 
            this.scor.ForeColor = System.Drawing.Color.Blue;
            this.scor.Name = "scor";
            this.scor.Size = new System.Drawing.Size(42, 22);
            this.scor.Text = "Scor: 0";
            this.scor.Visible = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(6, 25);
            // 
            // scorAdversar
            // 
            this.scorAdversar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.scorAdversar.ForeColor = System.Drawing.Color.Red;
            this.scorAdversar.Image = ((System.Drawing.Image)(resources.GetObject("scorAdversar.Image")));
            this.scorAdversar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scorAdversar.Name = "scorAdversar";
            this.scorAdversar.Size = new System.Drawing.Size(91, 22);
            this.scorAdversar.Text = "Scor Adversar: 0";
            // 
            // etaleaza
            // 
            this.etaleaza.BackColor = System.Drawing.Color.Transparent;
            this.etaleaza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("etaleaza.BackgroundImage")));
            this.etaleaza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.etaleaza.Location = new System.Drawing.Point(1105, 906);
            this.etaleaza.Name = "etaleaza";
            this.etaleaza.Size = new System.Drawing.Size(147, 43);
            this.etaleaza.TabIndex = 3;
            this.etaleaza.UseVisualStyleBackColor = true;
            this.etaleaza.Visible = false;
            this.etaleaza.Click += new System.EventHandler(this.etaleaza_Click);
            // 
            // IaPiesaButton
            // 
            this.IaPiesaButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IaPiesaButton.BackgroundImage")));
            this.IaPiesaButton.Location = new System.Drawing.Point(12, 874);
            this.IaPiesaButton.Name = "IaPiesaButton";
            this.IaPiesaButton.Size = new System.Drawing.Size(50, 75);
            this.IaPiesaButton.TabIndex = 7;
            this.IaPiesaButton.TabStop = false;
            this.IaPiesaButton.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // colliderPuneJos
            // 
            this.colliderPuneJos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("colliderPuneJos.BackgroundImage")));
            this.colliderPuneJos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.colliderPuneJos.Location = new System.Drawing.Point(43, 666);
            this.colliderPuneJos.Name = "colliderPuneJos";
            this.colliderPuneJos.Size = new System.Drawing.Size(75, 75);
            this.colliderPuneJos.TabIndex = 8;
            this.colliderPuneJos.TabStop = false;
            // 
            // eRandulAdversaruluiLabel
            // 
            this.eRandulAdversaruluiLabel.AutoSize = true;
            this.eRandulAdversaruluiLabel.BackColor = System.Drawing.Color.Transparent;
            this.eRandulAdversaruluiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eRandulAdversaruluiLabel.ForeColor = System.Drawing.Color.Red;
            this.eRandulAdversaruluiLabel.Location = new System.Drawing.Point(321, 333);
            this.eRandulAdversaruluiLabel.Name = "eRandulAdversaruluiLabel";
            this.eRandulAdversaruluiLabel.Size = new System.Drawing.Size(638, 73);
            this.eRandulAdversaruluiLabel.TabIndex = 9;
            this.eRandulAdversaruluiLabel.Text = "E randul adversarului";
            this.eRandulAdversaruluiLabel.Visible = false;
            // 
            // Joc
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 961);
            this.Controls.Add(this.eRandulAdversaruluiLabel);
            this.Controls.Add(this.colliderPuneJos);
            this.Controls.Add(this.IaPiesaButton);
            this.Controls.Add(this.etaleaza);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Joc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.Joc_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IaPiesaButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colliderPuneJos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button etaleaza;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripLabel scor;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem adversar;
        private System.Windows.Forms.ToolStripMenuItem shakiraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem babyYodaToolStripMenuItem;
        private System.Windows.Forms.PictureBox IaPiesaButton;
        private System.Windows.Forms.ToolStripSeparator toolStripButton1;
        public System.Windows.Forms.ToolStripLabel scorAdversar;
        public System.Windows.Forms.PictureBox colliderPuneJos;
        public System.Windows.Forms.Label eRandulAdversaruluiLabel;
    }
}

