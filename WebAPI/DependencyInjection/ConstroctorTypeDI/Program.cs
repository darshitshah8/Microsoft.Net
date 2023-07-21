using Microsoft.Extensions.DependencyInjection;

public static class Program
{
    static void Main()
    {
        var services = new ServiceCollection()
            .AddTransient<IEmailService, EmailService>()
            .AddTransient<UserService>()
            .BuildServiceProvider();

        var userService = services.GetRequiredService<UserService>();
        userService.RegisterUser("example@example.com");

        Console.ReadLine();
    }
}
