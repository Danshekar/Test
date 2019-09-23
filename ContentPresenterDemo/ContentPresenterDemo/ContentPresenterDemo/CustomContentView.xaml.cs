﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContentPresenterDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomContentView : ContentView
    {
        public static readonly BindableProperty ReadonlyContentProperty = BindableProperty.Create(nameof(ReadonlyContent), typeof(View), typeof(CustomContentView));
        public View ReadonlyContent
        {
            get { return (View)GetValue(ReadonlyContentProperty); }
            set { SetValue(ReadonlyContentProperty, value); }
        }

        public static readonly BindableProperty WritableContentProperty = BindableProperty.Create(nameof(WritableContent), typeof(View), typeof(CustomContentView));
        public View WritableContent
        {
            get { return (View)GetValue(WritableContentProperty); }
            set { SetValue(WritableContentProperty, value); }
        }
        public CustomContentView()
        {
            InitializeComponent();
        }
    }
}