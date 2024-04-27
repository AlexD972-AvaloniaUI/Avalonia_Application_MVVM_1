using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace AvaloniaApplication_MVVM_1.ViewModels;

public partial class MainViewModel : ViewModelBase
{
	public ObservableCollection<MyData> YourCollection { get; set; }

	public MainViewModel()
	{
		YourCollection = new ObservableCollection<MyData>();

		for (int i = 0; i < 21; i++)
		{
			YourCollection.Add(new MyData
			{
				Propriete1 = "N/A",
				Propriete0 = " " + (10*i),
				// Ajoutez plus de propriétés ici jusqu'à Propriete10
			});
		}
	}

	public class MyData
	{
		public string Propriete1 { get; set; }
		public string Propriete0 { get; set; }
		// Ajoutez plus de propriétés ici jusqu'à Propriete10
	}

	//public void Button_Jalon1_Clicked(object sender )
	//{
		
	//}
}
