# Belajar Dengan Jenius C#

## Penulis : Gun Gun Febrianza

## IL Assembly

Dalam **IL Assembly** terdapat struktur yang terdiri dari :
1.	**IL Directive** 
Pada **IL Assembly** sebuah **directive** direpresentasikan secara sintaksis dengan prefix dot, digunakan untuk memberi struktur pada sebuah **IL Code**. Pada **Common language Runtime** sebuah **IL Directive** digunakan untuk membuat sebuah **namespace, class** dan **method**. 
2.	**IL Attribute** 
Setiap **IL Directive** bisa memiliki dan menggunakan sebuah **IL Attribute** sehingga bisa digunakan untuk mengekspresikan **arbitrary code** dan cara bagaimana sebuah **IL Directive** hendak bekerja.
3.	**IL Label** 
Setiap baris pada **IL Assembly** memiliki **IL Label** yang bisa digunakan untuk melakukan **jumping code,** dimanfaatkan saat penggunaan **looping** dan **branching code**.
4.	**IL Opcode** 
**IL Opcode** atau kode **mnemonic** yang merepresentasikan **IL Instruction** untuk memanipulasi **stack**. Selanjutnya **IL assembly** akan diubah kedalam **managed code** oleh program yang bernama **ILASM** atau **IL Assemble**r dan program **IL** **Dissasembler** adalah sebuah program yang mampu menerjemahkan kembali **managed code** ke dalam **IL Assembly.**

**Sample** **mnemonic** dan **opcode IL Assembly** :

| Mnemonic   | Opcode | Purpose                                                     |
| ---------- | ------ | ----------------------------------------------------------- |
| add        | 0x58   | Menjumlahkan dua item yang berada pada **evaluation stack** |
| add.ovf    | 0xd6   | Menjumlahkan dua item yang berada pada **evaluation stack** |
| add.ovf.un | 0xd7   | Menjumlahkan dua item yang berada pada **evaluation stack** |

Instruksi **Add.ovf** memiliki kemampuan untuk mendeteksi **overflow** dan **Add.ovf.un** juga sama untuk mendeteksi **overflow** hanya saja untuk tipe data **unsigned**. 

Ada banyak sekali **Opcode** yang bisa dibaca pada lampiran, kita akan mengkajinya satu persatu namun secara klasifikasi kumpulan **opcode** ini akan dibagi menjadi 3 bagian diantaranya adalah sebagai berikut :

1. **Retrieve Instruction**

   | Opcode  | Description                                                  |
| :-----: | ------------------------------------------------------------ |
| *starg* | Memindahkan sebuah nilai dari **evaluation stack** kedalam **method argument** |
| *stloc* | Mengambil sebuah nilai di dalam memori dan menyimpanya ke dalam sebuah **local variable** |
| *stobj* | Menyalin nilai di dalam memori untuk dipindahkan pada alamat memori spesifik |
|  *pop*  | Membuang nilai aktual yang berada di dalam **top of stack.** |


2. **Control Instruction**

   | Opcode                | Description                                                  |
   | --------------------- | ------------------------------------------------------------ |
   | *ret*                 | Untuk keluar dari sebuah **method**                          |
   | *call*                | Memanggil salah satu **method**                              |
   | *Add, sub, mull, div* | Melakukan operasi aritmetika                                 |
   | *box,unbox*           | Konversi **value type** ke dalam **reference type**          |
   | *and,or,not,xor*      | Melakukan operasi **bitwise**                                |
   | *ceg,clt,cgt*         | Membandingkan dua buah nilai                                 |
   | *blt,blg,ble,beg*     | Untuk melakukan logika percabangan (**if less than,greater than , if equal and if less than or equal**) |

3. **Operation Load Instruction**

   | **Opcode** | **Penjelasan**                                              |
   | ---------- | ----------------------------------------------------------- |
   | *ldstr*    | Memuat sebuah string dari memori ke dalam evaluation stack. |
   | *ldarg*    | Memuat sebuah method argument ke dalam evaluation stack.    |
   | *ldc*      | Memuat sebuah nilai konstanta ke dalam evaluation stack.    |
   | *ldobj*    | Memuat sebuah object ke dalam **evaluation stack.**         |

Di bawah ini adalah kerangka dasar dari kode **IL Assembly** secara general.

```c#
1 .assembly extern mscorlib {}
2 .assembly FirstApp {}
3 .module FirstApp.exe
4 .namespace FirstApp
5 {
6     .class Test
7     {
8         .method public static void Main() il managed
9         {
10            IL_0000:.entrypoint
11            IL_0001:.maxstack    1
12            IL_0002: ldstr        "Hello"
13            IL_0003: call         void [mscorlib] System.Console:: WriteLine(string)
14            IL_0005: ret
15         }
16     }
17 }

```

Untuk bisa menggunakan **IL Assembly** sebuah struktur atau kerangka dasar yang terdiri dari kumpulan **IL directive** harus dibuat terlebih dahulu, agar selanjutnya sebuah **IL opcode** bisa digunakan. Adapun penjelasan setiap barisnya adalah sebagai berikut :
1.	Pada baris kode pertama terdapat **IL directive .assembly**, selanjutnya terdapat **IL attribute extern** yang membuat baris ini memiliki kemampuan untuk mendapatkan referensi **mscorlib**. **Mscorlib** adalah sebuah **dynamic link library** yang menjadi inti dari **Framework Base Class** yang di dalamnya terdapat kumpulan **namespace**. 
2.	Pada baris kode kedua hanya terdapat **IL directive** yang selanjutnya diikuti oleh **identifier** dengan nama **FirstApp**, sehingga sifat dari kode adalah memberi nama untuk **assembly** itu sendiri. 
3.	Pada baris ketiga terdapat **directive module** dengan **identifier** **FirstApp.exe** yang berarti bahwa keluaran akhirnya ditujukan untuk membuat sebuah **executable**. 
4.	Pada baris keempat terdapat **IL directive** **.namespace**, diikuti **identifier** dengan nama **FirstApp**. 
5.	Pada baris keenam terdapat **IL directive .class** yang digunakan untuk merepresentasikan **class** yang ingin bangun di **level intermediate** pada program yang akan dibuat. 
6.	Pada baris ke delapan terdapat **IL directive .method** yang disertai dengan **IL attribute** dengan visibilitas **public**, **modifier static** dan **return** berupa **void**.  **Attribute il managed** menyatakan bahwa di dalam **method** tersebut akan terdapat **IL code**. 
7.	Pada baris kode ke sepuluh terdapat **IL directive .entrypoint** yang akan menjadi tempat pertama yang dieksekusi ketika sebuah **executable** berjalan (**running time**). Pada baris kode kesepuluh juga terdapat awalan **string “IL_0000”** yang disebut dengan **IL Label**. Kode label ini bersifat opsional bisa ditambahkan atau tidak.
8.	Pada baris kode ke sebelas terdapat **IL directive maxstack** yang berarti variabel yang bisa disimpan kedalam **evaluation stack** hanya 1.
9.	Pada baris kode ke dua belas terdapat kode **mnemonic ldstr** yang berfungsi untuk memuat **string** dari dalam **memory** ke dalam **evaluation stack**. 
10.	Pada baris kode ke tiga belas instruksi call digunakan untuk memanggil suatu fungsi di dalam **mscorlib**. Fungsi yang dimaksud adalah suatu **method** di dalam suatu **class** pada suatu **namespace** yang disediakan dalam **mscorlib**. Fungsi yang dipanggil adalah **method** **writeline** dengan **parameter** **string** yang berada di dalam **class console** dan **namespace system.**
11.	Pada baris kode keempat instruksi **ret** dipanggil atau dikenal dengan **return**, namun pada kode di atas **return** berupa **void**. 

---------------------

