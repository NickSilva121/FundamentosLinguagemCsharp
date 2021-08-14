using System;
using System.Collections.Generic;
using System.Text;

namespace MaoNaMassa
{
    class Conta
    {
        public int numero;
        public double saldo;
        public Cliente titular;

        public bool Saque(double valoraSerSacado)
        {
            if (valoraSerSacado > this.saldo || valoraSerSacado < 0)
            {

                return false;
            }
            else
            {
                if (this.titular.MaiorDeIdade())
                {
                    this.saldo -= valoraSerSacado;

                    return true;
                }
                else
                {
                    if(valoraSerSacado <= 200)
                    {
                        this.saldo -= valoraSerSacado;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    return false;
                }
            }
        }
    }
}
