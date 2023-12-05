﻿using Microsoft.Extensions.DependencyInjection.Extensions;

namespace CarbookWebAPI.Cars;

public static class CarServiceRegistration
{
    public static IServiceCollection AddCarServices(this IServiceCollection services)
    {
        // services.TryAddScoped<CarService>();
        // services.TryAddScoped<ICarService>(provider =>
        // {
        //     return new LoggedCarService(provider.GetRequiredService<CarService>(), provider.GetRequiredService<ILogger<ICarService>>());
        // });
        
        services.TryAddScoped<ICarService, CarService>();
        services.TryDecorate<ICarService, LoggedCarService>();
        
        services.TryAddScoped<ICarProvider, CarProvider>();
        services.TryAddScoped<ICarModelProvider, CarModelProvider>();
        services.TryAddScoped<ICarMileageProvider, CarMileageProvider>();
        services.TryAddScoped<ICarProductionDateProvider, CarProductionDateProvider>();

        return services;
    }
}