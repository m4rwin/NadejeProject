using MahApps.Metro.Controls;
using Nadeje.Entities;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Nadeje
{
	/// <summary>
	/// Interaction logic for LoginPage.xaml
	/// </summary>
	public partial class LoginPage : MetroWindow
	{
		public LoginPage()
		{
			InitializeComponent();
			lblErrorMessage.Visibility = Visibility.Hidden;
			txbNick.Focusable = true;
			txbNick.Focus();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
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
	}
}
