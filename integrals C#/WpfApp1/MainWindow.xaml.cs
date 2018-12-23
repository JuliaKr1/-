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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
	
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		
		 double Y(double p)
		{
			return Math.Pow(p,3)*Math.Log(p);
		}
		 double Sympson()
		{
			double x, a, b, h, s;
			int n;
			a = 1;
			b = 2;
			n = 10;
			

			h = (b - a) / n;
			s = 0;
			x = a + h;
			while (x < b)
			{
				s = s + 4 * Y(x);
				x = x + h;
				s = s + 2 * Y(x);
				x = x + h;
			}
			s = h / 3 * (s + Y(a) - Y(b));
			return s;
		}
		double Trapec()
		{
			double x, a, b, h, s;
			int n;
			a = 1;
			b = 2;
			n = 10;


			h = (b - a) / n;
			s = 0;
			x = a + h;
			while (x < b)
			{
				s = s+Y(x);
				x = x + h;
			}
			s = h * (s + (Y(a) + Y(b))/2);
			return s;
		}
		double Pryamoyg()
		{
			double x, a, b, h, s;
			int n;
			a = 1;
			b = 2;
			n = 10;


			h = (b - a) / n;
			s = 0;
			x = a + h/2 ;
			
			while (x < b)
			{
				s = s + Y(x);
				x = x + h;
			}
			s = h * s;
			return s;
		}

		private void button1_Click(object sender, RoutedEventArgs e)
		{
			label1.Content =Pryamoyg();
			
		}
		private void button2_Click(object sender, RoutedEventArgs e)
		{
			
			label2.Content = Sympson();
			
		}
		private void button3_Click(object sender, RoutedEventArgs e)
		{
			label3.Content = Trapec();
		}
		private void escButton_Click(object sender, RoutedEventArgs e)
		{
			this.Close(); // закрытие окна
		}
	}
}
