
namespace project
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
            this.labelgagnant = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblp1name = new System.Windows.Forms.Label();
            this.lbl2plnom = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.resultat2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5dice = new System.Windows.Forms.Label();
            this.label4dice = new System.Windows.Forms.Label();
            this.label3dice = new System.Windows.Forms.Label();
            this.label2dice = new System.Windows.Forms.Label();
            this.label1dice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(170, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ROLL DICE 1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelgagnant
            // 
            this.labelgagnant.AutoSize = true;
            this.labelgagnant.ForeColor = System.Drawing.SystemColors.Info;
            this.labelgagnant.Location = new System.Drawing.Point(422, 9);
            this.labelgagnant.Name = "labelgagnant";
            this.labelgagnant.Size = new System.Drawing.Size(111, 13);
            this.labelgagnant.TabIndex = 18;
            this.labelgagnant.Text = "WAITING FOR ROLE";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(649, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "ROLL DICE 2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblp1name
            // 
            this.lblp1name.Location = new System.Drawing.Point(225, 36);
            this.lblp1name.Name = "lblp1name";
            this.lblp1name.Size = new System.Drawing.Size(100, 23);
            this.lblp1name.TabIndex = 27;
            this.lblp1name.Text = "PLAYER 1";
            // 
            // lbl2plnom
            // 
            this.lbl2plnom.AutoSize = true;
            this.lbl2plnom.Location = new System.Drawing.Point(752, 46);
            this.lbl2plnom.Name = "lbl2plnom";
            this.lbl2plnom.Size = new System.Drawing.Size(58, 13);
            this.lbl2plnom.TabIndex = 28;
            this.lbl2plnom.Text = "PLAYER 2";
            this.lbl2plnom.Click += new System.EventHandler(this.lbl2plnom_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(267, 384);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(49, 13);
            this.result.TabIndex = 29;
            this.result.Text = "SCORE";
            this.result.Click += new System.EventHandler(this.label1_Click);
            // 
            // resultat2
            // 
            this.resultat2.AutoSize = true;
            this.resultat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultat2.Location = new System.Drawing.Point(729, 384);
            this.resultat2.Name = "resultat2";
            this.resultat2.Size = new System.Drawing.Size(49, 13);
            this.resultat2.TabIndex = 30;
            this.resultat2.Text = "SCORE";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(409, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "END";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.Image = global::project.Properties.Resources.dice_0;
            this.label4.Location = new System.Drawing.Point(659, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 106);
            this.label4.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Image = global::project.Properties.Resources.dice_0;
            this.label5.Location = new System.Drawing.Point(752, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 113);
            this.label5.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.Image = global::project.Properties.Resources.dice_0;
            this.label6.Location = new System.Drawing.Point(618, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 106);
            this.label6.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.Image = global::project.Properties.Resources.dice_0;
            this.label7.Location = new System.Drawing.Point(502, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 109);
            this.label7.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Image = global::project.Properties.Resources.dice_0;
            this.label8.Location = new System.Drawing.Point(471, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 104);
            this.label8.TabIndex = 20;
            // 
            // label5dice
            // 
            this.label5dice.Image = global::project.Properties.Resources.dice_0;
            this.label5dice.Location = new System.Drawing.Point(225, 238);
            this.label5dice.Name = "label5dice";
            this.label5dice.Size = new System.Drawing.Size(202, 106);
            this.label5dice.TabIndex = 5;
            // 
            // label4dice
            // 
            this.label4dice.Image = global::project.Properties.Resources.dice_0;
            this.label4dice.Location = new System.Drawing.Point(290, 92);
            this.label4dice.Name = "label4dice";
            this.label4dice.Size = new System.Drawing.Size(118, 113);
            this.label4dice.TabIndex = 4;
            // 
            // label3dice
            // 
            this.label3dice.Image = global::project.Properties.Resources.dice_0;
            this.label3dice.Location = new System.Drawing.Point(146, 92);
            this.label3dice.Name = "label3dice";
            this.label3dice.Size = new System.Drawing.Size(115, 106);
            this.label3dice.TabIndex = 3;
            this.label3dice.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2dice
            // 
            this.label2dice.Image = global::project.Properties.Resources.dice_0;
            this.label2dice.Location = new System.Drawing.Point(34, 238);
            this.label2dice.Name = "label2dice";
            this.label2dice.Size = new System.Drawing.Size(185, 109);
            this.label2dice.TabIndex = 2;
            // 
            // label1dice
            // 
            this.label1dice.Image = global::project.Properties.Resources.dice_0;
            this.label1dice.Location = new System.Drawing.Point(12, 92);
            this.label1dice.Name = "label1dice";
            this.label1dice.Size = new System.Drawing.Size(107, 104);
            this.label1dice.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(913, 414);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.resultat2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.lbl2plnom);
            this.Controls.Add(this.lblp1name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelgagnant);
            this.Controls.Add(this.label5dice);
            this.Controls.Add(this.label4dice);
            this.Controls.Add(this.label3dice);
            this.Controls.Add(this.label2dice);
            this.Controls.Add(this.label1dice);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "MAY THE BEST WIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1dice;
        private System.Windows.Forms.Label label2dice;
        private System.Windows.Forms.Label label3dice;
        private System.Windows.Forms.Label label4dice;
        private System.Windows.Forms.Label label5dice;
        private System.Windows.Forms.Label labelgagnant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblp1name;
        private System.Windows.Forms.Label lbl2plnom;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label resultat2;
        private System.Windows.Forms.Button button3;
    }
}

