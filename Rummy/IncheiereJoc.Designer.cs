
namespace Rummy
{
    partial class IncheiereJoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncheiereJoc));
            this.scorAdversar = new System.Windows.Forms.Label();
            this.scor = new System.Windows.Forms.Label();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelGuest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scorAdversar
            // 
            this.scorAdversar.AutoSize = true;
            this.scorAdversar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorAdversar.Location = new System.Drawing.Point(598, 403);
            this.scorAdversar.Name = "scorAdversar";
            this.scorAdversar.Size = new System.Drawing.Size(0, 25);
            this.scorAdversar.TabIndex = 0;
            // 
            // scor
            // 
            this.scor.AutoSize = true;
            this.scor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scor.Location = new System.Drawing.Point(598, 356);
            this.scor.Name = "scor";
            this.scor.Size = new System.Drawing.Size(0, 25);
            this.scor.TabIndex = 1;
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewGame.Location = new System.Drawing.Point(47, 285);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(179, 47);
            this.buttonNewGame.TabIndex = 2;
            this.buttonNewGame.Text = "Joaca din nou";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(47, 338);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(179, 47);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Inchide jocul";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelGuest
            // 
            this.labelGuest.AutoSize = true;
            this.labelGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuest.ForeColor = System.Drawing.Color.Red;
            this.labelGuest.Location = new System.Drawing.Point(251, 9);
            this.labelGuest.Name = "labelGuest";
            this.labelGuest.Size = new System.Drawing.Size(347, 24);
            this.labelGuest.TabIndex = 4;
            this.labelGuest.Text = "Host-ul va decide daca mai jucati sau nu";
            this.labelGuest.Visible = false;
            // 
            // IncheiereJoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.labelGuest);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.scor);
            this.Controls.Add(this.scorAdversar);
            this.Name = "IncheiereJoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IncheiereJoc";
            this.Shown += new System.EventHandler(this.IncheiereJoc_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scorAdversar;
        private System.Windows.Forms.Label scor;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelGuest;
    }
}