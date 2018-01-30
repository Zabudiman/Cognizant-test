﻿using System;
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

namespace DesktopCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string part1 = "";
        private string part2 = "";
        private string action;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void executeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void num1btn_Click(object sender, RoutedEventArgs e)
        {
            string buttonValue = ((Button)sender).Content.ToString();
            resultBox.Text = resultBox.Text + buttonValue;
            part1 = part1 + buttonValue;
        }

        private void action_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text = resultBox.Text + ((Button)sender).Content.ToString();
            part2 = part1;
            part1 = "";
            action = ((Button)sender).Content.ToString();
        }

        //private void action_Click(object sender, RoutedEventArgs e)
        //{
        //    resultBox.Text = resultBox.Text + ((Button)sender).Content.ToString();
        //    part2 = part1;
        //    part1 = "";
        //    action = "-";
        //}

        private void executeBtn_Click(object sender, RoutedEventArgs e)
        {
            int part1num = int.Parse(part1);
            int part2num = int.Parse(part2);
            switch (action)
            {
                case "+";
                    resultBox.Text = (part2num + part1num).ToString();
                    break;
                case "-";
                    resultBox.Text = (part2num - part1num).ToString();
                    break;
                case "*";
                    resultBox.Text = (part2num * part1num).ToString();
                    break;
                case "/";
                    resultBox.Text = (part2num / part1num).ToString();
                    break;
            }
            //if (action == "+")
            //{
            //    resultBox.Text = (part2num + part1num).ToString();
            //}
            //else if (action == "-")
            //{
            //    resultBox.Text = (part2num - part1num).ToString();
            //}
            //else if (action == "*")
            //{
            //    resultBox.Text = (part2num * part1num).ToString();
            //}
            //else if (action == "/")
            //{
            //    resultBox.Text = (part2num / part1num).ToString();
            //}

            part1 = resultBox.Text;
        }

        private void multiplyBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void divideBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}