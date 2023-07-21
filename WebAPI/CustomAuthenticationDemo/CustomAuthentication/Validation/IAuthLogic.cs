using CustomAuthentication.InputTypes;

namespace CustomAuthentication.Validation
{
    public interface IAuthLogic
    {
        string Register(RegisterInputType registerInput);
    }
}