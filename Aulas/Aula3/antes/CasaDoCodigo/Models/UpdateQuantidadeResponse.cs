using CasaDoCodigo.aula3.antes.Models.ViewModels;
using CasaDoCodigo.Models;

namespace CasaDoCodigo.aula3.antes.Models
{
    public class UpdateQuantidadeResponse
    {
        public UpdateQuantidadeResponse(ItemPedido itemPedido, CarrinhoViewModel carrinhoViewModel)
        {
            ItemPedido = itemPedido;
            CarrinhoViewModel = carrinhoViewModel;
        }

        public ItemPedido ItemPedido { get; }
        public CarrinhoViewModel CarrinhoViewModel { get; } 
    }
}
