namespace eCommerceApp.Application.DTOs.Identity
{
    public class CreateUser : BaseModel
    {
        public required string FullName { get; set; }
        public required string confirmPassword { get; set; }
    }
}

