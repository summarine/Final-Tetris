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
namespace Tetris
{
    /// <summary>
    /// Rating.xaml 的交互逻辑
    /// </summary>
    public partial class Rating : Window
    {
        public Rating()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string path = @"c:\temp\MyTest.txt";//写入内容文件的路径，也是导出内容文件的路径
            if (File.Exists(path))
            {
                // 目标文本如果不存在，则新建一个新的文件
                string appendText = textbox1.Text;
                File.AppendAllText(path, appendText, Encoding.UTF8);//写入内容
            }
        }
    }
}
