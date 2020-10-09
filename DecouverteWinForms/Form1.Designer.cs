namespace DecouverteWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.TextBoxResultat = new System.Windows.Forms.TextBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMoins = new System.Windows.Forms.Button();
            this.buttonMultiplier = new System.Windows.Forms.Button();
            this.buttonDiviser = new System.Windows.Forms.Button();
            this.buttonEgal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClickChiffre);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ClickChiffre);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(392, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ClickChiffre);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(230, 126);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ClickChiffre);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(311, 126);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ClickChiffre);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(392, 126);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ClickChiffre);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(230, 155);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ClickChiffre);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(311, 155);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ClickChiffre);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(392, 155);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.ClickChiffre);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(311, 184);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 23);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.ClickChiffre);
            // 
            // TextBoxResultat
            // 
            this.TextBoxResultat.Location = new System.Drawing.Point(230, 232);
            this.TextBoxResultat.Name = "TextBoxResultat";
            this.TextBoxResultat.Size = new System.Drawing.Size(237, 20);
            this.TextBoxResultat.TabIndex = 2;
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(499, 96);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(75, 23);
            this.buttonPlus.TabIndex = 10;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonClickOperation);
            // 
            // buttonMoins
            // 
            this.buttonMoins.Location = new System.Drawing.Point(499, 125);
            this.buttonMoins.Name = "buttonMoins";
            this.buttonMoins.Size = new System.Drawing.Size(75, 23);
            this.buttonMoins.TabIndex = 11;
            this.buttonMoins.Text = "-";
            this.buttonMoins.UseVisualStyleBackColor = true;
            this.buttonMoins.Click += new System.EventHandler(this.buttonClickOperation);
            // 
            // buttonMultiplier
            // 
            this.buttonMultiplier.Location = new System.Drawing.Point(499, 155);
            this.buttonMultiplier.Name = "buttonMultiplier";
            this.buttonMultiplier.Size = new System.Drawing.Size(75, 23);
            this.buttonMultiplier.TabIndex = 12;
            this.buttonMultiplier.Text = "*";
            this.buttonMultiplier.UseVisualStyleBackColor = true;
            this.buttonMultiplier.Click += new System.EventHandler(this.buttonClickOperation);
            // 
            // buttonDiviser
            // 
            this.buttonDiviser.Location = new System.Drawing.Point(499, 184);
            this.buttonDiviser.Name = "buttonDiviser";
            this.buttonDiviser.Size = new System.Drawing.Size(75, 23);
            this.buttonDiviser.TabIndex = 13;
            this.buttonDiviser.Text = "/";
            this.buttonDiviser.UseVisualStyleBackColor = true;
            this.buttonDiviser.Click += new System.EventHandler(this.buttonClickOperation);
            // 
            // buttonEgal
            // 
            this.buttonEgal.Location = new System.Drawing.Point(499, 229);
            this.buttonEgal.Name = "buttonEgal";
            this.buttonEgal.Size = new System.Drawing.Size(75, 23);
            this.buttonEgal.TabIndex = 14;
            this.buttonEgal.Text = "=";
            this.buttonEgal.UseVisualStyleBackColor = true;
            this.buttonEgal.Click += new System.EventHandler(this.buttonEgal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEgal);
            this.Controls.Add(this.buttonDiviser);
            this.Controls.Add(this.buttonMultiplier);
            this.Controls.Add(this.buttonMoins);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.TextBoxResultat);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.TextBox TextBoxResultat;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMoins;
        private System.Windows.Forms.Button buttonMultiplier;
        private System.Windows.Forms.Button buttonDiviser;
        private System.Windows.Forms.Button buttonEgal;
    }
}

