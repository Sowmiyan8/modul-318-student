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
            this.abfahrt = new System.Windows.Forms.Button();
            this.ankunft = new System.Windows.Forms.Button();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.suchen = new System.Windows.Forms.Button();
            this.vs = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.verbindungen = new System.Windows.Forms.ListBox();
            this.minuten = new System.Windows.Forms.NumericUpDown();
            this.stunden = new System.Windows.Forms.NumericUpDown();
            this.wechsel = new System.Windows.Forms.PictureBox();
            this.standort = new System.Windows.Forms.ComboBox();
            this.zielort = new System.Windows.Forms.ComboBox();
            this.stationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stationsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.minuten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stunden)).BeginInit();
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
            // abfahrt
            // 
            this.abfahrt.Location = new System.Drawing.Point(60, 118);
            this.abfahrt.Name = "abfahrt";
            this.abfahrt.Size = new System.Drawing.Size(38, 23);
            this.abfahrt.TabIndex = 2;
            this.abfahrt.Text = "AB";
            this.abfahrt.UseVisualStyleBackColor = true;
            // 
            // ankunft
            // 
            this.ankunft.Location = new System.Drawing.Point(25, 118);
            this.ankunft.Name = "ankunft";
            this.ankunft.Size = new System.Drawing.Size(38, 23);
            this.ankunft.TabIndex = 2;
            this.ankunft.Text = "AN";
            this.ankunft.UseVisualStyleBackColor = true;
            // 
            // datum
            // 
            this.datum.Location = new System.Drawing.Point(104, 121);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(179, 20);
            this.datum.TabIndex = 3;
            // 
            // suchen
            // 
            this.suchen.Location = new System.Drawing.Point(421, 118);
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
            this.vs.Location = new System.Drawing.Point(23, 162);
            this.vs.Name = "vs";
            this.vs.Size = new System.Drawing.Size(73, 13);
            this.vs.TabIndex = 6;
            this.vs.Text = "Verbindungen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = ":";
            // 
            // verbindungen
            // 
            this.verbindungen.FormattingEnabled = true;
            this.verbindungen.Location = new System.Drawing.Point(25, 188);
            this.verbindungen.Name = "verbindungen";
            this.verbindungen.Size = new System.Drawing.Size(529, 420);
            this.verbindungen.TabIndex = 8;
            // 
            // minuten
            // 
            this.minuten.Location = new System.Drawing.Point(357, 121);
            this.minuten.Name = "minuten";
            this.minuten.Size = new System.Drawing.Size(46, 20);
            this.minuten.TabIndex = 9;
            // 
            // stunden
            // 
            this.stunden.Location = new System.Drawing.Point(289, 121);
            this.stunden.Name = "stunden";
            this.stunden.Size = new System.Drawing.Size(46, 20);
            this.stunden.TabIndex = 9;
            // 
            // wechsel
            // 
            this.wechsel.Image = ((System.Drawing.Image)(resources.GetObject("wechsel.Image")));
            this.wechsel.Location = new System.Drawing.Point(502, 46);
            this.wechsel.Name = "wechsel";
            this.wechsel.Size = new System.Drawing.Size(56, 56);
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
            this.standort.SelectedIndexChanged += new System.EventHandler(this.standort_SelectedIndexChanged);
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
            this.ClientSize = new System.Drawing.Size(1261, 681);
            this.Controls.Add(this.zielort);
            this.Controls.Add(this.standort);
            this.Controls.Add(this.stunden);
            this.Controls.Add(this.minuten);
            this.Controls.Add(this.verbindungen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vs);
            this.Controls.Add(this.suchen);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.ankunft);
            this.Controls.Add(this.abfahrt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wechsel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fahrplan";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Fahrplan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minuten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stunden)).EndInit();
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
        private System.Windows.Forms.Button abfahrt;
        private System.Windows.Forms.Button ankunft;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.Button suchen;
        private System.Windows.Forms.Label vs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox verbindungen;
        private System.Windows.Forms.NumericUpDown minuten;
        private System.Windows.Forms.NumericUpDown stunden;
        private System.Windows.Forms.PictureBox wechsel;
        private System.Windows.Forms.ComboBox standort;
        private System.Windows.Forms.ComboBox zielort;
        private System.Windows.Forms.BindingSource stationsBindingSource;
        private System.Windows.Forms.BindingSource stationsBindingSource1;
        private System.Windows.Forms.BindingSource stationsBindingSource2;
        private System.Windows.Forms.BindingSource stationBindingSource;
    }
}

