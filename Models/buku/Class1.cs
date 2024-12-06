using System;

namespace buku
{
    public class data_buku
    {
        public int id_buku {get; set;}
        public string judul {get; set;}
        public string pengarang {get; set;}
        public int stock {get; set;}
        public string kategori {get; set;}

        public data_buku(int id_buku, string judul, string pengarang, int stock, string ategori)
        {
            ID = id_buku;
            Judul = judul;
            Pengarang = pengarang;
            Stock = stock;
            Kategori = kategori;
        }


    }

    public class perpustakaan_buku
}
