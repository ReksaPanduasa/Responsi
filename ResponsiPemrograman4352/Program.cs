using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4352
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan();

            karyawan.Nik = "190302123";
            karyawan.Nama = "Reksa";
            karyawan.GajiBulanan = 3000000;

            Karyawan karyawans = new Karyawan();

            karyawans.Nik = "190302124";
            karyawans.Nama = "Panduasa";
            karyawans.GajiBulanan = 2000000;

            Console.WriteLine("No  Nik/Nama\t\tGaji Bulanan");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1. {0} {1}\t\t{2}", karyawan.Nik, karyawan.Nama, karyawan.GajiBulanan);
            Console.WriteLine("2. {0} {1}\t\t{2}", karyawans.Nik, karyawans.Nama, karyawans.GajiBulanan);
            Console.WriteLine();
            Console.WriteLine("Asyiiiiik kenaikan gaji 10% dong");
            Console.WriteLine("1. {0} {1}\t\t{2}", karyawan.Nik, karyawan.Nama + (karyawan.GajiBulanan * 0.10));
            Console.WriteLine("2. {0} {1}\t\t{2}", karyawans.Nik, karyawans.Nama + (karyawans.GajiBulanan * 0.10));
            Console.ReadKey();
        }
    }
}
