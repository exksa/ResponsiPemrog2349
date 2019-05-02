using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2349
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek dari class mahasiswa
            Karyawan me = new Karyawan();
            Karyawan you = new Karyawan("18112365", "Dwi", 2000000);

            Console.WriteLine("No.  Nik / Nama          Gaji Bulanan");
            Console.Write("1.   {0}", me.Nik.ToString());
            Console.Write(" / {0}", me.Nama.ToString());
            Console.WriteLine("    {0}", me.GajiBulanan.ToString());
            Console.Write("2.   {0}", you.Nik.ToString());
            Console.Write(" / {0}", you.Nama.ToString());
            Console.WriteLine("      {0}", you.GajiBulanan.ToString());

            Console.WriteLine();
            Console.WriteLine("Asyik kenaikan gaji 10%");
            Console.WriteLine();

            var hasil = (me.GajiBulanan * 0.10) + me.GajiBulanan;
            var hasil2 = (you.GajiBulanan * 0.10) + you.GajiBulanan;

            Console.WriteLine("No.  Nik / Nama          Gaji Bulanan");
            Console.Write("1.   {0}", me.Nik.ToString());
            Console.Write(" / {0}", me.Nama.ToString());
            Console.WriteLine("    {0}", hasil);
            Console.Write("2.   {0}", you.Nik.ToString());
            Console.Write(" / {0}", you.Nama.ToString());
            Console.WriteLine("      {0}", hasil2);

            Console.ReadKey();
        }

        static int Bonus(int gajibulanan)
        {
            return gajibulanan * (10 / 100);
        }
    }
}
