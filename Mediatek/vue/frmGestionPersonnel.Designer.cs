
namespace Mediatek
{
    partial class frmGestionPersonnel
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
            this.lstPersonnel = new System.Windows.Forms.ListBox();
            this.lbGestion = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbPrenom = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.lbService = new System.Windows.Forms.Label();
            this.cboBoxService = new System.Windows.Forms.ComboBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.grpSaisie = new System.Windows.Forms.GroupBox();
            this.btnAjt = new System.Windows.Forms.Button();
            this.btnAbs = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.grpBtn = new System.Windows.Forms.GroupBox();
            this.btnVider = new System.Windows.Forms.Button();
            this.grpSaisie.SuspendLayout();
            this.grpBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPersonnel
            // 
            this.lstPersonnel.FormattingEnabled = true;
            this.lstPersonnel.Location = new System.Drawing.Point(372, 72);
            this.lstPersonnel.Name = "lstPersonnel";
            this.lstPersonnel.Size = new System.Drawing.Size(446, 498);
            this.lstPersonnel.TabIndex = 0;
            // 
            // lbGestion
            // 
            this.lbGestion.AutoSize = true;
            this.lbGestion.BackColor = System.Drawing.Color.Teal;
            this.lbGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGestion.ForeColor = System.Drawing.Color.White;
            this.lbGestion.Location = new System.Drawing.Point(59, 28);
            this.lbGestion.Name = "lbGestion";
            this.lbGestion.Size = new System.Drawing.Size(239, 25);
            this.lbGestion.TabIndex = 1;
            this.lbGestion.Text = "Gestion du Personnel";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.BackColor = System.Drawing.Color.Teal;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.ForeColor = System.Drawing.Color.White;
            this.lbInfo.Location = new System.Drawing.Point(440, 28);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(287, 25);
            this.lbInfo.TabIndex = 2;
            this.lbInfo.Text = "Informations du Personnel";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(21, 17);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(42, 20);
            this.lbNom.TabIndex = 3;
            this.lbNom.Text = "Nom";
            // 
            // lbPrenom
            // 
            this.lbPrenom.AutoSize = true;
            this.lbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrenom.Location = new System.Drawing.Point(172, 19);
            this.lbPrenom.Name = "lbPrenom";
            this.lbPrenom.Size = new System.Drawing.Size(64, 20);
            this.lbPrenom.TabIndex = 4;
            this.lbPrenom.Text = "Prénom";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTel.Location = new System.Drawing.Point(21, 76);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(30, 20);
            this.lbTel.TabIndex = 5;
            this.lbTel.Text = "Tél";
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.Location = new System.Drawing.Point(175, 76);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(37, 20);
            this.lbMail.TabIndex = 6;
            this.lbMail.Text = "Mail";
            // 
            // lbService
            // 
            this.lbService.AutoSize = true;
            this.lbService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbService.Location = new System.Drawing.Point(22, 127);
            this.lbService.Name = "lbService";
            this.lbService.Size = new System.Drawing.Size(61, 20);
            this.lbService.TabIndex = 7;
            this.lbService.Text = "Service";
            // 
            // cboBoxService
            // 
            this.cboBoxService.FormattingEnabled = true;
            this.cboBoxService.Location = new System.Drawing.Point(25, 150);
            this.cboBoxService.Name = "cboBoxService";
            this.cboBoxService.Size = new System.Drawing.Size(295, 21);
            this.cboBoxService.TabIndex = 8;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(26, 42);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(144, 20);
            this.txtNom.TabIndex = 9;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(176, 42);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(144, 20);
            this.txtPrenom.TabIndex = 10;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(25, 99);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(144, 20);
            this.txtTel.TabIndex = 11;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(175, 99);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(144, 20);
            this.txtMail.TabIndex = 12;
            // 
            // grpSaisie
            // 
            this.grpSaisie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpSaisie.Controls.Add(this.btnVider);
            this.grpSaisie.Controls.Add(this.txtMail);
            this.grpSaisie.Controls.Add(this.txtTel);
            this.grpSaisie.Controls.Add(this.txtPrenom);
            this.grpSaisie.Controls.Add(this.txtNom);
            this.grpSaisie.Controls.Add(this.cboBoxService);
            this.grpSaisie.Controls.Add(this.lbService);
            this.grpSaisie.Controls.Add(this.lbMail);
            this.grpSaisie.Controls.Add(this.lbTel);
            this.grpSaisie.Controls.Add(this.lbPrenom);
            this.grpSaisie.Controls.Add(this.lbNom);
            this.grpSaisie.Location = new System.Drawing.Point(12, 71);
            this.grpSaisie.Name = "grpSaisie";
            this.grpSaisie.Size = new System.Drawing.Size(350, 247);
            this.grpSaisie.TabIndex = 13;
            this.grpSaisie.TabStop = false;
            // 
            // btnAjt
            // 
            this.btnAjt.BackColor = System.Drawing.Color.Teal;
            this.btnAjt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjt.ForeColor = System.Drawing.Color.White;
            this.btnAjt.Location = new System.Drawing.Point(25, 19);
            this.btnAjt.Name = "btnAjt";
            this.btnAjt.Size = new System.Drawing.Size(295, 46);
            this.btnAjt.TabIndex = 14;
            this.btnAjt.Text = "AJOUTER";
            this.btnAjt.UseVisualStyleBackColor = false;
            // 
            // btnAbs
            // 
            this.btnAbs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbs.ForeColor = System.Drawing.Color.White;
            this.btnAbs.Location = new System.Drawing.Point(24, 151);
            this.btnAbs.Name = "btnAbs";
            this.btnAbs.Size = new System.Drawing.Size(295, 46);
            this.btnAbs.TabIndex = 15;
            this.btnAbs.Text = "VOIR LES ABSENCES";
            this.btnAbs.UseVisualStyleBackColor = false;
            // 
            // btnModif
            // 
            this.btnModif.BackColor = System.Drawing.Color.Gray;
            this.btnModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModif.ForeColor = System.Drawing.Color.White;
            this.btnModif.Location = new System.Drawing.Point(25, 86);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(143, 46);
            this.btnModif.TabIndex = 16;
            this.btnModif.Text = "MODIFIER";
            this.btnModif.UseVisualStyleBackColor = false;
            // 
            // btnSupp
            // 
            this.btnSupp.BackColor = System.Drawing.Color.Maroon;
            this.btnSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupp.ForeColor = System.Drawing.Color.White;
            this.btnSupp.Location = new System.Drawing.Point(174, 86);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(144, 46);
            this.btnSupp.TabIndex = 17;
            this.btnSupp.Text = "SUPPRIMER";
            this.btnSupp.UseVisualStyleBackColor = false;
            // 
            // grpBtn
            // 
            this.grpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpBtn.Controls.Add(this.btnSupp);
            this.grpBtn.Controls.Add(this.btnModif);
            this.grpBtn.Controls.Add(this.btnAbs);
            this.grpBtn.Controls.Add(this.btnAjt);
            this.grpBtn.Location = new System.Drawing.Point(12, 359);
            this.grpBtn.Name = "grpBtn";
            this.grpBtn.Size = new System.Drawing.Size(350, 211);
            this.grpBtn.TabIndex = 18;
            this.grpBtn.TabStop = false;
            // 
            // btnVider
            // 
            this.btnVider.BackColor = System.Drawing.Color.Gray;
            this.btnVider.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnVider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnVider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVider.ForeColor = System.Drawing.Color.White;
            this.btnVider.Location = new System.Drawing.Point(26, 192);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(75, 28);
            this.btnVider.TabIndex = 19;
            this.btnVider.Text = "VIDER";
            this.btnVider.UseVisualStyleBackColor = false;
            // 
            // frmGestionPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 588);
            this.Controls.Add(this.grpBtn);
            this.Controls.Add(this.grpSaisie);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.lbGestion);
            this.Controls.Add(this.lstPersonnel);
            this.Name = "frmGestionPersonnel";
            this.Text = "Gestion du Personnel";
            this.grpSaisie.ResumeLayout(false);
            this.grpSaisie.PerformLayout();
            this.grpBtn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPersonnel;
        private System.Windows.Forms.Label lbGestion;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbPrenom;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.Label lbService;
        private System.Windows.Forms.ComboBox cboBoxService;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.GroupBox grpSaisie;
        private System.Windows.Forms.Button btnAjt;
        private System.Windows.Forms.Button btnAbs;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.GroupBox grpBtn;
        private System.Windows.Forms.Button btnVider;
    }
}

