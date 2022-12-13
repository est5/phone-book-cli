namespace Cli.Model;
public class Contact
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}\nPhone: {PhoneNumber}";
    }
}
