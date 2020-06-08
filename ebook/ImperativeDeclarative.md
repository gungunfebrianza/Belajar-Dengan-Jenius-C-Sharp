# Belajar Dengan Jenius C#

## Penulis : Gun Gun Febrianza

## Imperative & Declarative Programming

Pada **Procedural Oriented Programming (POP)**, setiap kali proyek baru dibuat dan membutuhkan tempat penyimpanan maka sebuah variabel harus dibuat. Agar bisa bekerja dengan berbagai **function** yang telah dibuat maka variabel harus dibuat menjadi global. Jika ingin menambah fitur maka **function** baru tinggal dibuat, namun memiliki kemungkinan **global data** yang telah disimpan sebelumnya perlu dimodifikasi ulang agar bisa bekerja dengan **function** yang baru dibuat.

Cara **Function** akses Data dalam **POP** :

![](../assets/POPFunction.png)

Saat skala proyek semakin besar proses pembuatan fitur baru akan menjadi sangat kompleks, karena semua **global variable** yang telah menyimpan data dan **function** yang memodifikasinya harus diingat. Kekurangan **procedural programming** juga menjadi penyebab **“Software Crisis”** yang terjadi pada **industry software** dimasanya. Kekuranganya diantara lain adalah :

1.	Terfokus pada **function** daripada data.
2.	Pada program dengan skala yang besar, sulitnya melakukan identifikasi global data dan **function** yang mengubahnya 
3.	Semakin banyak **global data** yang digunakan kemungkinan **error** semakin meningkat dan sulitnya **maintenance code**.
4.	Sulitnya mengelola intergritas data
5.	Modifikasi pada **global** data artinya memodifikasi seluruh **function** yang terikat dengan **global data**.
Sehingga untuk mengatasi **software crisis** ini **Object Oriented Programming** diperkenalkan untuk mengatasi kekurangan yang dimiliki oleh **Procedural Oriented Programming**. 

---------------------

