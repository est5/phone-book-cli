using Cli.DB;
using Cli.Model;

var ctx = new PhoneBookContext();
ctx.Contacts.Add(new Contact { Name = "Ilyha", PhoneNumber = "1488-322-228" });
ctx.SaveChanges();

var contact = ctx.Contacts.First();
System.Console.WriteLine(contact);
