using System.Collections.Generic;
using MVC.Models;
using MVC.Views;

namespace MVC.Controllers
{
    public class ProdutoController
    {
        Produto produtoModel =  new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void Listar(){
            produtoView.MostrarNoConsole( produtoModel.Listar() );
        } 
        
        public void Buscar(string _preco){
            List<Produto> lista = produtoModel.Listar();
            lista  = lista.FindAll(x => x.Preco == float.Parse(_preco));
            produtoView.MostrarNoConsole( lista );
        }
    


    }
}