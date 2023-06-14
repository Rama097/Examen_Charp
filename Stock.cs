using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPharmacie
{
    public class Stock
    {
        private List<Medicament> Medicaments { get; set; }
    }
    public Stock()
    {
        listeMedicament = new List<Medicament>();
    }
    public void AjouterMedicament(Medicament medicament)
    {
        listeMedicament.Add(medicament);
    }
    public void SupprimerMedicament(Medicament medicament)
    {
        listeMedicament.Remove(medicament);
    }
}
