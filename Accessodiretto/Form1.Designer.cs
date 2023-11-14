namespace Accessodiretto
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Aggiungi = new System.Windows.Forms.Button();
            this.cerca = new System.Windows.Forms.Button();
            this.visualizza = new System.Windows.Forms.Button();
            this.modifica = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.cancfisic = new System.Windows.Forms.Button();
            this.recuperare = new System.Windows.Forms.Button();
            this.cancellalogic = new System.Windows.Forms.Button();
            this.proddacerc = new System.Windows.Forms.TextBox();
            this.prezdamod = new System.Windows.Forms.TextBox();
            this.proddamod = new System.Windows.Forms.TextBox();
            this.prezzo = new System.Windows.Forms.TextBox();
            this.prodotto = new System.Windows.Forms.TextBox();
            this.proddacanclogic = new System.Windows.Forms.TextBox();
            this.proddacancfisic = new System.Windows.Forms.TextBox();
            this.proddarecu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "prodotto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "cerca prodotto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "recupera prodotto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "cancellazione logica";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "prezzo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "prezzo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "cancellazione fisica";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "prodotto";
            // 
            // Aggiungi
            // 
            this.Aggiungi.Location = new System.Drawing.Point(12, 61);
            this.Aggiungi.Name = "Aggiungi";
            this.Aggiungi.Size = new System.Drawing.Size(160, 42);
            this.Aggiungi.TabIndex = 8;
            this.Aggiungi.Text = "Aggiungi";
            this.Aggiungi.UseVisualStyleBackColor = true;
            this.Aggiungi.Click += new System.EventHandler(this.Aggiungi_Click);
            // 
            // cerca
            // 
            this.cerca.Location = new System.Drawing.Point(227, 61);
            this.cerca.Name = "cerca";
            this.cerca.Size = new System.Drawing.Size(115, 42);
            this.cerca.TabIndex = 9;
            this.cerca.Text = "cerca";
            this.cerca.UseVisualStyleBackColor = true;
            this.cerca.Click += new System.EventHandler(this.cerca_Click);
            // 
            // visualizza
            // 
            this.visualizza.Location = new System.Drawing.Point(735, 35);
            this.visualizza.Name = "visualizza";
            this.visualizza.Size = new System.Drawing.Size(178, 42);
            this.visualizza.TabIndex = 10;
            this.visualizza.Text = "Visualizza file";
            this.visualizza.UseVisualStyleBackColor = true;
            this.visualizza.Click += new System.EventHandler(this.visualizza_Click);
            // 
            // modifica
            // 
            this.modifica.Location = new System.Drawing.Point(390, 61);
            this.modifica.Name = "modifica";
            this.modifica.Size = new System.Drawing.Size(165, 42);
            this.modifica.TabIndex = 11;
            this.modifica.Text = "modifica";
            this.modifica.UseVisualStyleBackColor = true;
            this.modifica.Click += new System.EventHandler(this.modifica_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(750, 94);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(153, 42);
            this.reset.TabIndex = 12;
            this.reset.Text = "resetta file";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // cancfisic
            // 
            this.cancfisic.Location = new System.Drawing.Point(337, 176);
            this.cancfisic.Name = "cancfisic";
            this.cancfisic.Size = new System.Drawing.Size(145, 42);
            this.cancfisic.TabIndex = 13;
            this.cancfisic.Text = "Cancellazione fisica";
            this.cancfisic.UseVisualStyleBackColor = true;
            this.cancfisic.Click += new System.EventHandler(this.cancfisic_Click);
            // 
            // recuperare
            // 
            this.recuperare.Location = new System.Drawing.Point(171, 176);
            this.recuperare.Name = "recuperare";
            this.recuperare.Size = new System.Drawing.Size(122, 42);
            this.recuperare.TabIndex = 14;
            this.recuperare.Text = "recupera";
            this.recuperare.UseVisualStyleBackColor = true;
            this.recuperare.Click += new System.EventHandler(this.recuperare_Click);
            // 
            // cancellalogic
            // 
            this.cancellalogic.Location = new System.Drawing.Point(12, 176);
            this.cancellalogic.Name = "cancellalogic";
            this.cancellalogic.Size = new System.Drawing.Size(124, 42);
            this.cancellalogic.TabIndex = 15;
            this.cancellalogic.Text = "cancellazione logica";
            this.cancellalogic.UseVisualStyleBackColor = true;
            this.cancellalogic.Click += new System.EventHandler(this.cancellalogic_Click);
            // 
            // proddacerc
            // 
            this.proddacerc.Location = new System.Drawing.Point(227, 35);
            this.proddacerc.Name = "proddacerc";
            this.proddacerc.Size = new System.Drawing.Size(110, 20);
            this.proddacerc.TabIndex = 16;
            // 
            // prezdamod
            // 
            this.prezdamod.Location = new System.Drawing.Point(498, 35);
            this.prezdamod.Name = "prezdamod";
            this.prezdamod.Size = new System.Drawing.Size(67, 20);
            this.prezdamod.TabIndex = 17;
            // 
            // proddamod
            // 
            this.proddamod.Location = new System.Drawing.Point(390, 35);
            this.proddamod.Name = "proddamod";
            this.proddamod.Size = new System.Drawing.Size(92, 20);
            this.proddamod.TabIndex = 18;
            // 
            // prezzo
            // 
            this.prezzo.Location = new System.Drawing.Point(110, 35);
            this.prezzo.Name = "prezzo";
            this.prezzo.Size = new System.Drawing.Size(62, 20);
            this.prezzo.TabIndex = 19;
            // 
            // prodotto
            // 
            this.prodotto.Location = new System.Drawing.Point(12, 35);
            this.prodotto.Name = "prodotto";
            this.prodotto.Size = new System.Drawing.Size(92, 20);
            this.prodotto.TabIndex = 20;
            // 
            // proddacanclogic
            // 
            this.proddacanclogic.Location = new System.Drawing.Point(15, 150);
            this.proddacanclogic.Name = "proddacanclogic";
            this.proddacanclogic.Size = new System.Drawing.Size(124, 20);
            this.proddacanclogic.TabIndex = 21;
            // 
            // proddacancfisic
            // 
            this.proddacancfisic.Location = new System.Drawing.Point(337, 150);
            this.proddacancfisic.Name = "proddacancfisic";
            this.proddacancfisic.Size = new System.Drawing.Size(145, 20);
            this.proddacancfisic.TabIndex = 22;
            // 
            // proddarecu
            // 
            this.proddarecu.Location = new System.Drawing.Point(171, 150);
            this.proddarecu.Name = "proddarecu";
            this.proddarecu.Size = new System.Drawing.Size(122, 20);
            this.proddarecu.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 403);
            this.Controls.Add(this.proddarecu);
            this.Controls.Add(this.proddacancfisic);
            this.Controls.Add(this.proddacanclogic);
            this.Controls.Add(this.prodotto);
            this.Controls.Add(this.prezzo);
            this.Controls.Add(this.proddamod);
            this.Controls.Add(this.prezdamod);
            this.Controls.Add(this.proddacerc);
            this.Controls.Add(this.cancellalogic);
            this.Controls.Add(this.recuperare);
            this.Controls.Add(this.cancfisic);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.modifica);
            this.Controls.Add(this.visualizza);
            this.Controls.Add(this.cerca);
            this.Controls.Add(this.Aggiungi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Aggiungi;
        private System.Windows.Forms.Button cerca;
        private System.Windows.Forms.Button visualizza;
        private System.Windows.Forms.Button modifica;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button cancfisic;
        private System.Windows.Forms.Button recuperare;
        private System.Windows.Forms.Button cancellalogic;
        private System.Windows.Forms.TextBox proddacerc;
        private System.Windows.Forms.TextBox prezdamod;
        private System.Windows.Forms.TextBox proddamod;
        private System.Windows.Forms.TextBox prezzo;
        private System.Windows.Forms.TextBox prodotto;
        private System.Windows.Forms.TextBox proddacanclogic;
        private System.Windows.Forms.TextBox proddacancfisic;
        private System.Windows.Forms.TextBox proddarecu;
    }
}

