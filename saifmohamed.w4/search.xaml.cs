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
    /// Interaction logic for search.xaml
    /// </summary>
    public partial class search : Page
    {
        facebokkEntities db = new facebokkEntities();
        public search()
        {
            InitializeComponent();
        }

        private void dltbtn_Click(object sender, RoutedEventArgs e)
        {
            var dep = citytxt.Text;
            dg.ItemsSource = db.userrs.Where(x => x.city == dep).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            delete delete = new delete();
            this.NavigationService.Navigate(delete);
        }
    }
}
