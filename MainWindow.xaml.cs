using System;
using System.Windows;

namespace Calculator;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private string currentView = "";
    private string[] preAns;
    private long num1=0, num2=0;
    private bool isFirstPressed = false,newNumber=false;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button8(object sender, RoutedEventArgs e)
    {
        if (newNumber) { currentView = ""; newNumber = false; }
        currentView += '8';
        theView.Text = currentView;
    }

    private void Button9(object sender, RoutedEventArgs e)
    {
        if (newNumber) { currentView = ""; newNumber = false; }
        currentView += '9';
        theView.Text = currentView;
    }

    private void Button4(object sender, RoutedEventArgs e)
    {
        if (newNumber) { currentView = ""; newNumber = false; }
        currentView += '4';
        theView.Text = currentView;
    }

    private void Button5(object sender, RoutedEventArgs e)
    {
        if (newNumber) { currentView = ""; newNumber = false; }
        currentView += '5';
        theView.Text = currentView;
    }

    private void Button6(object sender, RoutedEventArgs e)
    {
        if (newNumber) { currentView = ""; newNumber = false; }
        currentView += '6';
        theView.Text = currentView;
    }

    private void Button1(object sender, RoutedEventArgs e)
    {
        if (newNumber) { currentView = ""; newNumber = false; }
        currentView += '1';
        theView.Text = currentView;
    }

    private void Button2(object sender, RoutedEventArgs e)
    {
        if (newNumber) { currentView = ""; newNumber = false; }
        currentView += '2';
        theView.Text = currentView;
    }

    private void Button3(object sender, RoutedEventArgs e)
    {
        if (newNumber) { currentView = ""; newNumber = false; }
        currentView += '3';
        theView.Text = currentView;
    }

    private void DeleteLastDigite(object sender, RoutedEventArgs e)
    {
        currentView=currentView.Substring(0, currentView.Length-1);
        theView.Text = currentView;
    }

    private void Button0(object sender, RoutedEventArgs e)
    {
        if (newNumber) { currentView = "";newNumber= false; }
        currentView += '0';
        theView.Text = currentView;
    }

    private void ButtonPlus(object sender, RoutedEventArgs e)
    {
        if (isFirstPressed)
        {
            num2 = Convert.ToInt64(currentView);
            num1 += num2;
            currentView = Convert.ToString(num1);
            theView.Text= currentView;
            newNumber = true;
        }
        else
        {
            num1 = Convert.ToInt64(currentView);
            currentView = "";
            theView.Text = currentView;
            isFirstPressed = true;
        }
    }

    private void button7(object sender, RoutedEventArgs e)
    {
        if (newNumber) { currentView = ""; newNumber = false; }
        currentView += '7';
        theView.Text = currentView;
    }
}
