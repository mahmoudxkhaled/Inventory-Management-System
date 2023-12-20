namespace Retail.Client;
public static class AddScopedConfigurationExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {

        IEnumerable<Type> instances = AppDomain.CurrentDomain.
            GetAssemblies().SelectMany(assembly => assembly.GetTypes()).
            Where(type => type.IsSubclassOf(typeof(IService)));

        foreach (var Service in instances) services.AddScoped(Service);
        return services;

    }

}
