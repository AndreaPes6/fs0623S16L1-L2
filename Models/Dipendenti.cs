namespace MuratoriFortissimi.Models
{
    public class Dipendenti
    {
        public int IdDipendenti { get; set; }
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public string? Indirizzo { get; set; }
        public string? CodiceFiscale { get; set; }
        public bool StatoConiugazione { get; set; }
        public int NumFigli { get; set; }
        public string? Mansione { get; set; }

    }
}
