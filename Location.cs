using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using static appMappe.Form1;

namespace appMappe
{
    public class Location
    {
        List<string> _Nomi = new List<string>();

        private string _name;
        public string Name
        {
          get { return _name; }
        }

        private string _indirizzo;

        public string Indirizzo
        {
            get { return _indirizzo; }
            set { _indirizzo = value; }
        }
        
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private PointLatLng _coordinates;

        public PointLatLng Coordinates
        {
            get { return _coordinates; }
            set { _coordinates = value; }
        }

        private GMarkerGoogle _marker;

        public GMarkerGoogle Marker
        {
            get { return _marker; }
            private set { _marker = value; }
        }
        
        private MarkerType _markerType;

        public MarkerType MarkerType 
        {
            get { return _markerType; }
            set { _markerType = value; }
        }

        private MarkerColor _markerColor;
        public MarkerColor MarkerColor 
        {  
            get { return _markerColor; }
            set { _markerColor = value; }
        }

        private GMapOverlay _overlay;
        public GMapOverlay Overlay
        {
            get { return _overlay; }
            set { _overlay = value; }
        }

        public Location(string indirizzo, string name, string description, PointLatLng coordinates, MarkerType markerType, MarkerColor markerColor, GMapOverlay overlay)
        {
            if (_Nomi.Contains(name))
            {
                throw new System.Exception("Nome già presente");
            }
            else
            {
                _Nomi.Add(name);
            }

            this.Indirizzo = indirizzo;
            this._name = name;
            this.Description = description;
            this.Coordinates = coordinates;
            this.MarkerType = markerType;
            this.MarkerColor = markerColor;
            this.Marker = CreateMarker(markerType, markerColor, coordinates);
            this.Overlay = overlay;
        }

        public override string ToString()
        {
            return $"{Name} - {Description} - {MarkerType} - {MarkerColor}";
        }

        private GMarkerGoogle CreateMarker(MarkerType type, MarkerColor color, PointLatLng coordinates)
        {
            GMarkerGoogleType googleMarkerType = GetGoogleMarkerType(type, color);
            return new GMarkerGoogle(coordinates, googleMarkerType);
        }

        private GMarkerGoogleType GetGoogleMarkerType(MarkerType type, MarkerColor color)
        {
            switch (type)
            {
                case MarkerType.Pushpin:
                    switch (color)
                    {
                        case MarkerColor.Yellow: return GMarkerGoogleType.yellow_pushpin;
                        case MarkerColor.Red: return GMarkerGoogleType.red_pushpin;
                        case MarkerColor.Blue: return GMarkerGoogleType.blue_pushpin;
                        default: return GMarkerGoogleType.yellow_pushpin;
                    }
                case MarkerType.RedDot:
                    return GMarkerGoogleType.red_dot;
                case MarkerType.BlueDot:
                    return GMarkerGoogleType.blue_dot;
                default:
                    return GMarkerGoogleType.yellow_pushpin;
            }
        }

        private bool _disposed = false;

        public void Dispose()
        {    
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _marker?.Dispose();
                }

                _disposed = true;
            }
        }


    }
}
