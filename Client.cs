using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPharmacie
{
    public class Client
    {
        private string Id { get; set; }    
        private string NomCl { get; set; }
        private string PrenomCl { get; set; }
        private string AdresseCl { get; set; }   
        private int NumTelCl { get; set; }
        
    }

    public Client(int id,string NomClient, string PrenomClient,string AdresseClient,string NumTelClient)
    {
        IdCl= id;
        NomCl = NomClient;
        PrenomCl = PrenomClient;
        AdresseCl = AdresseClient;
        NumTelCl = NumTelClient;
    }

    
}
