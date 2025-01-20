using System.Windows.Input;
using IbragimovLaba5.DatabaseContext;
using IbragimovLaba5.Entity;


namespace IbragimovLaba5;

public partial class RegPage : ContentPage
{
	public RegPage()
	{
		InitializeComponent();
	}

    private void GoBackToFirstPage(object sender, EventArgs e)
    {
        AppShell.Current.GoToAsync("..", true);
    }
}