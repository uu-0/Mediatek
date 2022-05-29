
namespace Mediatek.vue
{
    partial class frmGestionPersonnel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.chkboxPwd = new System.Windows.Forms.CheckBox();
            this.lbMdp = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtLogin);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Controls.Add(this.chkboxPwd);
            this.groupBox1.Controls.Add(this.lbMdp);
            this.groupBox1.Controls.Add(this.lbLogin);
            this.groupBox1.Location = new System.Drawing.Point(229, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Gray;
            this.btnConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(181, 190);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(161, 38);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "CONNEXION";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(10, 120);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(213, 20);
            this.txtPwd.TabIndex = 4;
            // 
            // chkboxPwd
            // 
            this.chkboxPwd.AutoSize = true;
            this.chkboxPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxPwd.Location = new System.Drawing.Point(10, 146);
            this.chkboxPwd.Name = "chkboxPwd";
            this.chkboxPwd.Size = new System.Drawing.Size(185, 22);
            this.chkboxPwd.TabIndex = 2;
            this.chkboxPwd.Text = "Afficher le mot de passe";
            this.chkboxPwd.UseVisualStyleBackColor = true;
            this.chkboxPwd.CheckedChanged += new System.EventHandler(this.chcPwd_CheckedChanged);
            // 
            // lbMdp
            // 
            this.lbMdp.AutoSize = true;
            this.lbMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMdp.Location = new System.Drawing.Point(6, 97);
            this.lbMdp.Name = "lbMdp";
            this.lbMdp.Size = new System.Drawing.Size(105, 20);
            this.lbMdp.TabIndex = 1;
            this.lbMdp.Text = "Mot de passe";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(6, 45);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(130, 20);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Nom d\'utilisateur ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mediatek.Properties.Resources.imglogin;
            this.pictureBox1.Location = new System.Drawing.Point(29, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(10, 68);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(213, 20);
            this.txtLogin.TabIndex = 6;
            // 
            // frmGestionPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(624, 301);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGestionPersonnel";
            this.Text = "Connexion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbMdp;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.CheckBox chkboxPwd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtLogin;
    }
}