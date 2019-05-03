namespace SwissTransportGUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbAbfahrtstaffel = new System.Windows.Forms.GroupBox();
            this.btnStandort = new System.Windows.Forms.Button();
            this.lbBeliebigeStation = new System.Windows.Forms.ListBox();
            this.txtBeliebigeStation = new System.Windows.Forms.TextBox();
            this.lbAbfahrtstaffel = new System.Windows.Forms.ListBox();
            this.btnAbfahrtstaffel = new System.Windows.Forms.Button();
            this.lblBeliebigeStation = new System.Windows.Forms.Label();
            this.gbFahrplan = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnWechseln = new System.Windows.Forms.Button();
            this.lblSwissTransport = new System.Windows.Forms.Label();
            this.lvAusgabe = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLoeschen = new System.Windows.Forms.Button();
            this.txtZielstation = new System.Windows.Forms.TextBox();
            this.txtStartstation = new System.Windows.Forms.TextBox();
            this.lbZielstation = new System.Windows.Forms.ListBox();
            this.lbStartstation = new System.Windows.Forms.ListBox();
            this.lblZielstation = new System.Windows.Forms.Label();
            this.lblStartstation = new System.Windows.Forms.Label();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.lblZeit = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbAbfahrtstaffel.SuspendLayout();
            this.gbFahrplan.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1232, 696);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbAbfahrtstaffel);
            this.tabPage1.Controls.Add(this.gbFahrplan);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1224, 667);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fahrplan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbAbfahrtstaffel
            // 
            this.gbAbfahrtstaffel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbAbfahrtstaffel.BackColor = System.Drawing.Color.White;
            this.gbAbfahrtstaffel.Controls.Add(this.btnStandort);
            this.gbAbfahrtstaffel.Controls.Add(this.lbBeliebigeStation);
            this.gbAbfahrtstaffel.Controls.Add(this.txtBeliebigeStation);
            this.gbAbfahrtstaffel.Controls.Add(this.lbAbfahrtstaffel);
            this.gbAbfahrtstaffel.Controls.Add(this.btnAbfahrtstaffel);
            this.gbAbfahrtstaffel.Controls.Add(this.lblBeliebigeStation);
            this.gbAbfahrtstaffel.Location = new System.Drawing.Point(831, -12);
            this.gbAbfahrtstaffel.Name = "gbAbfahrtstaffel";
            this.gbAbfahrtstaffel.Size = new System.Drawing.Size(398, 683);
            this.gbAbfahrtstaffel.TabIndex = 24;
            this.gbAbfahrtstaffel.TabStop = false;
            // 
            // btnStandort
            // 
            this.btnStandort.BackColor = System.Drawing.Color.White;
            this.btnStandort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStandort.Image = ((System.Drawing.Image)(resources.GetObject("btnStandort.Image")));
            this.btnStandort.Location = new System.Drawing.Point(218, 250);
            this.btnStandort.Name = "btnStandort";
            this.btnStandort.Size = new System.Drawing.Size(75, 69);
            this.btnStandort.TabIndex = 9;
            this.btnStandort.UseVisualStyleBackColor = false;
            this.btnStandort.Click += new System.EventHandler(this.btnStandort_Click);
            // 
            // lbBeliebigeStation
            // 
            this.lbBeliebigeStation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbBeliebigeStation.FormattingEnabled = true;
            this.lbBeliebigeStation.ItemHeight = 16;
            this.lbBeliebigeStation.Location = new System.Drawing.Point(56, 132);
            this.lbBeliebigeStation.Name = "lbBeliebigeStation";
            this.lbBeliebigeStation.Size = new System.Drawing.Size(295, 100);
            this.lbBeliebigeStation.TabIndex = 24;
            this.lbBeliebigeStation.TabStop = false;
            this.lbBeliebigeStation.DoubleClick += new System.EventHandler(this.lbBeliebigestation_DoubleClick);
            // 
            // txtBeliebigeStation
            // 
            this.txtBeliebigeStation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBeliebigeStation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBeliebigeStation.Location = new System.Drawing.Point(56, 104);
            this.txtBeliebigeStation.Name = "txtBeliebigeStation";
            this.txtBeliebigeStation.Size = new System.Drawing.Size(295, 22);
            this.txtBeliebigeStation.TabIndex = 7;
            this.txtBeliebigeStation.TextChanged += new System.EventHandler(this.txtBeliebigeStation_TextChanged);
            this.txtBeliebigeStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BewegenBeliebigeStation);
            // 
            // lbAbfahrtstaffel
            // 
            this.lbAbfahrtstaffel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbAbfahrtstaffel.FormattingEnabled = true;
            this.lbAbfahrtstaffel.ItemHeight = 16;
            this.lbAbfahrtstaffel.Location = new System.Drawing.Point(33, 327);
            this.lbAbfahrtstaffel.Name = "lbAbfahrtstaffel";
            this.lbAbfahrtstaffel.Size = new System.Drawing.Size(339, 292);
            this.lbAbfahrtstaffel.TabIndex = 22;
            this.lbAbfahrtstaffel.TabStop = false;
            // 
            // btnAbfahrtstaffel
            // 
            this.btnAbfahrtstaffel.BackColor = System.Drawing.Color.White;
            this.btnAbfahrtstaffel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbfahrtstaffel.Image = ((System.Drawing.Image)(resources.GetObject("btnAbfahrtstaffel.Image")));
            this.btnAbfahrtstaffel.Location = new System.Drawing.Point(124, 250);
            this.btnAbfahrtstaffel.Name = "btnAbfahrtstaffel";
            this.btnAbfahrtstaffel.Size = new System.Drawing.Size(75, 69);
            this.btnAbfahrtstaffel.TabIndex = 8;
            this.btnAbfahrtstaffel.UseVisualStyleBackColor = false;
            this.btnAbfahrtstaffel.Click += new System.EventHandler(this.btnAbfahrtstaffel_Click);
            // 
            // lblBeliebigeStation
            // 
            this.lblBeliebigeStation.AutoSize = true;
            this.lblBeliebigeStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeliebigeStation.Location = new System.Drawing.Point(120, 74);
            this.lblBeliebigeStation.Name = "lblBeliebigeStation";
            this.lblBeliebigeStation.Size = new System.Drawing.Size(152, 20);
            this.lblBeliebigeStation.TabIndex = 20;
            this.lblBeliebigeStation.Text = "Beliebige Station";
            // 
            // gbFahrplan
            // 
            this.gbFahrplan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbFahrplan.BackColor = System.Drawing.Color.White;
            this.gbFahrplan.Controls.Add(this.lblZeit);
            this.gbFahrplan.Controls.Add(this.dateTimePicker1);
            this.gbFahrplan.Controls.Add(this.btnWechseln);
            this.gbFahrplan.Controls.Add(this.lblSwissTransport);
            this.gbFahrplan.Controls.Add(this.lvAusgabe);
            this.gbFahrplan.Controls.Add(this.btnLoeschen);
            this.gbFahrplan.Controls.Add(this.txtZielstation);
            this.gbFahrplan.Controls.Add(this.txtStartstation);
            this.gbFahrplan.Controls.Add(this.lbZielstation);
            this.gbFahrplan.Controls.Add(this.lbStartstation);
            this.gbFahrplan.Controls.Add(this.lblZielstation);
            this.gbFahrplan.Controls.Add(this.lblStartstation);
            this.gbFahrplan.Controls.Add(this.btnSuchen);
            this.gbFahrplan.Location = new System.Drawing.Point(-4, -12);
            this.gbFahrplan.Name = "gbFahrplan";
            this.gbFahrplan.Size = new System.Drawing.Size(835, 683);
            this.gbFahrplan.TabIndex = 23;
            this.gbFahrplan.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 271);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 22);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2019, 5, 3, 0, 0, 0, 0);
            // 
            // btnWechseln
            // 
            this.btnWechseln.BackColor = System.Drawing.Color.White;
            this.btnWechseln.Image = ((System.Drawing.Image)(resources.GetObject("btnWechseln.Image")));
            this.btnWechseln.Location = new System.Drawing.Point(670, 149);
            this.btnWechseln.Name = "btnWechseln";
            this.btnWechseln.Size = new System.Drawing.Size(75, 69);
            this.btnWechseln.TabIndex = 4;
            this.btnWechseln.UseVisualStyleBackColor = false;
            this.btnWechseln.Click += new System.EventHandler(this.btnWechseln_Click);
            // 
            // lblSwissTransport
            // 
            this.lblSwissTransport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSwissTransport.AutoSize = true;
            this.lblSwissTransport.BackColor = System.Drawing.Color.White;
            this.lblSwissTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwissTransport.ForeColor = System.Drawing.Color.Black;
            this.lblSwissTransport.Location = new System.Drawing.Point(24, 15);
            this.lblSwissTransport.Name = "lblSwissTransport";
            this.lblSwissTransport.Size = new System.Drawing.Size(0, 44);
            this.lblSwissTransport.TabIndex = 22;
            // 
            // lvAusgabe
            // 
            this.lvAusgabe.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lvAusgabe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvAusgabe.FullRowSelect = true;
            this.lvAusgabe.GridLines = true;
            this.lvAusgabe.Location = new System.Drawing.Point(30, 327);
            this.lvAusgabe.Name = "lvAusgabe";
            this.lvAusgabe.Size = new System.Drawing.Size(760, 294);
            this.lvAusgabe.TabIndex = 28;
            this.lvAusgabe.TabStop = false;
            this.lvAusgabe.UseCompatibleStateImageBehavior = false;
            this.lvAusgabe.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Datum";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Zeit";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Von";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nach";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Gleis";
            this.columnHeader5.Width = 101;
            // 
            // btnLoeschen
            // 
            this.btnLoeschen.BackColor = System.Drawing.Color.White;
            this.btnLoeschen.Image = ((System.Drawing.Image)(resources.GetObject("btnLoeschen.Image")));
            this.btnLoeschen.Location = new System.Drawing.Point(670, 224);
            this.btnLoeschen.Name = "btnLoeschen";
            this.btnLoeschen.Size = new System.Drawing.Size(75, 69);
            this.btnLoeschen.TabIndex = 6;
            this.btnLoeschen.UseVisualStyleBackColor = false;
            this.btnLoeschen.Click += new System.EventHandler(this.btnLoeschen_Click);
            // 
            // txtZielstation
            // 
            this.txtZielstation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtZielstation.Location = new System.Drawing.Point(371, 102);
            this.txtZielstation.Name = "txtZielstation";
            this.txtZielstation.Size = new System.Drawing.Size(252, 22);
            this.txtZielstation.TabIndex = 1;
            this.txtZielstation.TextChanged += new System.EventHandler(this.txtZielstation_TextChanged);
            this.txtZielstation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BewegenZiel);
            // 
            // txtStartstation
            // 
            this.txtStartstation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtStartstation.Location = new System.Drawing.Point(32, 102);
            this.txtStartstation.Name = "txtStartstation";
            this.txtStartstation.Size = new System.Drawing.Size(256, 22);
            this.txtStartstation.TabIndex = 0;
            this.txtStartstation.TextChanged += new System.EventHandler(this.txtStartstation_TextChanged);
            this.txtStartstation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BewegenStart);
            // 
            // lbZielstation
            // 
            this.lbZielstation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbZielstation.FormattingEnabled = true;
            this.lbZielstation.ItemHeight = 16;
            this.lbZielstation.Location = new System.Drawing.Point(371, 132);
            this.lbZielstation.Name = "lbZielstation";
            this.lbZielstation.Size = new System.Drawing.Size(252, 84);
            this.lbZielstation.TabIndex = 18;
            this.lbZielstation.TabStop = false;
            this.lbZielstation.DoubleClick += new System.EventHandler(this.lbZielstation_DoubleClick);
            // 
            // lbStartstation
            // 
            this.lbStartstation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbStartstation.FormattingEnabled = true;
            this.lbStartstation.ItemHeight = 16;
            this.lbStartstation.Location = new System.Drawing.Point(32, 132);
            this.lbStartstation.Name = "lbStartstation";
            this.lbStartstation.Size = new System.Drawing.Size(256, 84);
            this.lbStartstation.TabIndex = 17;
            this.lbStartstation.TabStop = false;
            this.lbStartstation.DoubleClick += new System.EventHandler(this.lbStartstation_DoubleClick);
            // 
            // lblZielstation
            // 
            this.lblZielstation.AutoSize = true;
            this.lblZielstation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZielstation.Location = new System.Drawing.Point(368, 74);
            this.lblZielstation.Name = "lblZielstation";
            this.lblZielstation.Size = new System.Drawing.Size(96, 20);
            this.lblZielstation.TabIndex = 16;
            this.lblZielstation.Text = "Zielstation";
            // 
            // lblStartstation
            // 
            this.lblStartstation.AutoSize = true;
            this.lblStartstation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartstation.Location = new System.Drawing.Point(28, 74);
            this.lblStartstation.Name = "lblStartstation";
            this.lblStartstation.Size = new System.Drawing.Size(107, 20);
            this.lblStartstation.TabIndex = 15;
            this.lblStartstation.Text = "Startstation";
            // 
            // btnSuchen
            // 
            this.btnSuchen.BackColor = System.Drawing.Color.White;
            this.btnSuchen.Image = ((System.Drawing.Image)(resources.GetObject("btnSuchen.Image")));
            this.btnSuchen.Location = new System.Drawing.Point(670, 74);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(75, 69);
            this.btnSuchen.TabIndex = 3;
            this.btnSuchen.UseVisualStyleBackColor = false;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1224, 667);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Google Maps";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1218, 661);
            this.webBrowser1.TabIndex = 0;
            // 
            // lblZeit
            // 
            this.lblZeit.AutoSize = true;
            this.lblZeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZeit.Location = new System.Drawing.Point(28, 248);
            this.lblZeit.Name = "lblZeit";
            this.lblZeit.Size = new System.Drawing.Size(40, 20);
            this.lblZeit.TabIndex = 30;
            this.lblZeit.Text = "Zeit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1230, 695);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SwissTransport ";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbAbfahrtstaffel.ResumeLayout(false);
            this.gbAbfahrtstaffel.PerformLayout();
            this.gbFahrplan.ResumeLayout(false);
            this.gbFahrplan.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbAbfahrtstaffel;
        private System.Windows.Forms.Button btnStandort;
        private System.Windows.Forms.ListBox lbBeliebigeStation;
        private System.Windows.Forms.TextBox txtBeliebigeStation;
        private System.Windows.Forms.ListBox lbAbfahrtstaffel;
        private System.Windows.Forms.Button btnAbfahrtstaffel;
        private System.Windows.Forms.Label lblBeliebigeStation;
        private System.Windows.Forms.GroupBox gbFahrplan;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnWechseln;
        private System.Windows.Forms.ListView lvAusgabe;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnLoeschen;
        private System.Windows.Forms.TextBox txtZielstation;
        private System.Windows.Forms.TextBox txtStartstation;
        private System.Windows.Forms.ListBox lbZielstation;
        private System.Windows.Forms.ListBox lbStartstation;
        private System.Windows.Forms.Label lblZielstation;
        private System.Windows.Forms.Label lblStartstation;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.Label lblSwissTransport;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label lblZeit;
    }
}

