using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoffeeCount
{
    public partial class Settings : Form
    {
        Home Mirror;
        int _Kaffeestand;
        float _ProKaffee;
        bool Change = false;

        /*==========================================================================*/
        public Settings(Home Buffer)
        /*----------------------------------------------------------------------------
        Description:
        ============================================================================*/
        {
            Mirror = Buffer;
            InitializeComponent();
            _Kaffeestand = Mirror._getAnzahlKaffee();
            _ProKaffee = Mirror._getKosten();
            _ActualizeTBX();
        }

        /*==========================================================================*/
        private void _ActualizeTBX()
        /*----------------------------------------------------------------------------
        Description:
        ============================================================================*/
        {
            _lblSWVersion.Text = "Version 0.2";
            _tbxKaffeestand.Text = _Kaffeestand.ToString();
            _tbxKosten.Text = (Math.Round(_ProKaffee,2)).ToString();
        }

        /*==========================================================================*/
        private void _btnAbbruch_Click(object sender, EventArgs e)
        /*----------------------------------------------------------------------------
        Description:
        ============================================================================*/
        {
            this.Close();
        }

        /*==========================================================================*/
        private void _btnVerwenden_Click(object sender, EventArgs e)
        /*----------------------------------------------------------------------------
        Description:
        ============================================================================*/
        {
            Mirror._setParameters(_Kaffeestand, _ProKaffee, Change);
            this.Close();
        }

        /*==========================================================================*/
        private void _lblReset_Click(object sender, EventArgs e)
        /*----------------------------------------------------------------------------
        Description:
        ============================================================================*/
        {
            _Kaffeestand = 0;
            Change = true;
            _tbxKosten.ForeColor = SystemColors.WindowText;
            _tbxKaffeestand.ForeColor = SystemColors.WindowText;
            _ActualizeTBX();
        }

        /*==========================================================================*/
        private void _tbxKaffeestand_Click(object sender, EventArgs e)
        /*----------------------------------------------------------------------------
        Description:
        ============================================================================*/
        {
            _tbxKaffeestand.Text = "";
            _tbxKaffeestand.ForeColor = SystemColors.WindowText;
        }

        /*==========================================================================*/
        private void _btnAddKaffee_Click(object sender, EventArgs e)
        /*----------------------------------------------------------------------------
        Description:
        ============================================================================*/
        {
            float Buffer = _StringToFloatFilter(_tbxKaffeestand.Text);

            if (Buffer == 0)
            {
                return;
            }

            _tbxKaffeestand.ForeColor = SystemColors.WindowText;
            _Kaffeestand = Convert.ToInt32(Buffer);
            _ActualizeTBX();
        }

        /*==========================================================================*/
        private void _tbxKaffeestand_Leave(object sender, EventArgs e)
        /*----------------------------------------------------------------------------
        Description:
        ============================================================================*/
        {
            if (_tbxKaffeestand.Text == "")
            {
                _tbxKaffeestand.ForeColor = SystemColors.ScrollBar;
                _tbxKaffeestand.Text = _Kaffeestand.ToString();
                _ActualizeTBX();
            }
            else
            {
                float Buffer = _StringToFloatFilter(_tbxKaffeestand.Text);

                _Kaffeestand = Convert.ToInt32(Buffer);
                _ActualizeTBX();
            }
        }

        /*==========================================================================*/
        private float _StringToFloatFilter(string Text)
        /*----------------------------------------------------------------------------
        Description:
        ============================================================================*/
        {
            string Buffer = string.Empty;
            int Merker = 0;

            if (Text.Length == 0)
            {
                return 0;
            }

            foreach (char numChar in Text.ToCharArray())
            {
                if (Char.IsNumber(numChar))
                {
                    Buffer += numChar;
                }
                if ((numChar == '.' || numChar == ',' )&& Merker == 0)
                {
                    Merker++;
                    Buffer += ".";
                }

            }

            if (Buffer == string.Empty)
            {
                return 0;
            }

            return float.Parse(Buffer);
        }

        /*==========================================================================*/
        private void _tbxKosten_Click(object sender, EventArgs e)
        /*----------------------------------------------------------------------------
        Description:
        ============================================================================*/
        {
            _tbxKosten.Text = "";
            _tbxKosten.ForeColor = SystemColors.WindowText;
        }

        /*==========================================================================*/
        private void _tbxKosten_Leave(object sender, EventArgs e)
        /*----------------------------------------------------------------------------
        Description:
        ============================================================================*/
        {
            if (_tbxKosten.Text == "")
            {
                _tbxKosten.ForeColor = SystemColors.ScrollBar;
                _tbxKosten.Text = _tbxKosten.ToString();
                _ActualizeTBX();
            }
            else
            {
                float Buffer = _StringToFloatFilter(_tbxKosten.Text);

                _ProKaffee = Buffer;
                _ActualizeTBX();
            }
        }

        /*==========================================================================*/
        private void _btnAddKosten_Click(object sender, EventArgs e)
        /*----------------------------------------------------------------------------
        Description:
        ============================================================================*/
        {
            float Buffer = _StringToFloatFilter(_tbxKosten.Text);

            if (Math.Round(Buffer, 2) == 0.00)
            {
                return;
            }

            _tbxKosten.ForeColor = SystemColors.WindowText;
            _ProKaffee = Buffer;
            _ActualizeTBX();
        }
    }
}
