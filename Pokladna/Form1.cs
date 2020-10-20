using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokladna
{
    public partial class Form1 : Form
    {
        List<PoklZaznam> pokladna;
        Irepos repositar;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JsonDotaz jsonDotaz = new JsonDotaz("Zaznamy.json");
            jsonDotaz.VytvorTestData();
            repositar = jsonDotaz;

            comboBoxRok.SelectedIndex = comboBoxRok.Items.IndexOf(DateTime.Now.Year.ToString());
            comboBoxMesic.SelectedIndex = DateTime.Now.Month-1;

          
            
            //repositar = new SqlDotaz();

            //pokladna = repositar.NactiVse();
            //foreach(var p in pokladna)
            //{
            //    listView2.Items.Add(p.DoItem());
            //}
        }

        private void comboBoxRok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRok.SelectedIndex >= 0 && comboBoxMesic.SelectedIndex >= 0) 
            {
                pokladna = repositar.NactiMesic(int.Parse(comboBoxRok.SelectedItem.ToString()),comboBoxMesic.SelectedIndex+1);
                listView2.Items.Clear();
                foreach (var p in pokladna)
                {
                    listView2.Items.Add(p.DoItem());
                }
            }   
          
        }

        private void comboBoxMesic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRok.SelectedIndex >= 0 && comboBoxMesic.SelectedIndex >= 0)
            {
                pokladna = repositar.NactiMesic(int.Parse(comboBoxRok.SelectedItem.ToString()), comboBoxMesic.SelectedIndex + 1);
                listView2.Items.Clear();
                foreach (var p in pokladna)
                {
                    listView2.Items.Add(p.DoItem());
                }
            }
        }
    }
}
