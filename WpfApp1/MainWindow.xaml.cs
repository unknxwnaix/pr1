using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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

namespace WpfApp1
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
        public void Main1()
        {
            Random rnd = new Random();
            int bot = rnd.Next(1,3);
            if (bot == 1)
            {
                tb1.Text = "Бот ходит первый";
                Vars.hod++;
                Bothod();
            }
            else
            {
                tb1.Text = "Ты ходишь первый";
            }
        }
        public void proverka()
        {
            int a = 0;
            if (b1.Content == b2.Content && b1.Content == b3.Content)
            {
                a++;
            }
            if (b4.Content == b5.Content && b4.Content == b6.Content)
            {
                a++;
            }
            if (b7.Content == b8.Content && b7.Content == b9.Content)
            {
                a++;
            }

            if (b1.Content == b4.Content && b1.Content == b7.Content)
            {
                a++;
            }
            if (b2.Content == b5.Content && b2.Content == b8.Content)
            {
                a++;
            }
            if (b3.Content == b6.Content && b3.Content == b9.Content)
            {
                a++;
            }

            if (b1.Content == b5.Content && b1.Content == b9.Content)
            {
                a++;
            }
            if (b3.Content == b5.Content && b3.Content == b7.Content)
            {
                a++;
            }
            if (a != 0)
            {
                List<Button> allbuttons = new List<Button> { b1, b2, b3, b4, b5, b6, b7, b8, b9 };
                foreach (Button button in allbuttons)
                {
                    button.IsEnabled = false;
                }
                if (Vars.gamematcher % 2 == 0)
                {
                    Vars.hod++;
                }
                if (Vars.hod % 2 == 0)
                {
                    tb1.Text = "Вы победили";
                }
                else
                {
                    tb1.Text = "Победил бот";
                }
                
            }
            
        }
        public void Bothod()
        {
            Random rnd = new Random();
            Vars.hod++;
            List <Button> allbuttons = new List<Button> { b1, b2, b3, b4, b5, b6, b7, b8, b9 };
            List<Button> allbuttons1 = new List<Button> { };
            if (Vars.hod1 != 10) 
            {
                int a = 0;
                allbuttons.RemoveAt(Vars.hod1-1);
                foreach (Button button in allbuttons)
                {
                    if (button.IsEnabled != false)
                    {
                        allbuttons1.Add(button);
                    }
                    a++;
                }
                allbuttons.Clear();
                foreach (Button button in allbuttons1)
                {
                    allbuttons.Add(button);
                }
                allbuttons1.Clear();
            }
            if (allbuttons.Count != 0)
            {
                int hod = rnd.Next(1, allbuttons.Count);
                allbuttons[hod-1].Content = Vars.hod2;
                allbuttons[hod-1].IsEnabled = false;
                allbuttons.RemoveAt(hod - 1);
            }
            proverka();

        }
        private void startb_Click(object sender, RoutedEventArgs e)
        {
            List<Button> allbuttons = new List<Button> { b1, b2, b3, b4, b5, b6, b7, b8, b9 };
            int a = 0;
            Vars.gamematcher++;
            if (Vars.gamematcher % 2 == 0)
            {
                Vars.hod2 = "O";
            }
            else
            {
                Vars.hod2 = "X";
            }
            foreach (Button button in allbuttons)
            {
                a++;
                button.IsEnabled = true;
                if (a==1)
                {
                    button.Content = "";
                }
                if (a == 2)
                {
                    button.Content = " ";
                }
                if (a == 3)
                {
                    button.Content = "  ";
                }
                if (a == 4)
                {
                    button.Content = "   ";
                }
                if (a == 5)
                {
                    button.Content = "    ";
                    a = 0;
                }
            }
            Main1();
        }
        public void click(int f)
        {
            List<Button> allbuttons = new List<Button> { b1, b2, b3, b4, b5, b6, b7, b8, b9 };
            Vars.hod++;
            if (Vars.hod2 == "X")
            {
                Vars.hod2 = "O";
            }
            else
            {
                Vars.hod2 = "X";
            }
            allbuttons[f - 1].IsEnabled = false;
            allbuttons[f - 1].Content = Vars.hod2;
            if (Vars.hod2 == "X")
            {
                Vars.hod2 = "O";
            }
            else
            {
                Vars.hod2 = "X";
            }
            proverka();
            Vars.hod1 = 1;
            Bothod();
        }
        private void b1_Click(object sender, RoutedEventArgs e)
        {
            click(1);
        }
        private void b2_Click(object sender, RoutedEventArgs e)
        {
            click(2);
        }
        private void b3_Click(object sender, RoutedEventArgs e)
        {
            click(3);
        }
        private void b4_Click(object sender, RoutedEventArgs e)
        {
            click(4);
        }
        private void b5_Click(object sender, RoutedEventArgs e)
        {
            click(5);
        }
        private void b6_Click(object sender, RoutedEventArgs e)
        {
            click(6);
        }
        private void b7_Click(object sender, RoutedEventArgs e)
        {
            click(7);
        }
        private void b8_Click(object sender, RoutedEventArgs e)
        {
            click(8);
        }
        private void b9_Click(object sender, RoutedEventArgs e)
        {
            click(9);
        }   
    }
}
