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
    /// Interaction logic for admin_login.xaml
    /// </summary>
    public partial class admin_login : Page
    {
        facebokkEntities db = new facebokkEntities();
        public admin_login()
        {
            InitializeComponent();
        }

        private void signinbtn_Click(object sender, RoutedEventArgs e)
        {
            try

            {
                adminn adminn  = new adminn();

                adminn = db.adminns.First(x => usntxt.Text == x.admin_username && pastxt.Password == x.admin_pass);
                if (adminn != null)
                {
                    search search = new search();
                    this.NavigationService.Navigate(search);
                    
                }
            }
            catch
            {
                MessageBox.Show("invalid username or password");
            }
        }
    }
}
