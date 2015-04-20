namespace CoffeeCount
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this._btnExit = new System.Windows.Forms.Button();
            this._tbxKaffeHeute = new System.Windows.Forms.TextBox();
            this._tbxKosten = new System.Windows.Forms.TextBox();
            this._btnSettings = new System.Windows.Forms.Button();
            this._tbxKaffe = new System.Windows.Forms.TextBox();
            this._btnCoffee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnExit
            // 
            this._btnExit.Location = new System.Drawing.Point(197, 169);
            this._btnExit.Name = "_btnExit";
            this._btnExit.Size = new System.Drawing.Size(75, 23);
            this._btnExit.TabIndex = 1;
            this._btnExit.Text = "Exit";
            this._btnExit.UseVisualStyleBackColor = true;
            this._btnExit.Click += new System.EventHandler(this._btnExit_Click);
            // 
            // _tbxKaffeHeute
            // 
            this._tbxKaffeHeute.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tbxKaffeHeute.Location = new System.Drawing.Point(102, 15);
            this._tbxKaffeHeute.Name = "_tbxKaffeHeute";
            this._tbxKaffeHeute.Size = new System.Drawing.Size(80, 47);
            this._tbxKaffeHeute.TabIndex = 2;
            this._tbxKaffeHeute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _tbxKosten
            // 
            this._tbxKosten.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tbxKosten.Location = new System.Drawing.Point(188, 21);
            this._tbxKosten.Name = "_tbxKosten";
            this._tbxKosten.Size = new System.Drawing.Size(84, 38);
            this._tbxKosten.TabIndex = 3;
            this._tbxKosten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _btnSettings
            // 
            this._btnSettings.Location = new System.Drawing.Point(12, 169);
            this._btnSettings.Name = "_btnSettings";
            this._btnSettings.Size = new System.Drawing.Size(75, 23);
            this._btnSettings.TabIndex = 1;
            this._btnSettings.Text = "Settings";
            this._btnSettings.UseVisualStyleBackColor = true;
            this._btnSettings.Click += new System.EventHandler(this._btnSettings_Click);
            // 
            // _tbxKaffe
            // 
            this._tbxKaffe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tbxKaffe.Location = new System.Drawing.Point(12, 21);
            this._tbxKaffe.Name = "_tbxKaffe";
            this._tbxKaffe.Size = new System.Drawing.Size(84, 38);
            this._tbxKaffe.TabIndex = 3;
            this._tbxKaffe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _btnCoffee
            // 
            this._btnCoffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._btnCoffee.Image = global::CoffeeCount.Properties.Resources.Kaffee1;
            this._btnCoffee.Location = new System.Drawing.Point(86, 74);
            this._btnCoffee.Name = "_btnCoffee";
            this._btnCoffee.Size = new System.Drawing.Size(112, 80);
            this._btnCoffee.TabIndex = 0;
            this._btnCoffee.UseVisualStyleBackColor = true;
            this._btnCoffee.MouseDown += new System.Windows.Forms.MouseEventHandler(this._btnCoffee_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kosten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kaffee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Heute";
            // 
            // Home
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 204);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._tbxKaffe);
            this.Controls.Add(this._tbxKosten);
            this.Controls.Add(this._tbxKaffeHeute);
            this.Controls.Add(this._btnSettings);
            this.Controls.Add(this._btnExit);
            this.Controls.Add(this._btnCoffee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "CoffeeCount";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnCoffee;
        private System.Windows.Forms.Button _btnExit;
        private System.Windows.Forms.TextBox _tbxKaffeHeute;
        private System.Windows.Forms.TextBox _tbxKosten;
        private System.Windows.Forms.Button _btnSettings;
        private System.Windows.Forms.TextBox _tbxKaffe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

