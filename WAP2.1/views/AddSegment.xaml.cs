using wap2.data.models.Modules.Customers;
using WAP2._1.ViewModel.segment;

namespace WAP2._1.views;

public partial class AddSegment : ContentPage
{
	public Segmento Segmento { get; set; }
	public AddSegment()
	{
		InitializeComponent();
        this.BindingContext = new AddSegmentViewModel();
    }

    public AddSegment(Segment segment)
    {
        InitializeComponent();
        var view = new AddSegmentViewModel();
        view.Segment = segment;

        this.BindingContext = view;

    }
}