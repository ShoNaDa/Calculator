using System;
using System.Windows;
using System.Data;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string equation = "";
        public MainWindow()
        {
            InitializeComponent();
        }
        //нажата цифра 1
        private void Click_to_one(object sender, RoutedEventArgs e)
        {
            if (equation == "")
            {
                equation = "1";
                Reply_line.Text = equation;
            }
            else if (equation[equation.Length - 1] == '0' && equation.Length == 1)
            {
                equation = equation.Substring(0, equation.Length - 1);
                equation += "1";
                Reply_line.Text = equation;
            }
            else if (equation[equation.Length - 1] == '0' && equation[equation.Length - 2] != '1' && equation[equation.Length - 2] != '2' && equation[equation.Length - 2] != '3' && equation[equation.Length - 2] != '4' && equation[equation.Length - 2] != '5' && equation[equation.Length - 2] != '6' && equation[equation.Length - 2] != '7' && equation[equation.Length - 2] != '8' && equation[equation.Length - 2] != '9' && equation[equation.Length - 2] != '0')
            {
                equation = equation.Substring(0, equation.Length - 1);
                equation += "1";
                Reply_line.Text = equation;
            }
            else
            {
                equation += "1";
                Reply_line.Text = equation;
            }
        }
        //нажата цифра 2
        private void Click_to_two(object sender, RoutedEventArgs e)
        {
            if (equation == "")
            {
                equation = "2";
                Reply_line.Text = equation;
            }
            else if (equation[equation.Length - 1] == '0' && equation.Length == 1)
            {
                equation = equation.Substring(0, equation.Length - 1);
                equation += "2";
                Reply_line.Text = equation;
            }
            else if (equation[equation.Length - 1] == '0' && equation[equation.Length - 2] != '1' && equation[equation.Length - 2] != '2' && equation[equation.Length - 2] != '3' && equation[equation.Length - 2] != '4' && equation[equation.Length - 2] != '5' && equation[equation.Length - 2] != '6' && equation[equation.Length - 2] != '7' && equation[equation.Length - 2] != '8' && equation[equation.Length - 2] != '9' && equation[equation.Length - 2] != '0')
            {
                equation = equation.Substring(0, equation.Length - 1);
                equation += "2";
                Reply_line.Text = equation;
            }
            else
            {
                equation += "2";
                Reply_line.Text = equation;
            }
        }
        //нажата цифра 3
        private void Click_to_three(object sender, RoutedEventArgs e)
        {
            if (equation == "")
            {
                equation = "3";
                Reply_line.Text = equation;
            }
            else if (equation[equation.Length - 1] == '0' && equation.Length == 1)
            {
                equation = equation.Substring(0, equation.Length - 1);
                equation += "3";
                Reply_line.Text = equation;
            }
            else if (equation[equation.Length - 1] == '0' && equation[equation.Length - 2] != '1' && equation[equation.Length - 2] != '2' && equation[equation.Length - 2] != '3' && equation[equation.Length - 2] != '4' && equation[equation.Length - 2] != '5' && equation[equation.Length - 2] != '6' && equation[equation.Length - 2] != '7' && equation[equation.Length - 2] != '8' && equation[equation.Length - 2] != '9' && equation[equation.Length - 2] != '0')
            {
                equation = equation.Substring(0, equation.Length - 1);
                equation += "3";
                Reply_line.Text = equation;
            }
            else
            {
                equation += "3";
                Reply_line.Text = equation;
            }
        }
        //нажата цифра 4
        private void Click_to_four(object sender, RoutedEventArgs e)
        {
            if (equation == "")
            {
                equation = "4";
                Reply_line.Text = equation;
            }
            else if (equation[equation.Length - 1] == '0' && equation.Length == 1)
            {
                equation = equation.Substring(0, equation.Length - 1);
                equation += "4";
                Reply_line.Text = equation;
            }
            else if (equation[equation.Length - 1] == '0' && equation[equation.Length - 2] != '1' && equation[equation.Length - 2] != '2' && equation[equation.Length - 2] != '3' && equation[equation.Length - 2] != '4' && equation[equation.Length - 2] != '5' && equation[equation.Length - 2] != '6' && equation[equation.Length - 2] != '7' && equation[equation.Length - 2] != '8' && equation[equation.Length - 2] != '9' && equation[equation.Length - 2] != '0')
            {
                equation = equation.Substring(0, equation.Length - 1);
                equation += "4";
                Reply_line.Text = equation;
            }
            else
            {
                equation += "4";
                Reply_line.Text = equation;
            }
        }
        //нажата цифра 5
        private void Click_to_five(object sender, RoutedEventArgs e)
        {
            if (equation == "")
            {
                equation = "5";
                Reply_line.Text = equation;
            }
            else if (equation[equation.Length - 1] == '0' && equation.Length == 1)
            {
                equation = equation.Substring(0, equation.Length - 1);
                equation += "5";
                Reply_line.Text = equation;
            }
            else if (equation[equation.Length - 1] == '0' && equation[equation.Length - 2] != '1' && equation[equation.Length - 2] != '2' && equation[equation.Length - 2] != '3' && equation[equation.Length - 2] != '4' && equation[equation.Length - 2] != '5' && equation[equation.Length - 2] != '6' && equation[equation.Length - 2] != '7' && equation[equation.Length - 2] != '8' && equation[equation.Length - 2] != '9' && equation[equation.Length - 2] != '0')
            {
                equation = equation.Substring(0, equation.Length - 1);
                equation += "5";
                Reply_line.Text = equation;
            }
            else
            {
                equation += "5";
                Reply_line.Text = equation;
            }
        }
        //нажата цифра 6
        private void Click_to_six(object sender, RoutedEventArgs e)
        {
            if (equation == "")
            {
                equation = "6";
                Reply_line.Text = equation;
            }
            else if (equation[equation.Length - 1] == '0' && equation.Length == 1)
            {
                equation = equation.Substring(0, equation.Length - 1);
                equation += "6";
                Reply_line.Text = equation;
            }
            else if (equation[equation.Length - 1] == '0' && equation[equation.Length - 2] != '1' && equation[equation.Length - 2] != '2' && equation[equation.Length - 2] != '3' && equation[equation.Length - 2] != '4' && equation[equation.Length - 2] != '5' && equation[equation.Length - 2] != '6' && equation[equation.Length - 2] != '7' && equation[equation.Length - 2] != '8' && equation[equation.Length - 2] != '9' && equation[equation.Length - 2] != '0')
            {
                equation = equation.Substring(0, equation.Length - 1);
                equation += "6";
                Reply_line.Text = equation;
            }
            else
            {
                equation += "6";
                Reply_line.Text = equation;
            }
        }
        //нажата цифра 7
        private void Click_to_seven(object sender, RoutedEventArgs e)
        {
            if (equation == "")
            {
                equation = "7";
                Reply_line.Text = equation;
            }
            else if (equation[equation.Length - 1] == '0' && equation.Length == 1)
            {
                equation = equation.Substring(0, equation.Length - 1);
                equation += "7";
                Reply_line.Text = equation;
            }
            else if (equation[equation.Length - 1] == '0' && equation[equation.Length - 2] != '1' && equation[equation.Length - 2] != '2' && equation[equation.Length - 2] != '3' && equation[equation.Length - 2] != '4' && equation[equation.Length - 2] != '5' && equation[equation.Length - 2] != '6' && equation[equation.Length - 2] != '7' && equation[equation.Length - 2] != '8' && equation[equation.Length - 2] != '9' && equation[equation.Length - 2] != '0')
            {
                equation = equation.Substring(0, equation.Length - 1);
                equation += "7";
                Reply_line.Text = equation;
            }
            else
            {
                equation += "7";
                Reply_line.Text = equation;
            }
        }
        //нажата цифра 8
        private void Click_to_eight(object sender, RoutedEventArgs e)
        {
            if (equation == "")
            {
                equation = "8";
                Reply_line.Text = equation;
            }
            else if (equation[equation.Length - 1] == '0' && equation.Length == 1)
            {
                equation = equation.Substring(0, equation.Length - 1);
                equation += "8";
                Reply_line.Text = equation;
            }
            else if (equation[equation.Length - 1] == '0' && equation[equation.Length - 2] != '1' && equation[equation.Length - 2] != '2' && equation[equation.Length - 2] != '3' && equation[equation.Length - 2] != '4' && equation[equation.Length - 2] != '5' && equation[equation.Length - 2] != '6' && equation[equation.Length - 2] != '7' && equation[equation.Length - 2] != '8' && equation[equation.Length - 2] != '9' && equation[equation.Length - 2] != '0')
            {
                equation = equation.Substring(0, equation.Length - 1);
                equation += "8";
                Reply_line.Text = equation;
            }
            else
            {
                equation += "8";
                Reply_line.Text = equation;
            }
        }
        //нажата цифра 9
        private void Click_to_nine(object sender, RoutedEventArgs e)
        {
            if (equation == "")
            {
                equation = "9";
                Reply_line.Text = equation;
            }
            else if (equation[equation.Length - 1] == '0' && equation.Length == 1)
            {
                equation = equation.Substring(0, equation.Length - 1);
                equation += "9";
                Reply_line.Text = equation;
            }
            else if (equation[equation.Length - 1] == '0' && equation[equation.Length - 2] != '1' && equation[equation.Length - 2] != '2' && equation[equation.Length - 2] != '3' && equation[equation.Length - 2] != '4' && equation[equation.Length - 2] != '5' && equation[equation.Length - 2] != '6' && equation[equation.Length - 2] != '7' && equation[equation.Length - 2] != '8' && equation[equation.Length - 2] != '9' && equation[equation.Length - 2] != '0')
            {
                equation = equation.Substring(0, equation.Length - 1);
                equation += "9";
                Reply_line.Text = equation;
            }
            else
            {
                equation += "9";
                Reply_line.Text = equation;
            }
        }
        //нажата цифра 0
        private void Click_to_zero(object sender, RoutedEventArgs e)
        {
            if (equation == "" || equation == "0")
            {
                equation = "0";
                Reply_line.Text = equation;
            } 
            else if (equation[equation.Length - 1] == '0' && (equation[equation.Length - 2] == '-' || equation[equation.Length - 2] == '*' || equation[equation.Length - 2] == '+'))
            {
                equation = equation.Substring(0, equation.Length - 1);
                equation += "0";
                Reply_line.Text = equation;
            }
            else if (equation[equation.Length - 1] == '/')
            {
                MessageBox.Show(Convert.ToString("Ошибка!"));
            }
            else
            {
                equation += "0";
                Reply_line.Text = equation;
            }
        }
        //нажата кнопка минус
        private void Click_to_minus(object sender, RoutedEventArgs e)
        {
            if (equation == "")
            {
                equation = "-";
                Reply_line.Text = equation;
            }
            else if (equation[equation.Length - 1] == '/' || equation[equation.Length - 1] == '*' || equation[equation.Length - 1] == '+' || equation[equation.Length - 1] == '-')
            {
                equation = equation.Substring(0, equation.Length - 1);
                equation += "-";
                Reply_line.Text = equation;
            }
            else
            {
                equation += "-";
                Reply_line.Text = equation;
            }
        }
        //нажата кнопка плюс
        private void Click_to_plus(object sender, RoutedEventArgs e)
        {
            if (equation == "")
            {
                MessageBox.Show(Convert.ToString("Ошибка!"));
            }
            else if (equation[equation.Length - 1] == '/' || equation[equation.Length - 1] == '*' || equation[equation.Length - 1] == '+' || equation[equation.Length - 1] == '-')
            {
                equation = equation.Substring(0, equation.Length - 1);
                equation += "+";
                Reply_line.Text = equation;
            }
            else
            {
                equation += "+";
                Reply_line.Text = equation;
            }
        }
        //нажата кнопка умножить
        private void Click_to_multiply(object sender, RoutedEventArgs e)
        {
            if (equation == "")
            {
                MessageBox.Show(Convert.ToString("Ошибка!"));
            }
            else if (equation[equation.Length - 1] == '/' || equation[equation.Length - 1] == '*' || equation[equation.Length - 1] == '+' || equation[equation.Length - 1] == '-')
            {
                equation = equation.Substring(0, equation.Length - 1);
                equation += "*";
                Reply_line.Text = equation;
            }
            else
            {
                equation += "*";
                Reply_line.Text = equation;
            }
        }
        //нажата кнопка разделить
        private void Click_to_divide(object sender, RoutedEventArgs e)
        {
            if (equation == "")
            {
                MessageBox.Show(Convert.ToString("Ошибка!"));
            }
            else if (equation[equation.Length - 1] == '/' || equation[equation.Length - 1] == '*' || equation[equation.Length - 1] == '+' || equation[equation.Length - 1] == '-')
            {
                equation = equation.Substring(0, equation.Length - 1);
                equation += "/";
                Reply_line.Text = equation;
            }
            else
            {
                equation += "/";
                Reply_line.Text = equation;
            }
        }
        //нажата кнопка равно
        private void Click_to_equal(object sender, RoutedEventArgs e)
        {
            if (equation[equation.Length - 1] == '/' || equation[equation.Length - 1] == '*' || equation[equation.Length - 1] == '+' || equation[equation.Length - 1] == '-')
            {
                MessageBox.Show(Convert.ToString("Ошибка!"));
            }
            else
            {
                try
                {

                    //Ответ             
                    var result = new DataTable().Compute(equation, null);
                    equation = Convert.ToString(result);
                    Reply_line.Text = Convert.ToString(result);
                }
                catch (FormatException message)
                {
                    //сообщение об ошибке если шо
                    MessageBox.Show(Convert.ToString(message));
                }
            }
        }
        //нажата кнопка стереть
        private void Click_to_clear(object sender, RoutedEventArgs e)
        {
            equation = "";
            Reply_line.Text = "0";
        }
    }
}
