# Belajar Dengan Jenius C#

## Penulis : Gun Gun Febrianza

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

<img src="assets/pinvoke1.PNG" style="zoom:67%;" />

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

​	**Passes address of thunk** sebagai **callback parameter**.<img src="../assets/pinvoke-callback.PNG" alt="pinvoke-callback" style="zoom:67%;" />

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

### CIL

Kompilasi menggunakan **Two-stage compilation** :

- **C# Compiler** : **C# Code** -> CIL
- **JIT Compiler** : CIL -> **Native Code**

<img src="../assets/2stagecompilation.png" style="zoom:67%;" />

### Common Intermediate Language

- **Assembly**-**like** **statement**
- Terdapat **Clasess**, **structs**, **inheritance** & **methods**

Contoh CIL :

```c#
.assembly extern mscorlib {} //automatically added
.assembly hello {}
.class Program {
	.method static public void Main() cil managed {
	.entrypoint //designates this method as the entry pt
	.locals init (string name) //create a local var
        ldstr “World" //load the string onto eval stack
        stloc.0 //store the string into the first local var
        ldstr "Hello, {0}!"
        ldloc name //load local var onto eval stack
        call void [mscorlib] System.Console::WriteLine(string, object) 
    	//call method with stack items as params
        ret
	}
}
```

