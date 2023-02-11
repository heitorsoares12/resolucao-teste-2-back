namespace Payments.API.Models
{
    public class Entity
    {
        public Entity(string id)
        {
            Id = id;
        }

        public string Id { get; private set; }
    }
}
