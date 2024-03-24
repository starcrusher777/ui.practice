using Avalonia.Controls;
using Avalonia.Interactivity;
using Tmds.DBus.Protocol;
using System;
using Avalonia.Controls.Notifications;

namespace Avalonia.TestApp.Views;

public partial class MainWindow : Window
{
    private readonly INotificationManager _notificationManager;
    public MainWindow()
    {
        InitializeComponent();
        //_notificationManager = new WindowNotificationManager(this);
    }
    private void ClosePane_Click(object? sender, RoutedEventArgs routedEventArgs)
    {
        //MySplitView.IsPaneOpen = true;
    }

    //public void buttonClick(object? sender, RoutedEventArgs routedEventArgs)
    //{
    //    _notificationManager.Show(new Notification("Window", "You clicked a button"));
    //}
}