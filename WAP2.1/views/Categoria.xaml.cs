using Microsoft.Toolkit.Mvvm.Input;
using wap2.data.models.Modules.Products;
using wap2.data.sqlite;
using wap2.data.sqlite.Repositories.Products;
using WAP2._1.ViewModel.category;
using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore;
using System.Windows.Input;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using wap2.data.models.servicios;
using intCoders.data.common.Repositories;

namespace WAP2._1.views;

public partial class Categoria : ContentPage
{
    //CategoriaViewModel categoriaViewModel;

    public ObservableCollection<Category> _category;
    public ObservableCollection<Category> Category 
    {
        get { return _category; }
        set { _category = value; }
    }
    public Categoria()
	{
		InitializeComponent();
        
        Load();
        
        BindingContext = this;
       
        OnAddCategoria();
        
        OnAppearing();
        Reload();
        
    }
    
    public void Load()
    {
        using (var sqLiteContext = new WapSqLiteContext())
        {
            var repo = new CategoryRepository(sqLiteContext);
            Category = new ObservableCollection<Category>(repo.GetAll().ToList());

        }
    }

    public async void OnAppearing()
    {
        IsBusy = true;
    }
    [ICommand]
    public async void Reload()
    {
        IsBusy = true;
        try
        {
            using (var sqLiteContext = new WapSqLiteContext())
            {
                var repo = new CategoryRepository(sqLiteContext);
                Category.Clear();
                var newCategories = repo.GetAll().ToList();
                foreach (var newCategory in newCategories)
                {
                    Category.Add(newCategory);
                }

            }
        }

        finally
        {
            IsBusy = false;
        }
    }

    [ICommand]
    public async void OnAddCategoria()
    {
        await Shell.Current.GoToAsync(nameof(AddCategoria));
    }


    [ICommand]
    public async Task Delete(Category category)

    {
        try
        {
            await App.CategoriaServicio.DeleteCategoriaAsync(category.Id);
            Category.Remove(category);
        }
        catch (Exception ex)
        {
            ex = ex;
        }
    }

    [ICommand]
    public async Task Edit(Category category)
    {
        if (category == null)
            return;
        
        await Navigation.PushAsync(new AddCategoria(category));

    }




}