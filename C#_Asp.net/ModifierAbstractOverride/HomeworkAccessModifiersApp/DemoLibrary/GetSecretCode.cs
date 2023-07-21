namespace DemoLibrary
{
    public class GetSecretCode : SecureData
    {
        public string GetCode()
        {
            return SecretCode();
        }
    }

}
