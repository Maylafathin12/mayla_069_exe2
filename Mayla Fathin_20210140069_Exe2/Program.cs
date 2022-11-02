using System;

namespace Mayla_Fathin_20210140069_Exe2
{
   class Exe2
    {
        //mendeklarasikan array int dengan ukuran 89
        //yang diambil dari 2 digit terakhir nim = 69
        public decimal[] mayla = new decimal[89];

        //jumlah array yang akan tersimpan
        public decimal n;

        //membuat fungsi method
        public void Input()
        {
            //menggunakan perulangan while untuk mendapatkan jumlah elemen yang disimpan pada array
            while (true)
            {
                //digunakan untuk menampilkan  masukkan banyaknya elemen pada array
                Console.WriteLine("Masukkan banyaknya elemen pada array : ");
                //menerima jumlah inputan dan disimpan ke dalam variable s dalam bentuk string
                string s = Console.ReadLine();
                //mendeklarasikan variable n yang di konversi dari variable s(dari string ke decimal)
                n = decimal.Parse(s);
                //menggunakan if else untuk menetapkan batasan elemen yang dimasukkan
                //jika n lebih dari 0 atau n kurang dari sama dengan 89
                if ((n > 0) && (n <= 89))
                    break; //menjalankan perintah selanjutnya untuk menetapkan batasan elemen yang dicari
                else
                Console.WriteLine("");
                Console.WriteLine("Array hanya dapat menampung sampai 89!"); //akan menampilkan output array dapat menampung maksimal 89 elemnt
            }
            //menerima elemen array
            Console.Write(------------------------------);
            Console.WriteLine("Masukkan elemen array : ");
            Console.Write(------------------------------);
        }

    }
}
