using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Doberman : RazasPerros
    {
        public override void Comer()
        {
            Console.WriteLine("El perro Doberman esta comiendo");  
        }

        public override void Ladrido()
        {
            Console.WriteLine("El perro Doberman esta ladrando");
        }

        public override void Olfato()
        {
            Console.WriteLine("El perro Doberman tiene buen olfato");
        }

        public override void Velocidad()
        {
            Console.WriteLine("El perro Doberman es veloz");
        }

    }
}
