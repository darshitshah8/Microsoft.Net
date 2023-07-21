// CONSTROCTOR TYPE
public class UserService
{
    private readonly IEmailService _emailService;

    public UserService(IEmailService emailService)
    {
        _emailService = emailService;
    }

    public void RegisterUser(string email)
    {
        _emailService.SendEmail(email, "Welcome to our application", "Thank you for registering!");
    }
}
