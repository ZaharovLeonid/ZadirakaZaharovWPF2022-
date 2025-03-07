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

namespace TransformedButtons__chapter_29_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Title = "Transformed Buttons";
            // Create Canvas as content of window.
            Canvas canv = new Canvas();
            Content = canv;
            // Untransformed button.
            Button btn = new Button();
            btn.Content = "Untransformed";
            canv.Children.Add(btn);
            Canvas.SetLeft(btn, 50);
            Canvas.SetTop(btn, 100);
            // Translated button.
            btn = new Button();
            btn.Content = "Translated";
            btn.RenderTransform = new TranslateTransform(-100, 150);
            canv.Children.Add(btn);
            Canvas.SetLeft(btn, 200);
            Canvas.SetTop(btn, 100);
            // Scaled button.
            btn = new Button();
            btn.Content = "Scaled";
            btn.RenderTransform = new ScaleTransform(1.5, 4);
            canv.Children.Add(btn);
            Canvas.SetLeft(btn, 350);
            Canvas.SetTop(btn, 100);
            // Skewed button.
            btn = new Button();
            btn.Content = "Skewed";
            btn.RenderTransform = new SkewTransform(0, 20);
            canv.Children.Add(btn);
            Canvas.SetLeft(btn, 500);
            Canvas.SetTop(btn, 100);
            // Rotated button.
            btn = new Button();
            btn.Content = "Rotated";
            btn.RenderTransform = new RotateTransform(-30);
            canv.Children.Add(btn);
            Canvas.SetLeft(btn, 650);
            Canvas.SetTop(btn, 100);
            InitializeComponent();
        }
    }
}
/*using System; 
using System.Windows; 
using System.Windows.Controls; 
using System.Windows.Input;
using System.Windows.Media; 
namespace Petzold.TransformedButtons { 
    public class TransformedButtons : Window {
        [STAThread] public static void Main() {
            Application app = new Application(); 
            app.Run(new TransformedButtons()); }
        public TransformedButtons() {
            Title = "Transformed Buttons"; 
            // Create Canvas as content of window.
            Canvas canv = new Canvas();    
            Content = canv;         
            // Untransformed button.
            Button btn = new Button();    
            btn.Content = "Untransformed";   
            canv.Children.Add(btn);      
            Canvas.SetLeft(btn, 50);    
            Canvas.SetTop(btn, 100);     
            // Translated button.
            btn = new Button();     
            btn.Content = "Translated";    
            btn.RenderTransform = new  TranslateTransform(-100, 150);  
            canv.Children.Add(btn);         
            Canvas.SetLeft(btn, 200);       
            Canvas.SetTop(btn, 100);    
            // Scaled button.
            btn = new Button();    
            btn.Content = "Scaled";      
            btn.RenderTransform = new  ScaleTransform(1.5, 4);     
            canv.Children.Add(btn);           
            Canvas.SetLeft(btn, 350);       
            Canvas.SetTop(btn, 100);          
            // Skewed button.
            btn = new Button();    
            btn.Content = "Skewed";      
            btn.RenderTransform = new  SkewTransform(0, 20);    
            canv.Children.Add(btn);          
            Canvas.SetLeft(btn, 500);           
            Canvas.SetTop(btn, 100);           
            // Rotated button.
            btn = new Button();    
            btn.Content = "Rotated";    
            btn.RenderTransform = new  RotateTransform(-30);      
            canv.Children.Add(btn);     
            Canvas.SetLeft(btn, 650); 
            Canvas.SetTop(btn, 100);   
        }   
    }
}*/