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

namespace WpfHomeApp2_CalculatorWithGrid
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
        int? num1 = 0, num2 = 0, count = 0; string? op;
        List<History> Gechmish = new() { };
        private void gechmishiArxivleshdir()
        {
            Gechmish.Add(History.getHistory(Misal.Content.ToString(), Cvb.Content.ToString()));

            Misal.Content = num1;
        }

        private void emeliyyatlarSiyahisi(object sender, MouseButtonEventArgs e)
        {
            foreach (var item in Gechmish)
                MessageBox.Show(item.ToString());
        }

        private void Ishlem_withClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.Name == "berabere")
                {

                    if (op != null)
                    {
                        if (op == "+")
                        {
                            Cvb.Content = (num1 + num2).ToString();
                        }
                        else if (op == "-")
                        {
                            Cvb.Content = (num1 - num2).ToString();
                        }
                        else if (op == "X")
                        {
                            Cvb.Content = (num1 * num2).ToString();
                        }
                        else if (op == "/")
                        {
                            Cvb.Content.Equals((num1 / num2).ToString());
                            //Cvb.Content = (num1 / num2).ToString();
                        }


                        Misal.Content += "=";
                        //count = 0;
                        op = null; num1 = 0; num2 = 0;
                    }
                }
                else if (btn.Name == "arti")
                {
                    if (num1 != null)
                    {
                        Misal.Content += "+";
                        op = "+";
                        //count++;
                    }
                }
                else if (btn.Name == "eksi")
                {
                    if (num1 != null)
                    {
                        Misal.Content += "-";
                        op = "-";
                        //count++;
                    }
                }
                else if (btn.Name == "charpi")
                {
                    if (num1 != null)
                    {
                        Misal.Content += "X";
                        op = "X";
                        //count++;
                    }
                }
                else if (btn.Name == "bolu")
                {
                    if (num1 != null)
                    {
                        Misal.Content += "/";
                        op = "/";
                        // count++;
                    }
                }
                else if(btn.Name == "kare")
                {
                    Cvb.Content = num1 * num1;
                    num1 = 0;
                }
                else if(btn.Name == "paydaOl")
                {
                    double payda = (double)num1;
                    
                    Cvb.Content = 1/ payda;
                    num1 = 0;
                }
                else if(btn.Name == "sifirla")
                {
                    Cvb.Content = "a"; 
                    Misal.Content = "a";
                    num1 = 0; num2 = 0;  // op = "";
                }


                //else if(btn.Name == "Opposite")
                //{
                //    MessageBox.Show(num1.ToString());
                //    if (num1 != null)
                //    {
                //        num2 = -1;
                //        MessageBox.Show(num2.ToString()); //return;
                //    }
                //    else { num1 = -1; MessageBox.Show(num1.ToString()); }
                //}
            }
        }

        private void Rakam_click(object sender, RoutedEventArgs e)
        {
            //foreach (var item in GridRow3.Children )
            //{
            //  if(item is Button btn)
            // {   
            if (sender is Button btn)
            {
                
                if (btn.Content.ToString() == "0")
                        {

                            if (op == null)
                            {
                                num1 = num1 * 10 + 0; gechmishiArxivleshdir();
                                Cvb.Content = num1.ToString(); Misal.Content = num1.ToString();
                            }
                            else
                            {
                                num2 = num2 * 10 + 0; string sec = num2.ToString();
                                Cvb.Content = num2.ToString();

                                Misal.Content = Misal.Content.ToString().Substring(0, Misal.Content.ToString().Length - ((num2 / 10).ToString() + op).Length);

                                Misal.Content += op;
                                //MessageBox.Show(Misal.Content.ToString());
                                Misal.Content += num2.ToString();

                            }

                        }
                        else if (btn.Content.ToString() == "1")
                {

                    if (op == null)
                    {
                        num1 = num1 * 10 + 1; gechmishiArxivleshdir();
                        Cvb.Content = num1.ToString(); Misal.Content = num1.ToString();
                    }
                    else
                    {
                        num2 = num2 * 10 + 1; string sec = num2.ToString();
                        Cvb.Content = num2.ToString();

                        Misal.Content = Misal.Content.ToString().Substring(0, Misal.Content.ToString().Length - ((num2 / 10).ToString() + op).Length);

                        Misal.Content += op;
                        //MessageBox.Show(Misal.Content.ToString());
                        Misal.Content += num2.ToString();

                    }

                }
                /*
                else if (btn.Content.ToString() == "2")
                {
                    Cvb.Content = "2";
                    Misal.Content += "2";

                if (op == null) { num1 = num1 * 10 + 2; gechmishiArxivleshdir(); }
                else num2 = num2 * 10 + 2;
                }
                */


                else if (btn.Content.ToString() == "2")
                {

                    if (op == null)
                    {
                        num1 = num1 * 10 + 2; gechmishiArxivleshdir();
                        Cvb.Content = num1.ToString(); Misal.Content = num1.ToString();
                    }
                    else
                    {
                        num2 = num2 * 10 + 2; string sec = num2.ToString();
                        Cvb.Content = num2.ToString();

                        Misal.Content = Misal.Content.ToString().Substring(0, Misal.Content.ToString().Length - ((num2 / 10).ToString() + op ).Length);

                        Misal.Content += op;
                        //MessageBox.Show(Misal.Content.ToString());
                        Misal.Content += num2.ToString();

                    }

                }





                else if (btn.Content.ToString() == "3")
                {

                    if (op == null)
                    {
                        num1 = num1 * 10 + 3; gechmishiArxivleshdir();
                        Cvb.Content = num1.ToString(); Misal.Content = num1.ToString();
                    }
                    else
                    {
                        num2 = num2 * 10 + 3; string sec = num2.ToString();
                        Cvb.Content = num2.ToString();

                        Misal.Content = Misal.Content.ToString().Substring(0, Misal.Content.ToString().Length - ((num2 / 10).ToString() + op).Length);

                        Misal.Content += op;
                        //MessageBox.Show(Misal.Content.ToString());
                        Misal.Content += num2.ToString();

                    }

                }
                else if (btn.Content.ToString() == "4")
                {

                    if (op == null)
                    {
                        num1 = num1 * 10 + 4; gechmishiArxivleshdir();
                        Cvb.Content = num1.ToString(); Misal.Content = num1.ToString();
                    }
                    else
                    {
                        num2 = num2 * 10 + 4; string sec = num2.ToString();
                        Cvb.Content = num2.ToString();

                        Misal.Content = Misal.Content.ToString().Substring(0, Misal.Content.ToString().Length - ((num2 / 10).ToString() + op).Length);

                        Misal.Content += op;
                        //MessageBox.Show(Misal.Content.ToString());
                        Misal.Content += num2.ToString();

                    }

                }
                else if (btn.Content.ToString() == "5")
                {

                    if (op == null)
                    {
                        num1 = num1 * 10 + 5; gechmishiArxivleshdir();
                        Cvb.Content = num1.ToString(); Misal.Content = num1.ToString();
                    }
                    else
                    {
                        num2 = num2 * 10 + 5; string sec = num2.ToString();
                        Cvb.Content = num2.ToString();

                        Misal.Content = Misal.Content.ToString().Substring(0, Misal.Content.ToString().Length - ((num2 / 10).ToString() + op).Length);

                        Misal.Content += op;
                        //MessageBox.Show(Misal.Content.ToString());
                        Misal.Content += num2.ToString();

                    }

                }
                else if (btn.Content.ToString() == "6")
                {

                    if (op == null)
                    {
                        num1 = num1 * 10 + 6; gechmishiArxivleshdir();
                        Cvb.Content = num1.ToString(); Misal.Content = num1.ToString();
                    }
                    else
                    {
                        num2 = num2 * 10 + 6; string sec = num2.ToString();
                        Cvb.Content = num2.ToString();

                        Misal.Content = Misal.Content.ToString().Substring(0, Misal.Content.ToString().Length - ((num2 / 10).ToString() + op).Length);

                        Misal.Content += op;
                        //MessageBox.Show(Misal.Content.ToString());
                        Misal.Content += num2.ToString();

                    }

                }
                else if (btn.Content.ToString() == "7")
                {

                    if (op == null)
                    {
                        num1 = num1 * 10 + 7; gechmishiArxivleshdir();
                        Cvb.Content = num1.ToString(); Misal.Content = num1.ToString();
                    }
                    else
                    {
                        num2 = num2 * 10 + 7; string sec = num2.ToString();
                        Cvb.Content = num2.ToString();

                        Misal.Content = Misal.Content.ToString().Substring(0, Misal.Content.ToString().Length - ((num2 / 10).ToString() + op).Length);

                        Misal.Content += op;
                        //MessageBox.Show(Misal.Content.ToString());
                        Misal.Content += num2.ToString();

                    }

                }
                else if (btn.Content.ToString() == "8")
                {

                    if (op == null)
                    {
                        num1 = num1 * 10 + 8; gechmishiArxivleshdir();
                        Cvb.Content = num1.ToString(); Misal.Content = num1.ToString();
                    }
                    else
                    {
                        num2 = num2 * 10 + 8; string sec = num2.ToString();
                        Cvb.Content = num2.ToString();

                        Misal.Content = Misal.Content.ToString().Substring(0, Misal.Content.ToString().Length - ((num2 / 10).ToString() + op).Length);

                        Misal.Content += op;
                        //MessageBox.Show(Misal.Content.ToString());
                        Misal.Content += num2.ToString();

                    }

                }
                else if (btn.Content.ToString() == "9")
                {

                    if (op == null)
                    {
                        num1 = num1 * 10 + 9; gechmishiArxivleshdir();
                        Cvb.Content = num1.ToString(); Misal.Content = num1.ToString();
                    }
                    else
                    {
                        num2 = num2 * 10 + 9; string sec = num2.ToString();
                        Cvb.Content = num2.ToString();

                        Misal.Content = Misal.Content.ToString().Substring(0, Misal.Content.ToString().Length - ((num2 / 10).ToString() + op).Length);

                        Misal.Content += op;
                        //MessageBox.Show(Misal.Content.ToString());
                        Misal.Content += num2.ToString();

                    }

                }

            }
        }
    }
}
