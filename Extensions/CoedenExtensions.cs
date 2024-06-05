
using Coeden.Models;
using Coeden.Services;


namespace Coeden.Extensions
{
  public static class CoedenExtensions
  {

    public static IServiceCollection AddCoedenServices(this IServiceCollection services,
    IConfiguration config)
    {
      services.Configure<TreeStoreDatabaseSettings>(config.GetSection("CoedenStoreDatabase"));
      services.AddSingleton<TreeService>();
      return services;
    }
  }
}