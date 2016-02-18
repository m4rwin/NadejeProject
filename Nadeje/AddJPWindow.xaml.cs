using MahApps.Metro.Controls;
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
	/// Interaction logic for AddJPWindow.xaml
	/// </summary>
	public partial class AddJPWindow : MetroWindow
	{
		public AddJPWindow()
		{
			InitializeComponent();
		}

		private void btnSaveJP_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
