### Array di C#

#### 1. Pengenalan Array 1 Dimensi

**Array 1 Dimensi** adalah salah satu bentuk array yang paling sederhana. Array adalah struktur data yang memungkinkan kita untuk menyimpan beberapa nilai dalam satu variabel. Setiap elemen dalam array diakses menggunakan indeks, yang merupakan angka yang menunjukkan posisi elemen tersebut dalam array.

Bayangkan array sebagai deretan kotak yang bersebelahan, di mana setiap kotak dapat menyimpan satu nilai. Jika Anda ingin menyimpan sejumlah besar data yang terkait (misalnya, nilai ujian dari semua siswa di kelas), Anda dapat menggunakan array untuk menyimpan semua nilai tersebut dalam satu variabel, daripada membuat variabel terpisah untuk setiap nilai.

**Deklarasi Array:**
- Untuk mendeklarasikan array, kita harus menentukan tipe data elemen yang akan disimpan, diikuti dengan tanda kurung siku `[]`, dan nama variabel array.
- Array harus diinisialisasi dengan ukuran tertentu atau diisi dengan nilai-nilai tertentu.

**Contoh Deklarasi dan Inisialisasi Array 1 Dimensi:**

##### Contoh 1: Deklarasi dan Inisialisasi Array 1 Dimensi
```csharp
using System;

namespace Array1Dimensi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarasi dan inisialisasi array dengan ukuran 5
            int[] angka = new int[5]; // Deklarasi array dengan 5 elemen
            
            // Inisialisasi nilai pada array
            angka[0] = 10;
            angka[1] = 20;
            angka[2] = 30;
            angka[3] = 40;
            angka[4] = 50;

            // Mencetak nilai array
            for (int i = 0; i < angka.Length; i++)
            {
                Console.WriteLine($"angka[{i}] = {angka[i]}"); // Mencetak setiap elemen array
            }
        }
    }
}
```
**Penjelasan:** Pada contoh ini, kita mendeklarasikan array `angka` yang dapat menyimpan 5 elemen integer. Nilai dari array diinisialisasi satu per satu, dan kemudian dicetak menggunakan loop `for`. Perhatikan bahwa indeks array dimulai dari 0.

##### Contoh 2: Inisialisasi Array Secara Langsung
```csharp
using System;

namespace Array1DimensiInisialisasi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarasi dan inisialisasi array langsung dengan nilai-nilai
            int[] angka = { 10, 20, 30, 40, 50 }; // Inisialisasi langsung

            // Mencetak nilai array
            for (int i = 0; i < angka.Length; i++)
            {
                Console.WriteLine($"angka[{i}] = {angka[i]}"); // Mencetak setiap elemen array
            }
        }
    }
}
```
**Penjelasan:** Di sini, kita mendeklarasikan dan menginisialisasi array `angka` secara langsung dengan nilai-nilai. Tidak perlu menentukan ukuran array karena ukuran ditentukan berdasarkan jumlah elemen yang diberikan.

##### Contoh 3: Mengakses dan Mengubah Nilai Array
```csharp
using System;

namespace AksesUbahArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] angka = { 1, 2, 3, 4, 5 };

            // Mengakses dan mencetak elemen ketiga
            Console.WriteLine($"Elemen ketiga sebelum diubah: {angka[2]}");

            // Mengubah nilai elemen ketiga
            angka[2] = 10;

            // Mencetak elemen ketiga setelah diubah
            Console.WriteLine($"Elemen ketiga setelah diubah: {angka[2]}");
        }
    }
}
```
**Penjelasan:** Pada contoh ini, elemen ketiga dari array `angka` diakses dan diubah dari `3` menjadi `10`. Array diakses menggunakan indeks, dan nilai elemen dapat diubah dengan mengassign nilai baru.

##### Contoh 4: Menggunakan Loop untuk Inisialisasi Array
```csharp
using System;

namespace InisialisasiArrayLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] angka = new int[5];

            // Inisialisasi array menggunakan loop
            for (int i = 0; i < angka.Length; i++)
            {
                angka[i] = (i + 1) * 10; // Mengisi array dengan kelipatan 10
            }

            // Mencetak nilai array
            for (int i = 0; i < angka.Length; i++)
            {
                Console.WriteLine($"angka[{i}] = {angka[i]}");
            }
        }
    }
}
```
**Penjelasan:** Dalam contoh ini, array `angka` diinisialisasi menggunakan loop `for`, yang mengisi array dengan kelipatan 10. Setiap elemen diakses dan diubah dalam loop.

##### Contoh 5: Mencari Nilai Tertinggi dalam Array
```csharp
using System;

namespace CariNilaiTertinggi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] angka = { 10, 25, 17, 30, 5 };
            int max = angka[0];

            // Loop untuk mencari nilai tertinggi
            for (int i = 1; i < angka.Length; i++)
            {
                if (angka[i] > max)
                {
                    max = angka[i]; // Mengupdate nilai tertinggi
                }
            }

            Console.WriteLine($"Nilai tertinggi dalam array adalah: {max}");
        }
    }
}
```
**Penjelasan:** Contoh ini menunjukkan cara mencari nilai tertinggi dalam array `angka` menggunakan loop `for` dan variabel `max` untuk menyimpan nilai tertinggi.

---

#### 2. Pengenalan Array 2 Dimensi

Array 2 Dimensi (2D) adalah perluasan dari array 1 dimensi, di mana kita dapat menyimpan data dalam bentuk tabel atau matriks. Array 2D memiliki baris dan kolom, dan setiap elemen diakses menggunakan dua indeks: satu untuk baris dan satu untuk kolom.

Bayangkan array 2D sebagai tabel dengan sejumlah baris dan kolom, di mana setiap kotak dalam tabel tersebut dapat menyimpan satu nilai. Array 2D sangat berguna ketika Anda perlu menyimpan data yang terorganisir dalam bentuk grid, seperti data siswa dalam kelas berdasarkan mata pelajaran.

**Deklarasi Array 2 Dimensi:**
- Array 2D dideklarasikan dengan menyebutkan tipe data, diikuti dengan tanda `[ , ]`, dan nama variabel array.
- Array 2D dapat diinisialisasi dengan ukuran tertentu atau langsung dengan nilai-nilai tertentu.

**Contoh Deklarasi dan Inisialisasi Array 2 Dimensi:**

##### Contoh 1: Deklarasi dan Inisialisasi Array 2 Dimensi
```csharp
using System;

namespace Array2Dimensi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarasi dan inisialisasi array 2D dengan ukuran 2x3
            int[,] matriks = new int[2, 3];

            // Inisialisasi nilai pada array 2D
            matriks[0, 0] = 1;
            matriks[0, 1] = 2;
            matriks[0, 2] = 3;
            matriks[1, 0] = 4;
            matriks[1, 1] = 5;
            matriks[1, 2] = 6;

            // Mencetak nilai array 2D
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriks[i, j] + " "); // Mencetak setiap elemen array
                }
                Console.WriteLine(); // Pindah baris
            }
        }
    }
}
```
**Penjelasan:** Array `matriks` dideklarasikan dengan ukuran 2x3, yang berarti dua baris dan tiga kolom. Setiap elemen diinisialisasi secara manual, dan kemudian dicetak dalam bentuk tabel menggunakan nested loop.

##### Contoh 2: Inisialisasi Array 2 Dimensi Secara Langsung
```csharp
using System;

namespace InisialisasiArray2Dimensi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarasi dan inisialisasi array 2D secara langsung
            int[,] matriks = {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            // Mencetak nilai array 2D
            for (int i = 0; i < matriks.GetLength(0); i++)
            {
                for (int j = 0; j < matriks.GetLength(1); j++)
                {
                    Console.Write(matriks[i, j] + " "); // Mencetak setiap elemen array
                }
                Console.WriteLine(); // Pindah baris
            }
        }
    }
}
```
**Penjel

asan:** Dalam contoh ini, array 2D `matriks` diinisialisasi langsung dengan nilai-nilai tanpa perlu mendeklarasikan ukuran secara eksplisit. Method `GetLength()` digunakan untuk mendapatkan ukuran baris dan kolom dari array.

##### Contoh 3: Mengakses dan Mengubah Nilai dalam Array 2 Dimensi
```csharp
using System;

namespace UbahArray2Dimensi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriks = {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            // Mengubah nilai pada posisi [1, 1]
            matriks[1, 1] = 10;

            // Mencetak nilai array 2D
            for (int i = 0; i < matriks.GetLength(0); i++)
            {
                for (int j = 0; j < matriks.GetLength(1); j++)
                {
                    Console.Write(matriks[i, j] + " "); // Mencetak setiap elemen array
                }
                Console.WriteLine(); // Pindah baris
            }
        }
    }
}
```
**Penjelasan:** Pada contoh ini, nilai pada posisi [1, 1] dalam array `matriks` diubah dari `5` menjadi `10`. Setiap elemen dalam array diakses menggunakan indeks baris dan kolom.

##### Contoh 4: Array 2 Dimensi dengan Loop untuk Inisialisasi
```csharp
using System;

namespace InisialisasiArray2DimensiLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriks = new int[2, 3];

            // Mengisi array 2D menggunakan loop
            for (int i = 0; i < matriks.GetLength(0); i++)
            {
                for (int j = 0; j < matriks.GetLength(1); j++)
                {
                    matriks[i, j] = (i + 1) * (j + 1); // Mengisi dengan hasil perkalian
                }
            }

            // Mencetak array 2D
            for (int i = 0; i < matriks.GetLength(0); i++)
            {
                for (int j = 0; j < matriks.GetLength(1); j++)
                {
                    Console.Write(matriks[i, j] + " ");
                }
                Console.WriteLine(); // Pindah baris
            }
        }
    }
}
```
**Penjelasan:** Di sini, array 2D `matriks` diisi menggunakan loop. Nilai-nilai elemen dihasilkan dari hasil perkalian antara indeks baris dan kolom, yang memberikan hasil matriks perkalian sederhana.

##### Contoh 5: Menjumlahkan Semua Elemen dalam Array 2 Dimensi
```csharp
using System;

namespace JumlahArray2Dimensi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriks = {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            int jumlah = 0;

            // Loop untuk menjumlahkan semua elemen
            for (int i = 0; i < matriks.GetLength(0); i++)
            {
                for (int j = 0; j < matriks.GetLength(1); j++)
                {
                    jumlah += matriks[i, j]; // Menambahkan setiap elemen ke jumlah
                }
            }

            Console.WriteLine($"Jumlah semua elemen dalam array 2D adalah: {jumlah}");
        }
    }
}
```
**Penjelasan:** Contoh ini menunjukkan cara menjumlahkan semua elemen dalam array 2D `matriks`. Setiap elemen ditambahkan ke variabel `jumlah`, dan hasil akhirnya dicetak.

