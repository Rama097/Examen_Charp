using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPharmacie
{
    public class Medicament
    {
        private string NomM { get; set; }
        private int PrixM { get; set; }
        private double Quantite{ get; set; }
        private DateTime DateExp{ get; set; }
        private string Fournisseur { get;set; }
    }
    public Medicament(string nom_M,int prix_M,double quantite,DateTime dateExp,string fournisseur_M)
    {
        NomM = nom_M;
        PrixM = prix_M;
        Quantite = quantite;
        DateExp = dateExp;
        Fournisseur = fournisseur_M;
    }


}
