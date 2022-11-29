
namespace CSharpLearn
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Rechts = new System.Windows.Forms.Button();
            this.Oben = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Unten = new System.Windows.Forms.Button();
            this.Mitte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(359, 412);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.UseWaitCursor = true;
            this.Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CSharpLearn.Properties.Resources.F4jQ;
            this.pictureBox1.Location = new System.Drawing.Point(190, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 263);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // Rechts
            // 
            this.Rechts.Location = new System.Drawing.Point(472, 385);
            this.Rechts.Name = "Rechts";
            this.Rechts.Size = new System.Drawing.Size(75, 23);
            this.Rechts.TabIndex = 2;
            this.Rechts.Text = "Rechts";
            this.Rechts.UseVisualStyleBackColor = true;
            this.Rechts.UseWaitCursor = true;
            this.Rechts.Click += new System.EventHandler(this.Rechts_Click_1);
            // 
            // Oben
            // 
            this.Oben.Location = new System.Drawing.Point(359, 324);
            this.Oben.Name = "Oben";
            this.Oben.Size = new System.Drawing.Size(75, 23);
            this.Oben.TabIndex = 3;
            this.Oben.Text = "Oben";
            this.Oben.UseVisualStyleBackColor = true;
            this.Oben.UseWaitCursor = true;
            this.Oben.Click += new System.EventHandler(this.Oben_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(240, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Links";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.UseWaitCursor = true;
            this.button3.Click += new System.EventHandler(this.Links_Click);
            // 
            // Unten
            // 
            this.Unten.Location = new System.Drawing.Point(359, 458);
            this.Unten.Name = "Unten";
            this.Unten.Size = new System.Drawing.Size(75, 23);
            this.Unten.TabIndex = 5;
            this.Unten.Text = "Unten";
            this.Unten.UseVisualStyleBackColor = true;
            this.Unten.UseWaitCursor = true;
            this.Unten.Click += new System.EventHandler(this.Unten_Click);
            // 
            // Mitte
            // 
            this.Mitte.Location = new System.Drawing.Point(359, 369);
            this.Mitte.Name = "Mitte";
            this.Mitte.Size = new System.Drawing.Size(75, 23);
            this.Mitte.TabIndex = 6;
            this.Mitte.Text = "Mitte";
            this.Mitte.UseVisualStyleBackColor = true;
            this.Mitte.UseWaitCursor = true;
            this.Mitte.Click += new System.EventHandler(this.Mitte_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(861, 493);
            this.Controls.Add(this.Mitte);
            this.Controls.Add(this.Unten);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Oben);
            this.Controls.Add(this.Rechts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "Form1";
            this.Text = "CSharp";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Rechts;
        private System.Windows.Forms.Button Oben;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Unten;
        private System.Windows.Forms.Button Mitte;
    }
}

