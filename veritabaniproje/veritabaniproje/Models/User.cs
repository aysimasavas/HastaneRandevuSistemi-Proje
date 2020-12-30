using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veritabaniproje.Models
{
    public class User
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public int SehirId { get; set; }
        public string Tckn { get; set; }
        public string Password { get; set; }

    }
}
