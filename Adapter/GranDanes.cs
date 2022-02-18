using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class GranDanes : RazasPerros
    {
        Rottweiler Rottweiler = new Rottweiler();

        public override void Comer()
        {
            Rottweiler.Protector();
        }

        public override void Ladrido()
        {
            Rottweiler.Delicado();
            Rottweiler.Protector();
        }

        public override void Olfato()
        {
            Rottweiler.Adiestrados();
        }

        public override void Velocidad()
        {
            Rottweiler.Inteligentes();
            Rottweiler.Fuerte();
        }

    }
}
