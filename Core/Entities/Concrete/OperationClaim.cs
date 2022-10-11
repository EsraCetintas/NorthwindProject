namespace Core.Entities.Concrete
{
    public class OperationClaim:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public OperationClaim(int id, string name)
        {
            Id = id;
            Name = name;    
        }

        public OperationClaim()
        {

        }
    }

}
