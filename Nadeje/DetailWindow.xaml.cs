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
using MahApps.Metro.Controls;
using System.IO;

namespace Nadeje
{
	/// <summary>
	/// Interaction logic for DetailWindow.xaml
	/// </summary>
	public partial class DetailWindow : MetroWindow
	{
		#region Fields / Properties
		private Human CurrentHomeless;
		private User CurrentUser;
		#endregion


		#region C-tors
		public DetailWindow() { }

		public DetailWindow(User user, Human selection)
		{
			InitializeComponent();

			if (selection != null)
			{
				this.CurrentHomeless = selection;
				this.CurrentUser = user;
				MyInit();
			}
			else { CurrentHomeless = new Human(); }
			SetPicture();
		}
		#endregion

		#region Init
		private void MyInit()
		{
			txbFirstName.Text = CurrentHomeless.FirstName;
			txbLastName.Text = CurrentHomeless.LastName;
			txbBirthYear.Text = CurrentHomeless.BirthYear.ToString();

			dataFirstAid.ItemsSource = CurrentHomeless.FirstAidList;
			dataServiceInterruption.ItemsSource = CurrentHomeless.InteruptionList;

			SetRights();
		}
		#endregion

		#region Methods
		private void SetRights()
		{
			if(CurrentUser.Type == UserType.PSS)
			{
				txbFirstName.IsEnabled = false;
				txbLastName.IsEnabled = false;
				txbBirthYear.IsEnabled = false;
				switchServices.IsEnabled = false;
				btnAddJP.IsEnabled = false;
				btnAddServices.IsEnabled = false;
				btnSave.IsEnabled = false;
				imgGenre.MouseLeftButtonUp -= imgGenre_MouseLeftButtonUp;
			}
			else if(CurrentUser.Type == UserType.SP)
			{
				txbFirstName.IsEnabled = true;
				txbLastName.IsEnabled = true;
				txbBirthYear.IsEnabled = true;
				switchServices.IsEnabled = true;
				btnAddJP.IsEnabled = true;
				btnAddServices.IsEnabled = true;
				btnSave.IsEnabled = true;
				imgGenre.MouseLeftButtonUp += imgGenre_MouseLeftButtonUp;
			}
		}

		private void SetPicture()
		{
			if (CurrentHomeless.Genre)
			{
				ImageSource imageSource = new BitmapImage(new Uri(CurrentHomeless.GenrePicture));
				imgGenre.Source = imageSource;
			}
			else
			{
				ImageSource imageSource = new BitmapImage(new Uri(CurrentHomeless.GenrePicture));
				imgGenre.Source = imageSource;
			}
		}
		#endregion

		#region Events
		private void imgGenre_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			string man = "pack://application:,,,/Nadeje;component/Pictures/man.png";
			string woman = "pack://application:,,,/Nadeje;component/Pictures/woman.png";

			if (imgGenre.Source.ToString().Equals(man))
			{
				ImageSource imageSource = new BitmapImage(new Uri(woman));
				imgGenre.Source = imageSource;
				CurrentHomeless.Genre = false;
				CurrentHomeless.GenrePicture = woman;
			}
			else if (imgGenre.Source.ToString().Equals(woman))
			{
				ImageSource imageSource = new BitmapImage(new Uri(man));
				imgGenre.Source = imageSource;
				CurrentHomeless.Genre = true;
				CurrentHomeless.GenrePicture = man;
			}
		}

		private void btnAddServices_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnAddJP_Click(object sender, RoutedEventArgs e)
		{
			AddJPWindow jp = new AddJPWindow();
			jp.Show();
		}

		private void btnSave_Click(object sender, RoutedEventArgs e)
		{
			//if (CurrentHomeless == null)
			//	CurrentHomeless = new Human();

			//CurrentHomeless.FirstName = txbFirstName.Text;
			//CurrentHomeless.LastName = txbLastName.Text;
			//int year = -1;
			//if (int.TryParse(txbBirthYear.Text, out year))
			//	CurrentHomeless.BirthYear = year;

			//CurrentHomeless.Add();
		}

		#endregion

		
	}
}
