# Belajar Dengan Jenius C#

## Penulis : Gun Gun Febrianza

## Process

Ketika suatu **program** yang tersimpan di dalam **hardisk** di muat ke dalam **memory**, maka program tersebut akan menjadi suatu **process**. Pada kajian **operating system**, **process** adalah sebuah **address space** dalam **memory**. Setiap aplikasi baik itu **dekstop**, **web** atau **mobile application** memerlukan **process** agar dapat berjalan.

**Process** memberikan jaminan keamanan pada sebuah **program** agar tidak mengalami konflik dengan **program** lainnya, mencegah terjadinya insiden dimana alokasi data dari suatu **process** dapat dibaca oleh **process** lainnya. Sistem operasi memberikan sebuah model isolasi agar program dapat dijalankan dan dihentikan secara independen.



---------------------

## Threading

Konsep **threading**  membuat aplikasi C# yang kita buat dapat melakukan berbagai operasi sekaligus dalam satu waktu.Sebuah **Process** dapat memiliki satu atau lebih **thread** untuk melakukan **multitasking**. **Thread** dapat digunakan untuk melakukan **multitasking**

Sebuah **process** dieksekusi oleh **processor** dengan memanfaatkan **Program Counter (PC)** untuk melacak instruksi selanjutnya yang akan dieksekusi, **CPU Register** dan **Signalling**.

**Thread** adalah sekumpulan instruksi (**set of instructions**) di dalam sebuah **program** yang dapat dieksekusi secara independen, sebuah **thread** memiliki **Program Counter (PC)** dan sekumpulan **register** (**set of registers**). 

Sebuah **process** dapat memiliki dua atau lebih **threads** yang dapat berbagi **data** dan **resources**, jika kita ingin melakukan sharing **resources** antar **threads** diperlukan kecermatan agar tidak terjadi **deadlock**.

Sebuah sistem operasi juga melakukan manajemen **Thread Pool** yang di dalamnya terdapat sekumpulan **threads**, menunggu pekerjaan yang akan dialokasikan agar dapat dieksekusi secara **concurrent**. 

Menggunakan **threads** dari dalam **thread pools** lebih baik dari pada melakukan inisiasi **thread** baru, dengan begitu kita dapat mencegah **delay** yang disebabkan dari proses pembuatan **thread** dan penghapusan **thread**. Hal ini membuat performance aplikasi menjadi lebih baik.