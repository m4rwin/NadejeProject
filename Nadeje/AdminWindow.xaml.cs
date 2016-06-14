using Nadeje.Db;
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

namespace Nadeje
{
	/// <summary>
	/// Interaction logic for AdminWindow.xaml
	/// </summary>
	public partial class AdminWindow : Window
	{
		#region C-tor
		public AdminWindow()
		{
			InitializeComponent();
		}
		#endregion

		#region Events
		private void btnAddUser_Click(object sender, RoutedEventArgs e)
		{
			string usr = txbUserName.Text;
			string psw = txbUserPsw.Text;
			string role = cmbRole.Text;

			string con = @"Data Source=MARWINPC\SQLEXPRESS;Initial Catalog=NadejeDb;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			DbManager.Insert(con, "dbo.user", usr, psw, role);
		}
		#endregion
	}
}
