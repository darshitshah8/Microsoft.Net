using GraphGLAPI.Models;

namespace GraphGLAPI.GqlTypes
{
    public class Subscription
    {
        [Subscribe]
        public Chocolate ChocolateAdd([EventMessage] Chocolate chocolate) => chocolate;
    }
}
