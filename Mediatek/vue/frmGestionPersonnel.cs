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
        /// Instance du controleur
        /// </summary>
        private Controle controle;

        /// <summary>
        /// Objet pour gérer la liste des personnels
        /// </summary>
        BindingSource bdgPersonnels = new BindingSource();

        /// <summary>
        /// Objet pour gérer la liste des services
        /// </summary>
        BindingSource bdgServices = new BindingSource();

        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        BindingSource bdgAbsences = new BindingSource();

        /// <summary>
        /// Objet pour gérer la liste des motifs
        /// </summary>
        BindingSource bdgMotifs = new BindingSource();

        /// <summary>
        /// Booléen pour déterminer l'affichage :
        /// - GESTION DU PERSONNEL
        /// - GESTION DES ABSENCES
        /// </summary>
        private bool show;

        /// <summary>
        /// Initialisation des composants graphiques
        /// Récupération du controleur
        /// </summary>
        /// <param name="controle"></param>
        public frmGestionPersonnel()
        {
            InitializeComponent();
            this.controle = controle;
            Init();
        }

        /// <summary>
        /// Initialisation : GESTION DU PERSONNEL
        /// </summary>
        public void Init()
        {
            // Remplissage de liste lstPersonnel et cbBoxService
            RemplirDGVPersonnels();
            RemplirCbBoxServices();

            // Affichage des composants graphiques
            show = false;
            ShowComponents(show);
        }

        /// <summary>
        /// Affiche/Cache les composants graphiques
        /// </summary>
        /// <param name="show"></param>
        public void ShowComponents(bool show)
        {
            // GESTION DU PERSONNEL
            txtNom.Enabled = !show;
            txtPrenom.Enabled = !show;
            lbService.Visible = !show;
            cboBoxService.Visible = !show;
            lstPersonnel.Visible = !show;

            // GESTION DES ABSENCES à voir après

            if (!show)
            {
                // GESTION DU PERSONNEL
                btnVider.Location = new Point(26,192);
                lbNom.ForeColor = System.Drawing.Color.Black;
                lbPrenom.ForeColor = System.Drawing.Color.Black;
                btnAbs.Text = "VOIR LES ABSENCES";
                lbInfo.Text = "Informations du Personnel";
                lbGestion.Text = "Gestion du Personnel";
            }
            else
            {
                // GESTION DES ABSENCES 
                btnVider.Location = new Point(26,192);
                lbNom.ForeColor = System.Drawing.Color.DimGray;
                lbPrenom.ForeColor = System.Drawing.Color.DimGray;
                btnAbs.Text = "RETOUR ";
                lbInfo.Text = "Listes des Absences";
                lbGestion.Text = "Gestion des Absences";
            }
        }
    }
}
