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

namespace logintohome
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtbox_username.Text !="" && pwdbox_pass.Password =="" && txtbox_fullname.Text =="" && rdobtn_male.IsChecked==true || rdobtn_female.IsChecked==true && rdobtn_married.IsChecked==true || rdobtn_unmarried.IsChecked==true && rdobtn_male.IsChecked==true || rdobtn_married.IsChecked==true && rdobtn_male.IsChecked == true || rdobtn_unmarried.IsChecked == true)
            {
                string gen = "";
                string sur = "";
                if(rdobtn_male.IsChecked== true)
                {
                    gen = "Male";
                    sur = "Mr.";
                }
                else
                {
                    gen = "female";
                    if (rdobtn_married.IsChecked== true)
                    {
                        sur = "Mrs.";
                    }
                    else
                    {
                        sur = "Miss.";
                    }
                }
                loginhome ologin = new loginhome();
                ologin.lbl_welcome.Content = "Welcome " + sur + "." + txtbox_fullname.Text +",\n"+"Your Gender is " +gen;
                ologin.Show();
            }
           
        }
    }
}
