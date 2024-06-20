using Prova.Models;
using Prova.ViewModel;

namespace Prova;

public partial class DiceView : ContentPage
{
	public DiceView()
	{
		InitializeComponent();
		BindingContext = new DiceViewModel();

	}


}