namespace Core.Entities.Concrete
{
    public class UserOperationClaim : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }

        public UserOperationClaim(int id, int userId, int operationClaimId)
        {
            Id = id;
            UserId = userId;
            OperationClaimId = operationClaimId;
        }
        public UserOperationClaim()
        {

        }
    }

}
