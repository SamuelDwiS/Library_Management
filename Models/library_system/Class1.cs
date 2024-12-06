using System;
using System.Collections.Generic;

namespace library_system
{
    public class lib_sistem
    {
        public List<string> daftar_buku = new List<string>();
        public List<string> anggota = new List<string>();

        public void tambahBuku(string buku)
        {
            daftar_buku.Add(buku);
            Console.WriteLine("Sudah Ditambahkan :" + buku);
        }

        public void deleteBuku(string buku)
        {
            daftar_buku.Remove(buku);
            Console.WriteLine("Buku sudah di hapus :" + buku);
        }

        public void pinjamBuku(int id_buku)
        {
            foreach(var buku in daftar_buku)
            {
                Console.WriteLine("Daftar Buku: " S + buku);
            }
        }


    }
}


