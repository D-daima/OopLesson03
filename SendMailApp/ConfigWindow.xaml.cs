using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Channels;
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

        public bool textCheck;

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
            NullCheck();//更新処理を呼び出す
        }

        private bool NullCheck() {
            if(tbSmtp.Text != "" && tbPassWord.Password != "" && tbPort.Text != "" && tbSender.Text != "") {
                try {
                    (Config.GetInstance()).UpdateStatus(
                    tbSmtp.Text,
                    tbUserName.Text,
                    tbPassWord.Password,
                    int.Parse(tbPort.Text),
                    cbSsl.IsChecked ?? false);
                    textCheck = false;
                    return true;
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            } else {
                MessageBox.Show("入力されていない項目があります。");
                return false;
            }
        }

        //OKボタン
        private void btOk_Click(object sender, RoutedEventArgs e) {
            if(NullCheck() == true) {
                this.Close();
            }
        }
        //キャンセルボタン
        private void btCancel_Click(object sender, RoutedEventArgs e) {
            if(textCheck == true) {
                message();
            } else {
                this.Close();
            }
        }
        //ロード時に一度だけ呼び出される
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            Config cf = Config.GetInstance();
            tbSmtp.Text = cf.Smtp;
            tbUserName.Text = tbSender.Text = cf.MailAddress;
            if(cf.Port != 0) {
                tbPort.Text = cf.Port.ToString();
            } 
            tbPassWord.Password = cf.PassWord;
            cbSsl.IsChecked = cf.Ssl;
            textCheck = false;
        }
                
        public void message() {
            var result = MessageBox.Show("変更が反映されていません。", "質問", MessageBoxButton.OKCancel);
            if(result == MessageBoxResult.OK) {
                this.Close();
            } else if(result == MessageBoxResult.Cancel) {
            }
        }

        private void tbText_TextChanged(object sender, TextChangedEventArgs e) {
            textCheck = true;            
        }

        private void tbPassWord_PasswordChanged(object sender, RoutedEventArgs e) {
            textCheck = true;
        }

    }      
}
