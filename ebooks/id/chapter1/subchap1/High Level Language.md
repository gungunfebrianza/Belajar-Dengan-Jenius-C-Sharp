# Belajar Dengan Jenius C#

## Penulis : Gun Gun Febrianza

## High Level Language

**High Level Language** disebut juga **Machine Independant Language** dikenal dengan sebutan **third generation language**. **High Level language** adalah bahasa pemrograman dengan **strong abstraction** dari kedetailan tentang komputer. Diciptakan untuk menyederhanakan pemrograman. 

Abstraksi ini membuat proses pengembangan sebuah program menjadi lebih sederhana dan prosesnya mudah difahami. Jumlah abstraksi yang disediakan menjelaskan seberapa tinggi level pemrograman itu sendiri. 

Pada Tahun **1960**, bahasa pemrograman tingkat tinggi yang menggunakan **compiler** dikenal dengan sebutan **Autocodes** [1]. Contoh **Autocodes** adalah **Fortran** dan **Cobol**. Bahasa pemrograman tingkat tinggi pertama didunia adalah **Plankalkül** yang dibuat oleh **Konrad Zuse** [2]. 

**High Level Language Programming** seperti bahasa **C**, **C++**, **Python** dan **Java** mempunyai satu ke banyak (**one to many**) relasi dengan **Assembly Language** dan **Machine Language**. 

Disinilah kedalaman **abstraction** dari sebuah bahasa tingkat tinggi dinilai. Sebuah **Statement** satu baris yang dibuat menggunakan **C++** akan mengembang jika diterjemahkan kedalam **Assembly Language** dan **Machine-language Instruction**. 

Di bawah ini adalah dua buah **statement** dengan **C++ code** yang di dalamnya terdapat **Arithmetic Operation** dan hasilnya ditetapkan kedalam sebuah **Variable** dengan asumsi **X** dan **Y** adalah **Integer** :

```c++
int Y;
int X = (Y + 4) * 3;
```

Jika diterjemahkan kedalam **Assembly Language** maka dibutuhkan banyak **statement code** seperti di bawah ini.

```assembly
mov eax,Y ; Pindahkan Y ke EAX register
add eax,4 ; Tambah nilai 4 ke EAX register
mov ebx,3 ; Pindahkan 3 ke EBX register
imul ebx ; Kalikan EAX dengan EBX
mov X,eax ; Pindahkan EAX ke X
```

Selanjutnya dari bahasa **assembly** akan diterjemahkan kedalam bahasa mesin dengan relasi satu ke satu, artinya dari setiap satu instruksi yang dibuat menggunakan bahasa **assembly** mengacu  pada satu **Machine-language Instruction** yang selanjutnya menjadi sinyal listrik (**Digital Signal**). 

**Register** adalah nama sebuah lokasi di dalam **CPU** untuk menyimpan sebuah hasil sementara [3]. 

---------------------

[1] London, Keith, "4, Programming," in *Introduction to Computers*, London, Faber and Faber Limited, 1968, p. 184.

[2] Giloi, Wolfgang, K., "Konrad Zuse's Plankalkül: The First High-Level "non von Neumann," *Programming Language,* vol. 19, pp. 17-24, 1997. 

[3] Irvine, "Basic Concepts," in *Assembly Language for x86 Processor, 7th edition*, Pearson, 2014, p. 4.

