using Microsoft.Toolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using wap2.data.models.Modules.Customers;
using wap2.data.sqlite;
using wap2.data.sqlite.Repositories.Customer;

namespace WAP2._1.views;

public partial class Segmento : ContentPage
{
	public ObservableCollection<Segment> segments;
	
	public ObservableCollection<Segment> Segments
	{
		get { return segments; }
		set { segments = value; }
	}

	public Segmento()
	{
		InitializeComponent();
		BindingContext = this;
		Load();
        OnAppearing();
        Reload();
        OnAddSegment();

    }


	public void Load()
	{
        using (var sqLiteContext = new WapSqLiteContext())
        {
            var repo = new SegmentRepository(sqLiteContext);
            Segments = new ObservableCollection<Segment>(repo.GetAll().ToList());

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
                var repo = new SegmentRepository(sqLiteContext);
                Segments.Clear();
                var newSegments = repo.GetAll().ToList();
                foreach (var newSegment in newSegments)
                {
                    Segments.Add(newSegment);
                }
            }
        }
        finally
        {
            IsBusy = false;
        }
    }

    [ICommand]
    public async void OnAddSegment()
    {
        await Shell.Current.GoToAsync(nameof(AddSegment));
    }

    [ICommand]
    public async Task Delete(Segment segment)

    {
        try
        {
            await App.CategoriaServicio.DeleteCategoriaAsync(segment.Id);
            Segments.Remove(segment);
        }
        catch (Exception ex)
        {
            ex = ex;
        }
    }

    [ICommand]
    public async Task Edit(Segment segment)
    {
        if (segment == null)
            return;

        await Navigation.PushAsync(new AddSegment(segment));

    }

}