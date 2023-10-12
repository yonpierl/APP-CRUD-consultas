using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wap2.data.models.Modules.Products;
using wap2.data.sqlite;
using wap2.data.sqlite.Repositories.Products;
using WAP2._1.views;

namespace WAP2._1.ViewModel.category
{
    public partial class CategoriaViewModel : BaseCategoriaViewModel
    {



        public CategoriaViewModel(INavigation navigation)
        {



            Navigation = navigation;
        }



        /*[ICommand]
        private async void Edit(Category category)
        {
            if (category == null)
                return;
            await Navigation.PushAsync(new AddCategoria(category));
        }*/







    }
}
