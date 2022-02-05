
namespace Rummy
{
    partial class Conectare_Retea
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
            this.labelAlegere = new System.Windows.Forms.Label();
            this.hostButton = new System.Windows.Forms.Button();
            this.guestButton = new System.Windows.Forms.Button();
            this.intrareJocButton = new System.Windows.Forms.Button();
            this.labelMesaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAlegere
            // 
            this.labelAlegere.AutoSize = true;
            this.labelAlegere.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlegere.Location = new System.Drawing.Point(33, 9);
            this.labelAlegere.Name = "labelAlegere";
            this.labelAlegere.Size = new System.Drawing.Size(360, 66);
            this.labelAlegere.TabIndex = 0;
            this.labelAlegere.Text = "Gazduieste sau intra in joc\r\n\r\n";
            // 
            // hostButton
            // 
            this.hostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostButton.Location = new System.Drawing.Point(31, 103);
            this.hostButton.Name = "hostButton";
            this.hostButton.Size = new System.Drawing.Size(126, 52);
            this.hostButton.TabIndex = 1;
            this.hostButton.Text = "HOST";
            this.hostButton.UseVisualStyleBackColor = true;
            this.hostButton.Click += new System.EventHandler(this.hostButton_Click);
            // 
            // guestButton
            // 
            this.guestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestButton.Location = new System.Drawing.Point(267, 103);
            this.guestButton.Name = "guestButton";
            this.guestButton.Size = new System.Drawing.Size(126, 52);
            this.guestButton.TabIndex = 2;
            this.guestButton.Text = "JOIN";
            this.guestButton.UseVisualStyleBackColor = true;
            this.guestButton.Click += new System.EventHandler(this.guestButton_Click);
            // 
            // intrareJocButton
            // 
            this.intrareJocButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intrareJocButton.Location = new System.Drawing.Point(146, 103);
            this.intrareJocButton.Name = "intrareJocButton";
            this.intrareJocButton.Size = new System.Drawing.Size(126, 52);
            this.intrareJocButton.TabIndex = 4;
            this.intrareJocButton.Text = "Intra in joc\r\n";
            this.intrareJocButton.UseVisualStyleBackColor = true;
            this.intrareJocButton.Visible = false;
            this.intrareJocButton.Click += new System.EventHandler(this.intrareJocButton_Click);
            // 
            // labelMesaje
            // 
            this.labelMesaje.AutoSize = true;
            this.labelMesaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMesaje.Location = new System.Drawing.Point(0, 26);
            this.labelMesaje.Name = "labelMesaje";
            this.labelMesaje.Size = new System.Drawing.Size(0, 15);
            this.labelMesaje.TabIndex = 5;
            // 
            // Conectare_Retea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 200);
            this.Controls.Add(this.labelMesaje);
            this.Controls.Add(this.intrareJocButton);
            this.Controls.Add(this.guestButton);
            this.Controls.Add(this.hostButton);
            this.Controls.Add(this.labelAlegere);
            this.Name = "Conectare_Retea";
            this.Text = "Conectare_Retea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlegere;
        private System.Windows.Forms.Button hostButton;
        private System.Windows.Forms.Button guestButton;
        private System.Windows.Forms.Button intrareJocButton;
        public System.Windows.Forms.Label labelMesaje;
    }
}