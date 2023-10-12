using intCoders.data.common.Repositories;
using Microsoft.EntityFrameworkCore;
using wap2.data.models.Modules.Products;

namespace wap2.data.sqlite.Repositories.Products;

public class CategoryRepository: SqLiteRepository<Category>
{
    public CategoryRepository(DbContext context) : base(context) { }
}

/*
public class UsandoCatgoryRepository
{
    private ObservableCollection<Category> _categories;
    public ObservableCollection<Category> Categories
    {
        get { return _categories; } 
        set { _categories = value; }
    }
    
    public void Load()
    {
        using (var sqLiteContext = new WapSqLiteContext())
        {
            var repo = new CategoryRepository(sqLiteContext);
            Categories = new ObservableCollection<Category>(repo.GetAll().ToList());
        }
    }

    public async Task AddNew()
    {
        var name = txtName.Text;
        
        using (var sqLiteContext = new WapSqLiteContext())
        {
            var repo = new CategoryRepository(sqLiteContext);
            await repo.SaveItem(new Category
            {
                Name = name,
                CreatedDate = DateTime.UtcNow
            });

            await sqLiteContext.SaveChangesAsync();
        }
    }
}
*/