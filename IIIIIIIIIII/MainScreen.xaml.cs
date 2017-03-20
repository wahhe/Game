using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IIIIIIIIIII
{
	public partial class MainScreen : ContentPage
	{
		int win, lose, tie;
		string playerChoice, cpuChoice;

		Random rand = new Random();

		public MainScreen()
		{
			InitializeComponent();

			//start of game settings
			win = lose = tie = 0;
			outcomeLabel.Text = "";
			playerImage.Source = null;
			cpuImage.Source = null;
			outcomeLabel.IsVisible = false;
		}
		async public void rockButton_Clicked(object sender, EventArgs e)
		{
			rockButton.IsEnabled = false;
			paperButton.IsEnabled = false;
			scissorsButton.IsEnabled = false;

			rockButton.IsVisible = false;
			paperButton.IsVisible = false;
			scissorsButton.IsVisible = false;

			playerChoice = "rock";
			playerImage.Source = "Rock.png";
			DependencyService.Get<IIIIIIIIIIIIIIII.IAudio>().PlayAudioFile("choicepop.wav");
			await Task.Delay(1000);

			int randValue = rand.Next(1, 4);

			if (randValue == 1)
			{
				cpuChoice = "rock";
				cpuImage.Source = "Rock.png";
			}
			else if (randValue == 2)
			{
				cpuChoice = "paper";
				cpuImage.Source = "Paper.png";
			}
			else
			{
				cpuChoice = "scissors";
				cpuImage.Source = "Scissors.png";
			}

			DependencyService.Get<IIIIIIIIIIIIIIII.IAudio>().PlayAudioFile("choicepop.wav");
			await Task.Delay(1000);

			if (playerChoice == cpuChoice)
			{
				outcomeLabel.Text = "TIE";
				tie++;
				TieLabel.Text = "T: " + tie;
			}
			else if (cpuChoice == "paper")
			{
				outcomeLabel.Text = "YOU LOSE";
				lose++;
				LossLabel.Text = "L: " + lose;
			}
			else
			{
				outcomeLabel.Text = "YOU WIN";
				win++;
				WinLabel.Text = "W: " + win;
			}

			outcomeLabel.IsVisible = true;
			DependencyService.Get<IIIIIIIIIIIIIIII.IAudio>().PlayAudioFile("losepoint.wav");
			await Task.Delay(3000);

			playerImage.Source = null;
			cpuImage.Source = null;
			outcomeLabel.IsVisible = false;

			rockButton.IsEnabled = true;
			paperButton.IsEnabled = true;
			scissorsButton.IsEnabled = true;

			rockButton.IsVisible = true;
			paperButton.IsVisible = true;
			scissorsButton.IsVisible = true;
		}


		async public void paperButton_Clicked(object sender, EventArgs e)
		{
			rockButton.IsEnabled = false;
			paperButton.IsEnabled = false;
			scissorsButton.IsEnabled = false;

			rockButton.IsVisible = false;
			paperButton.IsVisible = false;
			scissorsButton.IsVisible = false;


			playerChoice = "paper";
			playerImage.Source = "paper.png";
			DependencyService.Get<IIIIIIIIIIIIIIII.IAudio>().PlayAudioFile("choicepop.wav");
			await Task.Delay(1000);

			int randValue = rand.Next(1, 4);

			if (randValue == 1)
			{
				cpuChoice = "rock";
				cpuImage.Source = "Rock.png";
			}
			else if (randValue == 2)
			{
				cpuChoice = "paper";
				cpuImage.Source = "Paper.png";
			}
			else
			{
				cpuChoice = "scissors";
				cpuImage.Source = "Scissors.png";
			}

			DependencyService.Get<IIIIIIIIIIIIIIII.IAudio>().PlayAudioFile("choicepop.wav");
			await Task.Delay(1000);

			if (playerChoice == cpuChoice)
			{
				outcomeLabel.Text = "TIE";
				tie++;
				TieLabel.Text = "T: " + tie;
			}
			else if (cpuChoice == "scissors")
			{
				outcomeLabel.Text = "YOU LOSE";
				lose++;
				LossLabel.Text = "L: " + lose;
			}
			else
			{
				outcomeLabel.Text = "YOU WIN";
				win++;
				WinLabel.Text = "W: " + win;
			}

			outcomeLabel.IsVisible = true;
			DependencyService.Get<IIIIIIIIIIIIIIII.IAudio>().PlayAudioFile("losepoint.wav");
			await Task.Delay(3000);

			playerImage.Source = null;
			cpuImage.Source = null;
			outcomeLabel.IsVisible = false;

			rockButton.IsEnabled = true;
			paperButton.IsEnabled = true;
			scissorsButton.IsEnabled = true;

			rockButton.IsVisible = true;
			paperButton.IsVisible = true;
			scissorsButton.IsVisible = true;
		}

		async public void scissorsButton_Clicked(object sender, EventArgs e)
		{
			rockButton.IsEnabled = false;
			paperButton.IsEnabled = false;
			scissorsButton.IsEnabled = false;

			rockButton.IsVisible = false;
			paperButton.IsVisible = false;
			scissorsButton.IsVisible = false;

			playerChoice = "scissors";
			playerImage.Source = "scissors.png";
			DependencyService.Get<IIIIIIIIIIIIIIII.IAudio>().PlayAudioFile("choicepop.wav");
			await Task.Delay(1000);

			int randValue = rand.Next(1, 4);

			if (randValue == 1)
			{
				cpuChoice = "rock";
				cpuImage.Source = "Rock.png";
			}
			else if (randValue == 2)
			{
				cpuChoice = "paper";
				cpuImage.Source = "Paper.png";
			}
			else
			{
				cpuChoice = "scissors";
				cpuImage.Source = "Scissors.png";
			}

			DependencyService.Get<IIIIIIIIIIIIIIII.IAudio>().PlayAudioFile("choicepop.wav");
			await Task.Delay(1000);

			if (playerChoice == cpuChoice)
			{
				outcomeLabel.Text = "TIE";
				tie++;
				TieLabel.Text = "T: " + tie;
			}
			else if (cpuChoice == "rock")
			{
				outcomeLabel.Text = "YOU LOSE";
				lose++;
				LossLabel.Text = "L: " + lose;
			}
			else
			{
				outcomeLabel.Text = "YOU WIN";
				win++;
				WinLabel.Text = "W: " + win;
			}

			outcomeLabel.IsVisible = true;
			DependencyService.Get<IIIIIIIIIIIIIIII.IAudio>().PlayAudioFile("losepoint.wav");
			await Task.Delay(3000);

			playerImage.Source = null;
			cpuImage.Source = null;
			outcomeLabel.IsVisible = false;

			rockButton.IsEnabled = true;
			paperButton.IsEnabled = true;
			scissorsButton.IsEnabled = true;

			rockButton.IsVisible = true;
			paperButton.IsVisible = true;
			scissorsButton.IsVisible = true;
		}
	}
}
