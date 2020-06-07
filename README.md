# Belajar Dengan Jenius C#

## Penulis : Gun Gun Febrianza

### Content Table



--------------

## P/Invoke

P/Invoke digunakan agar kita dapat memanggil **unmanaged functions** di dalam sebuah **COM Object** dan **C/C++ dll (Dynamic LInk Library)**. Misal melakukan akses pada **Win32 API**.

Untuk mendeklarasikan sebuah **unmanaged functions**, gunakan :

```c#
DllImport dan static extern
```

```c#
[DllImport(“kernel32.dll”)]
static extern int GetProcessHeap();
```

