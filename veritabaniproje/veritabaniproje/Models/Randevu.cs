using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veritabaniproje.Models
{
    public class Randevu
    {
        public int Id { get; set; }
        public string Tarih { get; set; }
        public int DoktorId { get; set; }
        public int UserId { get; set; }
        public int CocukId { get; set; }
        public int SaglikKurumuId { get; set; }
        public string Saat { get; set; }
    }
}
