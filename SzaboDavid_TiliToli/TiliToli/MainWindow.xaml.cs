using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace TiliToli
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button0.Visibility = Visibility.Hidden;
            ujjatek.IsEnabled = false;
            byte random = 0;
            byte xd = 0;
            byte kever = 0;
            Button nullaGomb = (Button)FindName("Button0");
            Random r = new Random();
            MegtettLepesek.Content = "Megtett lépések száma: ";
            do
            {
                do
                {
                    random = Convert.ToByte(r.Next(1, 9));
                } while (xd == random);
                xd = random;
                string button = "Button" + random;
                Button egyikGomb = (Button)FindName(button);
                int vtav = Math.Abs((int)(egyikGomb.Margin.Left - nullaGomb.Margin.Left));
                int ftav = Math.Abs((int)(egyikGomb.Margin.Top - nullaGomb.Margin.Top));
                if ((vtav < 120 && ftav == 0) || (ftav < 120 && vtav == 0))
                {
                    var seged = egyikGomb.Margin;
                    egyikGomb.Margin = nullaGomb.Margin;
                    nullaGomb.Margin = seged;
                    kever++;
                }
            } while (kever != 103);
            i = 0;
        }

        public int i = 0;
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Button egyikGomb = sender as Button;
            Button nullaGomb = (Button)FindName("Button0");

            int vTav = Math.Abs((int)(egyikGomb.Margin.Left - nullaGomb.Margin.Left));
            int fTav = Math.Abs((int)(egyikGomb.Margin.Top - nullaGomb.Margin.Top));
            if ((vTav <120 && fTav == 0) || (fTav < 120 && vTav == 0)) {
                var seged = egyikGomb.Margin;
                egyikGomb.Margin = nullaGomb.Margin;
                nullaGomb.Margin = seged;
                i++;
                MegtettLepesek.Content = "Megtett lépések száma: " + i;
            }
            if ((int)Button1.Margin.Left == 15 && (int)Button1.Margin.Top == 70 && (int)Button2.Margin.Left == 130 && (int)Button2.Margin.Top == 70 && (int)Button3.Margin.Left == 245 && (int)Button3.Margin.Top == 70 && (int)Button4.Margin.Left == 15 && (int)Button4.Margin.Top == 185 && (int)Button5.Margin.Left == 130 && (int)Button5.Margin.Top == 185 && (int)Button6.Margin.Left == 245 && (int)Button6.Margin.Top == 185 && (int)Button7.Margin.Left == 15 && (int)Button7.Margin.Top == 300 && (int)Button8.Margin.Left == 130 && (int)Button8.Margin.Top == 300)
            {
                MessageBox.Show("Gratulálok! Te egy Tilitoli király vagy! Sikeresen kiraktad " + Convert.ToString(i) + " lépésből!");
                i = 0;
                grat.Content = "Gratulálok!";
                Button1.IsEnabled = false;
                Button2.IsEnabled = false;
                Button3.IsEnabled = false;
                Button4.IsEnabled = false;
                Button5.IsEnabled = false;
                Button6.IsEnabled = false;
                Button7.IsEnabled = false;
                Button8.IsEnabled = false;
                ujjatek.IsEnabled = true;
            }
        }
        private void ujjatek_Click(object sender, RoutedEventArgs e)
        {
            grat.Visibility = Visibility.Hidden;
            ujjatek.IsEnabled = false;
            byte random = 0;
            byte xd = 0;
            byte kever = 0;
            Button nullaGomb = (Button)FindName("Button0");
            Random r = new Random();
            MegtettLepesek.Content = "Megtett lépések száma: ";
            do
            {
                do
                {
                    random = Convert.ToByte(r.Next(1, 9));
                } while (xd == random);
                xd = random;
                string button = "Button" + random;
                Button egyikGomb = (Button)FindName(button);
                int vtav = Math.Abs((int)(egyikGomb.Margin.Left - nullaGomb.Margin.Left));
                int ftav = Math.Abs((int)(egyikGomb.Margin.Top - nullaGomb.Margin.Top));
                if ((vtav < 120 && ftav == 0) || (ftav < 120 && vtav == 0))
                {
                    var seged = egyikGomb.Margin;
                    egyikGomb.Margin = nullaGomb.Margin;
                    nullaGomb.Margin = seged;
                    kever++;
                }
            } while (kever != 103);
            i = 0;
            Button1.IsEnabled = true;
            Button2.IsEnabled = true;
            Button3.IsEnabled = true;
            Button4.IsEnabled = true;
            Button5.IsEnabled = true;
            Button6.IsEnabled = true;
            Button7.IsEnabled = true;
            Button8.IsEnabled = true;
            ujjatek.IsEnabled = false;
        }
    }
}
