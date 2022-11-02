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
                //
                

            }
        }
    }
}
