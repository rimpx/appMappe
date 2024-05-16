using System;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.IO;
using System.Drawing;
using static GMap.NET.MapProviders.StrucRoads.SnappedPoint;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using GMap.NET.WindowsPresentation;

namespace appMappe
{
    public partial class Form1 : Form
    {
        public List<Location> _locations = new List<Location>();
        public List<Percorso> percorsi = new List<Percorso>();

        public Form1()
        {
            InitializeComponent();
            InitializeMap();
            InitializeComboBoxes();
        }

        private void InitializeMap()
        {
            MainMap.MapProvider = GMapProviders.OpenStreetMap;
            rd_OpenStreet.Checked = true;
            rd_Politica.Checked = true;
            MainMap.SetPositionByKeywords("Rome, Italy");
            MainMap.MinZoom = 5;
            MainMap.MaxZoom = 100;
            MainMap.Zoom = 12;
            MainMap.ShowCenter = false;
        }

       
        private void CmbMarkerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((MarkerType)cmbMarkerType.SelectedItem == MarkerType.Pushpin)
            {
                cmbMarkerColor.Enabled = true;
            }
            else
            {
                cmbMarkerColor.Enabled = false;
            }
        }


        public enum MarkerType
        {
            Pushpin,
            RedDot,
            BlueDot,
        }

        public enum MarkerColor
        {
            Yellow,
            Red,
            Blue,
        }
   
        private void MainMap_Load(object sender, EventArgs e)
        {
           
           
        }

        private void btn_CercaNome_Click(object sender, EventArgs e)
        {
            string locationName = tb_NomeCercato.Text;
            if (string.IsNullOrEmpty(locationName))
            {
                MessageBox.Show("Inserire il nome del luogo", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MarkerType selectedMarkerType = (MarkerType)cmbMarkerType.SelectedItem;
            MarkerColor selectedMarkerColor = cmbMarkerColor.Enabled ? (MarkerColor)cmbMarkerColor.SelectedItem : MarkerColor.Yellow;

            AddLocationByName(locationName, selectedMarkerType, selectedMarkerColor);
        }



        private void rd_OpenStreet_Click(object sender, EventArgs e)
        {
            if (rd_Geografica.Checked == true)
            {
                MainMap.MapProvider = GMapProviders.OpenCycleMap;
            }
            if (rd_Politica.Checked == true)
            {
                MainMap.MapProvider = GMapProviders.OpenStreetMap;
            }
            if (rd_Topografica.Checked == true)
            {
                MainMap.MapProvider = GMapProviders.OpenCycleTransportMap;
            }
        }

        private void rd_GoogleMaps_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_Geografica.Checked == true)
            {
                MainMap.MapProvider = GMapProviders.GoogleSatelliteMap;
            }
            if (rd_Politica.Checked == true)
            {
                MainMap.MapProvider = GMapProviders.GoogleMap;
            }
            if (rd_Topografica.Checked == true)
            {
                MainMap.MapProvider = GMapProviders.GoogleTerrainMap;
            }
          
        }

        private void rd_WikiMapia_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_Geografica.Checked == true)
            {
                MainMap.MapProvider = GMapProviders.BingSatelliteMap;
            }
            if (rd_Politica.Checked == true)
            {
                MainMap.MapProvider = GMapProviders.BingMap;
            }
            if (rd_Topografica.Checked == true)
            {
                MainMap.MapProvider = GMapProviders.BingHybridMap;
            }
        }

        private void btn_SalvaPosizione_Click(object sender, EventArgs e)
        {
            salvaPosizione();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }


        private void rd_Politica_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_GoogleMaps.Checked == true)
            {
                MainMap.MapProvider = GMapProviders.GoogleMap;
            }
            if (rd_OpenStreet.Checked == true)
            {
                MainMap.MapProvider = GMapProviders.OpenStreetMap;
            }
            if (rd_BingMappa.Checked == true)
            {
                MainMap.MapProvider = GMapProviders.BingMap;
            }
        }

        private void rd_Geografica_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_GoogleMaps.Checked == true)
            {
                MainMap.MapProvider = GMapProviders.GoogleSatelliteMap;
            }
            if (rd_OpenStreet.Checked == true)
            {
                MainMap.MapProvider = GMapProviders.OpenCycleMap;
            }
            if (rd_BingMappa.Checked == true)
            {
                MainMap.MapProvider = GMapProviders.BingSatelliteMap;
            }
        }

        private void rd_Topografica_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_GoogleMaps.Checked == true)
            {
                MainMap.MapProvider = GMapProviders.GoogleTerrainMap;
            }
            if (rd_OpenStreet.Checked == true)
            {
                MainMap.MapProvider = GMapProviders.OpenCycleTransportMap;
            }
            if (rd_BingMappa.Checked == true)
            {
                MainMap.MapProvider = GMapProviders.BingHybridMap;
            }
        }

        private string dataFilePath = Path.Combine(Application.StartupPath, "locations.json");

      
       
       
        private void btn_SalvasuFile_Click(object sender, EventArgs e)
        {
            SerializeLocations();
        }

        private void btn_CaricadaFile_Click(object sender, EventArgs e)
        {
            DeserializeLocations();
        }

        private void btn_CalcolaPercorso_Click(object sender, EventArgs e)
        {
            var startLocation = cmbStartLocation.SelectedItem as string;
            var endLocation = cmbEndLocation.SelectedItem as string;
            CalculateRouteBetweenLocations(startLocation, endLocation);
        }

        private void Viaggi_Click(object sender, EventArgs e)
        {
          
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            InitializeLocationComboBoxes();
        }

        private void btn_VisualizzaPercorso_Click(object sender, EventArgs e)
        {
            visualizzaPercorso();
        }

        private void btn_SalvaPercorso_Click(object sender, EventArgs e)
        {      
            if (string.IsNullOrWhiteSpace(txtNomePercorso.Text) || string.IsNullOrWhiteSpace(txtDescrizionePercorso.Text) ||
                cmbStartLocation.SelectedItem == null || cmbEndLocation.SelectedItem == null)
            {
                MessageBox.Show("Per favore, completa tutti i campi.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var partenza = _locations.Find(loc => loc.Name == cmbStartLocation.SelectedItem.ToString());
            var arrivo = _locations.Find(loc => loc.Name == cmbEndLocation.SelectedItem.ToString());
            Percorso nuovoPercorso = new Percorso(txtNomePercorso.Text, txtDescrizionePercorso.Text, partenza, arrivo, overlayAttuale, lbl_Distanza.Text, lbl_TempoMedio.Text);
            percorsi.Add(nuovoPercorso);
            cmb_EliminaPercorsi.Items.Add(nuovoPercorso);
            txtNomePercorso.Clear();
            txtDescrizionePercorso.Clear();
            visualizzaPercorso();
        }


        private void btn_EliminaPercorso_Click(object sender, EventArgs e)
        {
            Percorso daEliminare = (Percorso)cmb_EliminaPercorsi.SelectedItem;
            if (daEliminare != null && percorsi.Contains(daEliminare))
            {              
                RemoveRouteFromMap(daEliminare);  
                percorsi.Remove(daEliminare);           
                cmb_EliminaPercorsi.Items.Remove(daEliminare);               
                MainMap.Refresh();
                visualizzaPercorso();

                //MessageBox.Show("Percorso rimosso con successo!", "Eliminato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nessun percorso selezionato o il percorso non esiste nella lista.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_EliminaPosizioni_Click(object sender, EventArgs e)
        {
            Location posizioneDaEliminare = (Location)cmb_EliminaPosizioni.SelectedItem;
            if(posizioneDaEliminare != null && _locations.Contains(posizioneDaEliminare))
            {
                MainMap.Overlays.Remove(posizioneDaEliminare.Overlay);
                MainMap.Refresh();
                _locations.Remove(posizioneDaEliminare);
                posizioneDaEliminare.Dispose();
                cmb_EliminaPosizioni.Items.Remove(posizioneDaEliminare) ;
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Nessuna posizione selezionata o posizione non esistente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //-------------------------------------------------------------------- FUNZIONI: --------------------------------------------------------------------

        public GMapOverlay overlayAttualePin = default;
        private void AddLocationByName(string locationName, MarkerType type, MarkerColor color)
        {
            var geocodingProvider = GMapProviders.OpenStreetMap;
            var geo = geocodingProvider.GetPoint(locationName, out GeoCoderStatusCode statusCode);
            if (statusCode == GeoCoderStatusCode.OK && geo != null)
            {
                GMarkerGoogleType markerType = GetMarkerType(type, color);

                var marker = new GMarkerGoogle(geo.Value, markerType);
                var markersOverlay = new GMapOverlay("markers");
                markersOverlay.Markers.Add(marker);
                overlayAttualePin = markersOverlay;
                MainMap.Overlays.Add(markersOverlay);
                MainMap.Position = geo.Value;
                MainMap.Zoom = 15;
            }
            else
            {
                MessageBox.Show("Non è stato possibile trovare il luogo specificato.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private GMarkerGoogleType GetMarkerType(MarkerType type, MarkerColor color)
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

        private void salvaPosizione()
        {
            string indirizzo = tb_NomeCercato.Text.Trim();

            if (string.IsNullOrWhiteSpace(indirizzo))
            {
                MessageBox.Show("Inserire il nome del luogo prima di salvare", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }  

            string nomeSalvare = tb_NomeDaSalare.Text.Trim();

            if (string.IsNullOrWhiteSpace(nomeSalvare))
            {
                MessageBox.Show("Inserire il nome del luogo prima di salvare", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_locations.Any(x => x.Name.Equals(nomeSalvare, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Questa posizione è già stata salvata", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string descrizione = tb_DescrizionePosizione.Text.Trim();

            if (string.IsNullOrWhiteSpace(descrizione))
            {
                MessageBox.Show("Inserire una descrizione prima di salvare", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var geocodingProvider = GMapProviders.OpenStreetMap;
            var geo = geocodingProvider.GetPoint(indirizzo, out GeoCoderStatusCode statusCode);
            if (statusCode == GeoCoderStatusCode.OK && geo != null)
            {
                MarkerType chosenMarkerType = (MarkerType)cmbMarkerType.SelectedItem;
                MarkerColor chosenMarkerColor = (MarkerColor)cmbMarkerColor.SelectedItem;

                bool isPreferito = CheckBox_Preferito.Checked;
                bool daVisitare = check_DaVisitare.Checked;
                string tipo = GetSelectedTipo();

                Location newLocation;
                if (isPreferito)
                {
                    newLocation = new LocationPreferite(indirizzo, nomeSalvare, descrizione, geo.Value, chosenMarkerType, chosenMarkerColor, overlayAttualePin, daVisitare, tipo);
                }
                else
                {
                    newLocation = new Location(indirizzo, nomeSalvare, descrizione, geo.Value, chosenMarkerType, chosenMarkerColor, overlayAttualePin);
                }

                _locations.Add(newLocation);
                cmb_EliminaPosizioni.Items.Add(newLocation);

                var markersOverlay = new GMapOverlay("markers");
                markersOverlay.Markers.Add(newLocation.Marker);
                MainMap.Overlays.Add(markersOverlay);
                MainMap.Position = geo.Value;

                MessageBox.Show("Posizione salvata con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_NomeCercato.Clear();
                tb_NomeDaSalare.Clear();
                tb_DescrizionePosizione.Clear();
                check_DaVisitare.Checked = false;
                CheckBox_Preferito.Checked = false;
                rd_PrefeCasa.Checked = false;
                rd_PrefLavoro.Checked = false;
                rd_PrefScuola.Checked = false;
                rd_PrefAltro.Checked = false;
            }
            else
            {
                MessageBox.Show("Non è stato possibile trovare il luogo specificato.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetSelectedTipo()
        {
            if (rd_PrefLavoro.Checked)
                return "lavoro";
            if (rd_PrefScuola.Checked)
                return "scuola";
            if (rd_PrefeCasa.Checked)
                return "casa";
            return "altro"; // Assuming 'rd_Altro' is selected by default or as a fallback
        }


        private void InitializeComboBoxes()
        {
            cmbMarkerType.DataSource = Enum.GetValues(typeof(MarkerType));
            cmbMarkerType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarkerType.SelectedIndexChanged += CmbMarkerType_SelectedIndexChanged;

            cmbMarkerColor.DataSource = Enum.GetValues(typeof(MarkerColor));
            cmbMarkerColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarkerColor.Enabled = false;
        }

        private void visualizzaPercorso()
        {
            var visualizza = percorsi.Select(p => new
            {
                Nome = p.NomePercorso,
                Descrizione = p.DescrizionePercorso,
                Partenza = p.PosizionePartenza.Name,
                Arrivo = p.PosizioneArrivo.Name,
                Distanza = p.distanza,
                Tempo = p.tempo
            }).ToList();

            dgv_VisualizzaPercorsi.DataSource = visualizza;
        }

        private void RemoveRouteFromMap(Percorso percorso)
        {
              //percorso.Overlay.Routes.Clear();
              MainMap.Overlays.Remove(percorso.Overlay);
              MainMap.Refresh();
        }

        private void InitializeLocationComboBoxes()
        {
            cmbStartLocation.DataSource = _locations.Select(loc => loc.Name).ToList();
            cmbEndLocation.DataSource = _locations.Select(loc => loc.Name).ToList();
        }
        private void SerializeLocations()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.Objects // This will include type information in the JSON output
            };

            var json = JsonConvert.SerializeObject(_locations, settings);
            File.WriteAllText(dataFilePath, json);
        }



        public GMapOverlay overlayAttuale = default;

        private void CalculateAndDisplayRoute(Percorso percorso)
        {
            lbl_TempoMedio.Text = "";
            lbl_Distanza.Text = "";
            var routeProvider = GMapProviders.OpenStreetMap;

            var start = percorso.PosizionePartenza.Coordinates;
            var end = percorso.PosizioneArrivo.Coordinates;

            var route = routeProvider.GetRoute(start, end, false, false, 14);
            if (route != null)
            {

                var gMapRoute = new GMap.NET.WindowsForms.GMapRoute(route.Points, percorso.NomePercorso)
                {
                    Stroke = new Pen(Color.Red, 3)
                };

                var duration = route.Distance / 50.0 * 60.0;


                percorso.Overlay = new GMapOverlay(percorso.NomePercorso + "_overlay");


                percorso.Overlay.Routes.Add(gMapRoute);
                MainMap.Overlays.Add(percorso.Overlay);
                MainMap.ZoomAndCenterRoute(gMapRoute);
                overlayAttuale = percorso.Overlay;

                lbl_Distanza.Text = $"{route.Distance:0.00} km";
                lbl_TempoMedio.Text = $"{duration:0.00} minuti (a 50km/h)";
            }
            else
            {
                MessageBox.Show("Impossibile trovare un percorso.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateRouteBetweenLocations(string startName, string endName)
        {
            var startLocation = _locations.FirstOrDefault(loc => loc.Name.Equals(startName, StringComparison.OrdinalIgnoreCase));
            var endLocation = _locations.FirstOrDefault(loc => loc.Name.Equals(endName, StringComparison.OrdinalIgnoreCase));

            if (startLocation == null || endLocation == null)
            {
                MessageBox.Show("Una o entrambe le posizioni non sono state trovate.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Percorso percorso = new Percorso(
                "Percorso da " + startName + " a " + endName,
                "Descrizione del percorso tra " + startName + " e " + endName, // Descrizione
                startLocation, // Posizione di partenza
                endLocation, // Posizione di arrivo
                null,
                "",
                ""
            );

            CalculateAndDisplayRoute(percorso);
        }


        private void UpdateDataGridView()
        {
            dgv_Posizioni.DataSource = _locations.Select(loc => new {
                Nome = loc.Name,
                Indirizzo = loc.Indirizzo,
                Descrizione = loc.Description,
                TipoMarker = loc.MarkerType.ToString(),
                Colore = loc.MarkerColor.ToString(),
                DaVisitare = loc is LocationPreferite detailedLoc ? detailedLoc.DaVisitare.ToString() : "N/A",
                Tipo = loc is LocationPreferite detailed ? detailed.Tipo : "N/A"
            }).ToList();

            dgv_Posizioni.AutoGenerateColumns = true;
        }

        private void AddMarkerToMap(Location location)
        {
            GMarkerGoogleType markerType = GetMarkerType(location.MarkerType, location.MarkerColor);
            var marker = new GMarkerGoogle(location.Coordinates, markerType);
            var markersOverlay = new GMapOverlay(location.Name + "_overlay");
            markersOverlay.Markers.Add(marker);
            location.Overlay = markersOverlay;
            MainMap.Overlays.Add(markersOverlay);
        }

        private void DeserializeLocations()
        {
            if (File.Exists(dataFilePath))
            {
                var json = File.ReadAllText(dataFilePath);
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Objects 
                };

                var deserializedLocations = JsonConvert.DeserializeObject<List<Location>>(json, settings);
                var uniqueLocations = new HashSet<string>(_locations.Select(l => l.Name.ToLower()));

                foreach (var location in deserializedLocations)
                {
                    if (!uniqueLocations.Contains(location.Name.ToLower()))
                    {
                        uniqueLocations.Add(location.Name.ToLower());
                        _locations.Add(location);
                        AddMarkerToMap(location); 
                        cmb_EliminaPosizioni.Items.Add(location);
                    }
                }
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("File di dati non trovato.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }












    }
}
