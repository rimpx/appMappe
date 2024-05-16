using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using static appMappe.Form1;

namespace appMappe
{
    public class LocationPreferite : Location
    {
        private bool _daVisitare;
        public bool DaVisitare
        {
            get { return _daVisitare; }
            set { _daVisitare = value; }
        }

        private string _tipo;
        public string Tipo
        {
            get { return _tipo; }
            set
            {
                if (value == "casa" || value == "lavoro" || value == "scuola" || value == "altro")
                    _tipo = value;
                else
                    throw new ArgumentException("Tipodeve essere 'casa', 'lavoro', 'scuola', or 'altro'.");
            }
        }

        public LocationPreferite(string indirizzo, string name, string description, PointLatLng coordinates, MarkerType markerType, MarkerColor markerColor, GMapOverlay overlay, bool daVisitare, string tipo)
            : base(indirizzo, name, description, coordinates, markerType, markerColor, overlay)
        {
            this.DaVisitare = daVisitare;
            this.Tipo = tipo;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Da Visitare: {DaVisitare} - Tipo: {Tipo}";
        }
    }
}
