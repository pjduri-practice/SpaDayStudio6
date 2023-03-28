namespace SpaDay6.Models
{
    public class User
    {
        public int Id { get; }
        public int nextId = 0;
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //public string VerifyPassword { get; set; }

        public User()
        {
            Id = nextId;
            nextId++;
        }

        public User(string username, string email, string password/*, string verifyPassword*/)
        {
            Username = username;
            Email = email;
            Password = password;
            //VerifyPassword = verifyPassword;
        }

    }
}
