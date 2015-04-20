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
    public partial class Home : Form
    {
        List<string> LoggList = new List<string>();
        int AnzahlKaffe;
        int AnzahlKaffeHeute;
        float ProKaffe;

        /*==========================================================================*/
        public Home()
        /*----------------------------------------------------------------------------
        Description:
        ============================================================================*/
        {
            InitializeComponent();
            _fLoadSettings();
            _ActualizeTBX();
        }

        /*==========================================================================*/
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        /*----------------------------------------------------------------------------
        Description:
        ============================================================================*/
        {
            _fSaveSettings();
        }

        /*==========================================================================*/
        private void _fLoadSettings()
        /*----------------------------------------------------------------------------
        Description:
        ============================================================================*/
        {
            AnzahlKaffe = Properties.Settings.Default.Kaffe;
            AnzahlKaffeHeute = 0;
            ProKaffe = Properties.Settings.Default.ProKaffe;

            /* Falls das Programm zum ersten Mal gestartet wir und noch     *
             * keine gespeicherten Daten vorhanden sind: return             */
            if (Properties.Settings.Default.Logg == "")
            {
                return;
            }

            /* Gespeicherte Daten auswerten */
            LoggList = Properties.Settings.Default.Logg.Split('|').ToList<string>();
            LoggList.Remove("");
            
            for (int i = 0; i < LoggList.Count; i++)
            {
                LoggList[i] += "|";
            }

            string Date;
            DateTime Today = DateTime.Now;
            Date = Today.ToString("yyyy-MM-dd");

            
            if (LoggList[LoggList.Count-1].Contains(Date))
            {
                int i = LoggList.Count;
                AnzahlKaffeHeute = Convert.ToInt32(LoggList[i-1].Substring(LoggList[i-1].IndexOf('*')+1, 2));
                return;
            }
        }

        /*==========================================================================*/
        private void _ActualizeTBX()
        /*----------------------------------------------------------------------------
        Description:
        ============================================================================*/
        {
            _tbxKaffe.Text = AnzahlKaffe.ToString();
            _tbxKaffeHeute.Text = AnzahlKaffeHeute.ToString();
            _tbxKosten.Text = Math.Round((AnzahlKaffe*ProKaffe),2).ToString();
        }

        /*==========================================================================*/
        private void _btnExit_Click(object sender, EventArgs e)
        /*----------------------------------------------------------------------------
        Description:
        ============================================================================*/
        {
            this.Close();
        }

        /*==========================================================================*/
        private void _fSaveSettings()
        /*----------------------------------------------------------------------------
        Description:
        ============================================================================*/
        {
            string Buffer = "";
            for(int i = 0; i <= LoggList.Count -1; i++)
            {
                Buffer += LoggList.ElementAt(i).ToString();
            }
            Properties.Settings.Default.Logg = Buffer;
            Properties.Settings.Default.KaffeHeute = AnzahlKaffeHeute;
            Properties.Settings.Default.Kaffe = AnzahlKaffe;
            Properties.Settings.Default.ProKaffe = ProKaffe;
            Properties.Settings.Default.Save();
        }

        /*==========================================================================*/
        private void _btnCoffee_MouseDown(object sender, MouseEventArgs e)
        /*----------------------------------------------------------------------------
        Description:
        ============================================================================*/
        {
            string Date;
            DateTime Today = DateTime.Now;
            Date = Today.ToString("yyyy-MM-dd_HH:mm:ss");
            if (e.Button == MouseButtons.Left)
            {
                AnzahlKaffe++;
                AnzahlKaffeHeute++;
            }
            else
            {
                if (AnzahlKaffe != 0)
                {
                    AnzahlKaffe--;
                    if (AnzahlKaffeHeute != 0)
                    {
                        AnzahlKaffeHeute--;
                    }
                }
            }
            LoggList.Add(Date + "*" + AnzahlKaffe + "|");
            _ActualizeTBX();
            
        }

        /*==========================================================================*/
        private void _btnSettings_Click(object sender, EventArgs e)
        /*----------------------------------------------------------------------------
        Description:
        ============================================================================*/
        {
            Settings form2 = new Settings(this);
            form2.Show();
        }
        
        /*==========================================================================*/
        public int _getAnzahlKaffee()
        /*----------------------------------------------------------------------------
        Description:
        ============================================================================*/
        {
            return AnzahlKaffe;
        }

        /*==========================================================================*/
        public float _getKosten()
        /*----------------------------------------------------------------------------
        Description:
        ============================================================================*/
        {
            return ProKaffe;
        }

        /*==========================================================================*/
        public void _setParameters(int Kaffeestand, float neueKosten, bool Change)
        /*----------------------------------------------------------------------------
        Description:
        ============================================================================*/
        {
            if (Change)
            {
                AnzahlKaffeHeute = 0;
            }
            else
            {
                AnzahlKaffeHeute = Kaffeestand;
            }
            AnzahlKaffe = Kaffeestand;
            ProKaffe = neueKosten;
            _ActualizeTBX();
        }
    }
}
