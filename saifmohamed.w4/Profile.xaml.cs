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
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        facebokkEntities db = new facebokkEntities();
        public Profile(string dataa)
        {
            userr userr = new userr();
            InitializeComponent();
            data.ItemsSource = db.userrs.Where(x => x.username == dataa).ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sign_in sign_In = new sign_in();
            this.NavigationService.Navigate(sign_In);
        }

    }
}
