using CustomAuthentication.InputTypes;
using CustomAuthentication.Validation;

namespace CustomAuthentication.Type
{
    public class Mutation
    {
            public string Register([Service] IAuthLogic authLogic, RegisterInputType registerInput)
            {
                return authLogic.Register(registerInput);
            }
    }
}
