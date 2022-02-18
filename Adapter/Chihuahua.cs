using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Chihuahua : RazasPerros
    {
        public override void Comer()
        {
            Console.WriteLine("El perro Chihuahua esta comiendo");
        }

        public override void Ladrido()
        {
            Console.WriteLine("El perro Chihuahua esta ladrando");
        }

        public override void Olfato()
        {
            Console.WriteLine("El perro Chihuahua tiene buen olfato");
        }

        public override void Velocidad()
        {
            Console.WriteLine("El perro Chihuahua es veloz");
        }
    }
}
