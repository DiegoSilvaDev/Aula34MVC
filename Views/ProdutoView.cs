using System.Collections.Generic;
using MVC.Models;

namespace MVC.Views
{
    public class ProdutoView
    {
        public void MostrarNoConsole(List<Produto> lista){
            foreach (Produto item in lista)
            {
                System.Console.WriteLine("{0:c} - {1}",item.Preco, item.Nome);
            }
        }
    }
}