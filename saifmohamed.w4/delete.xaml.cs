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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace saifmohamed.w4
{
    /// <summary>
    /// Interaction logic for delete.xaml
    /// </summary>
    public partial class delete : Page
    {
        facebokkEntities db = new facebokkEntities();
        public delete()
        {
            InitializeComponent();
        }

        private void dltbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                db.userrs.Remove(db.userrs.First(x => x.phonenum == photxt.Text));
                db.SaveChanges();
                dg.ItemsSource = db.userrs.ToList();

            }
            catch
            {
                MessageBox.Show("this phonenumber is invalid");
            }
        }
      
    }
}
