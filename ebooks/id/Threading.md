# Belajar Dengan Jenius C#

## Penulis : Gun Gun Febrianza

## Process

Ketika suatu **program** yang tersimpan di dalam **hardisk** di muat ke dalam **memory**, maka program tersebut akan menjadi suatu **process**. Pada kajian **operating system**, **process** adalah sebuah **address space** dalam **memory**. Setiap aplikasi baik itu **dekstop**, **web** atau **mobile application** memerlukan **process** agar dapat berjalan.

**Process** memberikan jaminan keamanan pada sebuah **program** agar tidak mengalami konflik dengan **program** lainnya, mencegah terjadinya insiden dimana alokasi data dari suatu **process** dapat dibaca oleh **process** lainnya. Sistem operasi memberikan sebuah model isolasi agar program dapat dijalankan dan dihentikan secara independen.

**Performance** suatu aplikasi juga dipengaruhi oleh faktor **hardware** :

1. Kecepatan **CPU**
2. Jumlah **RAM**
3. Kecepatan **Hardisk** (5400 atau 7200 **RPM**)
4. Tipe **Disk** (**SSD** atau **HDD**)

Seluruh **Modern CPU** adalah **Microprocessor** yang berarti mereka tersimpan di dalam sebuah **chip** tunggal **Integrated Circuit** (**IC**).  Kebanyakan komputer hari ini telah memiliki lebih dari satu **CPU** sehingga dapat melakukan banyak sekali operasi secara simultan. 

### **Multi-core Processor**

Sebuah **Multi-core processor** memiliki lebih dari satu **processor** dalam satu **IC Chip** tunggal.  Sebagai contoh **dual-core processor** artinya terdapat dua **processor** dalam **1 IC Chip** dan **quad-core** artinya terdapat 4 **processor** dalam 1 **IC Chip**.

### Multitasking

**Multitasking** mengacu pada kemampuan suatu komputer untuk dapat menjalankan lebih dari satu **process** dalam satu waktu. Jumlah **process** yang dapat berjalan pada suatu sistem operasi secara proporsional dipengaruhi oleh jumlah **core-processor** yang tersedia.

**Single-core processor** dapat melakukan satu pekerjaan dalam satu waktu, **dual-core processor** dapat melakukan dua pekerjaan sekaligus dalam satu waktu, **quad-core processor** dapat melakukan empat pekerjaan sekaligus dalam satu waktu. 

Jika kita menambahkan konsep **CPU Schedulling** pada konteks kajian ini maka sebuah **CPU** dapat digunakan untuk menjalankan beberapa aplikasi sekaligus dalam satu waktu, semuanya dapat diwujudkan dengan memanfaatkan konsep **schedulling** atau **switching** yang diatur oleh **CPU Schedulling Algorithm**.

### Hyper-threading



---------------------

## Threading

Konsep **threading**  membuat aplikasi C# yang kita buat dapat melakukan berbagai operasi sekaligus dalam satu waktu.Sebuah **Process** dapat memiliki satu atau lebih **thread** untuk melakukan **multitasking**. **Thread** dapat digunakan untuk melakukan **multitasking**

Sebuah **process** dieksekusi oleh **processor** dengan memanfaatkan **Program Counter (PC)** untuk melacak instruksi selanjutnya yang akan dieksekusi, **CPU Register** dan **Signalling**.

**Thread** adalah sekumpulan instruksi (**set of instructions**) di dalam sebuah **program** yang dapat dieksekusi secara independen, sebuah **thread** memiliki **Program Counter (PC)** dan sekumpulan **register** (**set of registers**). 

Sebuah **process** dapat memiliki dua atau lebih **threads** yang dapat berbagi **data** dan **resources**, jika kita ingin melakukan sharing **resources** antar **threads** diperlukan kecermatan agar tidak terjadi **deadlock**.

Sebuah sistem operasi juga melakukan manajemen **Thread Pool** yang di dalamnya terdapat sekumpulan **threads**, menunggu pekerjaan yang akan dialokasikan agar dapat dieksekusi secara **concurrent**. 

Menggunakan **threads** dari dalam **thread pools** lebih baik dari pada melakukan inisiasi **thread** baru, dengan begitu kita dapat mencegah **delay** yang disebabkan dari proses pembuatan **thread** dan penghapusan **thread**. Hal ini membuat performance aplikasi menjadi lebih baik.