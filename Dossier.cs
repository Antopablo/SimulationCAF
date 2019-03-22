namespace DesignPatternFacade
{
    public class Dossier
    {
        private string _nom;
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        private int _nbEnfant;
        public int NbEnfant
        {
            get { return _nbEnfant; }
            set { _nbEnfant = value; }
        }

        private int _salaire;
        public int Salaire
        {
            get { return _salaire; }
            set { _salaire = value; }
        }

        private int _loyer;
        public int Loyer
        {
            get { return _loyer; }
            set { _loyer = value; }
        }

        private int _dette;
        public int Dette
        {
            get { return _dette; }
            set { _dette = value; }
        }

        private bool _eligibleLog;
        public bool EligibleLog
        {
            get { return _eligibleLog; }
            set { _eligibleLog = value; }
        }

        private bool _eligibileFam;
        public bool EligibleFam
        {
            get { return _eligibileFam; }
            set { _eligibileFam = value; }
        }

        private int _alloc;
        public int Alloc
        {
            get { return _alloc; }
            set { _alloc = value; }
        }


        public Dossier(string nom, int salaire = 0, int loyer = 0,  int nbEnfant = 0, int dette = 0)
        {
            Nom = nom;
            NbEnfant = nbEnfant;
            Salaire = salaire;
            Loyer = loyer;
            Dette = dette;
            Alloc = 0;
            EligibleFam = false;
            EligibleLog = false;
        }
    }
}