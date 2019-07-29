using System;

namespace video15_ref_out
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorActual = 10;

            Actualizar(valorActual); //Comportamiento normal
            Console.WriteLine($"el valor es: {valorActual}");

            valorActual = 10;
            ActualizarRef(ref valorActual); //pasar por referencia
            Console.WriteLine($"el valor es: {valorActual}"); // imprime 12


            int valorActual2;
            ActualizarOut(out valorActual2);
            Console.WriteLine($"el valor es: {valorActual2}"); // imprime 13

            ObjEjemplo ejemploValor = new ObjEjemplo(10);
            ActualizarObj(ejemploValor);
            Console.WriteLine($"el valor es: {ejemploValor.Entero}"); // imprime 13

            Console.ReadKey();
        }

        public static void Actualizar(int valor)
        {
            valor += 5;
            Console.WriteLine($"el valor es: {valor}");
        }

        public static void ActualizarIn(in int valor)
        {
            // valor += 5; //Error
            Console.WriteLine($"el valor es: {valor}");
        }

        //Actualizar por referencia
        public static void ActualizarRef(ref int valor)
        {
            valor += 2;
        }

        //Crear utilizando out
        public static void ActualizarOut(out int valor)
        {
            valor = 13;
        }

        public static void ActualizarObj(ObjEjemplo obj)
        {
            obj.Entero = 25;
        }

    }

    public class ObjEjemplo
    {
        public int Entero { get; set; }

        public ObjEjemplo(int entero)
        {
            Entero = entero;
        }
    }
}
