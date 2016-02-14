using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Nadeje.Entities;

namespace Nadeje
{
	/// <summary>
	/// Interaction logic for DetailWindow.xaml
	/// </summary>
	public partial class DetailWindow : Window
	{
		private Human CurrentItem;

		public DetailWindow(Human selection)
		{
			InitializeComponent();
			this.CurrentItem = selection;
			MyInit();
		}

		private void MyInit()
		{
			txbFirstName.Text = CurrentItem.FirstName;
			txbLastName.Text = CurrentItem.LastName;
			txbBirthYear.Text = CurrentItem.BirthYear.ToString();

			if (CurrentItem.ServicesForForeigners)
			{
				lblServicesForForeign.Content = "VYČERPÁNO";
				lblServicesForForeign.Foreground = new SolidColorBrush(Colors.DarkRed);
			}
			else
			{
				lblServicesForForeign.Content = "NEVYČERPÁNO";
				lblServicesForForeign.Foreground = new SolidColorBrush(Colors.DarkGreen);
			}

			dataFirstAid.ItemsSource = CurrentItem.FirstAidList;
			dataServiceInterruption.ItemsSource = CurrentItem.InteruptionList;
		}
	}
}
