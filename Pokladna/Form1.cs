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
            
            //repositar = new SqlDotaz();
            //pokladna = repositar.NactiVse();
        }
    }
}
