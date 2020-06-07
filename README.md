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

### P/Invoke Example

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

<img src="C:\Users\Gun Gun Febrianza\Pictures\Belajar-Dengan-Jenius-C-Sharp\assets\pinvoke1.PNG" style="zoom:67%;" />

Langkah-langkah dalam melakukan **P/Invoke** :

- Lokasi tempat untuk implementasi **Dll**
- Muat **Dll** ke dalam **memory**
- Temukan **address** dari **function**
- **Push Arguments** ke dalam **stack** kemudian **marshaling data**
- **Transfer Control** untuk **unmanaged code**



### P/Invoke Callback

Sebuah **unmanaged code** dapat melakukan **call back** pada **managed code**

**Unmanaged parameter** adalah sebuah **function pointer**

Pada **managed code** pemberian **parameter** harus di delegasikan

**P/Invoke** membuat **callback thunk**

​	**Passes address of thunk** sebagai **callback parameter**.<img src="C:\Users\Gun Gun Febrianza\Pictures\Belajar-Dengan-Jenius-C-Sharp\assets\pinvoke-callback.PNG" alt="pinvoke-callback" style="zoom:67%;" />

### Callback Example

```c#
public class SampleClass {
	delegate bool CallBack(int hwnd, int lParam);
    
	[DllImport("user32.dll")]
	static extern int EnumWindows(CallBack x, int lParam);
    
	// report the window handle
	public bool Report(int hwnd, int lParam) {
		Console.Write(“Window handle is ” + hwnd);
		return true;
	}
    
	public static void Main() {
		CallBack myCallBack = new CallBack(Report);
		EnumWindows(myCallBack, 0);
	}
}
```

### C++/CLI

Untuk menulis  **Managed C++ Code**

- **Compile** dengan /**CLR**
- **Generate CIL** dari **C++**

Efektif untuk melakukan **native access** pada **C++ Libraries**

- Membuat **managed wrapper**