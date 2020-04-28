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

namespace Povrs
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			List<Kvadrat> listaK = new List<Kvadrat>();
			listaK.Add(new Kvadrat(2));
			listaK.Add(new Pravougaonik(2, 3));

			//listaK.ForEach(k => MessageBox.Show(k.RacunajPovrsinu().ToString()));

			Pravougaonik p = new Pravougaonik(1, 4);
			if (p is Kvadrat)
				MessageBox.Show("Jeste");

			object OvoJeObjekat = new Kvadrat(4);
			MessageBox.Show(OvoJeObjekat.ToString());

			Kvadrat kk = new Pravougaonik(4, 5);
			kk.RacunajPovrsinu();
			
		}
	}

	public class Kvadrat
	{
		public int StranaA;
		public virtual int RacunajPovrsinu() => StranaA * StranaA;

		public Kvadrat(int a) => StranaA = a;
	}

	public class Pravougaonik : Kvadrat
	{
		public int StranaB;
		public override int RacunajPovrsinu() => StranaA * StranaB;

		public Pravougaonik(int a, int b) : base(a) => StranaB = b;
	}
}
