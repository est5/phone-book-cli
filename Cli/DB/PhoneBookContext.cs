using Cli.Model;
using Microsoft.EntityFrameworkCore;

namespace Cli.DB;
public class PhoneBookContext : DbContext
{
    public DbSet<Contact> Contacts { get; set; }
    public string DbPath { get; set; }

    public PhoneBookContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "phoneBook.db");
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}
