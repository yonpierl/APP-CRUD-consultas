using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wap2.data.models.Modules.Customers;

namespace WAP2._1.ViewModel.segment
{
    public partial class AddSegmentViewModel:BaseSegmentViewModel
    {
        public AddSegmentViewModel() 
        {
            Segment = new Segment
           {
                Name = "Nombre predeterminado",
            };
        }

        [ICommand]
        public async void GuardarSegment()
        {

            var segment = Segment;
            await App.SegmentServicio.UpdateSegmentAsync(segment);


            await Shell.Current.GoToAsync("..");
        }
    }
}
