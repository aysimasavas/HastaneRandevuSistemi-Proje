using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veritabaniproje.Models
{
    public class Cocuk
    {
        public int Id { get; set; }
        public int EbeveynId { get; set; }
        public string AdSoyad { get; set; }
    }
}
