namespace EFM4.Models.Entity {
    public class Login {
        public Login(string username, byte[] password) {
            Username = username;
            Password = password;
        }

        public string Username { get; set; }
        public byte[] Password { get; set; }
    }
}
