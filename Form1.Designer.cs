namespace Gestion_Archivo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cedula = new System.Windows.Forms.TextBox();
            this.Edad = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Imprimir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtHoraActual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Paises = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TipoCambio = new System.Windows.Forms.ComboBox();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Dolares = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(31, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Funciones asincronas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(31, 465);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Tarea asincronica";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.Imprimir);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Nombre);
            this.panel1.Controls.Add(this.Edad);
            this.panel1.Controls.Add(this.Cedula);
            this.panel1.Location = new System.Drawing.Point(54, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 224);
            this.panel1.TabIndex = 2;
            // 
            // Cedula
            // 
            this.Cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Cedula.Location = new System.Drawing.Point(47, 53);
            this.Cedula.Name = "Cedula";
            this.Cedula.Size = new System.Drawing.Size(203, 26);
            this.Cedula.TabIndex = 0;
            // 
            // Edad
            // 
            this.Edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Edad.Location = new System.Drawing.Point(271, 53);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(96, 26);
            this.Edad.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Nombre.Location = new System.Drawing.Point(47, 108);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(320, 26);
            this.Nombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cédula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre ";
            // 
            // Imprimir
            // 
            this.Imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Imprimir.ForeColor = System.Drawing.Color.White;
            this.Imprimir.Location = new System.Drawing.Point(134, 155);
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(137, 49);
            this.Imprimir.TabIndex = 6;
            this.Imprimir.Text = "Imprimir Valores";
            this.Imprimir.UseVisualStyleBackColor = false;
            this.Imprimir.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.Paises);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtHoraActual);
            this.panel2.Location = new System.Drawing.Point(588, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 153);
            this.panel2.TabIndex = 3;
            // 
            // txtHoraActual
            // 
            this.txtHoraActual.Location = new System.Drawing.Point(187, 61);
            this.txtHoraActual.Name = "txtHoraActual";
            this.txtHoraActual.Size = new System.Drawing.Size(205, 20);
            this.txtHoraActual.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(136, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Micro Servicios ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(161, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 39);
            this.button3.TabIndex = 1;
            this.button3.Text = "Hora api";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Paises
            // 
            this.Paises.AutoCompleteCustomSource.AddRange(new string[] {
            "Africa/Abidjan",
            "Africa/Algiers",
            "Africa/Bissau",
            "Africa/Cairo",
            "Africa/Casablanca",
            "Africa/Ceuta",
            "Africa/El_Aaiun",
            "Africa/Johannesburg",
            "Africa/Juba",
            "Africa/Khartoum",
            "Africa/Lagos",
            "Africa/Maputo",
            "Africa/Monrovia",
            "Africa/Nairobi",
            "Africa/Ndjamena",
            "Africa/Sao_Tome",
            "Africa/Tripoli",
            "Africa/Tunis",
            "Africa/Windhoek",
            "America/Adak",
            "America/Anchorage",
            "America/Araguaina",
            "America/Argentina/Buenos_Aires",
            "America/Argentina/Catamarca",
            "America/Argentina/Cordoba",
            "America/Argentina/Jujuy",
            "America/Argentina/La_Rioja",
            "America/Argentina/Mendoza",
            "America/Argentina/Rio_Gallegos",
            "America/Argentina/Salta",
            "America/Argentina/San_Juan",
            "America/Argentina/San_Luis",
            "America/Argentina/Tucuman",
            "America/Argentina/Ushuaia",
            "America/Asuncion",
            "America/Bahia",
            "America/Bahia_Banderas",
            "America/Barbados",
            "America/Belem",
            "America/Belize",
            "America/Boa_Vista",
            "America/Bogota",
            "America/Boise",
            "America/Cambridge_Bay",
            "America/Campo_Grande",
            "America/Cancun",
            "America/Caracas",
            "America/Cayenne",
            "America/Chicago",
            "America/Chihuahua",
            "America/Ciudad_Juarez",
            "America/Costa_Rica",
            "America/Cuiaba",
            "America/Danmarkshavn",
            "America/Dawson",
            "America/Dawson_Creek",
            "America/Denver",
            "America/Detroit",
            "America/Edmonton",
            "America/Eirunepe",
            "America/El_Salvador",
            "America/Fort_Nelson",
            "America/Fortaleza",
            "America/Glace_Bay",
            "America/Goose_Bay",
            "America/Grand_Turk",
            "America/Guatemala",
            "America/Guayaquil",
            "America/Guyana",
            "America/Halifax",
            "America/Havana",
            "America/Hermosillo",
            "America/Indiana/Indianapolis",
            "America/Indiana/Knox",
            "America/Indiana/Marengo",
            "America/Indiana/Petersburg",
            "America/Indiana/Tell_City",
            "America/Indiana/Vevay",
            "America/Indiana/Vincennes",
            "America/Indiana/Winamac",
            "America/Inuvik",
            "America/Iqaluit",
            "America/Jamaica",
            "America/Juneau",
            "America/Kentucky/Louisville",
            "America/Kentucky/Monticello",
            "America/La_Paz",
            "America/Lima",
            "America/Los_Angeles",
            "America/Maceio",
            "America/Managua",
            "America/Manaus",
            "America/Martinique",
            "America/Matamoros",
            "America/Mazatlan",
            "America/Menominee",
            "America/Merida",
            "America/Metlakatla",
            "America/Mexico_City",
            "America/Miquelon",
            "America/Moncton",
            "America/Monterrey",
            "America/Montevideo",
            "America/New_York",
            "America/Nome",
            "America/Noronha",
            "America/North_Dakota/Beulah",
            "America/North_Dakota/Center",
            "America/North_Dakota/New_Salem",
            "America/Nuuk",
            "America/Ojinaga",
            "America/Panama",
            "America/Paramaribo",
            "America/Phoenix",
            "America/Port-au-Prince",
            "America/Porto_Velho",
            "America/Puerto_Rico",
            "America/Punta_Arenas",
            "America/Rankin_Inlet",
            "America/Recife",
            "America/Regina",
            "America/Resolute",
            "America/Rio_Branco",
            "America/Santarem",
            "America/Santiago",
            "America/Santo_Domingo",
            "America/Sao_Paulo",
            "America/Scoresbysund",
            "America/Sitka",
            "America/St_Johns",
            "America/Swift_Current",
            "America/Tegucigalpa",
            "America/Thule",
            "America/Tijuana",
            "America/Toronto",
            "America/Vancouver",
            "America/Whitehorse",
            "America/Winnipeg",
            "America/Yakutat",
            "Antarctica/Casey",
            "Antarctica/Davis",
            "Antarctica/Macquarie",
            "Antarctica/Mawson",
            "Antarctica/Palmer",
            "Antarctica/Rothera",
            "Antarctica/Troll",
            "Asia/Almaty",
            "Asia/Amman",
            "Asia/Anadyr",
            "Asia/Aqtau",
            "Asia/Aqtobe",
            "Asia/Ashgabat",
            "Asia/Atyrau",
            "Asia/Baghdad",
            "Asia/Baku",
            "Asia/Bangkok",
            "Asia/Barnaul",
            "Asia/Beirut",
            "Asia/Bishkek",
            "Asia/Chita",
            "Asia/Choibalsan",
            "Asia/Colombo",
            "Asia/Damascus",
            "Asia/Dhaka",
            "Asia/Dili",
            "Asia/Dubai",
            "Asia/Dushanbe",
            "Asia/Famagusta",
            "Asia/Gaza",
            "Asia/Hebron",
            "Asia/Ho_Chi_Minh",
            "Asia/Hong_Kong",
            "Asia/Hovd",
            "Asia/Irkutsk",
            "Asia/Jakarta",
            "Asia/Jayapura",
            "Asia/Jerusalem",
            "Asia/Kabul",
            "Asia/Kamchatka",
            "Asia/Karachi",
            "Asia/Kathmandu",
            "Asia/Khandyga",
            "Asia/Kolkata",
            "Asia/Krasnoyarsk",
            "Asia/Kuching",
            "Asia/Macau",
            "Asia/Magadan",
            "Asia/Makassar",
            "Asia/Manila",
            "Asia/Nicosia",
            "Asia/Novokuznetsk",
            "Asia/Novosibirsk",
            "Asia/Omsk",
            "Asia/Oral",
            "Asia/Pontianak",
            "Asia/Pyongyang",
            "Asia/Qatar",
            "Asia/Qostanay",
            "Asia/Qyzylorda",
            "Asia/Riyadh",
            "Asia/Sakhalin",
            "Asia/Samarkand",
            "Asia/Seoul",
            "Asia/Shanghai",
            "Asia/Singapore",
            "Asia/Srednekolymsk",
            "Asia/Taipei",
            "Asia/Tashkent",
            "Asia/Tbilisi",
            "Asia/Tehran",
            "Asia/Thimphu",
            "Asia/Tokyo",
            "Asia/Tomsk",
            "Asia/Ulaanbaatar",
            "Asia/Urumqi",
            "Asia/Ust-Nera",
            "Asia/Vladivostok",
            "Asia/Yakutsk",
            "Asia/Yangon",
            "Asia/Yekaterinburg",
            "Asia/Yerevan",
            "Atlantic/Azores",
            "Atlantic/Bermuda",
            "Atlantic/Canary",
            "Atlantic/Cape_Verde",
            "Atlantic/Faroe",
            "Atlantic/Madeira",
            "Atlantic/South_Georgia",
            "Atlantic/Stanley",
            "Australia/Adelaide",
            "Australia/Brisbane",
            "Australia/Broken_Hill",
            "Australia/Darwin",
            "Australia/Eucla",
            "Australia/Hobart",
            "Australia/Lindeman",
            "Australia/Lord_Howe",
            "Australia/Melbourne",
            "Australia/Perth",
            "Australia/Sydney",
            "CET",
            "CST6CDT",
            "EET",
            "EST",
            "EST5EDT",
            "Etc/GMT",
            "Etc/GMT+1",
            "Etc/GMT+10",
            "Etc/GMT+11",
            "Etc/GMT+12",
            "Etc/GMT+2",
            "Etc/GMT+3",
            "Etc/GMT+4",
            "Etc/GMT+5",
            "Etc/GMT+6",
            "Etc/GMT+7",
            "Etc/GMT+8",
            "Etc/GMT+9",
            "Etc/GMT-1",
            "Etc/GMT-10",
            "Etc/GMT-11",
            "Etc/GMT-12",
            "Etc/GMT-13",
            "Etc/GMT-14",
            "Etc/GMT-2",
            "Etc/GMT-3",
            "Etc/GMT-4",
            "Etc/GMT-5",
            "Etc/GMT-6",
            "Etc/GMT-7",
            "Etc/GMT-8",
            "Etc/GMT-9",
            "Etc/UTC",
            "Europe/Andorra",
            "Europe/Astrakhan",
            "Europe/Athens",
            "Europe/Belgrade",
            "Europe/Berlin",
            "Europe/Brussels",
            "Europe/Bucharest",
            "Europe/Budapest",
            "Europe/Chisinau",
            "Europe/Dublin",
            "Europe/Gibraltar",
            "Europe/Helsinki",
            "Europe/Istanbul",
            "Europe/Kaliningrad",
            "Europe/Kirov",
            "Europe/Kyiv",
            "Europe/Lisbon",
            "Europe/London",
            "Europe/Madrid",
            "Europe/Malta",
            "Europe/Minsk",
            "Europe/Moscow",
            "Europe/Paris",
            "Europe/Prague",
            "Europe/Riga",
            "Europe/Rome",
            "Europe/Samara",
            "Europe/Saratov",
            "Europe/Simferopol",
            "Europe/Sofia",
            "Europe/Tallinn",
            "Europe/Tirane",
            "Europe/Ulyanovsk",
            "Europe/Vienna",
            "Europe/Vilnius",
            "Europe/Volgograd",
            "Europe/Warsaw",
            "Europe/Zurich",
            "HST",
            "Indian/Chagos",
            "Indian/Maldives",
            "Indian/Mauritius",
            "MET",
            "MST",
            "MST7MDT",
            "PST8PDT",
            "Pacific/Apia",
            "Pacific/Auckland",
            "Pacific/Bougainville",
            "Pacific/Chatham",
            "Pacific/Easter",
            "Pacific/Efate",
            "Pacific/Fakaofo",
            "Pacific/Fiji",
            "Pacific/Galapagos",
            "Pacific/Gambier",
            "Pacific/Guadalcanal",
            "Pacific/Guam",
            "Pacific/Honolulu",
            "Pacific/Kanton",
            "Pacific/Kiritimati",
            "Pacific/Kosrae",
            "Pacific/Kwajalein",
            "Pacific/Marquesas",
            "Pacific/Nauru",
            "Pacific/Niue",
            "Pacific/Norfolk",
            "Pacific/Noumea",
            "Pacific/Pago_Pago",
            "Pacific/Palau",
            "Pacific/Pitcairn",
            "Pacific/Port_Moresby",
            "Pacific/Rarotonga",
            "Pacific/Tahiti",
            "Pacific/Tarawa",
            "Pacific/Tongatapu",
            "WET"});
            this.Paises.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Paises.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Paises.FormattingEnabled = true;
            this.Paises.Items.AddRange(new object[] {
            "Africa/Abidjan",
            "Africa/Algiers",
            "Africa/Bissau",
            "Africa/Cairo",
            "Africa/Casablanca",
            "Africa/Ceuta",
            "Africa/El_Aaiun",
            "Africa/Johannesburg",
            "Africa/Juba",
            "Africa/Khartoum",
            "Africa/Lagos",
            "Africa/Maputo",
            "Africa/Monrovia",
            "Africa/Nairobi",
            "Africa/Ndjamena",
            "Africa/Sao_Tome",
            "Africa/Tripoli",
            "Africa/Tunis",
            "Africa/Windhoek",
            "America/Adak",
            "America/Anchorage",
            "America/Araguaina",
            "America/Argentina/Buenos_Aires",
            "America/Argentina/Catamarca",
            "America/Argentina/Cordoba",
            "America/Argentina/Jujuy",
            "America/Argentina/La_Rioja",
            "America/Argentina/Mendoza",
            "America/Argentina/Rio_Gallegos",
            "America/Argentina/Salta",
            "America/Argentina/San_Juan",
            "America/Argentina/San_Luis",
            "America/Argentina/Tucuman",
            "America/Argentina/Ushuaia",
            "America/Asuncion",
            "America/Bahia",
            "America/Bahia_Banderas",
            "America/Barbados",
            "America/Belem",
            "America/Belize",
            "America/Boa_Vista",
            "America/Bogota",
            "America/Boise",
            "America/Cambridge_Bay",
            "America/Campo_Grande",
            "America/Cancun",
            "America/Caracas",
            "America/Cayenne",
            "America/Chicago",
            "America/Chihuahua",
            "America/Ciudad_Juarez",
            "America/Costa_Rica",
            "America/Cuiaba",
            "America/Danmarkshavn",
            "America/Dawson",
            "America/Dawson_Creek",
            "America/Denver",
            "America/Detroit",
            "America/Edmonton",
            "America/Eirunepe",
            "America/El_Salvador",
            "America/Fort_Nelson",
            "America/Fortaleza",
            "America/Glace_Bay",
            "America/Goose_Bay",
            "America/Grand_Turk",
            "America/Guatemala",
            "America/Guayaquil",
            "America/Guyana",
            "America/Halifax",
            "America/Havana",
            "America/Hermosillo",
            "America/Indiana/Indianapolis",
            "America/Indiana/Knox",
            "America/Indiana/Marengo",
            "America/Indiana/Petersburg",
            "America/Indiana/Tell_City",
            "America/Indiana/Vevay",
            "America/Indiana/Vincennes",
            "America/Indiana/Winamac",
            "America/Inuvik",
            "America/Iqaluit",
            "America/Jamaica",
            "America/Juneau",
            "America/Kentucky/Louisville",
            "America/Kentucky/Monticello",
            "America/La_Paz",
            "America/Lima",
            "America/Los_Angeles",
            "America/Maceio",
            "America/Managua",
            "America/Manaus",
            "America/Martinique",
            "America/Matamoros",
            "America/Mazatlan",
            "America/Menominee",
            "America/Merida",
            "America/Metlakatla",
            "America/Mexico_City",
            "America/Miquelon",
            "America/Moncton",
            "America/Monterrey",
            "America/Montevideo",
            "America/New_York",
            "America/Nome",
            "America/Noronha",
            "America/North_Dakota/Beulah",
            "America/North_Dakota/Center",
            "America/North_Dakota/New_Salem",
            "America/Nuuk",
            "America/Ojinaga",
            "America/Panama",
            "America/Paramaribo",
            "America/Phoenix",
            "America/Port-au-Prince",
            "America/Porto_Velho",
            "America/Puerto_Rico",
            "America/Punta_Arenas",
            "America/Rankin_Inlet",
            "America/Recife",
            "America/Regina",
            "America/Resolute",
            "America/Rio_Branco",
            "America/Santarem",
            "America/Santiago",
            "America/Santo_Domingo",
            "America/Sao_Paulo",
            "America/Scoresbysund",
            "America/Sitka",
            "America/St_Johns",
            "America/Swift_Current",
            "America/Tegucigalpa",
            "America/Thule",
            "America/Tijuana",
            "America/Toronto",
            "America/Vancouver",
            "America/Whitehorse",
            "America/Winnipeg",
            "America/Yakutat",
            "Antarctica/Casey",
            "Antarctica/Davis",
            "Antarctica/Macquarie",
            "Antarctica/Mawson",
            "Antarctica/Palmer",
            "Antarctica/Rothera",
            "Antarctica/Troll",
            "Asia/Almaty",
            "Asia/Amman",
            "Asia/Anadyr",
            "Asia/Aqtau",
            "Asia/Aqtobe",
            "Asia/Ashgabat",
            "Asia/Atyrau",
            "Asia/Baghdad",
            "Asia/Baku",
            "Asia/Bangkok",
            "Asia/Barnaul",
            "Asia/Beirut",
            "Asia/Bishkek",
            "Asia/Chita",
            "Asia/Choibalsan",
            "Asia/Colombo",
            "Asia/Damascus",
            "Asia/Dhaka",
            "Asia/Dili",
            "Asia/Dubai",
            "Asia/Dushanbe",
            "Asia/Famagusta",
            "Asia/Gaza",
            "Asia/Hebron",
            "Asia/Ho_Chi_Minh",
            "Asia/Hong_Kong",
            "Asia/Hovd",
            "Asia/Irkutsk",
            "Asia/Jakarta",
            "Asia/Jayapura",
            "Asia/Jerusalem",
            "Asia/Kabul",
            "Asia/Kamchatka",
            "Asia/Karachi",
            "Asia/Kathmandu",
            "Asia/Khandyga",
            "Asia/Kolkata",
            "Asia/Krasnoyarsk",
            "Asia/Kuching",
            "Asia/Macau",
            "Asia/Magadan",
            "Asia/Makassar",
            "Asia/Manila",
            "Asia/Nicosia",
            "Asia/Novokuznetsk",
            "Asia/Novosibirsk",
            "Asia/Omsk",
            "Asia/Oral",
            "Asia/Pontianak",
            "Asia/Pyongyang",
            "Asia/Qatar",
            "Asia/Qostanay",
            "Asia/Qyzylorda",
            "Asia/Riyadh",
            "Asia/Sakhalin",
            "Asia/Samarkand",
            "Asia/Seoul",
            "Asia/Shanghai",
            "Asia/Singapore",
            "Asia/Srednekolymsk",
            "Asia/Taipei",
            "Asia/Tashkent",
            "Asia/Tbilisi",
            "Asia/Tehran",
            "Asia/Thimphu",
            "Asia/Tokyo",
            "Asia/Tomsk",
            "Asia/Ulaanbaatar",
            "Asia/Urumqi",
            "Asia/Ust-Nera",
            "Asia/Vladivostok",
            "Asia/Yakutsk",
            "Asia/Yangon",
            "Asia/Yekaterinburg",
            "Asia/Yerevan",
            "Atlantic/Azores",
            "Atlantic/Bermuda",
            "Atlantic/Canary",
            "Atlantic/Cape_Verde",
            "Atlantic/Faroe",
            "Atlantic/Madeira",
            "Atlantic/South_Georgia",
            "Atlantic/Stanley",
            "Australia/Adelaide",
            "Australia/Brisbane",
            "Australia/Broken_Hill",
            "Australia/Darwin",
            "Australia/Eucla",
            "Australia/Hobart",
            "Australia/Lindeman",
            "Australia/Lord_Howe",
            "Australia/Melbourne",
            "Australia/Perth",
            "Australia/Sydney",
            "CET",
            "CST6CDT",
            "EET",
            "EST",
            "EST5EDT",
            "Etc/GMT",
            "Etc/GMT+1",
            "Etc/GMT+10",
            "Etc/GMT+11",
            "Etc/GMT+12",
            "Etc/GMT+2",
            "Etc/GMT+3",
            "Etc/GMT+4",
            "Etc/GMT+5",
            "Etc/GMT+6",
            "Etc/GMT+7",
            "Etc/GMT+8",
            "Etc/GMT+9",
            "Etc/GMT-1",
            "Etc/GMT-10",
            "Etc/GMT-11",
            "Etc/GMT-12",
            "Etc/GMT-13",
            "Etc/GMT-14",
            "Etc/GMT-2",
            "Etc/GMT-3",
            "Etc/GMT-4",
            "Etc/GMT-5",
            "Etc/GMT-6",
            "Etc/GMT-7",
            "Etc/GMT-8",
            "Etc/GMT-9",
            "Etc/UTC",
            "Europe/Andorra",
            "Europe/Astrakhan",
            "Europe/Athens",
            "Europe/Belgrade",
            "Europe/Berlin",
            "Europe/Brussels",
            "Europe/Bucharest",
            "Europe/Budapest",
            "Europe/Chisinau",
            "Europe/Dublin",
            "Europe/Gibraltar",
            "Europe/Helsinki",
            "Europe/Istanbul",
            "Europe/Kaliningrad",
            "Europe/Kirov",
            "Europe/Kyiv",
            "Europe/Lisbon",
            "Europe/London",
            "Europe/Madrid",
            "Europe/Malta",
            "Europe/Minsk",
            "Europe/Moscow",
            "Europe/Paris",
            "Europe/Prague",
            "Europe/Riga",
            "Europe/Rome",
            "Europe/Samara",
            "Europe/Saratov",
            "Europe/Simferopol",
            "Europe/Sofia",
            "Europe/Tallinn",
            "Europe/Tirane",
            "Europe/Ulyanovsk",
            "Europe/Vienna",
            "Europe/Vilnius",
            "Europe/Volgograd",
            "Europe/Warsaw",
            "Europe/Zurich",
            "HST",
            "Indian/Chagos",
            "Indian/Maldives",
            "Indian/Mauritius",
            "MET",
            "MST",
            "MST7MDT",
            "PST8PDT",
            "Pacific/Apia",
            "Pacific/Auckland",
            "Pacific/Bougainville",
            "Pacific/Chatham",
            "Pacific/Easter",
            "Pacific/Efate",
            "Pacific/Fakaofo",
            "Pacific/Fiji",
            "Pacific/Galapagos",
            "Pacific/Gambier",
            "Pacific/Guadalcanal",
            "Pacific/Guam",
            "Pacific/Honolulu",
            "Pacific/Kanton",
            "Pacific/Kiritimati",
            "Pacific/Kosrae",
            "Pacific/Kwajalein",
            "Pacific/Marquesas",
            "Pacific/Nauru",
            "Pacific/Niue",
            "Pacific/Norfolk",
            "Pacific/Noumea",
            "Pacific/Pago_Pago",
            "Pacific/Palau",
            "Pacific/Pitcairn",
            "Pacific/Port_Moresby",
            "Pacific/Rarotonga",
            "Pacific/Tahiti",
            "Pacific/Tarawa",
            "Pacific/Tongatapu",
            "WET"});
            this.Paises.Location = new System.Drawing.Point(18, 61);
            this.Paises.Name = "Paises";
            this.Paises.Size = new System.Drawing.Size(155, 21);
            this.Paises.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.Dolares);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.Resultado);
            this.panel3.Controls.Add(this.TipoCambio);
            this.panel3.Location = new System.Drawing.Point(588, 240);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 191);
            this.panel3.TabIndex = 4;
            // 
            // TipoCambio
            // 
            this.TipoCambio.FormattingEnabled = true;
            this.TipoCambio.Items.AddRange(new object[] {
            "AUD",
            "BGN",
            "BRL",
            "CAD",
            "CHF",
            "CNY",
            "CZK",
            "DKK",
            "EUR",
            "GBP",
            "HUF",
            "IDR",
            "ILS",
            "INR",
            "ISK",
            "JPY",
            "KRW",
            "MXN",
            "MYR",
            "NOK",
            "NZD",
            "PHP",
            "PLN",
            "RON",
            "SEK",
            "SGD",
            "THB ",
            "TRY",
            "USD",
            "ZARl"});
            this.TipoCambio.Location = new System.Drawing.Point(52, 108);
            this.TipoCambio.Name = "TipoCambio";
            this.TipoCambio.Size = new System.Drawing.Size(138, 21);
            this.TipoCambio.TabIndex = 0;
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(257, 109);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(152, 20);
            this.Resultado.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(82, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Convertidor de monedas";
            // 
            // Dolares
            // 
            this.Dolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Dolares.Location = new System.Drawing.Point(52, 60);
            this.Dolares.Name = "Dolares";
            this.Dolares.Size = new System.Drawing.Size(138, 23);
            this.Dolares.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cantidad en dolares";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Resultado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Elegir tipo de cambio";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(182, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Convertir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Cedula;
        private System.Windows.Forms.Button Imprimir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Edad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoraActual;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox Paises;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Dolares;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.ComboBox TipoCambio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
    }
}

