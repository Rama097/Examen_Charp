using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPharmacie
{
    public class Vente
    {
        public int NumV { get; set; }
        public DateTime DateV { get; set; }
        public List<Medicament> MedicamentV { get; set; }
        public Client Client { get; set; }
        public double Total { get; set; }
    }
}
