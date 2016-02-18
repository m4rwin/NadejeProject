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
	public partial class MainWindow : MetroWindow
	{
		private User CurrentUser;

		public MainWindow()
		{
			InitializeComponent();
			dataGrid.ItemsSource = Human.arr;
		}

		public MainWindow(User u)
			:this()
		{
			this.CurrentUser = u;
			lblToolBar.Content = $"Uživatel: {u.Nick}  |  Typ: {u.Type}  |  čas přihlášení: {DateTime.Now}";
			txbFirstName.Focusable = true;
			txbFirstName.Focus();
			SetRights();
		}

		#region Methods
		private void SetRights()
		{
			if (CurrentUser.Type == UserType.PSS)
			{
				btnAddClient.IsEnabled = false;
			}
			else if (CurrentUser.Type == UserType.SP)
			{
				btnAddClient.IsEnabled = true;
			}
		}
		#endregion

		#region Events
		private void Button_Find_Click(object sender, RoutedEventArgs e)
		{
			List<Human> result = new List<Human>();

			string tmpFirstName = txbFirstName.Text.ToLower();
			if (!string.IsNullOrWhiteSpace(tmpFirstName))
			{
				var resultFirstName = Human.arr.Where(item => item.FirstName.ToLower().Contains(tmpFirstName));
				result.AddRange(resultFirstName);
			}

			string tmpLastName = txbLastName.Text.ToLower();
			if (!string.IsNullOrWhiteSpace(tmpLastName))
			{
				var resultLastName = Human.arr.Where(item => item.LastName.ToLower().Contains(tmpLastName));
				result.AddRange(resultLastName);
			}

			int tmpYear = -1;
			if (int.TryParse(txbBirdYear.Text, out tmpYear))
			{
				var resultBirthYear = Human.arr.Where(item => item.BirthYear == tmpYear);
				result.AddRange(resultBirthYear);
			}

			dataGrid.ItemsSource = result.Distinct();
		}

		private void btnEdit_Click(object sender, RoutedEventArgs e)
		{
			Human selection = (Human)dataGrid.SelectedItem;
			DetailWindow dw = new DetailWindow(CurrentUser, selection);
			dw.Show();
		}

		private void dataGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			Human selection = (Human)dataGrid.SelectedItem;
			DetailWindow dw = new DetailWindow(CurrentUser, selection);
			dw.Show();
		}

		private void txbFirstName_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			Button_Find_Click(null, null);
		}

		private void txbLastName_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			Button_Find_Click(null, null);
		}

		private void txbBirdYear_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			Button_Find_Click(null, null);
		}

		private void btnAddClient_Click(object sender, RoutedEventArgs e)
		{
			DetailWindow dw = new DetailWindow(CurrentUser, null);
			dw.Show();
		} 
		#endregion
	}
}
