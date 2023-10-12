using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using wap2.data.models.Modules.Products;

namespace WAP2._1.ViewModel.category
{
    public partial class BaseCategoriaViewModel:BaseViewModel
    {
        [ObservableProperty]
        private Category _category;

        public INavigation Navigation{ get; set; } 

    }
}
