using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using static appMappe.Form1;

namespace appMappe
{
    public class Percorso
    {

        private List<string> _Nomi = new List<string>();

        private string _nomePercorso;
        public string NomePercorso 
        {
            get { return _nomePercorso; }
        }

        private string _descrizionePercorso;
        public string DescrizionePercorso 
        { 
            get { return _descrizionePercorso; }
            set { _descrizionePercorso = value; }
        }

        private Location _posizionePartenza;
        public Location PosizionePartenza 
        { 
            get { return _posizionePartenza; }
            set { _posizionePartenza = value; }
        }

        private Location _posizioneArrivo;
        public Location PosizioneArrivo 
        {
            get { return _posizioneArrivo; }
            set { _posizioneArrivo = value; }
        }

        private GMapOverlay _overlay;
        public GMapOverlay Overlay 
        { 
            get { return _overlay;  }
            set { _overlay = value; }
        }

        private string _distanza;

        public string distanza
        {
            get { return _distanza; }
            set { _distanza = value; }
        }

        private string _tempo;

        public string tempo
        {
            get { return _tempo; }
            set { _tempo = value; }
        }



        public Percorso(string nomePercorso, string descrizionePercorso, Location partenza, Location arrivo, GMapOverlay overlay, string dist, string temp)
        {
            if (nomePercorso == null || descrizionePercorso == null || partenza == null || arrivo == null)
            {
                throw new System.Exception("Uno o più parametri sono nulli");
            }


            if (_Nomi.Contains(nomePercorso))
            {
                throw new System.Exception("Il percorso esiste già");
            }
            else
            {
                _Nomi.Add(nomePercorso);
            }

            this._nomePercorso = nomePercorso;
            this.DescrizionePercorso = descrizionePercorso;
            this.PosizionePartenza = partenza;
            this.PosizioneArrivo = arrivo;
            this.Overlay = overlay;
            this.distanza = dist;
            this.tempo = temp;
           

            

        }

        public override string ToString()
        {
            return $"{NomePercorso} - {DescrizionePercorso} - {PosizionePartenza.Name} - {PosizioneArrivo.Name}";
        }


       
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _posizionePartenza?.Dispose();
                _posizioneArrivo?.Dispose();
            }
        }

        ~Percorso()
        {
            Dispose(false);
        }
    }
}
