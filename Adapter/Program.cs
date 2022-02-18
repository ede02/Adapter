using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            RazasPerros perro1 = new Chihuahua();
            perro1.Comer();
            perro1.Ladrido();
            perro1.Olfato();
            perro1.Velocidad();

            RazasPerros perro2 = new Doberman();
            perro2.Comer();
            perro2.Ladrido();
            perro2.Olfato();
            perro2.Velocidad();

            RazasPerros perro3 = new GranDanes();
            perro3.Comer();
            perro3.Ladrido();
            perro3.Olfato();
            perro3.Velocidad();

            Console.ReadKey();
        }
    }
}
