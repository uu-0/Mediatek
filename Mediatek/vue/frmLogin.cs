using MediaTek.controleur;
using System.Windows.Forms;

namespace Mediatek.vue
{
    /// <summary>
    /// Fenêtre d'authentification (seuls les admin peuvent accéder à l'application)
    /// </summary>
    public partial class frmGestionPersonnel : Form
    {

        /// <summary>
        /// Instance du controleur
        /// </summary>
        private Controle controle;

        /// <summary>
        /// Initialisation des composants graphiques et écupération du contrôleur
        /// </summary>
        /// <param name="controle"></param>
        public frmGestionPersonnel(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            // cache le mot de passe par déf
            txtPwd.UseSystemPasswordChar = true;
        }

        /// <summary>
        /// Contrôle si checkBox est coché, si oui le mdp est affiché
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chcPwd_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkboxPwd.Checked)
            {
                txtPwd.UseSystemPasswordChar = false;
            }
            else
            {
                txtPwd.UseSystemPasswordChar = true;
            }
        }

        /// <summary>
        /// Demande au controleur de controler l'authentification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, System.EventArgs e)
        {
            //si les champs ne sont pas vides
            if(!txtLogin.Text.Equals("") && !txtPwd.Text.Equals(""))
            {
                //si les infos entrées ne sont pas incorrectes
                if(!controle.Authentification(txtLogin.Text, txtPwd.Text))
                {
                    MessageBox.Show("Le mot de passe ou le login est incorect.", "Information");
                    txtLogin.Text = "";
                    txtPwd.Text = "";
                    txtLogin.Focus();

                }
                else
                {
                    MessageBox.Show("Tous les champs doivent être remplis.", "Information");
                }
            }
        }
    }
}
