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
            Console.Write("------------------------------");
            Console.WriteLine("Masukkan elemen array   : ");
            Console.Write("------------------------------");

            //menggunakan perulangan for untuk menerima array
            //code akan berulang hingga sampai jumlah yang dimasukkan pada "masukkan banyak elemen pada array"
            for (int i = 0; i < n; i++)
            {
                //menampilkan <1> dan seterusnya
                Console.Write("<" + i + 1 + ">");
                //membaca dan menyimpan ke dalam array mayla
                string s1 = Console.ReadLine();
                mayla[i] = (int)decimal.Parse(s1);
            }
        }
        //metode untuk tidak mengembalikan nilai
        //metode untuk menampilkan array
        public void Taampil()
        {
            Console.WriteLine("");
            Console.Write("-------------------------------");
            Console.WriteLine("Elemen array telah tersusun");
            Console.Write("-------------------------------");

            //menggunakan perulangan for untuk menampilkan nilai data yang telah tersusun
            //akan mengulang sampai perulangan tersebut sama dengan jumlah data
            for (int MF = 0; MF < n - 1; MF++)
            {
                //code untuk menampilkan data yang sudah terurut
                Console.WriteLine((Convert.ToDecimal(mayla[MF])));
            }
        }
        public void insertionsort() //method unntuk mengurutkan data
        {
            //repeat step 22,3,4,5 variying i from 1 to n-1
            for (int i = 1; i < n; i++)
            {
                //set temp = arr[i]
                decimal temp = mayla[i];
                //set j = i - 1
                int MF = i - 1;
                //repeat until j becomes less than 0 or arr[MF] becomes less than or equal to temp
                while ((MF >= 0) && (mayla[MF] > temp))
                {
                    mayla[MF + 1] = mayla[MF];
                    MF = MF - 1;
                }
                //store temp at index j+1
                mayla[MF + 1] = temp;
            }
        }
    }
    class mergesort
    {
        //deklarasi array int dengan nilai maksimal 89
        //maksimal data yang bia disimpan adalah 89
    }
}
