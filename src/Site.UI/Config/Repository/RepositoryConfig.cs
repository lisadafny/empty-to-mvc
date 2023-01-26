using Site.UI.Repository;
using Site.UI.Repository.Interface;

namespace Site.UI.Config.Repository
{
    public static class RepositoryConfig
    {
        public static void ConfigRepository(this IServiceCollection services)
        {
            services.AddTransient<IPedidoRepository, PedidoRepository>();
        }
    }
}
