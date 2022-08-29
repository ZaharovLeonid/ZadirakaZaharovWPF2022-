﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
namespace Petzold.PeruseTheMenu 
{ 
    public class PeruseTheMenu : Window 
    { 
        [STAThread]
        public static void Main() 
        { 
            Application app = new Application(); 
            app.Run(new PeruseTheMenu()); 
        } 
        public PeruseTheMenu() 
        { 
            Title = "Ознакомтесь с меню";             
            
            // Создание объекта DockPanel.
            DockPanel dock = new DockPanel();             
            Content = dock;             
            
            // Создание меню, пристыкованного у верхнего края окна.
            Menu menu = new Menu();             
            dock.Children.Add(menu);             
            DockPanel.SetDock(menu, Dock.Top);             
            
            // Создание объекта TextBlock, заполняющего оставшуюся площадь.
            TextBlock text = new TextBlock();             
            text.Text = Title;    
            
            text.FontSize = 32;   // 24 пункта.
            text.TextAlignment = TextAlignment.Center;  //текст выравнивается по центру           
            dock.Children.Add(text);             
            
            // Создание меню File.
            MenuItem itemFile = new MenuItem();             
            itemFile.Header = "_File";             
            menu.Items.Add(itemFile);  
            
            MenuItem itemNew = new MenuItem();             
            itemNew.Header = "_New";             
            itemNew.Click += UnimplementedOnClick;             
            itemFile.Items.Add(itemNew);    
            
            MenuItem itemOpen = new MenuItem();             
            itemOpen.Header = "_Open";             
            itemOpen.Click += UnimplementedOnClick;             
            itemFile.Items.Add(itemOpen);  
            
            MenuItem itemSave = new MenuItem();             
            itemSave.Header = "_Save";             
            itemSave.Click += UnimplementedOnClick;             
            itemFile.Items.Add(itemSave); 
            
            itemFile.Items.Add(new Separator()); //рисует горизонтальную разделительную линию
            MenuItem itemExit = new MenuItem();             
            itemExit.Header = "E_xit";             
            itemExit.Click += ExitOnClick;             
            itemFile.Items.Add(itemExit);             
            
            // Создание меню Window.
            MenuItem itemWindow = new MenuItem();             
            itemWindow.Header = "_Window";             
            menu.Items.Add(itemWindow);     
            
            MenuItem itemTaskbar = new MenuItem();             
            itemTaskbar.Header = "_Show in Taskbar";             
            itemTaskbar.IsCheckable = true;   //может быть отмечен галочкой          
            itemTaskbar.IsChecked = ShowInTaskbar;         
            itemTaskbar.Click += TaskbarOnClick;             
            itemWindow.Items.Add(itemTaskbar);  
            
            MenuItem itemSize = new MenuItem();             
            itemSize.Header = "Size to _Content";            
            itemSize.IsCheckable = true;             
            itemSize.IsChecked = SizeToContent ==  SizeToContent.WidthAndHeight;             
            itemSize.Checked += SizeOnCheck;             
            itemSize.Unchecked += SizeOnCheck;             
            itemWindow.Items.Add(itemSize);  
            
            MenuItem itemResize = new MenuItem();             
            itemResize.Header = "_Resizable";             
            itemResize.IsCheckable = true;             
            itemResize.IsChecked = ResizeMode ==  ResizeMode.CanResize;             
            itemResize.Click += ResizeOnClick;             
            itemWindow.Items.Add(itemResize); 
            
            MenuItem itemTopmost = new MenuItem();             
            itemTopmost.Header = "_Topmost";             
            itemTopmost.IsCheckable = true;            
            itemTopmost.IsChecked = Topmost;             
            itemTopmost.Checked += TopmostOnCheck;             
            itemTopmost.Unchecked += TopmostOnCheck;           
            itemWindow.Items.Add(itemTopmost);         
        }       
        
        void UnimplementedOnClick(object sender,  RoutedEventArgs args)    //обрабатывает события Click для команд
                                                                           //New, Open и Save, выводит сообщение
        {             
            MenuItem item = sender as MenuItem;             
            string strItem = item.Header.ToString ().Replace("_", "");             
            MessageBox.Show("The " + strItem +                             
                " option has not yet  been implemented", Title);         
        }      
        
        void ExitOnClick(object sender,  RoutedEventArgs args)   //закрывает окно      
        { 
            Close();         
        } 

        void TaskbarOnClick(object sender,  RoutedEventArgs args)         
        {             
            MenuItem item = sender as MenuItem;             
            ShowInTaskbar = item.IsChecked;         
        }   
        
        void SizeOnCheck(object sender,  RoutedEventArgs args)         
        {            
            MenuItem item = sender as MenuItem;            
            SizeToContent = item.IsChecked ?  SizeToContent.WidthAndHeight :
                SizeToContent.Manual;         
        }    
        
        void ResizeOnClick(object sender,  RoutedEventArgs args)         
        {            
            MenuItem item = sender as MenuItem;           
            ResizeMode = item.IsChecked ?  ResizeMode.CanResize : 
                ResizeMode.NoResize;         
        }    
        
        void TopmostOnCheck(object sender,  RoutedEventArgs args)         
        {            
            MenuItem item = sender as MenuItem;            
            Topmost = item.IsChecked;         
        }     
    } 
} 