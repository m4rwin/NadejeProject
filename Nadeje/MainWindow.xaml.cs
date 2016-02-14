using Nadeje.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using MahApps.Metro.Controls;
using System;

namespace Nadeje
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow
	{
		private List<Human> arr = new List<Human>()
	{
		new Human() { ID = 1, FirstName = "Martin", LastName = "Hromek", BirthYear = 1986, ServicesForForeigners = true,
		FirstAidList = new List<FirstAid>() { new FirstAid() { ID = 1, From = new DateTime(2016, 2, 15, 16, 0, 0), To = new DateTime(2016, 2, 18, 15, 0, 0), Created = new DateTime(2016,2,14,22,0,2), WhoCreated = "Eva Březovská" },
		new FirstAid() { ID = 2, From = new DateTime(2016, 3, 5, 12, 0, 0), To = new DateTime(2016, 3, 10, 11, 0, 0), Created = new DateTime(2016,3,3,8,0,2), WhoCreated = "Eva Březovská" }},
		InteruptionList = new List<ServiceInterruption>() { new ServiceInterruption() { ID = 1, From = new DateTime(2016, 2,14,16,00,10), To = new DateTime(2016,3,10,11,0,20), Created = DateTime.Now, WhoCreated = "Eva Březovská", Reason = "Opilost", Note = "Choval se nezdvořile k sociálním pracovníkům" } } },
		new Human() { ID = 2, FirstName = "Johnny", LastName = "Rambo", BirthYear = 1952, ServicesForForeigners = false },
		new Human() { ID = 3, FirstName = "Eva", LastName = "Březovská", BirthYear = 1989, ServicesForForeigners = false }
	};

		public MainWindow()
		{
			InitializeComponent();
			dataGrid.ItemsSource = arr;
		}

		private void Button_Find_Click(object sender, RoutedEventArgs e)
		{
			List<Human> result = new List<Human>();

			string tmpFirstName = txbFirstName.Text.ToLower();
			if (!string.IsNullOrWhiteSpace(tmpFirstName))
			{
				var resultFirstName = arr.Where(item => item.FirstName.ToLower().Contains(tmpFirstName));
				result.AddRange(resultFirstName);
			}

			string tmpLastName = txbLastName.Text.ToLower();
			if (!string.IsNullOrWhiteSpace(tmpLastName))
			{
				var resultLastName = arr.Where(item => item.LastName.ToLower().Contains(tmpLastName));
				result.AddRange(resultLastName);
			}

			int tmpYear = -1;
			if (int.TryParse(txbBirdYear.Text, out tmpYear))
			{
				var resultBirthYear = arr.Where(item => item.BirthYear == tmpYear);
				result.AddRange(resultBirthYear);
			}

			dataGrid.ItemsSource = result.Distinct();
		}

		private void btnEdit_Click(object sender, RoutedEventArgs e)
		{
			Human selection = (Human)dataGrid.SelectedItem;
			DetailWindow dw = new DetailWindow(selection);
			dw.Show();
		}
	}
}
