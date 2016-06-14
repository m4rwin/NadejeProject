using MahApps.Metro.Controls;
using Nadeje.Entities;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System;

namespace Nadeje
{
	/// <summary>
	/// Interaction logic for LoginPage.xaml
	/// </summary>
	public partial class LoginPage : MetroWindow
	{
		#region C-tor
		public LoginPage()
		{
			InitializeComponent();
			lblErrorMessage.Visibility = Visibility.Hidden;
			txbNick.Focusable = true;
			txbNick.Focus();
		}
		#endregion

		#region Events
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (RunDbAdmin())
			{
				ShowAdministration();
				return;
			}

			User u = new User() { Nick = txbNick.Text, Psw = txbPsw.Password };
			if (u.IsUser())
			{
				MainWindow mw = new MainWindow(u);
				mw.Show();
				this.Close();
			}
			else
			{
				lblErrorMessage.Content = "Špatné přihlašovací jméno";
				lblErrorMessage.Foreground = new SolidColorBrush(Colors.DarkRed);
				lblErrorMessage.Visibility = Visibility.Visible;
			}
		}

		private void Button_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == Key.Enter)
			{
				Button_Click(null, null);
			}
		}

		private void Administration_Close(object sender, EventArgs e)
		{
			this.Show();
		}
		#endregion

		#region Methods
		private bool RunDbAdmin()
		{
			if (Keyboard.IsKeyDown(Key.LeftCtrl) && Keyboard.IsKeyDown(Key.LeftAlt))
				return true;
			else
				return false;
		}

		private void ShowAdministration()
		{
			var window = new AdminWindow();
			window.Closed += Administration_Close;
			this.Hide();
			window.Show();
		}
		#endregion
	}
}
