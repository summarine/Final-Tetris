using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Media;
using System.Threading;
namespace Tetris
{
	/// <summary>
	/// Singleplaywindow.xaml 的交互逻辑
	/// </summary>
	public partial class Singleplaywindow : Window
	{
        GameFrame game;
        PreviewWindow preview;
        ScoringBoard scoreBoard;
		public Singleplaywindow()
		{
			InitializeComponent();
            // 在此点之下插入创建对象所需的代码。
           
            game = new MyGameFrame(gameGrid,19,11);

            scoreBoard = new ScoringBoard(Scoring_Board);

            preview = new PreviewWindow(game, PreviewImage);

            game.RowsCleanEvent += scoreBoard.GetScore;
            game.RowsCleanEvent += Play;           

            game.GameOverEvent += scoreBoard.WhenGameOver;
            //game.GameOverEvent += writeScoreRating;
        }

        private void Play(Object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(System.Environment.CurrentDirectory + @"\Resources\Audio\didi.wav");
            //或者
            //SoundPlayer soundPlayer = new SoundPlayer(@"Resources\Audio\didi.wav");
            soundPlayer.Play();
        }
        private void Window_KeyDown(Object sender,KeyEventArgs e)
        {
            //if (e.Key == Key.Enter)
            //{
            //    if (game.State == GameState.Stoped)
            //    {
            //        game.Start();
            //    }
            //    else if (game.State == GameState.Active)
            //    {
            //        game.Pause();
            //    }
            //    else if (game.State == GameState.Paused)
            //    {
            //        game.Continue();
            //    }
            //}
             if (e.Key == Key.Escape)
            {
                if (game.State == GameState.Active || game.State == GameState.Paused)
                {
                    game.Stop();
                }
            }
            else 
            {
                if (game.activeBox!=null)
                {
                    game.KeyDown(e.Key);                    
                }
            } 
        }     

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            if (game.State == GameState.Stoped)
            {
                game.Start();
            }
            else if (game.State == GameState.Paused)
            {
                game.Continue();
            }
            else
            {
                //MessageBox.Show(this, "已启动游戏");
            }
        }

        private void PauseBtn_Click(object sender, RoutedEventArgs e)
        {
            if (game.State == GameState.Active)
            {
                game.Pause();
            }
            else
            {
                //MessageBox.Show(this, "无法暂停");
            }
        }
        private void StopBtn_Click(object sender, RoutedEventArgs e)
        {
            if (game.State == GameState.Active || game.State== GameState.Paused)
            {
                game.Stop();
            }
            else
            {
                //MessageBox.Show(this, "无法停止");
            }
        }
        //private void QuitBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    game.Stop();
        //    this.Close();
        //}
        
    }
}