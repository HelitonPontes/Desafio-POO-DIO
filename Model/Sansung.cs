using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Sansung : Smartphone
    {
        public override void InstalarAplicativo(string lojaApp, string nomeApp)
        {
            Console.WriteLine($"Entre na loja oficial: {lojaApp}. Nome APP: {nomeApp} ");
        }
    }
}
