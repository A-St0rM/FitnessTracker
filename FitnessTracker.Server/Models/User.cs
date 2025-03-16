namespace FitnessTracker.Server.Models
{
    public class User
    {

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string userName, string password)
        {
            this.Username = userName;
            this.Password = password;
        }

        public User()
        {
        }
    }
}
