//Registrar los datos de una persona, nombre, apellido, sexo y edad
using System;
struct Persona
{
    public string nombre;
    public string apellido;
    public Boolean sexo;
    public int edad;
}
class Program()
{
    static Persona[] personas = new Persona[10];
    public static void agregar(string nom, string ape, int edad, Boolean sex, int posicion)
    {
        Persona per = new Persona();
        per.nombre = nom;
        per.apellido = ape;
        per.edad = edad;
        per.sexo = sex;
        personas[posicion] = per;
        Console.Beep();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Registro guardado.");
        Console.ResetColor();
        
    }
    public static void PedirDatos(int pos)
    {
        string nombre;
        string apellido;
        bool sexo;
        int edad;

        Console.Write("Dime tu nombre: ");
        nombre = Console.ReadLine();
        Console.Write("Dime tu apellido: ");
        apellido = Console.ReadLine();
        Console.Write("Dime tu sexo [True: Hombre / False: Mujer]: ");
        sexo = Boolean.Parse(Console.ReadLine());
        Console.Write("Dime tu edad: ");
        edad = int.Parse(Console.ReadLine());

        agregar(nombre, apellido, edad, sexo, pos);
    }

    public static void Main()
    {
       
    }
    
}

