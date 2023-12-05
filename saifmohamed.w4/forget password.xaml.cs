using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for forget_password.xaml
    /// </summary>
    public partial class forget_password : Page
    {
        facebokkEntities db = new facebokkEntities();
        public forget_password()
        {
            InitializeComponent();
        }

        private void updbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (pass_text.Text.Length > 8 && Regex.IsMatch(pass_text.Text, @"^(?=.*[A-Z])(?=.*[1234567890])(?=.*[!@#$%^&*()_+<>/?.])"))
                {
                    if (pass_text.Text == confirmpasstxt.Text)
                    {
                        userr userr = new userr();
                        userr = db.userrs.First(x => x.phonenum == phnenmtxt.Text);
                        userr.pass = pass_text.Text;
                        db.userrs.AddOrUpdate(userr);
                        db.SaveChanges();
                        sign_in sign_in = new sign_in();
                        this.NavigationService.Navigate(sign_in);
                    }
                    else
                    {
                        MessageBox.Show("Password not match");
                    }
                }
                else
                {
                    MessageBox.Show("Password must more than 8 and be with one cabital key and spesial charactar and number");
                }
            }
            catch
            {
                MessageBox.Show("this phone num invalid");
            }
         
                   
                
   

        }
    }
}
