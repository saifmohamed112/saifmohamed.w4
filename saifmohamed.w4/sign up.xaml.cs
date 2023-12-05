using System;
using System.Collections.Generic;
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
    /// Interaction logic for sign_up.xaml
    /// </summary>,
    public partial class sign_up : Page
    {
        facebokkEntities db = new facebokkEntities();
        public sign_up()
        {
            InitializeComponent();
        }

        private void sgninbtn_Click(object sender, RoutedEventArgs e)
        {
            sign_in sign_In = new sign_in();
            this.NavigationService.Navigate(sign_In);
        }

        private void signupbtn_Click(object sender, RoutedEventArgs e)
        {
            if (passtxt.Text.Length > 8 && Regex.IsMatch(passtxt.Text, @"^(?=.*[A-Z])(?=.*[1234567890])(?=.*[!@#$%^&*()_+<>/?.])"))
            {
                var compo = city_cmp.SelectedItem.ToString().Split(' ').Last();
                var cmpp = gender_cmp.SelectedItem.ToString().Split(' ').Last();

                if (compo == "cairo" )
                {

                    if (cmpp == "male" )
                    {
                        userr userr = new userr();
                        userr.username = usrnmetxt.Text;
                        userr.pass = passtxt.Text;
                        userr.age = int.Parse(agetxt.Text);
                        userr.city = "cairo";
                        userr.gender = "male";
                        userr.phonenum = photxt.Text;
                        db.userrs.Add(userr);
                        db.SaveChanges();
                        sign_in sign_Up = new sign_in();
                        this.NavigationService.Navigate(sign_Up);
                    }
                   else 
                    {
                        userr userr = new userr();
                        userr.username = usrnmetxt.Text;
                        userr.pass = passtxt.Text;
                        userr.age = int.Parse(agetxt.Text);
                        userr.phonenum = photxt.Text;
                        userr.city = "cairo";
                        userr.gender = "female";
                        db.userrs.Add(userr);
                        db.SaveChanges();
                        sign_in sign_Up = new sign_in();
                        this.NavigationService.Navigate(sign_Up);
                    }

                }
                else if (compo == "monofia")
                {
                    if (cmpp == "male")
                    {
                        userr userr = new userr();
                        userr.username = usrnmetxt.Text;
                        userr.pass = passtxt.Text;
                        userr.phonenum = photxt.Text;
                        userr.age = int.Parse(agetxt.Text);
                        userr.city = "monofia";
                        userr.gender = "male";
                        db.userrs.Add(userr);
                        db.SaveChanges();
                        sign_in sign_Up = new sign_in();
                        this.NavigationService.Navigate(sign_Up);
                    }
                    else
                    {
                        userr userr = new userr();
                        userr.username = usrnmetxt.Text;
                        userr.pass = passtxt.Text;
                        userr.phonenum = photxt.Text;
                        userr.age = int.Parse(agetxt.Text);
                        userr.city = "monofia";
                        userr.gender = "female";
                        db.userrs.Add(userr);
                        db.SaveChanges();
                        sign_in sign_Up = new sign_in();
                        this.NavigationService.Navigate(sign_Up);
                    }


                }
                else if (compo == "alexandria") 
                {
                    if (cmpp == "male")
                    {
                        userr userr = new userr();
                        userr.username = usrnmetxt.Text;
                        userr.pass = passtxt.Text;
                        userr.age = int.Parse(agetxt.Text);
                        userr.phonenum = photxt.Text;
                        userr.city = "alexandria";
                        userr.gender = "male";
                        db.userrs.Add(userr);
                        db.SaveChanges();
                        sign_in sign_Up = new sign_in();
                        this.NavigationService.Navigate(sign_Up);
                    }
                    else 
                    {
                        userr userr = new userr();
                        userr.username = usrnmetxt.Text;
                        userr.pass = passtxt.Text;
                        userr.age = int.Parse(agetxt.Text);
                        userr.phonenum = photxt.Text;
                        userr.city = "alexandria";
                        userr.gender = "female";
                        db.userrs.Add(userr);
                        db.SaveChanges();
                        sign_in sign_Up = new sign_in();
                        this.NavigationService.Navigate(sign_Up);
                    }


                }
                else if (compo == "asyote")
                {
                    if (cmpp == "male")
                    {
                        userr userr = new userr();
                        userr.username = usrnmetxt.Text;
                        userr.pass = passtxt.Text;
                        userr.phonenum = photxt.Text;
                        userr.age = int.Parse(agetxt.Text);
                        userr.city = "asyote";
                        userr.gender = "asyote";
                        db.userrs.Add(userr);
                        db.SaveChanges();
                        sign_in sign_Up = new sign_in();
                        this.NavigationService.Navigate(sign_Up);
                    }
                    else 
                    {
                        userr userr = new userr();
                        userr.username = usrnmetxt.Text;
                        userr.pass = passtxt.Text;
                        userr.phonenum = photxt.Text;
                        userr.age = int.Parse(agetxt.Text);
                        userr.city = "asyote";
                        userr.gender = "female";
                        db.userrs.Add(userr);
                        db.SaveChanges();
                        sign_in sign_Up = new sign_in();
                        this.NavigationService.Navigate(sign_Up);
                    }


                }


            }
            else
            {
                MessageBox.Show("Password must more than 8 and be with one cabital key and spesial charactar and number");
            }
         
        }

        private void malera_Checked(object sender, RoutedEventArgs e)
        { 

        }

        private void city_cmp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void gender_cmp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
