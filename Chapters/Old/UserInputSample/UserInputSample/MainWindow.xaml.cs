﻿using System.Windows;

namespace UserInputSample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new InputData();
        }
    }
}
