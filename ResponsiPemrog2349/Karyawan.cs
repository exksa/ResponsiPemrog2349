using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2349
{
    class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
        public int Bonus1 { get; set; }

        public Karyawan()
        {
            Nik = "18112349";
            Nama = "Dylan";
            GajiBulanan = 3000000;
        }

        public Karyawan(string nik, string nama, int gajibulanan)
        {
            this.Nik = nik;
            this.Nama = nama;
            this.GajiBulanan = gajibulanan;
        }

        
    }
}
