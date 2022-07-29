using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            //this.saldo = valor;
            base.saldo = valor;
            // pode ser qualquer uma, mas o base. indica que é uma propriedade da class parent
        }
    }
}