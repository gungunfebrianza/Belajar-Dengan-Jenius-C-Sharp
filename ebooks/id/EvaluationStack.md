# Belajar Dengan Jenius C#

## Penulis : Gun Gun Febrianza

## Evaluation Stack

**Evaluation Stack** adalah tempat untuk melakukan operasi **computation** untuk **IL Assembly**, implementasi **evaluation stack** untuk **IL Assembly** mirip dengan **stack** dalam data struktur umumnya. Jika terdapat masukan maka aturanya selalu **Last In First Out (LIFO)**. Proses untuk menambahkan **item** kedalam **stack** disebut dengan **push** dan melepaskan **item** dari dalam **stack** disebut dengan **pop**.

**Evaluation Stack :**

![](../assets/EvaluationStack.jpg)

Instruksi yang menyalin sebuah nilai dari **memory** ke dalam **evaluation stack** disebut dengan **Load**. Seluruh **opcode** yang diawali dengan **ld** digunakan untuk memuat **item** ke dalam **stack** dan seluruh **opcode** yang diawali dengan **st** digunakan untuk menyimpan **item** kedalam **memory**. 

Instruksi yang digunakan untuk menyimpan data kedalam **memory**, juga menghasilkan proses **popping item** yang ada di dalam **evaluation stack**. Sebagai contoh jika ingin menjumlahkan dua buah angka, maka angka tersebut harus disimpan terlebih dahulu di dalam **evaluation stack**. 

Sebagai contoh terdapat operasi penjumlahan 10 + 20 – 5 maka operasinya bisa dilihat di dalam Tabel di bawah ini.

| IL Assembly                                                  | Evaluation Stack        |
| ------------------------------------------------------------ | ----------------------- |
| IL_0001:  ldc.i4  10<br/>IL_0002:  ldc.i4  20<br/>IL_0003:  add<br/>IL_0004:  ldc.i4.5<br/>IL_0005:  sub | 0000 0020<br/>0000 0010 |
| IL_0003:  add<br/>IL_0004:  ldc.i4 5<br/>IL_0005:  sub       | 0000 0030               |
| IL_0004:  ldc.i4 5<br/>IL_0005:  sub                         | 0000 0005<br/>0000 0030 |
| IL_0005:  sub                                                | 0000 0025               |



---------------------

