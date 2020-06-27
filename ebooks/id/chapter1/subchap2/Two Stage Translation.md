# Belajar Dengan Jenius C#

## Penulis : Gun Gun Febrianza

## Two-Stage Translation

**Modern-day Compilers** menggunakan **Two-stage Translation** untuk mengeksekusi **high-level language** agar bisa berjalan diberbagai arsitektur mesin komputer. Sehingga tantangan untuk menghadapi perbedaan bahasa **Assembly** bisa dihadapi, sebab setiap **Architectures** memiliki bahasa **Assembly** yang berbeda beda sebagai contoh pada **Architectures Intelx86** dan **ARM** keduanya memiliki **Assembly Language** yang berbeda. 

Dengan begitu peluang besar untuk membuat kompiler yang bisa berjalan pada **Multiple Architectures** bisa diwujudkan. 
Untuk diwujudkan sebuah **Intermediate Code** telah dikembangkan dalam dunia pemrograman. 

Pada **stage** pertama kompiler menerjemahkan **high-level language** ke **Intermediate-level Code** dan stage kedua menerjemahkan **Intermediate-level** **Code** ke **Low-level Machine Code**. 

**Stage** pertama penerjemahan terdiri dari :

1. **Lexical Analysis**, 
2. **Parsing**, 
3. **Semantic Analysis** dan 
4. **Code Generation** dengan **Target Language** untuk memproduksi **Intermediate Language**.

![](../../../assets/TwoStageTranslation.png)

Sebagai contoh kompiler yang digunakan untuk pemrograman C# menggunakan **schema Two Stage Translation. CIL Generator** akan menghasilkan **target language** berupa **IL Assembly.** 

**Stage** selanjutnya adalah **IL Assembly** sebagai **intermediate language** diterjemahkan kedalam **Low-level Machine Code** oleh sebuah program bernama **IL Assembler.** 

![](../../../assets/IntermediateLanguageTarget.png)

---------------------

