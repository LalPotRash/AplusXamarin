﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChooseProjPage : ContentPage
    {
        public ChooseProjPage()
        {
            InitializeComponent();
        }

        private void ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}