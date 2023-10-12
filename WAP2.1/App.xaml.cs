using System.Reflection;
using wap2.data.models.servicios;

namespace WAP2._1;

public partial class App : Application
{
    public static CategoriaServicio _CategoriaServicio;
    public static SegmentServicio segmentServicio;

    public static CategoriaServicio CategoriaServicio
    {
        get
        {
            if (_CategoriaServicio == null)
            {

                var folder = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                var DbPath = System.IO.Path.Join(folder, "wap2.db");

                _CategoriaServicio = new CategoriaServicio(DbPath);

            }
            return _CategoriaServicio;
        }
    }
    public static SegmentServicio SegmentServicio
    {
        get
        {
            if (segmentServicio == null)
            {

                var folder = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                var DbPath = System.IO.Path.Join(folder, "wap2.db");

                segmentServicio = new SegmentServicio(DbPath);

            }
            return segmentServicio;
        }
    }

    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
