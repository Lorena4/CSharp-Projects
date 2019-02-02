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

namespace Calculator1._1
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
            t.Text = t.Text + "1";
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            t.Text = t.Text + "2";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            t.Text = t.Text + "3";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            t.Text = t.Text + "4";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            t.Text = t.Text + "5";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            t.Text = t.Text + "6";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            t.Text = t.Text + "7";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            t.Text = t.Text + "8";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            t.Text = t.Text + "9";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            t.Text = t.Text + "0";
        }

       
        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            t.Text = t.Text + ".";
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            t.Text = "";
        }

        private void bO1_Click(object sender, RoutedEventArgs e)
        {
            t.Text = t.Text + "/";
        }

        private void bO2_Click(object sender, RoutedEventArgs e)
        {
            t.Text = t.Text + "*";
        }

        private void bO4_Click(object sender, RoutedEventArgs e)
        {
            t.Text = t.Text + "-";
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            Type scriptType = Type.GetTypeFromCLSID(Guid.Parse("0E59F1D5-1FBE-11D0-8FF2-00A0D10038BC"));
            dynamic obj = Activator.CreateInstance(scriptType, false);
            obj.Language = "javascript";
            string str = null;
           
           
          try{
                var result = obj.Eval(t.Text);
                str = Convert.ToString(result);
                t.Text = str;
                }

            catch (Exception){
               Console.Write("Error!");
            }
;            
          

        }

        private void Undo_Click(object sender, RoutedEventArgs e)
        {
            if (t.Text != "")
            {
                t.Text = t.Text.Remove(t.Text.Length - 1);
            }
        }

        private void bO3_Click(object sender, RoutedEventArgs e)
        {
            t.Text = t.Text + "+";
        }

    }
}
