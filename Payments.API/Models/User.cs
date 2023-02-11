namespace Payments.API.Models
{
    public class User : Entity
    {
        public User(string id, string name): base (id)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
