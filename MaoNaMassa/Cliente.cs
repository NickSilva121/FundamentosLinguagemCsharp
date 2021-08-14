namespace MaoNaMassa
{
    public class Cliente
    {
        public string nome;
        public string cpf;
        public string rg;
        public string endereco;
        public int idade;

        public bool MaiorDeIdade(){
            return this.idade >= 18;
        }
    }
}