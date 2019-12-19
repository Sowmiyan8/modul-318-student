namespace WindowsFormsApp1
{
    partial class Fahrplan
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fahrplan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.suchen = new System.Windows.Forms.Button();
            this.vs = new System.Windows.Forms.Label();
            this.wechsel = new System.Windows.Forms.PictureBox();
            this.standort = new System.Windows.Forms.ComboBox();
            this.zielort = new System.Windows.Forms.ComboBox();
            this.verbindungen = new System.Windows.Forms.ListView();
            this.time = new System.Windows.Forms.TextBox();
            this.map2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.abfahrten = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.stationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stationsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wechsel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zielort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Startort";
            // 
            // datum
            // 
            this.datum.Location = new System.Drawing.Point(25, 120);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(179, 20);
            this.datum.TabIndex = 3;
            // 
            // suchen
            // 
            this.suchen.Location = new System.Drawing.Point(295, 117);
            this.suchen.Name = "suchen";
            this.suchen.Size = new System.Drawing.Size(75, 23);
            this.suchen.TabIndex = 4;
            this.suchen.Text = "Suchen";
            this.suchen.UseVisualStyleBackColor = true;
            this.suchen.Click += new System.EventHandler(this.suchen_Click);
            // 
            // vs
            // 
            this.vs.AutoSize = true;
            this.vs.Location = new System.Drawing.Point(22, 181);
            this.vs.Name = "vs";
            this.vs.Size = new System.Drawing.Size(73, 13);
            this.vs.TabIndex = 6;
            this.vs.Text = "Verbindungen";
            // 
            // wechsel
            // 
            this.wechsel.Image = ((System.Drawing.Image)(resources.GetObject("wechsel.Image")));
            this.wechsel.Location = new System.Drawing.Point(491, 46);
            this.wechsel.Name = "wechsel";
            this.wechsel.Size = new System.Drawing.Size(49, 56);
            this.wechsel.TabIndex = 10;
            this.wechsel.TabStop = false;
            this.wechsel.Click += new System.EventHandler(this.wechsel_Click);
            // 
            // standort
            // 
            this.standort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.standort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.standort.FormattingEnabled = true;
            this.standort.Location = new System.Drawing.Point(25, 33);
            this.standort.Name = "standort";
            this.standort.Size = new System.Drawing.Size(471, 21);
            this.standort.TabIndex = 12;

            this.standort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.standort_KeyPress);
            // 
            // zielort
            // 
            this.zielort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.zielort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.zielort.FormattingEnabled = true;
            this.zielort.Location = new System.Drawing.Point(25, 81);
            this.zielort.Name = "zielort";
            this.zielort.Size = new System.Drawing.Size(471, 21);
            this.zielort.TabIndex = 12;

            this.zielort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.zielort_KeyDown);
            // 
            // verbindungen
            // 
            this.verbindungen.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.verbindungen.AutoArrange = false;
            this.verbindungen.FullRowSelect = true;
            this.verbindungen.HideSelection = false;
            this.verbindungen.Location = new System.Drawing.Point(25, 197);
            this.verbindungen.Name = "verbindungen";
            this.verbindungen.Size = new System.Drawing.Size(471, 361);
            this.verbindungen.TabIndex = 15;
            this.verbindungen.TabStop = false;
            this.verbindungen.UseCompatibleStateImageBehavior = false;
            this.verbindungen.View = System.Windows.Forms.View.Details;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(201, 120);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(77, 20);
            this.time.TabIndex = 16;
            this.time.Text = "zeit SS:mm";
            // 
            // map2
            // 
            this.map2.Location = new System.Drawing.Point(440, 52);
            this.map2.Name = "map2";
            this.map2.Size = new System.Drawing.Size(56, 20);
            this.map2.TabIndex = 4;
            this.map2.Text = "Map";
            this.map2.UseVisualStyleBackColor = true;
            this.map2.Click += new System.EventHandler(this.buttonmap);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "Map";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonmap2);
            // 
            // abfahrten
            // 
            this.abfahrten.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.abfahrten.AutoArrange = false;
            this.abfahrten.FullRowSelect = true;
            this.abfahrten.HideSelection = false;
            this.abfahrten.Location = new System.Drawing.Point(560, 46);
            this.abfahrten.Name = "abfahrten";
            this.abfahrten.Size = new System.Drawing.Size(283, 509);
            this.abfahrten.TabIndex = 15;
            this.abfahrten.TabStop = false;
            this.abfahrten.UseCompatibleStateImageBehavior = false;
            this.abfahrten.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Abfahrtstabel";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(377, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 20);
            this.button2.TabIndex = 4;
            this.button2.Text = "Abfahrten";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.abfahrtbutton);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(421, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Email";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.mailbtn);
            // 
            // stationsBindingSource
            // 
            this.stationsBindingSource.DataSource = typeof(SwissTransport.Stations);
            // 
            // stationsBindingSource1
            // 
            this.stationsBindingSource1.DataSource = typeof(SwissTransport.Stations);
            // 
            // stationsBindingSource2
            // 
            this.stationsBindingSource2.DataSource = typeof(SwissTransport.Stations);
            // 
            // stationBindingSource
            // 
            this.stationBindingSource.DataSource = typeof(SwissTransport.Station);
            // 
            // Fahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 681);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.time);
            this.Controls.Add(this.abfahrten);
            this.Controls.Add(this.verbindungen);
            this.Controls.Add(this.zielort);
            this.Controls.Add(this.standort);
            this.Controls.Add(this.vs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.map2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.suchen);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wechsel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fahrplan";
            this.Text = "Fahrplan ";
            this.Load += new System.EventHandler(this.Fahrplan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wechsel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.Button suchen;
        private System.Windows.Forms.Label vs;
        private System.Windows.Forms.PictureBox wechsel;
        private System.Windows.Forms.ComboBox standort;
        private System.Windows.Forms.ComboBox zielort;
        private System.Windows.Forms.BindingSource stationsBindingSource;
        private System.Windows.Forms.BindingSource stationsBindingSource1;
        private System.Windows.Forms.BindingSource stationsBindingSource2;
        private System.Windows.Forms.BindingSource stationBindingSource;
        private System.Windows.Forms.ListView verbindungen;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Button map2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView abfahrten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

