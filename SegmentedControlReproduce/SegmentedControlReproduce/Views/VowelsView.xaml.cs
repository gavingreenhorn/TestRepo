using SegmentedControlReproduce.ViewModels;

namespace SegmentedControlReproduce.Views;

public partial class VowelsView : ContentPage
{
	public VowelsView(VowelsViewModel vvw)
	{
		InitializeComponent();
        BindingContext = vvw;
    }
}