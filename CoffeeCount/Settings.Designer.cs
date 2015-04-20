namespace CoffeeCount
{
    partial class Settings
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
            this._btnAbbruch = new System.Windows.Forms.Button();
            this._btnVerwenden = new System.Windows.Forms.Button();
            this._lblReset = new System.Windows.Forms.Button();
            this._lblKaffeestand = new System.Windows.Forms.Label();
            this._lblSWVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._tbxKaffeestand = new System.Windows.Forms.TextBox();
            this._tbxKosten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._btnAddKaffee = new System.Windows.Forms.Button();
            this._btnAddKosten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnAbbruch
            // 
            this._btnAbbruch.Location = new System.Drawing.Point(106, 227);
            this._btnAbbruch.Name = "_btnAbbruch";
            this._btnAbbruch.Size = new System.Drawing.Size(75, 23);
            this._btnAbbruch.TabIndex = 0;
            this._btnAbbruch.Text = "Abbruch";
            this._btnAbbruch.UseVisualStyleBackColor = true;
            this._btnAbbruch.Click += new System.EventHandler(this._btnAbbruch_Click);
            // 
            // _btnVerwenden
            // 
            this._btnVerwenden.Location = new System.Drawing.Point(12, 227);
            this._btnVerwenden.Name = "_btnVerwenden";
            this._btnVerwenden.Size = new System.Drawing.Size(75, 23);
            this._btnVerwenden.TabIndex = 1;
            this._btnVerwenden.Text = "Verwenden";
            this._btnVerwenden.UseVisualStyleBackColor = true;
            this._btnVerwenden.Click += new System.EventHandler(this._btnVerwenden_Click);
            // 
            // _lblReset
            // 
            this._lblReset.Location = new System.Drawing.Point(12, 29);
            this._lblReset.Name = "_lblReset";
            this._lblReset.Size = new System.Drawing.Size(75, 23);
            this._lblReset.TabIndex = 2;
            this._lblReset.Text = "Reset";
            this._lblReset.UseVisualStyleBackColor = true;
            this._lblReset.Click += new System.EventHandler(this._lblReset_Click);
            // 
            // _lblKaffeestand
            // 
            this._lblKaffeestand.AutoSize = true;
            this._lblKaffeestand.Location = new System.Drawing.Point(12, 13);
            this._lblKaffeestand.Name = "_lblKaffeestand";
            this._lblKaffeestand.Size = new System.Drawing.Size(64, 13);
            this._lblKaffeestand.TabIndex = 4;
            this._lblKaffeestand.Text = "Kaffeestand";
            // 
            // _lblSWVersion
            // 
            this._lblSWVersion.AutoSize = true;
            this._lblSWVersion.Location = new System.Drawing.Point(12, 194);
            this._lblSWVersion.Name = "_lblSWVersion";
            this._lblSWVersion.Size = new System.Drawing.Size(0, 13);
            this._lblSWVersion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kaffeestand";
            // 
            // _tbxKaffeestand
            // 
            this._tbxKaffeestand.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this._tbxKaffeestand.Location = new System.Drawing.Point(12, 88);
            this._tbxKaffeestand.Name = "_tbxKaffeestand";
            this._tbxKaffeestand.Size = new System.Drawing.Size(100, 20);
            this._tbxKaffeestand.TabIndex = 8;
            this._tbxKaffeestand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._tbxKaffeestand.Click += new System.EventHandler(this._tbxKaffeestand_Click);
            this._tbxKaffeestand.Leave += new System.EventHandler(this._tbxKaffeestand_Leave);
            // 
            // _tbxKosten
            // 
            this._tbxKosten.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this._tbxKosten.Location = new System.Drawing.Point(12, 146);
            this._tbxKosten.Name = "_tbxKosten";
            this._tbxKosten.Size = new System.Drawing.Size(100, 20);
            this._tbxKosten.TabIndex = 9;
            this._tbxKosten.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._tbxKosten.Click += new System.EventHandler(this._tbxKosten_Click);
            this._tbxKosten.Leave += new System.EventHandler(this._tbxKosten_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kosten pro Kaffee";
            // 
            // _btnAddKaffee
            // 
            this._btnAddKaffee.Location = new System.Drawing.Point(133, 84);
            this._btnAddKaffee.Name = "_btnAddKaffee";
            this._btnAddKaffee.Size = new System.Drawing.Size(48, 23);
            this._btnAddKaffee.TabIndex = 10;
            this._btnAddKaffee.Text = "Add";
            this._btnAddKaffee.UseVisualStyleBackColor = true;
            this._btnAddKaffee.Click += new System.EventHandler(this._btnAddKaffee_Click);
            // 
            // _btnAddKosten
            // 
            this._btnAddKosten.Location = new System.Drawing.Point(133, 146);
            this._btnAddKosten.Name = "_btnAddKosten";
            this._btnAddKosten.Size = new System.Drawing.Size(48, 23);
            this._btnAddKosten.TabIndex = 11;
            this._btnAddKosten.Text = "Add";
            this._btnAddKosten.UseVisualStyleBackColor = true;
            this._btnAddKosten.Click += new System.EventHandler(this._btnAddKosten_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 262);
            this.Controls.Add(this._btnAddKosten);
            this.Controls.Add(this._btnAddKaffee);
            this.Controls.Add(this._tbxKosten);
            this.Controls.Add(this._tbxKaffeestand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._lblSWVersion);
            this.Controls.Add(this._lblKaffeestand);
            this.Controls.Add(this._lblReset);
            this.Controls.Add(this._btnVerwenden);
            this.Controls.Add(this._btnAbbruch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnAbbruch;
        private System.Windows.Forms.Button _btnVerwenden;
        private System.Windows.Forms.Button _lblReset;
        private System.Windows.Forms.Label _lblKaffeestand;
        private System.Windows.Forms.Label _lblSWVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tbxKaffeestand;
        private System.Windows.Forms.TextBox _tbxKosten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _btnAddKaffee;
        private System.Windows.Forms.Button _btnAddKosten;
    }
}