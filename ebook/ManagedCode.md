# Belajar Dengan Jenius C#

## Penulis : Gun Gun Febrianza

## Managed Code

**Managed code** atau **managed module** dieksekusi dan di bawah kontrol lingkungan **Common language runtime (CLR)** [1], **Managed module** adalah standar untuk **32-bit Microsoft Windows** **portable executable (PE32) file** atau standar untuk **64-bit** **Windows portable executable (PE32+) file** yang membutuhkan **Common language runtime (CLR)** agar bisa berjalan [2]. 

Hasil akhir dari pemrograman **CLR-Compliance a**dalah **managed code** atau **managed module** yaitu berupa **executable** atau **dynamic link library**. Perbedaan antara keduanya adalah pada **executable** tersedia sebuah **entrypoint**  sebagai tempat eksekusi pertama sementara pada **dynamic link library** tidak terdapat sebuah **entrypoint**.

Kompilasi **IL code** ke **Managed Module** :

![](../assets/CompileILCode.png)

Pada sebuah **managed** **module** terdapat beberapa **part** :

| Element     | Description                                                  |
| ----------- | ------------------------------------------------------------ |
| PE32 Header | Standar **PE Header** untuk **Windows**, jika **header** menggunakan **format PE32 file** bisa berjalan pada versi **32-bit** atau **64-bit**  sistem operasi **Windows**. Jika **header** menggunakan **format PE32+** maka **binary file** hanya bisa dieksikusi pada versi **64-bit** sistem operasi **windows**. Untuk **modules** yang hanya memiliki **IL code**, seluruh informasi yang ada pada **header PE32(+)** diabaikan. Untuk **modules** yang mengandung **native CPU code** maka **header** mengandung informasi tentang **native** **CPU code** yang dituju. |
| CLR Header  | Mengandung informasi tentang pembuatan **managed module** itu sendiri. Pada **header** terdapat informasi versi **CLR** yang dibutuhkan dan lokasi dari **module’s** **metadata**, **resources**, dan sebagainya. |
| Metadata    | Mengandung informasi yang menjelaskan **class** dan **types** yang digunakan di dalam sebuah **managed code** baik itu **executable** ataupun **dynamic link library.** |
| IL Code     | Kode yang diproduksi kompiler, saat **runtime CLR** akan menerjemahkan **IL code** ke **native code**. |



---------------------

[1] Geschwinde & Hans-Jücrgen*.* "Introduction - Managed Code", *Mono Kick Start.* : Sams Publishing. 2002.

[2] Richter*. Common Language Runtime Via C#*. Microsoft Press, 2010