
namespace MediaTek.modele
{
    /// <summary>
    /// Classe métier correspondant à la table "Motif" de la base de données
    /// </summary>
    public class Motif
    {
        private int idmotif;
        private string libelle;

        /// <summary>
        /// Getter : idmotif
        /// </summary>
        public int Idmotif { get => idmotif; }

        /// <summary>
        /// Getter : libelle
        /// </summary>
        public string Libelle { get => libelle; }

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, string libelle)
        {
            this.idmotif = idmotif;
            this.libelle = libelle;
        }

        /// <summary>
        /// Définit l'information à afficher : libelle
        /// </summary>
        /// <returns>nom du motif</returns>
        public override string ToString()
        {
            return this.libelle;
        }
    }
}