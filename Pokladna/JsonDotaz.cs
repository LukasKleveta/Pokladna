using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Pokladna
{
    class JsonDotaz : Irepos
    {
        private string DataSoubor;


        public JsonDotaz(string soubor)
        {
            DataSoubor = soubor;
        }



        public void VytvorTestData()
        {
            List<PoklZaznam> data = new List<PoklZaznam>();
            data.Add(new PoklZaznam(1, 1, new DateTime(2020, 1, 5), "Příjem z banky", 25000, 25000, ""));
            data.Add(new PoklZaznam(2, 2, new DateTime(2020, 1, 8), "Oprava trakotru", -2500, data.Last().Zustatek - 2500, ""));
            data.Add(new PoklZaznam(3, 3, new DateTime(2020, 2, 5), "Nová vydlice", -350, data.Last().Zustatek - 350, ""));
            data.Add(new PoklZaznam(4, 4, new DateTime(2020, 5, 21), "Pronájem pole", -8500, data.Last().Zustatek - 8500, ""));
            data.Add(new PoklZaznam(5, 5, new DateTime(2020, 7, 18), "Příjem z banky", 15000, data.Last().Zustatek + 15000, ""));

            string json = JsonConvert.SerializeObject(data, Formatting.Indented);

            File.WriteAllText(DataSoubor, json);


        }

        public List<PoklZaznam> NactiVse()
        {
            List<PoklZaznam> data;
            data = JsonConvert.DeserializeObject<List<PoklZaznam>>(File.ReadAllText(DataSoubor));
            return data;
        }

        public PoklZaznam NactiZaznam(int idPoklZaznam)
        {
            throw new NotImplementedException();
        }

        public void SmazZaznam(PoklZaznam poklZaznam)
        {
            throw new NotImplementedException();
        }

        public void UpravZaznam(PoklZaznam poklZaznam)
        {
            throw new NotImplementedException();
        }

        public PoklZaznam VytvorZaznam(PoklZaznam PoklZaznam)
        {
            throw new NotImplementedException();
        }

        public List<PoklZaznam> NactiMesic(int rok, int mesic)
        {
            List<PoklZaznam> data = NactiVse();
            return data.FindAll(prvek => prvek.Datum.Year == rok && prvek.Datum.Month == mesic);

        }
    }
}
