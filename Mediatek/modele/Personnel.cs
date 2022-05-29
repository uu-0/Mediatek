namespace MediaTek.modele
{
    /// <summary>
    /// Classe métier correspondant à la table "Personnel" de la base de données
    /// </summary>
    public class Personnel
    {
        private int idpersonnel;
        private string nom;
        private string prenom;
        private string tel;
        private string mail;
        private int idservice;
        private string service;

        /// <summary>
        /// Getter : idpersonnel
        /// </summary>
        public int Idpersonnel { get => idpersonnel; }

        /// <summary>
        /// Getter : nom
        /// </summary>
        public string Nom { get => nom; }

        /// <summary>
        /// Getter : prenom
        /// </summary>
        public string Prenom { get => prenom; }

        /// <summary>
        /// Getter : tel
        /// </summary>
        public string Tel { get => tel; }

        /// <summary>
        /// Getter : mail
        /// </summary>
        public string Mail { get => mail; }

        /// <summary>
        /// Getter : idservice
        /// </summary>
        public int Idservice { get => idservice; }

        /// <summary>
        /// Getter : service
        /// </summary>
        public string Service { get => service; }

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="idservice"></param>
        /// <param name="service"></param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, int idservice, string service)
        {
            this.idpersonnel = idpersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.idservice = idservice;
            this.service = service;
        }
    }
}
