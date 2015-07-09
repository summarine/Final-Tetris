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
using System.IO;
using Sever;
namespace Tetris
{
    /// <summary>
    /// Ratingwindow.xaml 的交互逻辑
    /// </summary>
    public partial class Ratingwindow : Window
    {
        static private string score_str;
        //static private string score_name;
        //ScoreMsg scoreMsg = new ScoreMsg();
        //public List<ScoreMsg> msgPool = new List<ScoreMsg>();
        public Ratingwindow()
        {
            InitializeComponent();
            string path = @"c:\temp\MyTest.txt";//写入内容文件的路径，也是导出内容文件的路径
            string readText = File.ReadAllText(path, Encoding.UTF8);//导出内容并接受
            string[] msg = readText.Split(';');

            int k=0;
            string[] msgs;
            score_str = k.ToString();
            for (k = 0; k < msg.Length;k++ )
            {
                msgs = msg[k].Split(':');
                score_str += ":" + msgs[0];
                //msgs[0].Remove(0);
                //msgs[1].Remove(0);
            }
            
           // string[] score_nameMsgs = score_name.Split(':');

            string[] MSGS = score_str.Split(':');
            int gap, i, j; 
            string temp;
            int n = MSGS.Length;
            for (gap = n / 2; gap > 0;gap/=2 )
            {
                for (i = gap; i < n; i++)
                {
                    for (j = i - gap; (j >= 0) && (Int32.Parse(MSGS[j]) < Int32.Parse(MSGS[j + gap])); j -= gap)
                    {
                        temp = MSGS[j];
                        MSGS[j] = MSGS[j + gap];
                        MSGS[j + gap] = temp;
                    }
                }
            }
            ratingwindow.Text ="\n\t" +MSGS[0]+"\n\t"+MSGS[1]+"\n\t"+MSGS[2]+"\n\t"+MSGS[3];
        }
    }
}
