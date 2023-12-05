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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace saifmohamed.w4
{
    /// <summary>
    /// Interaction logic for sign_in.xaml
    /// </summary>
    public partial class sign_in : Page
    {
        facebokkEntities db = new facebokkEntities();
        public sign_in()
        {
            InitializeComponent();
        }

        private void signinbtn_Click(object sender, RoutedEventArgs e)
        {

            try

            {
                string dataa = usntxt.Text;
                userr userr = new userr();

                userr = db.userrs.First(x => usntxt.Text == x.username && pastxt.Password == x.pass);
                if (userr != null)
                {
                    Profile profile = new Profile(usntxt.Text);
                    this.NavigationService.Navigate(profile);
                }
            }
            catch
            {
                MessageBox.Show("invalid username or password");
            }

        }

        private void signupbtn_Click(object sender, RoutedEventArgs e)
        {
            sign_up sign_Up = new sign_up();
            this.NavigationService.Navigate(sign_Up);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            forget_password forget_Password = new forget_password();
            this.NavigationService.Navigate(forget_Password);
        }

        private void adminpage_Click(object sender, RoutedEventArgs e)
        {
           admin_login admin_Login = new admin_login();
            this.NavigationService.Navigate(admin_Login);
        }
    }
}
