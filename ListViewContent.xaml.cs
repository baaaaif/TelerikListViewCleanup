using System.Collections.ObjectModel;

namespace TelerikListViewCleanup;

public partial class ListViewContent : ContentView
{
	
	public ListViewContent()
	{
		InitializeComponent();
		
	}

    private void ContentView_Unloaded(object sender, EventArgs e)
    {
		LabelName.Handler?.DisconnectHandler();
		LabelIndex.Handler?.DisconnectHandler();
    }
}