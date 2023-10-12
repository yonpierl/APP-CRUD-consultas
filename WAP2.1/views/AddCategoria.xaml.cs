using wap2.data.models.Modules.Products;
using Microsoft.Toolkit.Mvvm.Input;
using WAP2._1.ViewModel.category;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WAP2._1.views;

public partial class AddCategoria : ContentPage
{
    public Category Category { get; set; }
    public AddCategoria()
	{
		InitializeComponent();
        this.BindingContext = new AddCategoriaViewModel();
    }

    public AddCategoria(Category category)
    {

        InitializeComponent();

        var view = new AddCategoriaViewModel();
        view.Category = category;

        nombre.Text = view.Category.Name;
        descrip.Text = view.Category.Description;

        this.BindingContext = view;
    }
}