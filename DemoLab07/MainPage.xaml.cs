﻿using DemoLab07.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DemoLab07
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Friend> Friends;
        public MainPage()
        {
            this.InitializeComponent();
            Friends = FriendManage.GetFriends();
        }
        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var friend = (Friend)e.ClickedItem;
            ResultTextBlock.Text = "You selected" + friend.Name;
        }

    }
}
