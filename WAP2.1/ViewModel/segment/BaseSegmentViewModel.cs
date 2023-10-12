using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wap2.data.models.Modules.Customers;

namespace WAP2._1.ViewModel.segment
{
    public partial class BaseSegmentViewModel:BaseViewModel
    {
        [ObservableProperty]
        private Segment _segment;

        public INavigation Navigation { get; set; }
    }
}
