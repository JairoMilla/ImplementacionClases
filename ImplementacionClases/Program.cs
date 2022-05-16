// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using ImplementacionClases.Utils;

// Console.WriteLine(ConsoleUtils.Saludar("Jairo")); 

/*
 * Console.Write("Hola");
 * Console.Write(" Mundo");
*/

/*
// Cambio de colores
Console.BackgroundColor =ConsoleColor.DarkBlue;
Console.ForegroundColor =ConsoleColor.White;
*/

/*
// Input de consola - Output de consola 
Console.Write("Escriba un nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine($"Hola {nombre}");
*/

while (Menu())
{
    Console.ReadKey(); //Pausa ó solicitar una tecla
}

static bool Menu()
{
    bool continuar = true;

    Console.Clear(); // Limpiar la pantalla
    Console.Title = "Ejercicio Menú + Clases";

    Console.WriteLine("Menú de opciones");
    Console.WriteLine("--------------------");
    Console.WriteLine("1) Listar Datos");
    Console.WriteLine("2) Agregar Datos");
    Console.WriteLine("");
    Console.WriteLine("0) Salir");
    Console.WriteLine("");
    Console.Write("Ingrese una opción: ");

    String opcion = Console.ReadLine().Trim(); // Trim = " 1 " => "1"

    switch (opcion)
    {
        case "1":
            Console.WriteLine("Escogió la opción 1");
            break;
        case "2":
            Console.WriteLine("Escogió la opción 2");
            OpcionInsertar();
            break;
        case "0":
            Console.WriteLine("Saliendo de la consola...");
            continuar = false;
            break;
        default:
            Console.WriteLine("Opción no valida");
            break;
    }
    return continuar;
}

static void OpcionInsertar()
{
    try
    {
        Console.WriteLine("Ingrese los datos a ingresar");
        Console.WriteLine("Ingrese el id");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la temperatura");
        float temperatura = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el flujo");
        float flujo = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el nivel");
        float nivel = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el voltaje");
        float voltaje = float.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Ingrese correctamente los datos e intente otra vez");
        
    }
    /*
        int id;
        float flujo;
        float nivel;
        float temperatura;
        float voltaje;
    */



    /*
    // 1) cualquier cosa a string
    int i = 5;
    i.ToString();

    // 2) Convert (a cualquier tipo)
    int convertido = Convert.ToInt32("-100");

    // 3) Conversión explicita
    int test = 12345;
    float conDecimales = (float)test;

    // 4) conversión implicita
    int otroTest = 123456;
    float otroDecimal = otroTest;

    // 5) A traves de clases de tipos de dato
    string unEnteroSinConvertir = "98";
   */

}