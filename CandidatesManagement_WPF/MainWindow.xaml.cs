using CandidateManagement_Service;
using CandidateManagement_WPF;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CandidatesManagement_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IHRAccountService hRAccountService;
        public MainWindow()
        {
            InitializeComponent();
            hRAccountService = new HRAccountService();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var account = hRAccountService.GetAccountByEmail(txtEmail.Text);
            if (account != null)
            {
                if (account.Password == txtPassword.Password)
                {


                    if (account.MemberRole == 1)
                    {
                        CandidateProfileWindow candidateProfileWindow = new CandidateProfileWindow();
                        candidateProfileWindow.Show();
                    }
                    else if (account.MemberRole == 2)
                    {
                        JobPostingWindow jobPostingWindow = new JobPostingWindow();
                        jobPostingWindow.Show();
                    }
                    else
                    {
                        MessageBox.Show("Access Denid!!");
                    }


                }
                else
                {
                    MessageBox.Show("Password isn't correct", "Alert Title", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Account doesn't exist", "Alert Title", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}