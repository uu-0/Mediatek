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
        BindingSource bdgMotif = new BindingSource();

        /// <summary>
        /// Booléen pour déterminer l'affichage de gestion du personnel ou des absences
        /// </summary>
        private bool show;

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
            // remplissage des listes
            RemplirListePersonnel();
            RemplirComboBoxService();

            //affichage composants graphiques 
            show = false;
            ShowComponents(show);

        }

        /// <summary>
        /// affiche ou cache les composants graphiques
        /// </summary>
        /// <param name="show"></param>
        public void ShowComponents(bool show)
        {
            // Personnel
            txtNom.Enabled = !show;
            txtPrenom.Enabled = !show;
            lbService.Visible = !show;
            cboBoxService.Visible = !show;
            lstPersonnel.Visible = !show;

            // Absence
            lstAbs.Visible = show;
            lbDatedeb.Visible = show;
            lbDatefin.Visible = show;
            dateTimeDebut.Visible = show;
            dateTimeFin.Visible = show;
            lbMotif.Visible = show;
            cboBoxMotif.Visible = show;

            if (!show)
            {
                // Personnel
                btnRef.Location = new Point(287, 204);
                btnVider.Location = new Point(26, 214);
                lbGestion.Location = new Point(48, 12);
                lbInfo.Location = new Point(128, 12);
                lbNom.ForeColor = System.Drawing.Color.Black;
                lbPrenom.ForeColor = System.Drawing.Color.Black;
                lbMail.ForeColor = System.Drawing.Color.Black;
                lbService.ForeColor = System.Drawing.Color.Black;
                btnAbs.Text = "VOIR LES ABSENCES";
                lbInfo.Text = "Coordonnées";
                lbGestion.Text = "Gestion du Personnel";
            }
            else
            {
                // Absence
                btnRef.Location = new Point(287, 204);
                btnVider.Location = new Point(26, 214);
                lbGestion.Location = new Point(48, 12);
                lbInfo.Location = new Point(148, 12);
                //change la couleur des deux labels pour qu'ils aient la même que le fond
                lbNom.ForeColor = System.Drawing.Color.Gainsboro;
                lbPrenom.ForeColor = System.Drawing.Color.Gainsboro;
                lbMail.ForeColor = System.Drawing.Color.Gainsboro;
                lbService.ForeColor = System.Drawing.Color.Gainsboro;
                //change les textes des labels pour qu'ils correspondent aux actions demandées
                btnAbs.Text = "← RETOUR";
                lbInfo.Text = "Absences";
                lbGestion.Text = "Gestion de l'absence";
            }
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
        /// Rempli la comboBox Service
        /// </summary>
        public void RemplirComboBoxService()
        {
            List<Service> lesServices = controle.GetLesServices();
            bdgService.DataSource = lesServices;
            cboBoxService.DataSource = bdgService;
        }

        /// <summary>
        /// Affiche les absences
        /// </summary>
        public void RemplirListeAbsence()
        {
            Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
            List<Absence> lesAbsences = controle.GetLesAbsences(personnel.Idpersonnel);
            bdgAbsence.DataSource = lesAbsences;
            lstAbs.DataSource = bdgAbsence;
            lstAbs.Columns["idpersonnel"].Visible = false;
            lstAbs.Columns["idmotif"].Visible = false;
            lstAbs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        /// <summary>
        /// Affiche les motifs 
        /// </summary>
        public void RemplirComboBoxMotifs()
        {
            List<Motif> lesMotifs = controle.GetLesMotifs();
            bdgMotif.DataSource = lesMotifs;
            cboBoxMotif.DataSource = bdgMotif;
        }

        /// <summary>
        /// Affiche les informations du personnel sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstPersonnel_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = lstPersonnel.CurrentRow;
            txtNom.Text = row.Cells["Nom"].Value.ToString();
            txtPrenom.Text = row.Cells["Prenom"].Value.ToString();
            txtTel.Text = row.Cells["Tel"].Value.ToString();
            txtMail.Text = row.Cells["Mail"].Value.ToString();
            cboBoxService.Text = row.Cells["Service"].Value.ToString();
        }

        private void lstAbs_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = lstAbs.CurrentRow;
            dateTimeDebut.Value = (DateTime)row.Cells["Datedebut"].Value;
            dateTimeFin.Value = (DateTime)row.Cells["Datefin"].Value;
            cboBoxMotif.Text = row.Cells["Motif"].Value.ToString();
        }

        /// <summary>
        /// Ajout d'un personnel ou d'une absence (tous les champs doivent être remplis)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjt_Click(object sender, EventArgs e)
        {
            // Ajout d'un personnel
            if (!show)
            {
                //si les champs ne sont pas vides et q'un champs est séléctionné dans cboBoxService
                if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cboBoxService.SelectedIndex != -1)
                {
                    int idpersonnel = 0;
                    Service service = (Service)bdgService.List[bdgService.Position];
                    Personnel personnel = new Personnel(idpersonnel, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service.Idservice, service.Nom);
                    controle.AddPersonnel(personnel);

                    int nbRecord = lstPersonnel.Rows.Count;
                    RemplirListePersonnel();
                    if (nbRecord < lstPersonnel.Rows.Count)
                    {
                        lstPersonnel.ClearSelection();
                        Vider();
                        MessageBox.Show("Le personnel a été ajouté avec succès.", "Information");
                    }
                    else
                    {
                        // Le personnel existe dans la BDD
                        MessageBox.Show("Veuillez entrer un nouveau personnel.", "Information");
                    }
                }
                else
                {
                    // Les champs ne sont pas tous remplis
                    MessageBox.Show("Veuillez remplir tous les champs.", "Information");
                }
            }
            // Ajout d'une absence
            else
            {
                //vérifie qu'un motif a été sélectionné
                if (cboBoxMotif.SelectedIndex != -1)
                {
                    Motif motif = (Motif)bdgMotif.List[bdgMotif.Position];
                    Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                    Absence absence = new Absence(dateTimeDebut.Value, dateTimeFin.Value, personnel.Idpersonnel, motif.Idmotif, motif.Libelle);
                    controle.AddAbsence(absence, personnel.Idpersonnel);

                    int nbRecord = lstAbs.Rows.Count;
                    RemplirListeAbsence();
                    if (nbRecord < lstAbs.Rows.Count)
                    {
                        lstAbs.ClearSelection();
                        Vider();
                        MessageBox.Show("L'absence a été ajouté avec succès.", "Information");
                    }
                    else
                    {
                        // Se positionne sur l'élément dont la date de début existe déjà
                        lstAbs.ClearSelection();
                        int rowIndex = -1;
                        foreach (DataGridViewRow row in lstAbs.Rows)
                        {
                            if (row.Cells["datedebut"].Value.ToString().Equals(absence.Datedebut.ToString()))
                            {
                                rowIndex = row.Index;
                                break;
                            }
                        }
                        lstAbs.CurrentCell = this.lstAbs[1, rowIndex];
                        lstAbs.CurrentCell.Selected = true;

                        // La date de début correspond déjà à un personnel de la BD
                        MessageBox.Show("Veuillez entrer une nouvelle absence.", "Information");
                    }

                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs.", "Information");
                }
            }
        }

        /// <summary>
        /// Suppression d'un personnel ou d'une absence (tous les champs doievnt être remplis)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupp_Click(object sender, EventArgs e)
        {
            // Suppression d'un personnel
            if (!show)
            {
                // Vérifie qu'une ligne est sélectionnée 
                if (lstPersonnel.SelectedRows.Count > 0)
                {

                    Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];

                    // Si l'utilisateur choisi oui
                    if (MessageBox.Show("Voulez-vous vraiment supprimer le personnel " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        controle.DelPersonnel(personnel.Idpersonnel);
                        RemplirListePersonnel();
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une ligne", "Information");
                }
            }
            // Suppression d'une absence
            else
            {
                // Vérifie qu'une ligne est sélectionnée
                if (lstAbs.SelectedRows.Count > 0)
                {
                    Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                    Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];

                    // Si l'utilisateur dit oui
                    if (MessageBox.Show("Voulez-vous vraiment supprimer l'absence du " + absence.Datedebut.ToShortDateString() + " au " + absence.Datefin.ToShortDateString() + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        controle.DelAbsence(absence, personnel.Idpersonnel);
                        RemplirListeAbsence();
                    }
                }
                else
                {
                    MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
                }
            }
        }
        /// <summary>
        /// Modification des infos d'un personnel ou des infos d'une absence (tous les chaps doivent être remplis)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModif_Click(object sender, EventArgs e)
        {
            // Modification d'un personnel
            if (!show)
            {
                if (lstPersonnel.SelectedRows.Count > 0)
                {
                    Service service = (Service)bdgService.List[bdgService.Position];
                    Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                    personnel = new Personnel(personnel.Idpersonnel, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service.Idservice, service.Nom);

                    if (MessageBox.Show("Voulez-vous modifier les informations de ce personnel ?", "Confirmation de modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        controle.UpdatePersonnel(personnel);
                        RemplirListePersonnel();

                        // Test si la modification ne s'est pas faite
                        if (!(txtNom.Text.Contains(personnel.Nom) && txtPrenom.Text.Contains(personnel.Prenom)))
                        {
                            // La combinaison (nom, prénom) existe dans la BD
                            MessageBox.Show("Veuillez entrer un nouveau personnel", "Information");
                        }

                        // Sélectionne l'élément modifié ou à modifier (idpersonnel)
                        lstPersonnel.ClearSelection();
                        int rowIndex = -1;
                        foreach (DataGridViewRow row in lstPersonnel.Rows)
                        {
                            if (row.Cells["idpersonnel"].Value.ToString().Equals(personnel.Idpersonnel.ToString()))
                            {
                                rowIndex = row.Index;
                                break;
                            }
                        }
                        lstPersonnel.CurrentCell = this.lstPersonnel[1, rowIndex];
                        lstPersonnel.CurrentCell.Selected = true;
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une ligne", "Information");
                }
            }
            // Modification d'une absence
            else
            {
                if (lstAbs.SelectedRows.Count > 0)
                {
                    Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                    Motif motif = (Motif)bdgMotif.List[bdgMotif.Position];

                    // Données récupérées de la ligne à modifier
                    Absence absenceOLD = new Absence((DateTime)lstAbs.CurrentRow.Cells["Datedebut"].Value,
                                                     (DateTime)lstAbs.CurrentRow.Cells["Datefin"].Value,
                                                     personnel.Idpersonnel,
                                                     (int)lstAbs.CurrentRow.Cells["Idmotif"].Value,
                                                     (string)lstAbs.CurrentRow.Cells["Motif"].Value);

                    // Données récupérées de la saisie
                    Absence absenceNEW = new Absence(dateTimeDebut.Value, dateTimeFin.Value, personnel.Idpersonnel, motif.Idmotif, motif.Libelle);

                    if (MessageBox.Show("Voulez-vous modifier les informations de cette absence ?", "Confirmation de modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Supprime l'absence à modifier
                        // La modification de la date de début (PK) crée un conflit en BD
                        controle.DelAbsence(absenceOLD, personnel.Idpersonnel);

                        // Ajoute si possible l'absence avec les nouvelles valeurs en remplacement
                        controle.AddAbsence(absenceNEW, personnel.Idpersonnel);

                        // Rajoute l'absence initiale (non modifié) si la nouvelle absence n'est pas ajouté en BD
                        int nbRecord = lstAbs.Rows.Count;
                        RemplirListeAbsence();
                        if (nbRecord != lstAbs.Rows.Count)
                        {
                            controle.AddAbsence(absenceOLD, personnel.Idpersonnel);
                            RemplirListeAbsence();

                            // Se positionne sur l'élément dont la date de début existe déjà
                            lstAbs.ClearSelection();
                            int rowIndex = -1;
                            foreach (DataGridViewRow row in lstAbs.Rows)
                            {
                                if (row.Cells["datedebut"].Value.ToString().Equals(absenceNEW.Datedebut.ToString()))
                                {
                                    rowIndex = row.Index;
                                    break;
                                }
                            }
                            lstAbs.CurrentCell = this.lstAbs[0, rowIndex];
                            lstAbs.CurrentCell.Selected = true;

                            // L'absence existe dans la BD
                            MessageBox.Show("Veuillez entrer une nouvelle absence.", "Information");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Vide les champs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVider_Click(object sender, EventArgs e)
        {
            Vider();
        }

        /// <summary>
        /// Vide les champs
        /// </summary>
        private void Vider()
        {
            // Personnel
            if (!show)
            {
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtTel.Text = "";
                txtMail.Text = "";
                cboBoxService.SelectedIndex = -1;
                lstPersonnel.ClearSelection();
                txtNom.Focus();
            }
            // Absence
            else
            {
                dateTimeDebut.Value = DateTime.Now;
                dateTimeFin.Value = DateTime.Now;
                cboBoxMotif.SelectedIndex = -1;
                lstAbs.ClearSelection();
                dateTimeDebut.Focus();
            }
        }

        /// <summary>
        /// Affiche les composants graphiques (Gestion Personnel) (Gestion Absence)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbs_Click(object sender, EventArgs e)
        {
            if (lstPersonnel.CurrentCell.Selected)
            {
                // Affiche gestion des absences
                if (!show)
                {
                    show = true;
                    ShowComponents(show);
                    RemplirComboBoxMotifs();
                    RemplirListeAbsence();
                }
                // Affiche gestion du personnel
                else
                {
                    show = false;
                    ShowComponents(show);
                }
            }
            //il faut sélectionner une ligne dans lstPersnne
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne", "Information");
            }
        }

        private void lstAbs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
