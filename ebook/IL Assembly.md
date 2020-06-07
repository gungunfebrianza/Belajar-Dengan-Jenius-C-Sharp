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



---------------------

