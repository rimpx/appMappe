namespace appMappe
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainMap = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_NomeCercato = new System.Windows.Forms.TextBox();
            this.btn_CercaNome = new System.Windows.Forms.Button();
            this.rd_OpenStreet = new System.Windows.Forms.RadioButton();
            this.rd_GoogleMaps = new System.Windows.Forms.RadioButton();
            this.rd_BingMappa = new System.Windows.Forms.RadioButton();
            this.btn_SalvaPosizione = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_EliminaPosizioni = new System.Windows.Forms.Button();
            this.cmb_EliminaPosizioni = new System.Windows.Forms.ComboBox();
            this.btn_CaricadaFile = new System.Windows.Forms.Button();
            this.btn_SalvasuFile = new System.Windows.Forms.Button();
            this.tb_DescrizionePosizione = new System.Windows.Forms.TextBox();
            this.btn_AggiornaPosizioni = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Posizioni = new System.Windows.Forms.DataGridView();
            this.tb_NomeDaSalare = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Viaggi = new System.Windows.Forms.TabPage();
            this.btn_EliminaPercorso = new System.Windows.Forms.Button();
            this.cmb_EliminaPercorsi = new System.Windows.Forms.ComboBox();
            this.txtDescrizionePercorso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomePercorso = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_VisualizzaPercorso = new System.Windows.Forms.Button();
            this.btn_SalvaPercorso = new System.Windows.Forms.Button();
            this.dgv_VisualizzaPercorsi = new System.Windows.Forms.DataGridView();
            this.lbl_TempoMedio = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Distanza = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_CalcolaPercorso = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEndLocation = new System.Windows.Forms.ComboBox();
            this.cmbStartLocation = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rd_Topografica = new System.Windows.Forms.RadioButton();
            this.rd_Politica = new System.Windows.Forms.RadioButton();
            this.rd_Geografica = new System.Windows.Forms.RadioButton();
            this.cmbMarkerType = new System.Windows.Forms.ComboBox();
            this.cmbMarkerColor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CheckBox_Preferito = new System.Windows.Forms.CheckBox();
            this.rd_PrefeCasa = new System.Windows.Forms.RadioButton();
            this.rd_PrefLavoro = new System.Windows.Forms.RadioButton();
            this.rd_PrefScuola = new System.Windows.Forms.RadioButton();
            this.rd_PrefAltro = new System.Windows.Forms.RadioButton();
            this.check_DaVisitare = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Posizioni)).BeginInit();
            this.Viaggi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VisualizzaPercorsi)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMap
            // 
            this.MainMap.Bearing = 0F;
            this.MainMap.CanDragMap = true;
            this.MainMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.LevelsKeepInMemory = 5;
            this.MainMap.Location = new System.Drawing.Point(4, 4);
            this.MainMap.MarkersEnabled = true;
            this.MainMap.MaxZoom = 2;
            this.MainMap.MinZoom = 2;
            this.MainMap.MouseWheelZoomEnabled = true;
            this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MainMap.Name = "MainMap";
            this.MainMap.NegativeMode = false;
            this.MainMap.PolygonsEnabled = true;
            this.MainMap.RetryLoadTile = 0;
            this.MainMap.RoutesEnabled = true;
            this.MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap.ShowTileGridLines = false;
            this.MainMap.Size = new System.Drawing.Size(1021, 962);
            this.MainMap.TabIndex = 4;
            this.MainMap.Zoom = 0D;
            this.MainMap.Load += new System.EventHandler(this.MainMap_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1041, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "POSIZIONE:";
            // 
            // tb_NomeCercato
            // 
            this.tb_NomeCercato.Location = new System.Drawing.Point(1161, 73);
            this.tb_NomeCercato.Name = "tb_NomeCercato";
            this.tb_NomeCercato.Size = new System.Drawing.Size(274, 20);
            this.tb_NomeCercato.TabIndex = 6;
            // 
            // btn_CercaNome
            // 
            this.btn_CercaNome.Location = new System.Drawing.Point(1455, 73);
            this.btn_CercaNome.Name = "btn_CercaNome";
            this.btn_CercaNome.Size = new System.Drawing.Size(65, 52);
            this.btn_CercaNome.TabIndex = 7;
            this.btn_CercaNome.Text = "VAI";
            this.btn_CercaNome.UseVisualStyleBackColor = true;
            this.btn_CercaNome.Click += new System.EventHandler(this.btn_CercaNome_Click);
            // 
            // rd_OpenStreet
            // 
            this.rd_OpenStreet.AutoSize = true;
            this.rd_OpenStreet.Location = new System.Drawing.Point(6, 19);
            this.rd_OpenStreet.Name = "rd_OpenStreet";
            this.rd_OpenStreet.Size = new System.Drawing.Size(100, 17);
            this.rd_OpenStreet.TabIndex = 8;
            this.rd_OpenStreet.TabStop = true;
            this.rd_OpenStreet.Text = "OpenStreetMap";
            this.rd_OpenStreet.UseVisualStyleBackColor = true;
            this.rd_OpenStreet.Click += new System.EventHandler(this.rd_OpenStreet_Click);
            // 
            // rd_GoogleMaps
            // 
            this.rd_GoogleMaps.AutoSize = true;
            this.rd_GoogleMaps.Location = new System.Drawing.Point(112, 19);
            this.rd_GoogleMaps.Name = "rd_GoogleMaps";
            this.rd_GoogleMaps.Size = new System.Drawing.Size(88, 17);
            this.rd_GoogleMaps.TabIndex = 9;
            this.rd_GoogleMaps.TabStop = true;
            this.rd_GoogleMaps.Text = "Google Maps";
            this.rd_GoogleMaps.UseVisualStyleBackColor = true;
            this.rd_GoogleMaps.CheckedChanged += new System.EventHandler(this.rd_GoogleMaps_CheckedChanged);
            // 
            // rd_BingMappa
            // 
            this.rd_BingMappa.AutoSize = true;
            this.rd_BingMappa.Location = new System.Drawing.Point(210, 19);
            this.rd_BingMappa.Name = "rd_BingMappa";
            this.rd_BingMappa.Size = new System.Drawing.Size(67, 17);
            this.rd_BingMappa.TabIndex = 10;
            this.rd_BingMappa.TabStop = true;
            this.rd_BingMappa.Text = "BingMap";
            this.rd_BingMappa.UseVisualStyleBackColor = true;
            this.rd_BingMappa.CheckedChanged += new System.EventHandler(this.rd_WikiMapia_CheckedChanged);
            // 
            // btn_SalvaPosizione
            // 
            this.btn_SalvaPosizione.Location = new System.Drawing.Point(538, 301);
            this.btn_SalvaPosizione.Name = "btn_SalvaPosizione";
            this.btn_SalvaPosizione.Size = new System.Drawing.Size(170, 46);
            this.btn_SalvaPosizione.TabIndex = 11;
            this.btn_SalvaPosizione.Text = "SALVA";
            this.btn_SalvaPosizione.UseVisualStyleBackColor = true;
            this.btn_SalvaPosizione.Click += new System.EventHandler(this.btn_SalvaPosizione_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_BingMappa);
            this.groupBox1.Controls.Add(this.rd_OpenStreet);
            this.groupBox1.Controls.Add(this.rd_GoogleMaps);
            this.groupBox1.Location = new System.Drawing.Point(1063, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 43);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleziona il provider";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Viaggi);
            this.tabControl1.Location = new System.Drawing.Point(1037, 164);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(815, 802);
            this.tabControl1.TabIndex = 13;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CheckBox_Preferito);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.btn_EliminaPosizioni);
            this.tabPage1.Controls.Add(this.cmb_EliminaPosizioni);
            this.tabPage1.Controls.Add(this.btn_CaricadaFile);
            this.tabPage1.Controls.Add(this.btn_SalvasuFile);
            this.tabPage1.Controls.Add(this.tb_DescrizionePosizione);
            this.tabPage1.Controls.Add(this.btn_AggiornaPosizioni);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dgv_Posizioni);
            this.tabPage1.Controls.Add(this.tb_NomeDaSalare);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_SalvaPosizione);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(807, 776);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Posizioni";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_EliminaPosizioni
            // 
            this.btn_EliminaPosizioni.Location = new System.Drawing.Point(551, 499);
            this.btn_EliminaPosizioni.Name = "btn_EliminaPosizioni";
            this.btn_EliminaPosizioni.Size = new System.Drawing.Size(142, 44);
            this.btn_EliminaPosizioni.TabIndex = 26;
            this.btn_EliminaPosizioni.Text = "Elimina";
            this.btn_EliminaPosizioni.UseVisualStyleBackColor = true;
            this.btn_EliminaPosizioni.Click += new System.EventHandler(this.btn_EliminaPosizioni_Click);
            // 
            // cmb_EliminaPosizioni
            // 
            this.cmb_EliminaPosizioni.FormattingEnabled = true;
            this.cmb_EliminaPosizioni.Location = new System.Drawing.Point(521, 472);
            this.cmb_EliminaPosizioni.Name = "cmb_EliminaPosizioni";
            this.cmb_EliminaPosizioni.Size = new System.Drawing.Size(200, 21);
            this.cmb_EliminaPosizioni.TabIndex = 25;
            // 
            // btn_CaricadaFile
            // 
            this.btn_CaricadaFile.Location = new System.Drawing.Point(143, 16);
            this.btn_CaricadaFile.Name = "btn_CaricadaFile";
            this.btn_CaricadaFile.Size = new System.Drawing.Size(115, 31);
            this.btn_CaricadaFile.TabIndex = 3;
            this.btn_CaricadaFile.Text = "Carica da file";
            this.btn_CaricadaFile.UseVisualStyleBackColor = true;
            this.btn_CaricadaFile.Click += new System.EventHandler(this.btn_CaricadaFile_Click);
            // 
            // btn_SalvasuFile
            // 
            this.btn_SalvasuFile.Location = new System.Drawing.Point(22, 16);
            this.btn_SalvasuFile.Name = "btn_SalvasuFile";
            this.btn_SalvasuFile.Size = new System.Drawing.Size(115, 31);
            this.btn_SalvasuFile.TabIndex = 2;
            this.btn_SalvasuFile.Text = "Salva su file";
            this.btn_SalvasuFile.UseVisualStyleBackColor = true;
            this.btn_SalvasuFile.Click += new System.EventHandler(this.btn_SalvasuFile_Click);
            // 
            // tb_DescrizionePosizione
            // 
            this.tb_DescrizionePosizione.Location = new System.Drawing.Point(511, 127);
            this.tb_DescrizionePosizione.Name = "tb_DescrizionePosizione";
            this.tb_DescrizionePosizione.Size = new System.Drawing.Size(274, 20);
            this.tb_DescrizionePosizione.TabIndex = 18;
            // 
            // btn_AggiornaPosizioni
            // 
            this.btn_AggiornaPosizioni.Location = new System.Drawing.Point(22, 746);
            this.btn_AggiornaPosizioni.Name = "btn_AggiornaPosizioni";
            this.btn_AggiornaPosizioni.Size = new System.Drawing.Size(403, 24);
            this.btn_AggiornaPosizioni.TabIndex = 1;
            this.btn_AggiornaPosizioni.Text = "Aggiorna";
            this.btn_AggiornaPosizioni.UseVisualStyleBackColor = true;
            this.btn_AggiornaPosizioni.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Descrizione:";
            // 
            // dgv_Posizioni
            // 
            this.dgv_Posizioni.Location = new System.Drawing.Point(22, 53);
            this.dgv_Posizioni.Name = "dgv_Posizioni";
            this.dgv_Posizioni.Size = new System.Drawing.Size(403, 687);
            this.dgv_Posizioni.TabIndex = 0;
            // 
            // tb_NomeDaSalare
            // 
            this.tb_NomeDaSalare.Location = new System.Drawing.Point(511, 101);
            this.tb_NomeDaSalare.Name = "tb_NomeDaSalare";
            this.tb_NomeDaSalare.Size = new System.Drawing.Size(274, 20);
            this.tb_NomeDaSalare.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome:";
            // 
            // Viaggi
            // 
            this.Viaggi.Controls.Add(this.btn_EliminaPercorso);
            this.Viaggi.Controls.Add(this.cmb_EliminaPercorsi);
            this.Viaggi.Controls.Add(this.txtDescrizionePercorso);
            this.Viaggi.Controls.Add(this.label9);
            this.Viaggi.Controls.Add(this.txtNomePercorso);
            this.Viaggi.Controls.Add(this.label10);
            this.Viaggi.Controls.Add(this.btn_VisualizzaPercorso);
            this.Viaggi.Controls.Add(this.btn_SalvaPercorso);
            this.Viaggi.Controls.Add(this.dgv_VisualizzaPercorsi);
            this.Viaggi.Controls.Add(this.lbl_TempoMedio);
            this.Viaggi.Controls.Add(this.label8);
            this.Viaggi.Controls.Add(this.lbl_Distanza);
            this.Viaggi.Controls.Add(this.label6);
            this.Viaggi.Controls.Add(this.btn_CalcolaPercorso);
            this.Viaggi.Controls.Add(this.label5);
            this.Viaggi.Controls.Add(this.label4);
            this.Viaggi.Controls.Add(this.cmbEndLocation);
            this.Viaggi.Controls.Add(this.cmbStartLocation);
            this.Viaggi.Location = new System.Drawing.Point(4, 22);
            this.Viaggi.Name = "Viaggi";
            this.Viaggi.Padding = new System.Windows.Forms.Padding(3);
            this.Viaggi.Size = new System.Drawing.Size(807, 776);
            this.Viaggi.TabIndex = 1;
            this.Viaggi.Text = "Viaggi";
            this.Viaggi.UseVisualStyleBackColor = true;
            this.Viaggi.Click += new System.EventHandler(this.Viaggi_Click);
            // 
            // btn_EliminaPercorso
            // 
            this.btn_EliminaPercorso.Location = new System.Drawing.Point(570, 549);
            this.btn_EliminaPercorso.Name = "btn_EliminaPercorso";
            this.btn_EliminaPercorso.Size = new System.Drawing.Size(142, 44);
            this.btn_EliminaPercorso.TabIndex = 24;
            this.btn_EliminaPercorso.Text = "Elimina";
            this.btn_EliminaPercorso.UseVisualStyleBackColor = true;
            this.btn_EliminaPercorso.Click += new System.EventHandler(this.btn_EliminaPercorso_Click);
            // 
            // cmb_EliminaPercorsi
            // 
            this.cmb_EliminaPercorsi.FormattingEnabled = true;
            this.cmb_EliminaPercorsi.Location = new System.Drawing.Point(540, 522);
            this.cmb_EliminaPercorsi.Name = "cmb_EliminaPercorsi";
            this.cmb_EliminaPercorsi.Size = new System.Drawing.Size(200, 21);
            this.cmb_EliminaPercorsi.TabIndex = 23;
            // 
            // txtDescrizionePercorso
            // 
            this.txtDescrizionePercorso.Location = new System.Drawing.Point(516, 196);
            this.txtDescrizionePercorso.Name = "txtDescrizionePercorso";
            this.txtDescrizionePercorso.Size = new System.Drawing.Size(274, 20);
            this.txtDescrizionePercorso.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(445, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Descrizione:";
            // 
            // txtNomePercorso
            // 
            this.txtNomePercorso.Location = new System.Drawing.Point(516, 170);
            this.txtNomePercorso.Name = "txtNomePercorso";
            this.txtNomePercorso.Size = new System.Drawing.Size(274, 20);
            this.txtNomePercorso.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(445, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Nome:";
            // 
            // btn_VisualizzaPercorso
            // 
            this.btn_VisualizzaPercorso.Location = new System.Drawing.Point(20, 746);
            this.btn_VisualizzaPercorso.Name = "btn_VisualizzaPercorso";
            this.btn_VisualizzaPercorso.Size = new System.Drawing.Size(419, 24);
            this.btn_VisualizzaPercorso.TabIndex = 11;
            this.btn_VisualizzaPercorso.Text = "Aggiorna";
            this.btn_VisualizzaPercorso.UseVisualStyleBackColor = true;
            this.btn_VisualizzaPercorso.Click += new System.EventHandler(this.btn_VisualizzaPercorso_Click);
            // 
            // btn_SalvaPercorso
            // 
            this.btn_SalvaPercorso.Location = new System.Drawing.Point(591, 222);
            this.btn_SalvaPercorso.Name = "btn_SalvaPercorso";
            this.btn_SalvaPercorso.Size = new System.Drawing.Size(121, 54);
            this.btn_SalvaPercorso.TabIndex = 10;
            this.btn_SalvaPercorso.Text = "Salva percorso";
            this.btn_SalvaPercorso.UseVisualStyleBackColor = true;
            this.btn_SalvaPercorso.Click += new System.EventHandler(this.btn_SalvaPercorso_Click);
            // 
            // dgv_VisualizzaPercorsi
            // 
            this.dgv_VisualizzaPercorsi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VisualizzaPercorsi.Location = new System.Drawing.Point(20, 82);
            this.dgv_VisualizzaPercorsi.Name = "dgv_VisualizzaPercorsi";
            this.dgv_VisualizzaPercorsi.Size = new System.Drawing.Size(419, 658);
            this.dgv_VisualizzaPercorsi.TabIndex = 9;
            // 
            // lbl_TempoMedio
            // 
            this.lbl_TempoMedio.AutoSize = true;
            this.lbl_TempoMedio.Location = new System.Drawing.Point(547, 47);
            this.lbl_TempoMedio.Name = "lbl_TempoMedio";
            this.lbl_TempoMedio.Size = new System.Drawing.Size(0, 13);
            this.lbl_TempoMedio.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tempo medio:";
            // 
            // lbl_Distanza
            // 
            this.lbl_Distanza.AutoSize = true;
            this.lbl_Distanza.Location = new System.Drawing.Point(524, 24);
            this.lbl_Distanza.Name = "lbl_Distanza";
            this.lbl_Distanza.Size = new System.Drawing.Size(0, 13);
            this.lbl_Distanza.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Distanza:";
            // 
            // btn_CalcolaPercorso
            // 
            this.btn_CalcolaPercorso.Location = new System.Drawing.Point(337, 17);
            this.btn_CalcolaPercorso.Name = "btn_CalcolaPercorso";
            this.btn_CalcolaPercorso.Size = new System.Drawing.Size(124, 48);
            this.btn_CalcolaPercorso.TabIndex = 4;
            this.btn_CalcolaPercorso.Text = "Calcola percorso";
            this.btn_CalcolaPercorso.UseVisualStyleBackColor = true;
            this.btn_CalcolaPercorso.Click += new System.EventHandler(this.btn_CalcolaPercorso_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Luogo di destinazione";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Luogo di partenza";
            // 
            // cmbEndLocation
            // 
            this.cmbEndLocation.FormattingEnabled = true;
            this.cmbEndLocation.Location = new System.Drawing.Point(137, 44);
            this.cmbEndLocation.Name = "cmbEndLocation";
            this.cmbEndLocation.Size = new System.Drawing.Size(191, 21);
            this.cmbEndLocation.TabIndex = 1;
            // 
            // cmbStartLocation
            // 
            this.cmbStartLocation.FormattingEnabled = true;
            this.cmbStartLocation.Location = new System.Drawing.Point(137, 17);
            this.cmbStartLocation.Name = "cmbStartLocation";
            this.cmbStartLocation.Size = new System.Drawing.Size(191, 21);
            this.cmbStartLocation.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rd_Topografica);
            this.groupBox2.Controls.Add(this.rd_Politica);
            this.groupBox2.Controls.Add(this.rd_Geografica);
            this.groupBox2.Location = new System.Drawing.Point(1362, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 43);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleziona tipo cartina";
            // 
            // rd_Topografica
            // 
            this.rd_Topografica.AutoSize = true;
            this.rd_Topografica.Location = new System.Drawing.Point(164, 20);
            this.rd_Topografica.Name = "rd_Topografica";
            this.rd_Topografica.Size = new System.Drawing.Size(82, 17);
            this.rd_Topografica.TabIndex = 10;
            this.rd_Topografica.TabStop = true;
            this.rd_Topografica.Text = "Topografica";
            this.rd_Topografica.UseVisualStyleBackColor = true;
            this.rd_Topografica.CheckedChanged += new System.EventHandler(this.rd_Topografica_CheckedChanged);
            // 
            // rd_Politica
            // 
            this.rd_Politica.AutoSize = true;
            this.rd_Politica.Location = new System.Drawing.Point(16, 19);
            this.rd_Politica.Name = "rd_Politica";
            this.rd_Politica.Size = new System.Drawing.Size(59, 17);
            this.rd_Politica.TabIndex = 8;
            this.rd_Politica.TabStop = true;
            this.rd_Politica.Text = "Politica";
            this.rd_Politica.UseVisualStyleBackColor = true;
            this.rd_Politica.CheckedChanged += new System.EventHandler(this.rd_Politica_CheckedChanged);
            // 
            // rd_Geografica
            // 
            this.rd_Geografica.AutoSize = true;
            this.rd_Geografica.Location = new System.Drawing.Point(81, 19);
            this.rd_Geografica.Name = "rd_Geografica";
            this.rd_Geografica.Size = new System.Drawing.Size(77, 17);
            this.rd_Geografica.TabIndex = 9;
            this.rd_Geografica.TabStop = true;
            this.rd_Geografica.Text = "Geografica";
            this.rd_Geografica.UseVisualStyleBackColor = true;
            this.rd_Geografica.CheckedChanged += new System.EventHandler(this.rd_Geografica_CheckedChanged);
            // 
            // cmbMarkerType
            // 
            this.cmbMarkerType.FormattingEnabled = true;
            this.cmbMarkerType.Location = new System.Drawing.Point(1161, 99);
            this.cmbMarkerType.Name = "cmbMarkerType";
            this.cmbMarkerType.Size = new System.Drawing.Size(138, 21);
            this.cmbMarkerType.TabIndex = 19;
            // 
            // cmbMarkerColor
            // 
            this.cmbMarkerColor.FormattingEnabled = true;
            this.cmbMarkerColor.Location = new System.Drawing.Point(1305, 99);
            this.cmbMarkerColor.Name = "cmbMarkerColor";
            this.cmbMarkerColor.Size = new System.Drawing.Size(132, 21);
            this.cmbMarkerColor.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1041, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "MARKER:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.check_DaVisitare);
            this.groupBox3.Controls.Add(this.rd_PrefAltro);
            this.groupBox3.Controls.Add(this.rd_PrefScuola);
            this.groupBox3.Controls.Add(this.rd_PrefLavoro);
            this.groupBox3.Controls.Add(this.rd_PrefeCasa);
            this.groupBox3.Location = new System.Drawing.Point(468, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 73);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo di preferenza";
            // 
            // CheckBox_Preferito
            // 
            this.CheckBox_Preferito.AutoSize = true;
            this.CheckBox_Preferito.Location = new System.Drawing.Point(440, 177);
            this.CheckBox_Preferito.Name = "CheckBox_Preferito";
            this.CheckBox_Preferito.Size = new System.Drawing.Size(65, 17);
            this.CheckBox_Preferito.TabIndex = 28;
            this.CheckBox_Preferito.Text = "Preferito";
            this.CheckBox_Preferito.UseVisualStyleBackColor = true;
            // 
            // rd_PrefeCasa
            // 
            this.rd_PrefeCasa.AutoSize = true;
            this.rd_PrefeCasa.Location = new System.Drawing.Point(28, 44);
            this.rd_PrefeCasa.Name = "rd_PrefeCasa";
            this.rd_PrefeCasa.Size = new System.Drawing.Size(49, 17);
            this.rd_PrefeCasa.TabIndex = 0;
            this.rd_PrefeCasa.TabStop = true;
            this.rd_PrefeCasa.Text = "Casa";
            this.rd_PrefeCasa.UseVisualStyleBackColor = true;
            // 
            // rd_PrefLavoro
            // 
            this.rd_PrefLavoro.AutoSize = true;
            this.rd_PrefLavoro.Location = new System.Drawing.Point(83, 44);
            this.rd_PrefLavoro.Name = "rd_PrefLavoro";
            this.rd_PrefLavoro.Size = new System.Drawing.Size(58, 17);
            this.rd_PrefLavoro.TabIndex = 1;
            this.rd_PrefLavoro.TabStop = true;
            this.rd_PrefLavoro.Text = "Lavoro";
            this.rd_PrefLavoro.UseVisualStyleBackColor = true;
            // 
            // rd_PrefScuola
            // 
            this.rd_PrefScuola.AutoSize = true;
            this.rd_PrefScuola.Location = new System.Drawing.Point(147, 44);
            this.rd_PrefScuola.Name = "rd_PrefScuola";
            this.rd_PrefScuola.Size = new System.Drawing.Size(58, 17);
            this.rd_PrefScuola.TabIndex = 29;
            this.rd_PrefScuola.TabStop = true;
            this.rd_PrefScuola.Text = "Scuola";
            this.rd_PrefScuola.UseVisualStyleBackColor = true;
            // 
            // rd_PrefAltro
            // 
            this.rd_PrefAltro.AutoSize = true;
            this.rd_PrefAltro.Location = new System.Drawing.Point(211, 44);
            this.rd_PrefAltro.Name = "rd_PrefAltro";
            this.rd_PrefAltro.Size = new System.Drawing.Size(46, 17);
            this.rd_PrefAltro.TabIndex = 29;
            this.rd_PrefAltro.TabStop = true;
            this.rd_PrefAltro.Text = "Altro";
            this.rd_PrefAltro.UseVisualStyleBackColor = true;
            // 
            // check_DaVisitare
            // 
            this.check_DaVisitare.AutoSize = true;
            this.check_DaVisitare.Location = new System.Drawing.Point(111, 21);
            this.check_DaVisitare.Name = "check_DaVisitare";
            this.check_DaVisitare.Size = new System.Drawing.Size(77, 17);
            this.check_DaVisitare.TabIndex = 29;
            this.check_DaVisitare.Text = "Da Visitare";
            this.check_DaVisitare.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1864, 968);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbMarkerColor);
            this.Controls.Add(this.cmbMarkerType);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_CercaNome);
            this.Controls.Add(this.tb_NomeCercato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainMap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AppMappe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Posizioni)).EndInit();
            this.Viaggi.ResumeLayout(false);
            this.Viaggi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VisualizzaPercorsi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl MainMap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_NomeCercato;
        private System.Windows.Forms.Button btn_CercaNome;
        private System.Windows.Forms.RadioButton rd_OpenStreet;
        private System.Windows.Forms.RadioButton rd_GoogleMaps;
        private System.Windows.Forms.RadioButton rd_BingMappa;
        private System.Windows.Forms.Button btn_SalvaPosizione;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Viaggi;
        private System.Windows.Forms.Button btn_AggiornaPosizioni;
        private System.Windows.Forms.DataGridView dgv_Posizioni;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rd_Topografica;
        private System.Windows.Forms.RadioButton rd_Politica;
        private System.Windows.Forms.RadioButton rd_Geografica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_NomeDaSalare;
        private System.Windows.Forms.TextBox tb_DescrizionePosizione;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMarkerType;
        private System.Windows.Forms.ComboBox cmbMarkerColor;
        private System.Windows.Forms.Button btn_CaricadaFile;
        private System.Windows.Forms.Button btn_SalvasuFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEndLocation;
        private System.Windows.Forms.ComboBox cmbStartLocation;
        private System.Windows.Forms.Button btn_CalcolaPercorso;
        private System.Windows.Forms.Label lbl_TempoMedio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Distanza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_SalvaPercorso;
        private System.Windows.Forms.DataGridView dgv_VisualizzaPercorsi;
        private System.Windows.Forms.Button btn_VisualizzaPercorso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescrizionePercorso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNomePercorso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_EliminaPercorso;
        private System.Windows.Forms.ComboBox cmb_EliminaPercorsi;
        private System.Windows.Forms.Button btn_EliminaPosizioni;
        private System.Windows.Forms.ComboBox cmb_EliminaPosizioni;
        private System.Windows.Forms.CheckBox CheckBox_Preferito;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox check_DaVisitare;
        private System.Windows.Forms.RadioButton rd_PrefAltro;
        private System.Windows.Forms.RadioButton rd_PrefScuola;
        private System.Windows.Forms.RadioButton rd_PrefLavoro;
        private System.Windows.Forms.RadioButton rd_PrefeCasa;
    }
}

