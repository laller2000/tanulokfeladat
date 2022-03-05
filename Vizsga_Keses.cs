using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizsgakesesek
{
    class Vizsga_Keses
    {
        private int id;
        private int tanuloID;
        private DateTime mikor;
        private string igazolt;
        private string megjegyzes;

        public int Id { get => id; set => id = value; }
        public int TanuloID { get => tanuloID; set => tanuloID = value; }
        public DateTime Mikor { get => mikor; set => mikor = value; }
        public string Igazolt { get => igazolt; set => igazolt = value; }
        public string Megjegyzes { get => megjegyzes; set => megjegyzes = value; }

        public Vizsga_Keses(int id, int tanuloID, DateTime mikor, string igazolt, string megjegyzes)
        {
            Id = id;
            TanuloID = tanuloID;
            Mikor = mikor;
            Igazolt = igazolt;
            Megjegyzes = megjegyzes;
        }
    }
}
