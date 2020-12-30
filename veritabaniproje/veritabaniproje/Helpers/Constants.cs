using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veritabaniproje.Models;

namespace veritabaniproje.Helpers
{
    public class Constants
    {
        public static User user  { get; set; }
        public static Doktor doktor  { get; set; }
        public static Randevu randevu  { get; set; }
        public static Cocuk cocuk  { get; set; }
        
        public static string tarihFormat = "dd-MM-yyyy";
        public static string saatFormat = "HH:mm";

    }
}
