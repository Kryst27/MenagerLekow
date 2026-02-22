using MenagerLekow.MVVM.VIEWMODEL;
using PropertyChanged;

namespace MenagerLekow.MVVM.VIEW;

[AddINotifyPropertyChangedInterface]
public partial class StronaGlowna : ContentPage
{
	glownaViewModel glownaViewModel;

	public StronaGlowna(glownaViewModel glownaViewModel)
	{
		this.glownaViewModel = glownaViewModel;
		InitializeComponent();
		BindingContext = glownaViewModel;
    }

}