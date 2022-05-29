using MediaTek.controleur;
using MediaTek.modele;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Mediatek
{

    /// <summary>
    /// Fenêtre d'affichage des personnels et de leurs informations
    /// </summary>
    public partial class frmGestionPersonnel : Form
    {

        /// <summary>
        /// instance du controleur
        /// </summary>
        private Controle controle;
        /// <summary>
        /// Objet pour gérer la liste des développeurs
        /// </summary>
        BindingSource bdgPersonnel = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des profils
        /// </summary>
        BindingSource bdgService = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        BindingSource bdgAbsence = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des motifs
        /// </summary>
        BindingSource bdgMotifs = new BindingSource();

        /// <summary>
        /// Initialisation des composants graphiques
        /// Récupération du controleur
        /// </summary>
        /// <param name="controle"></param>
        public frmGestionPersonnel(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            Init();
        }

        /// <summary>
        /// Initialisation de la frame : remplissage des listes
        /// </summary>
        public void Init()
        {
            // Remplissage des listes
            RemplirListePersonnel();
            RemplirComboBoxService();

        }

        /// <summary>
        /// Affiche les personnels dans lstPersonnel
        /// </summary>
        public void RemplirListePersonnel()
        {
            List<Personnel> lesPersonnels = controle.GetLesPersonnels();
            bdgPersonnel.DataSource = lesPersonnels;
            lstPersonnel.DataSource = bdgPersonnel;
            lstPersonnel.Columns["idpersonnel"].Visible = false;
            lstPersonnel.Columns["idservice"].Visible = false;
            lstPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Rempli la comboBox ServiceS
        /// </summary>
        public void RemplirComboBoxService()
        {
            List<Service> lesServices = controle.GetLesServices();
            bdgService.DataSource = lesServices;
            cboBoxService.DataSource = bdgService;
        }

    }
}
