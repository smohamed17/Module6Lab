namespace TeenHangout;

public class User
{
    // this is creating the user web base. By letting the user type in 
    // an Username, typing the age, and favorite color. 
    public string Username { get; set; }
    public int Age { get; set; }
    public string FavoriteColor { get; set; }

    public User(string username, int age, string favoriteColor)
    {
        Username = username;
        Age = age;
        FavoriteColor = favoriteColor;
    }

}