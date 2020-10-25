namespace WebApi.Models.Users
{
  public class UpdateModel
    {
        public int Id { get; set; }
        public int Salary {get; set;}
        public string LoginName {get; set;}
        public string DisplayName {get; set;}
        public string Password { get; set; }
        public bool IsActive {get; set;}
        public string Country {get; set;}
        public string Address {get; set;}
        public string DateOfBirth {get; set;}
        public string File {get; set;}
 
    }
}