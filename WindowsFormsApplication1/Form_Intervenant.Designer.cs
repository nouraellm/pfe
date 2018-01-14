namespace WindowsFormsApplication1
{
    partial class Form_Intervenant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Intervenant));
            this.label7 = new System.Windows.Forms.Label();
            this.btn_modifie = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txttele = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtadresse = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmpmat = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnsupprime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(25, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "matricule";
            // 
            // btn_modifie
            // 
            this.btn_modifie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifie.Image = global::WindowsFormsApplication1.Properties.Resources.update;
            this.btn_modifie.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_modifie.Location = new System.Drawing.Point(191, 249);
            this.btn_modifie.Name = "btn_modifie";
            this.btn_modifie.Size = new System.Drawing.Size(120, 95);
            this.btn_modifie.TabIndex = 37;
            this.btn_modifie.Text = "Modifier";
            this.btn_modifie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_modifie.UseVisualStyleBackColor = true;
            this.btn_modifie.Click += new System.EventHandler(this.btn_modifie_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApplication1.Properties.Resources.add;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(65, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 95);
            this.button1.TabIndex = 36;
            this.button1.Text = "Ajouter";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttele
            // 
            this.txttele.Location = new System.Drawing.Point(101, 194);
            this.txttele.Name = "txttele";
            this.txttele.Size = new System.Drawing.Size(336, 20);
            this.txttele.TabIndex = 5;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(101, 166);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(336, 20);
            this.txtemail.TabIndex = 4;
            // 
            // txtadresse
            // 
            this.txtadresse.Location = new System.Drawing.Point(101, 118);
            this.txtadresse.Multiline = true;
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.Size = new System.Drawing.Size(336, 41);
            this.txtadresse.TabIndex = 3;
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(101, 91);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(336, 20);
            this.txtprenom.TabIndex = 2;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(101, 63);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(336, 20);
            this.txtnom.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(17, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = " Telephone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(47, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = " Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(33, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = " Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(23, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = " * Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(42, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = " * Nom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(326, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "* champs obligatoires";
            // 
            // cmpmat
            // 
            this.cmpmat.Enabled = false;
            this.cmpmat.FormattingEnabled = true;
            this.cmpmat.Location = new System.Drawing.Point(101, 35);
            this.cmpmat.Name = "cmpmat";
            this.cmpmat.Size = new System.Drawing.Size(315, 21);
            this.cmpmat.TabIndex = 41;
            this.cmpmat.SelectedIndexChanged += new System.EventHandler(this.cmpmat_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(422, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 42;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnsupprime
            // 
            this.btnsupprime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprime.Image = global::WindowsFormsApplication1.Properties.Resources.delete;
            this.btnsupprime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsupprime.Location = new System.Drawing.Point(317, 249);
            this.btnsupprime.Name = "btnsupprime";
            this.btnsupprime.Size = new System.Drawing.Size(120, 95);
            this.btnsupprime.TabIndex = 43;
            this.btnsupprime.Text = "Supprimer";
            this.btnsupprime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnsupprime.UseVisualStyleBackColor = true;
            this.btnsupprime.Click += new System.EventHandler(this.btnsupprime_Click);
            // 
            // Form_Intervenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(465, 367);
            this.Controls.Add(this.btnsupprime);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cmpmat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_modifie);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttele);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtadresse);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Intervenant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intervenant";
            this.Load += new System.EventHandler(this.Form_Intervenant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_modifie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txttele;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtadresse;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmpmat;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnsupprime;
    }
}