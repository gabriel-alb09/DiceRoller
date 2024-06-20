using System.Security.Cryptography.X509Certificates;
using System.Numerics;
using System;


namespace Prova;

public partial class Dados : ContentPage
{
	int numsort = 0;

	public Dados()
	{
		InitializeComponent();
	}

	private void RolarDado_Clicked(object sender, EventArgs e)
	{

		int max = (int)Lados.SelectedItem;
		numsort = new Random().Next(1, max + 1);
		Result.Text = numsort.ToString();

    }
}