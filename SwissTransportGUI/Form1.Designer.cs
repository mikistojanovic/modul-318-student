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
            this.lblSwissTransport = new System.Windows.Forms.Label();
            this.gbFahrplan = new System.Windows.Forms.GroupBox();
            this.txtZeit = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtZielstation = new System.Windows.Forms.TextBox();
            this.txtStartstation = new System.Windows.Forms.TextBox();
            this.lbAusgabe = new System.Windows.Forms.ListBox();
            this.lblZeit = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lbZielstation = new System.Windows.Forms.ListBox();
            this.lbStartstation = new System.Windows.Forms.ListBox();
            this.lblZielstation = new System.Windows.Forms.Label();
            this.lblStartstation = new System.Windows.Forms.Label();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.lblBeliebigeStation = new System.Windows.Forms.Label();
            this.gbAbfahrtstaffel = new System.Windows.Forms.GroupBox();
            this.txtBeliebigeStation = new System.Windows.Forms.TextBox();
            this.lbAbfahrtstaffel = new System.Windows.Forms.ListBox();
            this.btnAbfahrtstaffel = new System.Windows.Forms.Button();
            this.gbFahrplan.SuspendLayout();
            this.gbAbfahrtstaffel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSwissTransport
            // 
            this.lblSwissTransport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSwissTransport.AutoSize = true;
            this.lblSwissTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwissTransport.Location = new System.Drawing.Point(514, 9);
            this.lblSwissTransport.Name = "lblSwissTransport";
            this.lblSwissTransport.Size = new System.Drawing.Size(307, 44);
            this.lblSwissTransport.TabIndex = 1;
            this.lblSwissTransport.Text = "Swiss Transport";
            // 
            // gbFahrplan
            // 
            this.gbFahrplan.Controls.Add(this.txtZeit);
            this.gbFahrplan.Controls.Add(this.dateTimePicker1);
            this.gbFahrplan.Controls.Add(this.txtZielstation);
            this.gbFahrplan.Controls.Add(this.txtStartstation);
            this.gbFahrplan.Controls.Add(this.lbAusgabe);
            this.gbFahrplan.Controls.Add(this.lblZeit);
            this.gbFahrplan.Controls.Add(this.lblDatum);
            this.gbFahrplan.Controls.Add(this.lbZielstation);
            this.gbFahrplan.Controls.Add(this.lbStartstation);
            this.gbFahrplan.Controls.Add(this.lblZielstation);
            this.gbFahrplan.Controls.Add(this.lblStartstation);
            this.gbFahrplan.Controls.Add(this.btnSuchen);
            this.gbFahrplan.Location = new System.Drawing.Point(12, 56);
            this.gbFahrplan.Name = "gbFahrplan";
            this.gbFahrplan.Size = new System.Drawing.Size(844, 563);
            this.gbFahrplan.TabIndex = 14;
            this.gbFahrplan.TabStop = false;
            this.gbFahrplan.Text = "Fahrplan";
            // 
            // txtZeit
            // 
            this.txtZeit.Location = new System.Drawing.Point(369, 222);
            this.txtZeit.Name = "txtZeit";
            this.txtZeit.Size = new System.Drawing.Size(280, 22);
            this.txtZeit.TabIndex = 26;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 220);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(280, 22);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // txtZielstation
            // 
            this.txtZielstation.Location = new System.Drawing.Point(369, 47);
            this.txtZielstation.Name = "txtZielstation";
            this.txtZielstation.Size = new System.Drawing.Size(280, 22);
            this.txtZielstation.TabIndex = 24;
            this.txtZielstation.TextChanged += new System.EventHandler(this.txtZielstation_TextChanged);
            // 
            // txtStartstation
            // 
            this.txtStartstation.Location = new System.Drawing.Point(6, 47);
            this.txtStartstation.Name = "txtStartstation";
            this.txtStartstation.Size = new System.Drawing.Size(280, 22);
            this.txtStartstation.TabIndex = 23;
            this.txtStartstation.TextChanged += new System.EventHandler(this.txtStartstation_TextChanged);
            // 
            // lbAusgabe
            // 
            this.lbAusgabe.FormattingEnabled = true;
            this.lbAusgabe.ItemHeight = 16;
            this.lbAusgabe.Location = new System.Drawing.Point(6, 267);
            this.lbAusgabe.Name = "lbAusgabe";
            this.lbAusgabe.Size = new System.Drawing.Size(643, 276);
            this.lbAusgabe.TabIndex = 22;
            // 
            // lblZeit
            // 
            this.lblZeit.AutoSize = true;
            this.lblZeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZeit.Location = new System.Drawing.Point(366, 203);
            this.lblZeit.Name = "lblZeit";
            this.lblZeit.Size = new System.Drawing.Size(40, 20);
            this.lblZeit.TabIndex = 21;
            this.lblZeit.Text = "Zeit";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(3, 200);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(64, 20);
            this.lblDatum.TabIndex = 19;
            this.lblDatum.Text = "Datum";
            // 
            // lbZielstation
            // 
            this.lbZielstation.FormattingEnabled = true;
            this.lbZielstation.ItemHeight = 16;
            this.lbZielstation.Location = new System.Drawing.Point(369, 72);
            this.lbZielstation.Name = "lbZielstation";
            this.lbZielstation.Size = new System.Drawing.Size(280, 100);
            this.lbZielstation.TabIndex = 18;
            // 
            // lbStartstation
            // 
            this.lbStartstation.FormattingEnabled = true;
            this.lbStartstation.ItemHeight = 16;
            this.lbStartstation.Location = new System.Drawing.Point(6, 72);
            this.lbStartstation.Name = "lbStartstation";
            this.lbStartstation.Size = new System.Drawing.Size(280, 100);
            this.lbStartstation.TabIndex = 17;
            // 
            // lblZielstation
            // 
            this.lblZielstation.AutoSize = true;
            this.lblZielstation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZielstation.Location = new System.Drawing.Point(365, 24);
            this.lblZielstation.Name = "lblZielstation";
            this.lblZielstation.Size = new System.Drawing.Size(96, 20);
            this.lblZielstation.TabIndex = 16;
            this.lblZielstation.Text = "Zielstation";
            // 
            // lblStartstation
            // 
            this.lblStartstation.AutoSize = true;
            this.lblStartstation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartstation.Location = new System.Drawing.Point(2, 24);
            this.lblStartstation.Name = "lblStartstation";
            this.lblStartstation.Size = new System.Drawing.Size(107, 20);
            this.lblStartstation.TabIndex = 15;
            this.lblStartstation.Text = "Startstation";
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(672, 80);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(153, 56);
            this.btnSuchen.TabIndex = 14;
            this.btnSuchen.Text = "Suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            // 
            // lblBeliebigeStation
            // 
            this.lblBeliebigeStation.AutoSize = true;
            this.lblBeliebigeStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeliebigeStation.Location = new System.Drawing.Point(120, 21);
            this.lblBeliebigeStation.Name = "lblBeliebigeStation";
            this.lblBeliebigeStation.Size = new System.Drawing.Size(152, 20);
            this.lblBeliebigeStation.TabIndex = 20;
            this.lblBeliebigeStation.Text = "Beliebige Station";
            // 
            // gbAbfahrtstaffel
            // 
            this.gbAbfahrtstaffel.Controls.Add(this.txtBeliebigeStation);
            this.gbAbfahrtstaffel.Controls.Add(this.lbAbfahrtstaffel);
            this.gbAbfahrtstaffel.Controls.Add(this.btnAbfahrtstaffel);
            this.gbAbfahrtstaffel.Controls.Add(this.lblBeliebigeStation);
            this.gbAbfahrtstaffel.Location = new System.Drawing.Point(867, 56);
            this.gbAbfahrtstaffel.Name = "gbAbfahrtstaffel";
            this.gbAbfahrtstaffel.Size = new System.Drawing.Size(377, 562);
            this.gbAbfahrtstaffel.TabIndex = 21;
            this.gbAbfahrtstaffel.TabStop = false;
            this.gbAbfahrtstaffel.Text = "Abfahrtstaffel";
            // 
            // txtBeliebigeStation
            // 
            this.txtBeliebigeStation.Location = new System.Drawing.Point(6, 44);
            this.txtBeliebigeStation.Name = "txtBeliebigeStation";
            this.txtBeliebigeStation.Size = new System.Drawing.Size(365, 22);
            this.txtBeliebigeStation.TabIndex = 23;
            // 
            // lbAbfahrtstaffel
            // 
            this.lbAbfahrtstaffel.FormattingEnabled = true;
            this.lbAbfahrtstaffel.ItemHeight = 16;
            this.lbAbfahrtstaffel.Location = new System.Drawing.Point(6, 139);
            this.lbAbfahrtstaffel.Name = "lbAbfahrtstaffel";
            this.lbAbfahrtstaffel.Size = new System.Drawing.Size(365, 404);
            this.lbAbfahrtstaffel.TabIndex = 22;
            // 
            // btnAbfahrtstaffel
            // 
            this.btnAbfahrtstaffel.Location = new System.Drawing.Point(124, 80);
            this.btnAbfahrtstaffel.Name = "btnAbfahrtstaffel";
            this.btnAbfahrtstaffel.Size = new System.Drawing.Size(148, 53);
            this.btnAbfahrtstaffel.TabIndex = 21;
            this.btnAbfahrtstaffel.Text = "Abfahrtstaffel anzeigen";
            this.btnAbfahrtstaffel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 631);
            this.Controls.Add(this.gbAbfahrtstaffel);
            this.Controls.Add(this.gbFahrplan);
            this.Controls.Add(this.lblSwissTransport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbFahrplan.ResumeLayout(false);
            this.gbFahrplan.PerformLayout();
            this.gbAbfahrtstaffel.ResumeLayout(false);
            this.gbAbfahrtstaffel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSwissTransport;
        private System.Windows.Forms.GroupBox gbFahrplan;
        private System.Windows.Forms.TextBox txtZeit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtZielstation;
        private System.Windows.Forms.TextBox txtStartstation;
        private System.Windows.Forms.ListBox lbAusgabe;
        private System.Windows.Forms.Label lblZeit;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.ListBox lbZielstation;
        private System.Windows.Forms.ListBox lbStartstation;
        private System.Windows.Forms.Label lblZielstation;
        private System.Windows.Forms.Label lblStartstation;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.Label lblBeliebigeStation;
        private System.Windows.Forms.GroupBox gbAbfahrtstaffel;
        private System.Windows.Forms.TextBox txtBeliebigeStation;
        private System.Windows.Forms.ListBox lbAbfahrtstaffel;
        private System.Windows.Forms.Button btnAbfahrtstaffel;
    }
}

