using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
namespace Kundenregister
{
    public partial class Form3 : Form
    {
        public string[] abc = new string[10000];  //speicher
        public int abcd = 1;  //speichermerk
        public string checkmerk;
        public int merkdir = 0;
        public string suchausg;
        public int bestatige = 0;
        
        public Form3()
        {
            InitializeComponent();
            string[] strArray = File.ReadAllLines(".\\handelsregister.txt");
            for (int index = 0; index < strArray.Length; ++index)
            this.abc[index] = strArray[index];
            this.abcd = Convert.ToInt32(this.abc[0]);
            this.checkmerk = Convert.ToString(this.abcd);
            int checkmerk2;
            string checkmerk3;
            checkmerk2 = Convert.ToInt32(this.checkmerk) - 1;
            checkmerk3 = Convert.ToString(checkmerk2);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int erkenner = -1;
            int[] merkstelle = new int[10000];
            string[] ausgabe = new string[10000];
            int notiz = 0;
            string einsuch = sucheein.Text;
            for(int i=0;i<abcd;i++)
            {
                erkenner = abc[i].IndexOf(einsuch);
                if(erkenner!=-1)
                {
                    merkstelle[notiz] = i;
                    notiz++;
                    erkenner = -1;
                }

            }
            for(int i=0;i<notiz;i++)
            {
                ausgabe[i] = abc[merkstelle[i]];
            }


            if (notiz == 0)
            {
                label1.Text = "Es konnte niemand gefunden werden, sicher das du es richtig geschrieben hast?";
            }
            else
            {
                label1.Text = "";
                for (int i = 0; i < notiz; i++)
                {
                    label1.Text = label1.Text + "\n" + i + 1 + ": " + ausgabe[i];
                }
            }

            nutzerzahl.Text = Convert.ToString(notiz);
        }

        private void nutzerzahl_Click(object sender, EventArgs e)
        {

        }
    }
}
