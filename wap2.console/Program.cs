// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;
using wap2.data.models.Modules.Products;
using wap2.data.models.Modules.UserManagement;
using wap2.data.sqlite;
using wap2.data.sqlite.Repositories;
using wap2.data.sqlite.Repositories.Products;
using wap2.data.sqlite.Repositories.UserManagement;

Console.WriteLine("Hello, World!");

using (var context = new WapSqLiteContext())
{
    Console.WriteLine(context.Database.CanConnect());

    using (var command = context.Database.GetDbConnection().CreateCommand())
    {
        command.CommandText = "SELECT name from sqlite_master WHERE type='table'";
        context.Database.OpenConnection();
        using (var result = command.ExecuteReader())
        {
            while (result.Read())
            {
                Console.WriteLine(result.GetString(0));
            }
        }
    }

    var users = context.Users.ToList();
    var repo = new UserRepository(context);
    var items = repo.GetAll().ToList();

    Console.ReadLine();
}





using (var context = new WapSqLiteContext())
{
    var repo = new CategoryRepository(context);

    var items = repo.GetAll().ToList();

    var cat = new Category
    {
        Id = Guid.NewGuid(),
        Name = "Test",
    };

    await repo.SaveItem(cat);

    await context.SaveChangesAsync();
}   