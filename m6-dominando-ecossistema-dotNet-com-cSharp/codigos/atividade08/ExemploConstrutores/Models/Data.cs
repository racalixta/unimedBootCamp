using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    public class Data
    {
        private int mes;
        private bool mesValido;

        public int GetMes()
        {
            return this.mes;
        }

        public void SetMes(int mes)
        {
            if(mes > 0 && mes <= 12)
            {
                this.mesValido = true;
                this.mes = mes;
            }
        }

        public int Mes 
        { 
            get
            {
                return this.mes;
            } 
            
            set
            {
                if(value > 0 && value <= 12)
                {
                    this.mes = value;
                    this.mesValido = true;
                }
            }
        }

        public void ApresentarMes()
        {
            if(this.mesValido)
            {
                System.Console.WriteLine($"\nEstamos no mês: {mes}\n");
            }
            else
            {
                System.Console.WriteLine($"\nMês inválido!\n");
            }
        }
    }
}