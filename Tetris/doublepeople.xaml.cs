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
using System.Media;
namespace Tetris
{
    /// <summary>
    /// doublepeople.xaml 的交互逻辑
    /// </summary>
    public partial class doublepeople : Window
    {
        public doublepeople()
        {
            InitializeComponent();
            int r = 19, c = 10;
            //myGame = new MyGameFrame(myGrid, r, c);
            myGame = new MyGameFrame(myGrid, r, c);

            //myGame.AIInitialize(new SimpleAI(r, c, myGame,new Complex_AI_Integrator()));

            FriendGame = new MyGameFrame(aiGrid, r, c);
            //FriendGame.AIInitialize(new SimpleAI(r, c, FriendGame, new Simple_AI_Integrator()));
            preview = new PreviewWindow(myGame, PreviewImage);
            preview = new PreviewWindow(FriendGame, PreviewImage1);
            //设置计分板
            plarSc = new DoubleScoringBoard(PlayerScoreLabel);
            myGame.RowsCleanEvent += plarSc.GetScore;
            myGame.RowsCleanEvent += Play;
            aiSc = new DoubleScoringBoard(AIScoreLabel);
            FriendGame.RowsCleanEvent += aiSc.GetScore;

            plarSc.Threshold = aiSc.Threshold = 800;

            //增加增行函数的事件绑定
            aiSc.CrossThreshold += myGame.OtherCrossThreshold;
            plarSc.CrossThreshold += FriendGame.OtherCrossThreshold;

            //设置游戏结束
            myGame.GameOverEvent += GameFinish;
            myGame.GameOverEvent += plarSc.WhenGameOver;
            FriendGame.GameOverEvent += GameFinish;
            FriendGame.GameOverEvent += aiSc.WhenGameOver;

        }
        private void Play(Object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(System.Environment.CurrentDirectory + @"\Resources\Audio\didi.wav");
            //或者
            //SoundPlayer soundPlayer = new SoundPlayer(@"Resources\Audio\didi.wav");
            soundPlayer.Play();
        }
        private void GameFinish(object sender, EventArgs e)
        {
            if (FriendGame.State != GameState.Stoped)
                FriendGame.Stop();
            if (myGame.State != GameState.Stoped)
                myGame.Stop();
            //if (sender == myGame)
            //{
            //    MessageBox.Show("你输了");
            //}
            //else if (sender == FriendGame)
            //{
            //    MessageBox.Show("你赢了");
            //}
        }

        private void PauseBtn_Click(object sender, RoutedEventArgs e)
        {
            if (myGame.State == GameState.Active)
            {
                myGame.Pause();
                FriendGame.Pause();
            }
        }


        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if (myGame.State == GameState.Paused)
            {
                myGame.Continue();
                FriendGame.Continue();
            }
            else if (myGame.State == GameState.Stoped)
            {
                int seed = (new Random()).Next();
                myGame.SetFactorySeed(seed);
                FriendGame.SetFactorySeed(seed);
                myGame.Start();
                FriendGame.Start();
            }
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            if (myGame.State == GameState.Active || myGame.State == GameState.Paused)
            {
                myGame.Stop();
                FriendGame.Stop();

                plarSc.Clear();
                aiSc.Clear();
            }
        }

        private GameFrame myGame;
        private MyGameFrame FriendGame;
        private DoubleScoringBoard plarSc, aiSc;
        PreviewWindow preview;
        private void Window_KeyDown(Object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (myGame.State == GameState.Stoped)
                {
                    myGame.Start();
                }
                else if (myGame.State == GameState.Active)
                {
                    myGame.Pause();
                }
                else if (myGame.State == GameState.Paused)
                {
                    myGame.Continue();
                }
            }
            else if (e.Key == Key.Escape)
            {
                if (myGame.State == GameState.Active || myGame.State == GameState.Paused)
                {
                    myGame.Stop();
                }
            }
            else
                if (myGame.activeBox != null)
                {
                    if (e.Key == Key.A || e.Key == Key.W || e.Key == Key.S || e.Key == Key.D)
                    { myGame.KeyDown(e.Key); }
                    else
                    { FriendGame.KeyDown(e.Key); }
                }
        }
    }


}
