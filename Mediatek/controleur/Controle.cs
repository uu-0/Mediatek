using Mediatek.dal;
using Mediatek.vue;
using MediaTek.modele;
using System;
using System.Collections.Generic;

namespace MediaTek.controleur
{
    /// <summary>
    /// Gère les intéractions entre le modèle et la vue
    /// </summary>
    public class Controle
    {
        /// <summary>
        /// Fenêtre d'authentification
        /// </summary>
        private frmLogin frmLogin;

        /// <summary>
        /// Ouverture de la fenêtre
        /// </summary>
        public Controle()
        {
            frmLogin = new frmLogin(this);
            frmLogin.ShowDialog();
        }

        /// <summary>
        /// Demande la vérification de l'authentification
        /// Si login/pwd sont corrects, ouverture de la fenêtre principale
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public Boolean Authentification(string login, string pwd)
        {
            if (AccesDonnees.Authentification(login, pwd))
            {
                frmLogin.Hide();
                (new frmGestionPersonnel(this)).ShowDialog();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Récupère et retourne les infos du personnel provenant de la BDD
        /// </summary>
        /// <returns>liste des personnels</returns>
        public List<Personnel> GetLesPersonnels()
        {
            return AccesDonnees.GetLesPersonnels();
        }

        /// <summary>
        /// Récupère et retourne les infos des services provenant de la BDD
        /// </summary>
        /// <returns>liste des services</returns>
        public List<Service> GetLesServices()
        {
            return AccesDonnees.GetLesServices();
        }

        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel">objet de type personnel à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            AccesDonnees.AddPersonnel(personnel);
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="idpersonnel">id du personnel à supprimer</param>
        public void DelPersonnel(int idpersonnel)
        {
            AccesDonnees.DelPersonnel(idpersonnel);
        }

        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel">objet de type personnel à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            AccesDonnees.UpdatePersonnel(personnel);
        }

        /// <summary>
        /// Récupère et retourne les infos des absences provenant de la BDD
        /// </summary>
        /// <param name="idpersonnel">id du personnel dont les informations sont récupérées</param>
        /// <returns>liste des absences</returns>
        public List<Absence> GetLesAbsences(int idpersonnel)
        {
            return AccesDonnees.GetLesAbsences(idpersonnel);
        }

        /// <summary>
        /// Récupère et retourne les infos des motifs provenant de la BDD
        /// </summary>
        /// <returns>liste des motifs</returns>
        public List<Motif> GetLesMotifs()
        {
            return AccesDonnees.GetLesMotifs();
        }

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet de type absence à ajouter</param>
        /// <param name="idpersonnel">id du personnel à qui on ajoute une absence</param>
        public void AddAbsence(Absence absence, int idpersonnel)
        {
            AccesDonnees.AddAbsence(absence, idpersonnel);
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="absence">objet de type absence à supprimer</param>
        /// <param name="idpersonnel">id du personnel à qui on supprime une absence</param>
        public void DelAbsence(Absence absence, int idpersonnel)
        {
            AccesDonnees.DelAbsence(absence, idpersonnel);
        }
    }
}