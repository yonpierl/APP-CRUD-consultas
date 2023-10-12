
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wap2.data.models.Modules.Products;

namespace WAP2._1.ViewModel.category
{
    public partial class AddCategoriaViewModel:BaseCategoriaViewModel

    {
        public AddCategoriaViewModel()
        {
            
            Category = new Category
            {
                Name = "Nombre predeterminado",

            };


        }
        [ICommand]
        public async void GuardarCategoria()
        {

            var categoria = Category;
            await App.CategoriaServicio.UpdateCategoriaAsync(categoria);


            await Shell.Current.GoToAsync("..");
        }
        [ICommand]
        public async void Cancelar()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
