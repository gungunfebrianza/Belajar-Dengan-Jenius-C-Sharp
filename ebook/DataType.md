# Belajar Dengan Jenius C#

## Penulis : Gun Gun Febrianza

## C# Data Types

Jika sebelumnya anda telah belajar bahasa pemrograman C, maka anda pasti memahami bahwa struktur dari bahasa pemrograman C adalah sekumpulan **functions** dan **data types**.

Jika sebelumnya juga anda telah mempelajari bahasa pemrograman C++, maka anda pasti memahami bahwa struktur dari bahasa pemrograman C++ adalah sekumpulan **functions** dan **classes**.

Pada bahasa pemrograman C#,  strukturnya dibentuk dari sekumpulan **type declaration**.

C# mendukung dua jenis **types** yaitu **value types** dan **reference types**. Saat inisiasi seluruh nilai dari **value types** secara otomatis diberi nilai nol dan seluruh **reference types** secara otomatis diisi dengan **null value** saat inisiasi.

### Value Types

Secara **internal value types** menyimpan **data** secara langsung dan di alokasikan di dalam **Stack**.  

| Type    | Size     | Range                                                        | Description                   |
| ------- | -------- | ------------------------------------------------------------ | ----------------------------- |
| sbyte   | 8-bits   | **-128** to **127**                                          | Signed Byte                   |
| byte    | 8-bits   | **0** to **255**                                             | Unsigned Byte                 |
| short   | 16-bits  | **-32,768** to **32,767**                                    | Short Integer                 |
| ushort  | 16-bits  | **0** to **65,535**                                          | Unsigned Short Integer        |
| int     | 32-bits  | **-2,147,483,648** to **2,17483,648**                        | Integer                       |
| uint    | 32-bits  | **0** to **4,294,967,295**                                   | Unsigned Integer              |
| long    | 64-bits  | **-9223372036854775808** to **9223372036854775808**          | Long integer                  |
| ulong   | 64-bits  | **0** to **18,446,744,073,709,551,615**                      | Unsigned Long Integer         |
| char    | 16-bits  | **U+0000–U+ffff**                                            | Unicode Character             |
| float   | 32-bits  | **-3.402823E+38** to **3.402823E+38**, 7-digit precision     | Floating-point Integer        |
| double  | 64-bits  | **-1.79769313486232E+308** to **1.79769313486232E+308,<br/>15-digit precision** | Double Floating-point Integer |
| bool    | 1-bit    | **true, false**                                              | Logical                       |
| decimal | 127-bits | **-79228162514264337593543950335** to<br/>**79228162514264337593543950335**, 28-digit precision |                               |



### Reference Types

**Common Language Infrastructure (CLI)** mendukung berbagai tipe seperti :

- Classes
- Arrays
- Delegates
- 

Secara **internal reference types** menyimpan **data reference** dari **memory address** dan di alokasikan di dalam **Heap**.

---------------------

