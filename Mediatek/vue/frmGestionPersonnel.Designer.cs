
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionPersonnel));
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
            this.btnVider = new System.Windows.Forms.Button();
            this.btnAjt = new System.Windows.Forms.Button();
            this.btnAbs = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.grpBtn = new System.Windows.Forms.GroupBox();
            this.lstPersonnel = new System.Windows.Forms.DataGridView();
            this.lstAbs = new System.Windows.Forms.DataGridView();
            this.grpSaisie = new System.Windows.Forms.GroupBox();
            this.cboBoxMotif = new System.Windows.Forms.ComboBox();
            this.lbMotif = new System.Windows.Forms.Label();
            this.dateTimeFin = new System.Windows.Forms.DateTimePicker();
            this.lbDatefin = new System.Windows.Forms.Label();
            this.dateTimeDebut = new System.Windows.Forms.DateTimePicker();
            this.lbDatedeb = new System.Windows.Forms.Label();
            this.btnRef = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grpBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstPersonnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstAbs)).BeginInit();
            this.grpSaisie.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbGestion
            // 
            this.lbGestion.AutoSize = true;
            this.lbGestion.BackColor = System.Drawing.Color.Teal;
            this.lbGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGestion.ForeColor = System.Drawing.Color.White;
            this.lbGestion.Location = new System.Drawing.Point(64, 18);
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
            this.lbInfo.Location = new System.Drawing.Point(94, 12);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(152, 25);
            this.lbInfo.TabIndex = 2;
            this.lbInfo.Text = "Coordonnées";
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
            this.txtMail.Location = new System.Drawing.Point(179, 99);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(144, 20);
            this.txtMail.TabIndex = 12;
            // 
            // btnVider
            // 
            this.btnVider.BackColor = System.Drawing.Color.Gray;
            this.btnVider.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnVider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVider.ForeColor = System.Drawing.Color.White;
            this.btnVider.Location = new System.Drawing.Point(26, 214);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(75, 28);
            this.btnVider.TabIndex = 19;
            this.btnVider.Text = "VIDER";
            this.btnVider.UseVisualStyleBackColor = false;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // btnAjt
            // 
            this.btnAjt.BackColor = System.Drawing.Color.Teal;
            this.btnAjt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAjt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAjt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjt.ForeColor = System.Drawing.Color.White;
            this.btnAjt.Location = new System.Drawing.Point(25, 19);
            this.btnAjt.Name = "btnAjt";
            this.btnAjt.Size = new System.Drawing.Size(295, 46);
            this.btnAjt.TabIndex = 14;
            this.btnAjt.Text = "AJOUTER";
            this.btnAjt.UseVisualStyleBackColor = false;
            this.btnAjt.Click += new System.EventHandler(this.btnAjt_Click);
            // 
            // btnAbs
            // 
            this.btnAbs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAbs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAbs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnAbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbs.ForeColor = System.Drawing.Color.White;
            this.btnAbs.Location = new System.Drawing.Point(24, 151);
            this.btnAbs.Name = "btnAbs";
            this.btnAbs.Size = new System.Drawing.Size(295, 46);
            this.btnAbs.TabIndex = 15;
            this.btnAbs.Text = "VOIR LES ABSENCES";
            this.btnAbs.UseVisualStyleBackColor = false;
            this.btnAbs.Click += new System.EventHandler(this.btnAbs_Click);
            // 
            // btnModif
            // 
            this.btnModif.BackColor = System.Drawing.Color.Gray;
            this.btnModif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModif.ForeColor = System.Drawing.Color.White;
            this.btnModif.Location = new System.Drawing.Point(25, 86);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(143, 46);
            this.btnModif.TabIndex = 16;
            this.btnModif.Text = "MODIFIER";
            this.btnModif.UseVisualStyleBackColor = false;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.BackColor = System.Drawing.Color.Maroon;
            this.btnSupp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSupp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupp.ForeColor = System.Drawing.Color.White;
            this.btnSupp.Location = new System.Drawing.Point(174, 86);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(144, 46);
            this.btnSupp.TabIndex = 17;
            this.btnSupp.Text = "SUPPRIMER";
            this.btnSupp.UseVisualStyleBackColor = false;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // grpBtn
            // 
            this.grpBtn.BackColor = System.Drawing.Color.Gainsboro;
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
            // lstPersonnel
            // 
            this.lstPersonnel.BackgroundColor = System.Drawing.Color.White;
            this.lstPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstPersonnel.Location = new System.Drawing.Point(410, 72);
            this.lstPersonnel.Name = "lstPersonnel";
            this.lstPersonnel.Size = new System.Drawing.Size(538, 498);
            this.lstPersonnel.TabIndex = 19;
            this.lstPersonnel.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstPersonnel_CellEnter);
            // 
            // lstAbs
            // 
            this.lstAbs.BackgroundColor = System.Drawing.Color.White;
            this.lstAbs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstAbs.Location = new System.Drawing.Point(81, 17);
            this.lstAbs.Name = "lstAbs";
            this.lstAbs.Size = new System.Drawing.Size(258, 465);
            this.lstAbs.TabIndex = 20;
            this.lstAbs.Visible = false;
            this.lstAbs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstAbs_CellContentClick);
            this.lstAbs.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstAbs_CellEnter);
            // 
            // grpSaisie
            // 
            this.grpSaisie.BackColor = System.Drawing.Color.Gainsboro;
            this.grpSaisie.Controls.Add(this.btnRef);
            this.grpSaisie.Controls.Add(this.cboBoxMotif);
            this.grpSaisie.Controls.Add(this.lbMotif);
            this.grpSaisie.Controls.Add(this.dateTimeFin);
            this.grpSaisie.Controls.Add(this.lbDatefin);
            this.grpSaisie.Controls.Add(this.dateTimeDebut);
            this.grpSaisie.Controls.Add(this.lbDatedeb);
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
            this.grpSaisie.Location = new System.Drawing.Point(16, 72);
            this.grpSaisie.Name = "grpSaisie";
            this.grpSaisie.Size = new System.Drawing.Size(350, 258);
            this.grpSaisie.TabIndex = 13;
            this.grpSaisie.TabStop = false;
            // 
            // cboBoxMotif
            // 
            this.cboBoxMotif.FormattingEnabled = true;
            this.cboBoxMotif.Location = new System.Drawing.Point(25, 150);
            this.cboBoxMotif.Name = "cboBoxMotif";
            this.cboBoxMotif.Size = new System.Drawing.Size(298, 21);
            this.cboBoxMotif.TabIndex = 23;
            this.cboBoxMotif.Visible = false;
            // 
            // lbMotif
            // 
            this.lbMotif.AutoSize = true;
            this.lbMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotif.Location = new System.Drawing.Point(22, 127);
            this.lbMotif.Name = "lbMotif";
            this.lbMotif.Size = new System.Drawing.Size(44, 20);
            this.lbMotif.TabIndex = 21;
            this.lbMotif.Text = "Motif";
            this.lbMotif.Visible = false;
            // 
            // dateTimeFin
            // 
            this.dateTimeFin.Location = new System.Drawing.Point(25, 99);
            this.dateTimeFin.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dateTimeFin.MinDate = new System.DateTime(2000, 5, 29, 0, 0, 0, 0);
            this.dateTimeFin.Name = "dateTimeFin";
            this.dateTimeFin.Size = new System.Drawing.Size(298, 20);
            this.dateTimeFin.TabIndex = 22;
            this.dateTimeFin.Value = new System.DateTime(2022, 5, 29, 0, 0, 0, 0);
            this.dateTimeFin.Visible = false;
            // 
            // lbDatefin
            // 
            this.lbDatefin.AutoSize = true;
            this.lbDatefin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatefin.Location = new System.Drawing.Point(22, 76);
            this.lbDatefin.Name = "lbDatefin";
            this.lbDatefin.Size = new System.Drawing.Size(87, 20);
            this.lbDatefin.TabIndex = 22;
            this.lbDatefin.Text = "Date de fin";
            this.lbDatefin.Visible = false;
            // 
            // dateTimeDebut
            // 
            this.dateTimeDebut.Location = new System.Drawing.Point(26, 42);
            this.dateTimeDebut.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dateTimeDebut.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimeDebut.Name = "dateTimeDebut";
            this.dateTimeDebut.Size = new System.Drawing.Size(297, 20);
            this.dateTimeDebut.TabIndex = 21;
            this.dateTimeDebut.Value = new System.DateTime(2022, 5, 29, 0, 0, 0, 0);
            this.dateTimeDebut.Visible = false;
            // 
            // lbDatedeb
            // 
            this.lbDatedeb.AutoSize = true;
            this.lbDatedeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatedeb.Location = new System.Drawing.Point(22, 19);
            this.lbDatedeb.Name = "lbDatedeb";
            this.lbDatedeb.Size = new System.Drawing.Size(111, 20);
            this.lbDatedeb.TabIndex = 21;
            this.lbDatedeb.Text = "Date de début";
            this.lbDatedeb.Visible = false;
            // 
            // btnRef
            // 
            this.btnRef.BackgroundImage = global::Mediatek.Properties.Resources.refresh;
            this.btnRef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRef.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRef.FlatAppearance.BorderSize = 0;
            this.btnRef.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRef.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRef.Location = new System.Drawing.Point(287, 204);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(36, 38);
            this.btnRef.TabIndex = 24;
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(16, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 50);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lbInfo);
            this.panel2.Location = new System.Drawing.Point(511, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 50);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.lstAbs);
            this.panel3.Location = new System.Drawing.Point(473, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 496);
            this.panel3.TabIndex = 23;
            // 
            // frmGestionPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 588);
            this.Controls.Add(this.lstPersonnel);
            this.Controls.Add(this.grpBtn);
            this.Controls.Add(this.grpSaisie);
            this.Controls.Add(this.lbGestion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestionPersonnel";
            this.Text = "Gestion du Personnel";
            this.grpBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstPersonnel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstAbs)).EndInit();
            this.grpSaisie.ResumeLayout(false);
            this.grpSaisie.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button btnAjt;
        private System.Windows.Forms.Button btnAbs;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.GroupBox grpBtn;
        private System.Windows.Forms.DataGridView lstPersonnel;
        private System.Windows.Forms.DataGridView lstAbs;
        private System.Windows.Forms.GroupBox grpSaisie;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.ComboBox cboBoxMotif;
        private System.Windows.Forms.Label lbMotif;
        private System.Windows.Forms.DateTimePicker dateTimeFin;
        private System.Windows.Forms.Label lbDatefin;
        private System.Windows.Forms.DateTimePicker dateTimeDebut;
        private System.Windows.Forms.Label lbDatedeb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

