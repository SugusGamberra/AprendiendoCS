## 🎯 Primer contacto con C# y la plataforma .NET

En esta sesión empezamos a trabajar con **C# dentro de la plataforma .NET**, trasladando una aplicación ya conocida desde Java para entender **qué cambia y qué se mantiene** 🔄

> El código que hemos trasladado desde JAVA es el siguiente 👉🏻[CÓDIGO JAVA](https://github.com/SugusGamberra/AprendiendoJAVA/tree/main/M0485.PRG.P008.Menu/menu/src/aplicacion2)

---

### 🛠️ Entorno de trabajo

Usamos **Visual Studio Community** para desarrollo en .NET.

🔧 Si aún no tienes VS Community los enlaces están [aquí](../../README.md). Durante la instalación:

* Seleccionamos **Desarrollo de escritorio de .NET**
* Con eso es suficiente para trabajar con aplicaciones de consola, escritorio y más 🚀

Creamos un proyecto nuevo:

* Tipo **Aplicación de consola (multiplataforma)**
* Versión **.NET 8.0** 👉 tiene **soporte y mantenimiento a largo plazo**

---

### 🧱 Código inicial de un proyecto .NET

Lo primero que aparece es una estructura base con:

* Un `namespace`
* Una clase `Program`
* Un método `Main`

Aquí vemos por primera vez el modificador **`internal`**, que cambiamos a **`public`**:

```cs
namespace MO485.PRG.P01.Menu.Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
```

📌 **Diferencia clave**:

* `public` → accesible desde cualquier parte del proyecto
* `internal` → solo accesible dentro del mismo ensamblado

Esto lo iremos profundizando más adelante 😉

---

### 🌐 .NET vs C#

Es importante no confundir conceptos:

* 🧩 **.NET** → es la **plataforma**
* ✍️ **C#** → es el **lenguaje**
* Otros lenguajes como **VB** también funcionan sobre .NET

C# es el lenguaje más usado, pero **no es el único** ⭐

---

### ⚙️ ¿Cómo funciona .NET por dentro?

Todos los lenguajes .NET siguen el mismo proceso interno:

1. Código fuente (C#, VB, etc.)
2. Compilación a **MSIL** (lenguaje intermedio)
3. Se genera un **assembly** (`.exe` o `.dll`) con metadatos
4. En ejecución, el **CLR** convierte MSIL a código máquina usando **JIT**

👉 Esto hace que el código sea **independiente del lenguaje y del hardware** 🧠

---

### 🧩 Namespaces y estructura

Los **namespaces** en C# cumplen el mismo papel que los **packages en Java**:

* Organizan el código
* Evitan conflictos de nombres
* Reflejan la estructura del proyecto

---

### 🔁 Reutilización del diseño de la aplicación

La aplicación mantiene la misma idea que en Java:

* 🚀 [Clase principal](./MO485.PRG.P01.Menu.Net/aplicacion3/ProgramMain.cs) → arranque del programa
* ⚙️ [Lógica](./MO485.PRG.P01.Menu.Net/aplicacion3/Logica.cs) → funcionamiento de la calculadora
* 🖥️ [Interfaz de usuario](./MO485.PRG.P01.Menu.Net/aplicacion3/InterfazUsuario.cs) → comunicación con el usuario

Se reutiliza:

* Menú
* Operaciones
* Separación de responsabilidades

Esto demuestra que **un buen diseño se puede trasladar entre lenguajes** 💙

---

### ⌨️ Entrada de datos en consola

En C#:

* La lectura por consola se hace con métodos propios del lenguaje
* Los datos llegan como **texto** y deben convertirse a número para operar

📌 Algunas partes (como interfaz gráfica) **dan error o quedan pendientes**, y se verán en la próxima sesión.

---

### 🧠 Ideas clave de la sesión

✅ Diferenciar lenguaje y plataforma

✅ Entender el ciclo de compilación en .NET

✅ Reconocer similitudes Java ↔ C#

✅ Valorar la importancia de un diseño reutilizable

> Seguimos construyendo base sólida para los próximos días 🚀