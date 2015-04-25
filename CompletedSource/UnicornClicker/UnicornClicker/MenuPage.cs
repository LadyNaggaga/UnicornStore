﻿using System;
using Xamarin.Forms;

namespace XamarinFormsTest
{
	public class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			var play = new Button {
				Text = "Play"
			};

			play.Clicked += async (sender, e) => { await Navigation.PushAsync(new GamePage()); };

			var scores = new Button {
				Text = "Scores"
			};

			scores.Clicked += async (sender, e) => { await Navigation.PushAsync(new ScoreHistoryPage()); };

			Content = new StackLayout {
				VerticalOptions = LayoutOptions.Center,
				Children = { play, scores }
			};
		}
	}
}

