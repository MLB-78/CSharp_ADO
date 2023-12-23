namespace MYSQL___ADO
{
    partial class FicheAuteur
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
            this.lab_num = new System.Windows.Forms.Label();
            this.lab_nom = new System.Windows.Forms.Label();
            this.lab_prenom = new System.Windows.Forms.Label();
            this.lab_Nationalite = new System.Windows.Forms.Label();
            this.textNum = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.textNationalite = new System.Windows.Forms.TextBox();
            this.btn_annule = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_num
            // 
            this.lab_num.AutoSize = true;
            this.lab_num.Location = new System.Drawing.Point(37, 43);
            this.lab_num.Name = "lab_num";
            this.lab_num.Size = new System.Drawing.Size(55, 16);
            this.lab_num.TabIndex = 0;
            this.lab_num.Text = "Numéro";
            this.lab_num.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_nom
            // 
            this.lab_nom.AutoSize = true;
            this.lab_nom.Location = new System.Drawing.Point(37, 92);
            this.lab_nom.Name = "lab_nom";
            this.lab_nom.Size = new System.Drawing.Size(36, 16);
            this.lab_nom.TabIndex = 1;
            this.lab_nom.Text = "Nom";
            // 
            // lab_prenom
            // 
            this.lab_prenom.AutoSize = true;
            this.lab_prenom.Location = new System.Drawing.Point(38, 135);
            this.lab_prenom.Name = "lab_prenom";
            this.lab_prenom.Size = new System.Drawing.Size(54, 16);
            this.lab_prenom.TabIndex = 2;
            this.lab_prenom.Text = "Prénom";
            // 
            // lab_Nationalite
            // 
            this.lab_Nationalite.AutoSize = true;
            this.lab_Nationalite.Location = new System.Drawing.Point(38, 186);
            this.lab_Nationalite.Name = "lab_Nationalite";
            this.lab_Nationalite.Size = new System.Drawing.Size(71, 16);
            this.lab_Nationalite.TabIndex = 3;
            this.lab_Nationalite.Text = "Nationalité";
            // 
            // textNum
            // 
            this.textNum.Location = new System.Drawing.Point(198, 43);
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(100, 22);
            this.textNum.TabIndex = 4;
            this.textNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(198, 92);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(100, 22);
            this.textNom.TabIndex = 7;
            this.textNom.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textPrenom
            // 
            this.textPrenom.Location = new System.Drawing.Point(198, 135);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(100, 22);
            this.textPrenom.TabIndex = 8;
            // 
            // textNationalite
            // 
            this.textNationalite.Location = new System.Drawing.Point(198, 186);
            this.textNationalite.Name = "textNationalite";
            this.textNationalite.Size = new System.Drawing.Size(100, 22);
            this.textNationalite.TabIndex = 9;
            // 
            // btn_annule
            // 
            this.btn_annule.Location = new System.Drawing.Point(34, 293);
            this.btn_annule.Name = "btn_annule";
            this.btn_annule.Size = new System.Drawing.Size(75, 23);
            this.btn_annule.TabIndex = 10;
            this.btn_annule.Text = "Annuler";
            this.btn_annule.UseVisualStyleBackColor = true;
            this.btn_annule.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(223, 293);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 11;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // FicheAuteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btn_annule);
            this.Controls.Add(this.textNationalite);
            this.Controls.Add(this.textPrenom);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.textNum);
            this.Controls.Add(this.lab_Nationalite);
            this.Controls.Add(this.lab_prenom);
            this.Controls.Add(this.lab_nom);
            this.Controls.Add(this.lab_num);
            this.Name = "FicheAuteur";
            this.Text = "FicheAuteur";
            this.Load += new System.EventHandler(this.FicheAuteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_num;
        private System.Windows.Forms.Label lab_nom;
        private System.Windows.Forms.Label lab_prenom;
        private System.Windows.Forms.Label lab_Nationalite;
        private System.Windows.Forms.TextBox textNum;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.TextBox textNationalite;
        private System.Windows.Forms.Button btn_annule;
        private System.Windows.Forms.Button btn_valider;
    }
}