namespace Dbank.Models;

public class UsersClass
{
    static public int Id { get; } = 1;
    static public string Passport { get; set; } = "46 01 813113";

    public string Sername { get; set; }
    public string Name { get; set; }
    public string Patronymic { get; set; }

    public int Age { get; set; }
    public string CardNumber { get; set; }
}
