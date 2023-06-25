namespace Gorsel2018
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnIlerleme = new System.Windows.Forms.Button();
            this.btnHareket = new System.Windows.Forms.Button();
            this.btnListe = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnHesap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIlerleme
            // 
            this.btnIlerleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIlerleme.BackgroundImage = global::Gorsel2018.Properties.Resources.ball;
            this.btnIlerleme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIlerleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIlerleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIlerleme.ForeColor = System.Drawing.Color.Maroon;
            this.btnIlerleme.Location = new System.Drawing.Point(47, 239);
            this.btnIlerleme.Margin = new System.Windows.Forms.Padding(4);
            this.btnIlerleme.Name = "btnIlerleme";
            this.btnIlerleme.Size = new System.Drawing.Size(120, 100);
            this.btnIlerleme.TabIndex = 5;
            this.btnIlerleme.UseVisualStyleBackColor = false;
            this.btnIlerleme.Click += new System.EventHandler(this.btnIlerleme_Click);
            // 
            // btnHareket
            // 
            this.btnHareket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHareket.BackgroundImage = global::Gorsel2018.Properties.Resources.keyboard;
            this.btnHareket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHareket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHareket.Location = new System.Drawing.Point(195, 131);
            this.btnHareket.Margin = new System.Windows.Forms.Padding(4);
            this.btnHareket.Name = "btnHareket";
            this.btnHareket.Size = new System.Drawing.Size(120, 100);
            this.btnHareket.TabIndex = 4;
            this.btnHareket.UseVisualStyleBackColor = false;
            this.btnHareket.Click += new System.EventHandler(this.btnHareket_Click);
            // 
            // btnListe
            // 
            this.btnListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnListe.BackgroundImage = global::Gorsel2018.Properties.Resources.list;
            this.btnListe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListe.Location = new System.Drawing.Point(47, 131);
            this.btnListe.Margin = new System.Windows.Forms.Padding(4);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(120, 100);
            this.btnListe.TabIndex = 3;
            this.btnListe.UseVisualStyleBackColor = false;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnKapat.BackgroundImage = global::Gorsel2018.Properties.Resources.Actions_window_close_icon;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Location = new System.Drawing.Point(195, 239);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(120, 100);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTimer.BackgroundImage = global::Gorsel2018.Properties.Resources.Alarm_clock_icon;
            this.btnTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimer.Location = new System.Drawing.Point(195, 23);
            this.btnTimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(120, 100);
            this.btnTimer.TabIndex = 1;
            this.btnTimer.UseVisualStyleBackColor = false;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // btnHesap
            // 
            this.btnHesap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHesap.BackgroundImage = global::Gorsel2018.Properties.Resources.Calculator_icon;
            this.btnHesap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHesap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesap.Location = new System.Drawing.Point(47, 23);
            this.btnHesap.Margin = new System.Windows.Forms.Padding(4);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(120, 100);
            this.btnHesap.TabIndex = 0;
            this.btnHesap.UseVisualStyleBackColor = false;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(363, 367);
            this.Controls.Add(this.btnIlerleme);
            this.Controls.Add(this.btnHareket);
            this.Controls.Add(this.btnListe);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.btnHesap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Uygulamalar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnListe;
        private System.Windows.Forms.Button btnHareket;
        private System.Windows.Forms.Button btnIlerleme;
    }
}

