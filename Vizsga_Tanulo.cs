using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizsgakesesek
{
    class Vizsga_Tanulo
    {
        private int id;
        private string vezeteknev;
        private string keresztnev;
        private string osztaly;
        private string ofoneve;

        public int Id { get => id; set => id = value; }
        public string Vezeteknev { get => vezeteknev; set => vezeteknev = value; }
        public string Keresztnev { get => keresztnev; set => keresztnev = value; }
        public string Osztaly { get => osztaly; set => osztaly = value; }
        public string Ofoneve { get => ofoneve; set => ofoneve = value; }

        public Vizsga_Tanulo(int id, string vezeteknev, string keresztnev, string osztaly, string ofoneve)
        {
            Id = id;
            Vezeteknev = vezeteknev;
            Keresztnev = keresztnev;
            Osztaly = osztaly;
            Ofoneve = ofoneve;
        }
    }
}
