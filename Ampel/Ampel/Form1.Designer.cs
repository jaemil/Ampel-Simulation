namespace Ampel
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
            this.components = new System.ComponentModel.Container();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.ptBAuto = new System.Windows.Forms.PictureBox();
            this.ptBAmpel = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptBAuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptBAmpel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(338, 94);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(93, 79);
            this.btnstart.TabIndex = 2;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(338, 179);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(93, 79);
            this.btnstop.TabIndex = 3;
            this.btnstop.Text = "Stopp";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // ptBAuto
            // 
            this.ptBAuto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptBAuto.Image = global::Ampel.Properties.Resources.auto;
            this.ptBAuto.Location = new System.Drawing.Point(20, 376);
            this.ptBAuto.Name = "ptBAuto";
            this.ptBAuto.Size = new System.Drawing.Size(100, 50);
            this.ptBAuto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptBAuto.TabIndex = 1;
            this.ptBAuto.TabStop = false;
            // 
            // ptBAmpel
            // 
            this.ptBAmpel.Image = global::Ampel.Properties.Resources._1Rot;
            this.ptBAmpel.Location = new System.Drawing.Point(179, 12);
            this.ptBAmpel.Name = "ptBAmpel";
            this.ptBAmpel.Size = new System.Drawing.Size(109, 309);
            this.ptBAmpel.TabIndex = 0;
            this.ptBAmpel.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.ptBAuto);
            this.Controls.Add(this.ptBAmpel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptBAuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptBAmpel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptBAmpel;
        private System.Windows.Forms.PictureBox ptBAuto;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

