using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4352
{
    public class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        public void karyawan(string no, string nama, int gaji)
        {
            Nik = no;
            Nama = nama;
            GajiBulanan = gaji;
        }
    }
}
