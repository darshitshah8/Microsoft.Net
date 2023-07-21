// PROPERTY TYPE
public class UserService
{
    public IEmailService EmailService { get; set; }

    public void RegisterUser(string email)
    {
        EmailService.SendEmail(email, "Welcome to our application", "Thank you for registering!");
    }
}
