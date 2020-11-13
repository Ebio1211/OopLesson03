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

namespace SendMailApp
{
    /// <summary>
    /// ConfigWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class ConfigWindow : Window
    {
        public ConfigWindow()
        {
            InitializeComponent();
        }

        //初期値を表示
        private void btDefault_Click(object sender, RoutedEventArgs e)
        {
            Config cf = Config.GetInstance().getDefaultStatus();

            tbSmtp.Text = cf.Smtp;
            tbPort.Text = cf.Port.ToString();
            tbSender.Text = tbUserName.Text = cf.MailAddress;
            tbPassWord.Password = cf.PassWord;
            CbSsl.IsChecked = cf.Ssl;
            
        }

        //適用（更新）
        private void btApply_Click(object sender, RoutedEventArgs e)
        {
            if (WhiteSpaceJudge())
            {
                Config.GetInstance().UpdateStatus(
                    tbSmtp.Text,
                    tbSender.Text,
                    tbPassWord.Password,
                    int.Parse(tbPort.Text),
                    CbSsl.IsChecked ?? false);    //更新処理を呼び出す
            }
            else
            {
                MessageBox.Show("未入力の項目があります。");
            }

        }

        //OK
        private void btOk_Click(object sender, RoutedEventArgs e)
        {
            btApply_Click(sender, e);   //更新処理を呼び出す
            if(WhiteSpaceJudge())
                this.Close();
                
        }

        //未入力の項目があるか判定
        public bool WhiteSpaceJudge()
        {
            if (string.IsNullOrWhiteSpace(tbSmtp.Text) || string.IsNullOrWhiteSpace(tbSender.Text) ||
        string.IsNullOrWhiteSpace(tbPassWord.Password.ToString()) || string.IsNullOrWhiteSpace(tbUserName.Text) ||
            string.IsNullOrWhiteSpace(tbPort.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //キャンセル
        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            Cancel_Judge();
        }

        //変更されたか判定する
        public void Cancel_Judge()
        {
            Config cf = Config.GetInstance();
            if (tbSmtp.Text != cf.Smtp || tbSender.Text != cf.MailAddress
                                    || tbPassWord.Password != cf.PassWord || tbUserName.Text != cf.MailAddress
                                               || int.Parse(tbPort.Text) != cf.Port || CbSsl.IsChecked != cf.Ssl)
            {
                MessageBoxResult result = MessageBox.Show("変更が反映されてません", "警告", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        //ロード時に一度だけ呼び出される
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Config cf = Config.GetInstance();
            tbSmtp.Text = cf.Smtp;
            tbPort.Text = cf.Port.ToString();
            tbSender.Text = tbUserName.Text = cf.MailAddress;
            tbPassWord.Password = cf.PassWord;
            CbSsl.IsChecked = cf.Ssl;
        }
    }
}
