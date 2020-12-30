using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veritabaniproje.Models
{
    public class Doktor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BolumId { get; set; }
        public int PuanId { get; set; }
        public int MahId { get; set; }
        public string BosTarihBas { get; set; }
        public string BosTarihSon { get; set; }
        public string BosSaatBas { get; set; }
        public string BosSaatSon { get; set; }
    }
}
