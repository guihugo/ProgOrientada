using System;

//Metodos para controle de estoque

namespace Program
{
    class Produto
    {
       public string Nome;
       public double Price;
       public int Quantidade;

       public double ValorTotalEmEstoque()
       {
            return Price*Quantidade;
       }

       public void AdicionarQuantidade(int quantidade)
       {
            Quantidade += quantidade;
       }

       public void RetirarQuantidade(int quantidade)
       {
            Quantidade -= quantidade;
       }

        public override string ToString()
        {
            return Nome + ", $ " + Price + " Quantidade " + Quantidade + " Total: " + ValorTotalEmEstoque();
        }
    }
}
