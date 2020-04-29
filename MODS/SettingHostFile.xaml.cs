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
using ITEM;

namespace MODS
{
    /// <summary>
    /// SettingHostFile.xaml 的交互逻辑
    /// </summary>
    public partial class SettingHostFile : Window
    {
        public SettingHostFile()
        {
            InitializeComponent();
            TEXT_FILE_VAL.Text = Load_Files(TEXT_FILE_URL.Text);
        }
        Binding NTB = new Binding();
        IO_Help ih = new IO_Help();
        private void BT_UPDATE_Click(object sender, RoutedEventArgs e)
        {
            if (TEXT_FILE_VAL.Text == "")
            {
                MessageBox.Show("文本为空");
            }
            else
            {
                ih.OpenWriteFiles(TEXT_FILE_URL.Text, TEXT_FILE_VAL.Text, true);
            }
        }

        String Load_Files(String URL)
        {
            return ih.OpenReaderFiles(URL);
        }


        private void TEXT_FILE_URL_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void BT_LOAD_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TEXT_FILE_VAL.Text = Load_Files(TEXT_FILE_URL.Text);
            }
            catch
            {
                MessageBox.Show("加载失败");
            }
        }
    }
}
