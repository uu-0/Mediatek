using System;

namespace MediaTek.modele
{
    /// <summary>
    /// Classe métier correspondant à la table "Absence" de la base de données
    /// </summary>
    public class Absence
    {
        private DateTime datedebut;
        private DateTime datefin;
        private int idpersonnel;
        private int idmotif;
        private string motif;

        /// <summary>
        /// Getter : datedebut (format: jj/mm/aaaa)
        /// </summary>
        public DateTime Datedebut { get => datedebut.Date; }

        /// <summary>
        /// Getter : datefin (format: jj/mm/aaaa)
        /// </summary>
        public DateTime Datefin { get => datefin.Date; }

        /// <summary>
        /// Getter : idpersonnel
        /// </summary>
        public int Idpersonnel { get => idpersonnel; }

        /// <summary>
        /// Getter : idmotif
        /// </summary>
        public int Idmotif { get => idmotif; }

        /// <summary>
        /// Getter : motif
        /// </summary>
        public string Motif { get => motif; }


        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idpersonnel"></param>
        /// <param name="idmotif"></param>
        /// <param name="motif"></param>
        public Absence(DateTime datedebut, DateTime datefin, int idpersonnel, int idmotif, string motif)
        {
            this.datedebut = datedebut;
            this.datefin = datefin;
            this.idpersonnel = idpersonnel;
            this.idmotif = idmotif;
            this.motif = motif;
        }
    }
}