using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class ContaPoupanca : ContaCorrente
    {
        public ContaPoupanca(int agencia,int numero):base(agencia,numero)
        {
        }
        public int Agencia {get;}
        public int Numero { get; }


    }
}
