namespace Payments.API.Models
{
    public class Payment : Entity
    {
        public Payment(string id, string description, decimal value, string userId) : base(id)
        {
            Description = description;
            Value = value;
            UserId = userId;
        }
        public string Description { get; private set; }
        public decimal Value { get; private set; }

        public string UserId { get; private set; }
    }
}
