﻿using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Infrastructure.Contexts;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Mapster;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using FluentValidation;
using FluentValidation.AspNetCore;
using Core.Services;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDatabase(configuration);
        services.AddRepositories();
        services.AddServices();
        services.AddMapping();
        services.AddValidation();

        return services;
    }

    public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Bootcamp");

        services.AddDbContext<BootcampContext>(options =>
        {
            options.UseNpgsql(connectionString);
        });

        return services;
    }

    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IBankRepository, BankRepository>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddScoped<ICurrencyRepository, CurrencyRepository>();
        services.AddScoped<ICreditCardRepository, CreditCardRepository>();
        services.AddScoped<IAccountRepository, AccountRepository>();
        services.AddScoped<IPromotionRepository, PromotionRepository>();
        services.AddScoped<IEnterpriseRepository, EnterpriseRepository>();
        services.AddScoped<IRequestRepository, RequestRepository>();
        services.AddScoped<IServicePaymentRepository, ServicePaymentRepository>();
        services.AddScoped<IDepositRepository, DepositRepository>();
        services.AddScoped<IWithdrawalRepository, WithdrawalRepository>();
        services.AddScoped<ITransferRepository, TransferRepository>();

        

        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IBankService, BankService>();
        services.AddScoped<ICustomerService, CustomerService>();
        services.AddScoped<ICurrencyService, CurrencyService>();
        services.AddScoped<ICreditCardService, CreditCardService>();
        services.AddScoped<IJwtProvider, JwtProvider>();
        services.AddScoped<IAccountService, AccountService>();
        services.AddScoped<IPromotionService, PromotionService>();
        services.AddScoped<IEnterpriseService, EnterpriseService>();
        services.AddScoped<IRequestService, RequestService>();
        services.AddScoped<IDepositService, DepositService>();
        services.AddScoped<IServicePaymentService, ServicePaymentService>();
        services.AddScoped<IWithdrawalService, WithdrawalService>();
        services.AddScoped<ITransferService, TransferService>();
        
        


        return services;
    }

    public static IServiceCollection AddMapping(this IServiceCollection services)
    {
        var config = TypeAdapterConfig.GlobalSettings;
        config.Scan(Assembly.GetExecutingAssembly());

        services.AddSingleton(config);
        services.AddScoped<IMapper, ServiceMapper>();

        return services;
    }

    public static IServiceCollection AddValidation(this IServiceCollection services)
    {
        services.AddFluentValidation();
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        return services;
    }
}