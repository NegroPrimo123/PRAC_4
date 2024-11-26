public class User
{
    public int Id { get; set; }

    public string Firstname { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public int Age { get; set; }

    public User(string firstname, string username, string password, int age)
    {
        Firstname = firstname;
        Username = username;
        Password = password;
        Age = age;
    }
}
