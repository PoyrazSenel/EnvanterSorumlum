using System;
using System.Collections.Generic;
using System.Text;

namespace Performans_Odevi_232
{
    internal class StokHareketi
    {
        public int Id { get; set; }

        public int UrunId { get; set; }

        public string IslemTuru { get; set; }

        public int Miktar { get; set; }

        public DateTime Tarih { get; set; }
    }
}
