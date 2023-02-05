using Site.UI.Models;
using Site.UI.Repository.Interface;
using System.Security.Cryptography.X509Certificates;

namespace Site.UI.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        public Order ObterPedido()
        {
            return new Order();
        }
    }
}
