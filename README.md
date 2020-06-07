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

Contoh penggunaan **P/Invoke** :

```c#
using System.Runtime.InteropServices;
namespace HelloWorld {
	class MyClass {
		[DllImport(“user32.dll”, CharSet=CharSet.Ansi)]
		static extern int MessageBox(int hwnd, string msg, string caption, int t);
			public static void Main() {
				MessageBox(0, "Hello World!", "Caption", 0);
			}
		}
	}
```

Hasil dari kode di atas memiliki perbedaan :

![](C:\Users\Gun Gun Febrianza\Pictures\Belajar-Dengan-Jenius-C-Sharp\assets\pinvoke1.PNG)

Langkah-langkah dalam melakukan **P/Invoke** :

- Lokasi tempat untuk implementasi **Dll**
- Muat **Dll** ke dalam **memory**
- Temukan **address** dari **function**
- **Push Arguments** ke dalam **stack** kemudian **marshaling data**
- **Transfer Control** untuk **unmanaged code**

