using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Rottweiler
    {
        bool _deli;
        bool _protec;
        bool _grand;

        public void Delicado()
        {
            if (_deli)
                Console.WriteLine("Los perros son delicados");
            else
            {
                _deli = true;
                Console.WriteLine("Perro delicado");
            }
        }

        public void Protector()
        {
            if (!_deli)
                Console.WriteLine("Imposible que un perro no sea delicado");
            else
            {
                _protec = true;
                Console.WriteLine("Perro protector");
            }
        }

        public void Grande()
        {
            if (_deli && _protec)
            {
                _grand = true;
                Console.WriteLine("Hay perros que tienen la cara grande");
            }
            else
            {
                Console.WriteLine("Los Rottweiler tienen la cara grande");
            }
        }

        public void Fuerte()
        {
            if (_grand)
            {
                _grand = false;
                Console.WriteLine("Los perros son fuertes");
            }
            else
            {
                Console.WriteLine("Los perros tienen fuerza");
            }
        }

        public void Inteligentes()
        {
            if (_deli)
            {
                Console.WriteLine("Los perros poseen sentido de inteligencia");
            }
            else
            {
                Console.WriteLine("Los perros son inteligentes");
            }
        }

        public void Adiestrados()
        {
            if (_protec)
            {
                _deli = false;
                Console.WriteLine("Los perros son adiestrados");
            }
            else
            {
                Console.WriteLine("Con buena adiestracion los perros tienen buena educacion");
            }
        }
    }
}

