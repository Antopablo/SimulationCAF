using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFacade
{
    class CAF
    {
        private BureauRecouvrement _bureauRecouvrement;
        public BureauRecouvrement BureauRecouvrement
        {
            get {
                if (_bureauRecouvrement == null)
                {
                    _bureauRecouvrement = new BureauRecouvrement();
                }
                return _bureauRecouvrement; }
            //set { _bureauRecouvrement = value; }
        }

        private BureauArchive _bureauArchive;
        public BureauArchive BureauArchive
        {
            get {
                if (_bureauArchive == null)
                {
                    _bureauArchive = new BureauArchive(new List<Dossier>());
                }
                return _bureauArchive; }
            //set { _bureauArchive = value; }
        }

        private BureauAllocationLog _bureauAllocationLog;
        public BureauAllocationLog BureauAllocationLog
        {
            get
            {
                if (_bureauAllocationLog == null)
                {
                    _bureauAllocationLog = new BureauAllocationLog();
                }
                return _bureauAllocationLog; }
            //set { _bureauAllocationLog = value; }
        }

        private BureauAllocationFam _bureauAllocationFam;
        public BureauAllocationFam BureauAllocationFam
        {
            get {
                if (_bureauAllocationFam == null)
                {
                    _bureauAllocationFam = new BureauAllocationFam();
                }
                return _bureauAllocationFam; }
            //set { _bureauAllocationFam = value; }
        }

        private Compta _compta;
        public Compta Compta
        {
            get {
                if (_compta == null)
                {
                    _compta = new Compta();
                }
                return _compta; }
            //set { _compta = value; }
        }

        public void Traitement (Dossier dos)
        {
            //BureauArchive.ListeDossier.Add(dos);
            BureauAllocationFam.TestAllocFam(dos);
            BureauAllocationLog.TestAllocLog(dos);
            BureauRecouvrement.GenererDette(dos);
            BureauRecouvrement.VerifierDette(dos);
            Compta.PayerAlloc(dos);
            Console.WriteLine("\r\n");
        }


    }
}
