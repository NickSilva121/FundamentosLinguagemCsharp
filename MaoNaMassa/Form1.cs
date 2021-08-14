using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaoNaMassa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta contaAndre = new Conta();
            Cliente clienteAndre = new Cliente();

            clienteAndre.nome = "André";
            clienteAndre.endereco = "Rua João Tarcísio de Almeida, 250";
            clienteAndre.cpf = "106022439-98";
            clienteAndre.rg = "6991023";
            clienteAndre.idade = 18;
            contaAndre.numero = 1;
            contaAndre.saldo = 1500.00;

            contaAndre.titular = clienteAndre;

            MessageBox.Show("Cliente: " + clienteAndre.nome + "-----" + contaAndre.numero
                            + "\nSaldo em Conta: " + contaAndre.saldo
                            + "\n------------------------------------------------"
                            + "\nInformações Adicionais"
                            + "\n------------------------------------------------"
                            + "\nCPF: " + clienteAndre.cpf
                            + "\nRG: " + clienteAndre.rg
                            + "\nEndereço: " + clienteAndre.endereco);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conta contaAndre = new Conta();
            Cliente clienteAndre = new Cliente();

            contaAndre.titular = clienteAndre;
            contaAndre.saldo = 1500;
            clienteAndre.idade = 18;
            bool sacou = contaAndre.Saque(300.0);
            if (sacou = true)
            {
                MessageBox.Show("Saldo da Conta após saque: " + contaAndre.saldo);
            }
            else
            {
                MessageBox.Show("Não foi possível sacar da conta");
            }
        }
    }
}
