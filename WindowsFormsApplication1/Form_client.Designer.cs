namespace WindowsFormsApplication1
{
    partial class Form_client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_client));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttele = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtadresse = new System.Windows.Forms.TextBox();
            this.txtraisonsociale = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmpmat = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnsupprime = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(53, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "matricule";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(38, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = " Telephone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(70, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = " Email";
            // 
            // txttele
            // 
            this.txttele.Location = new System.Drawing.Point(125, 193);
            this.txttele.Name = "txttele";
            this.txttele.Size = new System.Drawing.Size(336, 20);
            this.txttele.TabIndex = 4;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(125, 163);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(336, 20);
            this.txtemail.TabIndex = 3;
            // 
            // txtadresse
            // 
            this.txtadresse.Location = new System.Drawing.Point(125, 109);
            this.txtadresse.Multiline = true;
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.Size = new System.Drawing.Size(336, 45);
            this.txtadresse.TabIndex = 2;
            // 
            // txtraisonsociale
            // 
            this.txtraisonsociale.Location = new System.Drawing.Point(125, 52);
            this.txtraisonsociale.Multiline = true;
            this.txtraisonsociale.Name = "txtraisonsociale";
            this.txtraisonsociale.Size = new System.Drawing.Size(336, 48);
            this.txtraisonsociale.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(58, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = " Adresse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(7, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "* Raison Sociale ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(354, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "* champs obligatoires";
            // 
            // cmpmat
            // 
            this.cmpmat.Enabled = false;
            this.cmpmat.FormattingEnabled = true;
            this.cmpmat.Location = new System.Drawing.Point(125, 20);
            this.cmpmat.Name = "cmpmat";
            this.cmpmat.Size = new System.Drawing.Size(315, 21);
            this.cmpmat.TabIndex = 35;
            this.cmpmat.SelectedIndexChanged += new System.EventHandler(this.cmpmat_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(446, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 36;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnsupprime
            // 
            this.btnsupprime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsupprime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprime.Image = global::WindowsFormsApplication1.Properties.Resources.delete;
            this.btnsupprime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsupprime.Location = new System.Drawing.Point(341, 243);
            this.btnsupprime.Name = "btnsupprime";
            this.btnsupprime.Size = new System.Drawing.Size(120, 95);
            this.btnsupprime.TabIndex = 38;
            this.btnsupprime.Text = "Supprime";
            this.btnsupprime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnsupprime.UseVisualStyleBackColor = true;
            this.btnsupprime.Click += new System.EventHandler(this.btnsupprime_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifier.Image = global::WindowsFormsApplication1.Properties.Resources.update;
            this.btn_modifier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_modifier.Location = new System.Drawing.Point(215, 243);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(120, 95);
            this.btn_modifier.TabIndex = 37;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter.Image = global::WindowsFormsApplication1.Properties.Resources.add;
            this.btn_ajouter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ajouter.Location = new System.Drawing.Point(89, 243);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(120, 95);
            this.btn_ajouter.TabIndex = 5;
            this.btn_ajouter.Text = " Ajouter";
            this.btn_ajouter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ajouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // Form_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(491, 360);
            this.Controls.Add(this.btnsupprime);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cmpmat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttele);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtadresse);
            this.Controls.Add(this.txtraisonsociale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form_client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttele;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtadresse;
        private System.Windows.Forms.TextBox txtraisonsociale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmpmat;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btnsupprime;
    }
}