namespace CodingExercise001.ApiServer.Models.Users
{
    public class UserCreationRequestModel
    {
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}
