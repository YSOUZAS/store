namespace Store.Data.Models
{
    public abstract class NamedEntity : Entity
    {
        public NamedEntity(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
