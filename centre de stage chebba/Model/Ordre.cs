using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace centre_de_stage_chebba.Model
{
    class Ordre
    {
        #region les attribut

        private int _id { get; set; }
        private string _benefice { get; set; }
        private string _nom_prenom { get; set; }
        private string _sujet { get; set; }
        private string _fiche { get; set; }
        private string _paimentValide { get; set; }
        private string _compteBancaire { get; set; }
        private string _sujetVersement { get; set; }
        private string _beneficeVers { get; set; }
        private string _compteBancaireVer { get; set; }
        private string _numOrdreEchange { get; set; }
        private string _classe { get; set; }
        private string _lobe { get; set; }
        private string _parag { get; set; }
        private string _paragSecond { get; set; }
        private string _numVisa { get; set; }
        private string _prixTotal { get; set; }
        private string _negation { get; set; }
        private string _prixTotalPayer { get; set; }
        private string _arreterA { get; set; }
        private string _au { get; set; }
        private string _dans { get; set; }
        private string _beneficeComptable { get; set; }
        private string _identBancaireComptable { get; set; }
        private string _ficheAppartient { get; set; }
        private string _lobeFiche { get; set; }
        private string _annesFinancier { get; set; }

        #endregion



        public Ordre(int id, string benefice, string nomPrenom, string sujet, string fiche,
         string paimentValide, string compteBancaire,
         string sujetVersement, string beneficeVers, string compteBancaireVer,
         string numOrdreEchange, string classe, string lobe, string parag, string paragSecond,
         string numVisa, string prixTotal, string negation, string prixTotalPayer, string arreterA, string au, string dans,
         string beneficeComptable, string identBancaireComptable, string ficheAppartient, string lobeFiche, string annesFinancier)

        {
            this._id = id;
            this._benefice = benefice;
            this._nom_prenom = nomPrenom;
            this._sujet = sujet;
            this._fiche = fiche;
            this._paimentValide = paimentValide;
            this._compteBancaire = compteBancaire;
            this._sujetVersement = sujetVersement;
            this._beneficeVers = beneficeVers;
            this._compteBancaireVer = compteBancaireVer;
            this._numOrdreEchange = numOrdreEchange;
            this._classe = classe;
            this._lobe = lobe;
            this._parag = parag;
            this._paragSecond = paragSecond;
            this._numVisa = numVisa;
            this._prixTotal = prixTotal;
            this._negation = negation;
            this._prixTotalPayer = prixTotalPayer;
            this._arreterA = arreterA;
            this._au = au;
            this._dans = dans;
            this._beneficeComptable = beneficeComptable;
            this._identBancaireComptable = identBancaireComptable;
            this._ficheAppartient = ficheAppartient;
            this._lobeFiche = lobeFiche;
            this._annesFinancier = annesFinancier;
            
        }
    }
}
