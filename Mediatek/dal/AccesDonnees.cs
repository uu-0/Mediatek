using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTek.connexion;
using MediaTek.modele;

namespace Mediatek.dal
{
    class AccesDonnees
    {
        /// <summary>
        /// Chaine de connexion à la BDD
        /// </summary>
        private static string connectionString = "Server=localhost;Database=mediatek;User Id=admin;Password=P@$$word; Ssl mode=none";
        /// <summary>
        /// Authentification (login/pwd)
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static Boolean Authentification(string login, string pwd)
        {
            string req = "SELECT * FROM responsable ";
            req += "WHERE login = @login AND pwd = SHA2(@pwd, 256);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@login", login);
            parameters.Add("@pwd", pwd);
            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            curseur.ReqSelect(req, parameters);

            if (curseur.Read())
            {
                curseur.Close();
                return true;
            }
            else
            {
                curseur.Close();
                return false;
            }
        }

        /// <summary>
        /// Récupère et retourne les personnels provenant de la BDD
        /// </summary>
        /// <returns>liste des personnels</returns>
        public static List<Personnel> GetLesPersonnels()
        {
            List<Personnel> lesPersonnels = new List<Personnel>();
            string req = "SELECT p.idpersonnel as idpersonnel, p.nom AS nom, p.prenom AS prenom, p.tel AS tel, p.mail AS mail, s.idservice AS idservice, s.nom AS 'service'";
            req += "FROM personnel p JOIN service s USING (idservice)";
            req += "ORDER BY nom, prenom;";

            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {


                Personnel personnel = new Personnel((int)curseur.Field("idpersonnel"),
                                                    (string)curseur.Field("nom"),
                                                    (string)curseur.Field("prenom"),
                                                    (string)curseur.Field("tel"),
                                                    (string)curseur.Field("mail"),
                                                    (int)curseur.Field("idservice"),
                                                    (string)curseur.Field("service"));
                lesPersonnels.Add(personnel);

            }
            curseur.Close();
            return lesPersonnels;
        }

        /// <summary>
        /// Récupère et retourne les services provenant de la BDD
        /// </summary>
        /// <returns>liste des services</returns>
        public static List<Service> GetLesServices()
        {
            List<Service> lesServices = new List<Service>();
            string req = "SELECT * FROM service ORDER BY nom;";
            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {
                Service service = new Service((int)curseur.Field("idservice"),
                                              (string)curseur.Field("nom"));
                lesServices.Add(service);
            }
            curseur.Close();
            return lesServices;
        }

        /// <summary>
        /// Ajoute un personnel
        /// </summary>
        /// <param name="personnel">objet de type personnel à ajouter</param>
        public static void AddPersonnel(Personnel personnel)
        {
            string req = "INSERT INTO personnel(nom, prenom, tel, mail, idservice) ";
            req += "SELECT * FROM(SELECT @nom AS nom, @prenom AS prenom, @tel AS tel, @mail AS mail, @idservice AS idservice) AS req ";
            req += "WHERE NOT EXISTS(SELECT nom, prenom FROM personnel WHERE nom = @nom AND prenom = @prenom); ";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            parameters.Add("@idservice", personnel.Idservice);
            ConnexionBDD connexion = ConnexionBDD.GetInstance(connectionString);
            connexion.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Suppression d'un personnel
        /// </summary>
        /// <param name="idpersonnel">idpersonnel du personnel sélectionné</param>
        public static void DelPersonnel(int idpersonnel)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", idpersonnel);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);

            // Suppression des absences du personnel
            string req = "DELETE FROM absence WHERE idpersonnel = @idpersonnel; ";
            conn.ReqUpdate(req, parameters);

            // Supression du personnel
            req = "DELETE FROM personnel WHERE idpersonnel = @idpersonnel;";
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Modification d'un personnel
        /// </summary>
        /// <param name="personnel">objet de type personnel à modifier</param>
        public static void UpdatePersonnel(Personnel personnel)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.Idpersonnel);
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            parameters.Add("idservice", personnel.Idservice);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);

            // Modifie la combinaison (nom, prénom) si possible
            string req = "UPDATE personnel SET nom = @nom, prenom = @prenom WHERE idpersonnel = @idpersonnel ";
            req += "AND NOT EXISTS(SELECT nom, prenom FROM personnel WHERE nom = @nom AND prenom = @prenom);";
            conn.ReqUpdate(req, parameters);

            // Modifie les autres informations
            req = "UPDATE personnel SET tel = @tel, mail = @mail, idservice = @idservice";
            req += " WHERE idpersonnel = @idpersonnel;";
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Récupère et retourne les absences du personnel sélectionné provenant de la BDD
        /// </summary>
        /// <param name="idpersonnel">idpersonnel du personnel sélectionné</param>
        /// <returns>liste des absences</returns>
        public static List<Absence> GetLesAbsences(int idpersonnel)
        {
            List<Absence> lesAbsences = new List<Absence>();
            string req = "SELECT a.datedebut AS 'datedebut', a.datefin AS 'datefin', a.idpersonnel AS 'idpersonnel', a.idmotif AS 'idmotif', m.libelle AS 'motif'";
            req += "FROM absence a JOIN motif m USING (idmotif)";
            req += "WHERE idpersonnel = " + idpersonnel + " ORDER BY datedebut DESC;";

            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {


                Absence absence = new Absence((DateTime)curseur.Field("datedebut"),
                                              (DateTime)curseur.Field("datefin"),
                                              (int)curseur.Field("idpersonnel"),
                                              (int)curseur.Field("idmotif"),
                                              (string)curseur.Field("motif"));

                lesAbsences.Add(absence);

            }
            curseur.Close();
            return lesAbsences;
        }

        /// <summary>
        /// Récupère et retourne les motifs provenant de la BDD
        /// </summary>
        /// <returns>liste des services</returns>
        public static List<Motif> GetLesMotifs()
        {
            List<Motif> lesMotifs = new List<Motif>();
            string req = "SELECT * FROM motif ORDER BY libelle;";
            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {
                Motif motif = new Motif((int)curseur.Field("idmotif"), (string)curseur.Field("libelle"));
                lesMotifs.Add(motif);
            }
            curseur.Close();
            return lesMotifs;
        }

        /// <summary>
        /// Ajoute une absence
        /// </summary>
        /// <param name="absence">objet de type absence à ajouter</param>
        /// <param name="idpersonnel">idpersonnel du personnel sélectionné</param> 
        public static void AddAbsence(Absence absence, int idpersonnel)
        {
            string req = "INSERT INTO absence(datedebut, datefin, idpersonnel, idmotif) ";
            req += "SELECT * FROM (SELECT @datedebut AS datedebut, @datefin AS datefin, " + idpersonnel + " AS idpersonnel, @idmotif AS idmotif) AS req ";
            req += "WHERE NOT EXISTS(SELECT datedebut, idpersonnel FROM absence WHERE datedebut = @datedebut AND idpersonnel = " + idpersonnel + "); ";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@datedebut", absence.Datedebut);
            parameters.Add("@datefin", absence.Datefin);
            parameters.Add("@idpersonnel", idpersonnel);
            parameters.Add("@idmotif", absence.Idmotif);
            ConnexionBDD connexion = ConnexionBDD.GetInstance(connectionString);
            connexion.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Suppression d'une absence
        /// </summary>
        /// <param name="absence">objet de type absence à supprimer</param>
        /// /// <param name="idpersonnel">idpersonnel du personnel sélectionné</param>
        public static void DelAbsence(Absence absence, int idpersonnel)
        {
            string req = "DELETE FROM absence WHERE idpersonnel = " + idpersonnel;
            req += " AND datedebut = @datedebut;";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@datedebut", absence.Datedebut);
            parameters.Add("@datefin", absence.Datefin);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }
    }
}