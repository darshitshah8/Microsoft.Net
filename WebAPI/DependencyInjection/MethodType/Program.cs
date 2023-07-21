
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
        var emailService = services.GetRequiredService<IEmailService>();
        userService.RegisterUser("example@example.com", emailService);

        Console.ReadLine();
    }
}
