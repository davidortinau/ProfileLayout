using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ProfileLayout.Views
{
    public partial class StrengthIndicators : ContentView
    {
        public static readonly BindableProperty StrengthProperty = 
            BindableProperty.Create<StrengthIndicators,Object>(p => p.Strength, default(Object));

        public Object Strength
        {
            get
            {
                return GetValue(StrengthProperty);
            }
            set
            {
                SetValue(StrengthProperty, value);
            }
        }

        public StrengthIndicators()
        {
            InitializeComponent();
        }
    }
}

