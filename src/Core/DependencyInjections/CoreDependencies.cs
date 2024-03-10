using ButterflyCalc.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ButterflyCalc.Core.DependencyInjections;

public static class CoreDependencies
{
  public static IServiceCollection AddCoreDependencies(this IServiceCollection services)
  {
    services.AddTransient<ICalculationService, CalculationService>();

    return services;
  }
}