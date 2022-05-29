namespace MediaTek.modele
{
    /// <summary>
    /// Classe métier correspondant à la table "Service" de la base de données
    /// </summary>
    public class Service
    {
        private int idservice;
        private string nom;

        /// <summary>
        /// Getter : idservice
        /// </summary>
        public int Idservice { get => idservice; }
        /// <summary>
        /// Getter : nom
        /// </summary>
        public string Nom { get => nom; }

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            this.idservice = idservice;
            this.nom = nom;
        }

        /// <summary>
        /// Définit l'information à afficher : nom
        /// </summary>
        /// <returns>nom du service</returns>
        public override string ToString()
        {
            return this.nom;
        }
    }
}