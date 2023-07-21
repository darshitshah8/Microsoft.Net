// METHOD
public class UserService
{
    public void RegisterUser(string email, IEmailService emailService)
    {
        emailService.SendEmail(email, "Welcome to our application", "Thank you for registering!");
    }
}
