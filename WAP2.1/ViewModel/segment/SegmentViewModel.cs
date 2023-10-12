using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAP2._1.ViewModel.segment
{
    public partial class SegmentViewModel:BaseSegmentViewModel
    {
        public SegmentViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }
    }
}
