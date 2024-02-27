namespace MuratoriFortissimi.Models
{
    public class StaticDB
    {
        private static int _maxId = 1;
        private static List<Dipendenti> _Dipendenti = [
           new Dipendenti() { IdDipendenti = 1, Nome = "Andrea", Cognome = "Pes", Indirizzo = "Via Marco Polo", CodiceFiscale = "PSENEDR02SFDA2343", StatoConiugazione = false, NumFigli = 0, Mansione = "nullafacente esperto" },
        ];

        public static List<Dipendenti> GetAll()
        {
            return _Dipendenti;
        }

        public static Dipendenti? GetById(int? id)
        {
            if (id is null) return null;

            for (int i = 0; i < _Dipendenti.Count; i++)
            {
                Dipendenti dipendenti = _Dipendenti[i];
                if (dipendenti.IdDipendenti == id)
                {
                    return dipendenti;
                }
            }

            return null;
        }

        public static Dipendenti Add(string nome, string cognome, string indirizzo, string codiceFiscale, bool statoConiugazione, int numFigli, string mansione)
        {
            _maxId++;
            var dipendenti = new Dipendenti() { IdDipendenti = _maxId, Nome = nome, Cognome = cognome, Indirizzo = indirizzo, CodiceFiscale = codiceFiscale, StatoConiugazione = statoConiugazione, NumFigli = numFigli, Mansione = mansione };
            _Dipendenti.Add(dipendenti);
            return dipendenti;
        }
    }
}
