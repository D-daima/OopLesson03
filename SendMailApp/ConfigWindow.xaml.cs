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

namespace SendMailApp {
    /// <summary>
    /// ConfigWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class ConfigWindow : Window {
        public ConfigWindow() {
            InitializeComponent();
            
        }

        private void btDefault_Click(object sender, RoutedEventArgs e) {
            Config cf = (Config.GetInstance()).getDefault();
            
            tbSmtp.Text = cf.Smtp;
            tbSender.Text = tbUserName.Text = cf.MailAddress;
            tbPort.Text = cf.Port.ToString();
            tbPassWord.Password = cf.PassWord;
            cbSsl.IsChecked = cf.Ssl;
            
        }
        //適用（更新）
        private void btApply_Click(object sender, RoutedEventArgs e) {
            (Config.GetInstance()).UpdateStatus(
                tbSmtp.Text,
                tbUserName.Text,
                tbPassWord.Password,
                int.Parse(tbPort.Text),
                cbSsl.IsEnabled);
            //cf.Smtp = tbSmtp.Text;
            //cf.MailAddress = tbUserName.Text;
            //cf.Port = int.Parse(tbPort.Text);
            //cf.PassWord = tbPassWord.Password;
            //cf.Ssl = cbSsl.IsEnabled;
            
        }
    }
}
