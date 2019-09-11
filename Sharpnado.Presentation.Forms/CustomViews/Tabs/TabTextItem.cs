﻿using Xamarin.Forms;

namespace Sharpnado.Presentation.Forms.CustomViews.Tabs
{
    public abstract class TabTextItem : TabItem
    {
        public static readonly BindableProperty FontFamilyProperty = BindableProperty.Create(
            nameof(FontFamily),
            typeof(string),
            typeof(TabTextItem),
            null,
            BindingMode.OneWay);

        public static readonly BindableProperty LabelProperty = BindableProperty.Create(
            nameof(Label),
            typeof(string),
            typeof(TabTextItem),
            string.Empty);

        public static readonly BindableProperty LabelSizeProperty = BindableProperty.Create(
            nameof(LabelSize),
            typeof(double),
            typeof(TabTextItem));

        public static readonly BindableProperty UnselectedLabelColorProperty = BindableProperty.Create(
            nameof(UnselectedLabelColor),
            typeof(Color),
            typeof(TabTextItem));

        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }

        public double LabelSize
        {
            get => (double)GetValue(LabelSizeProperty);
            set => SetValue(LabelSizeProperty, value);
        }

        public Color UnselectedLabelColor
        {
            get => (Color)GetValue(UnselectedLabelColorProperty);
            set => SetValue(UnselectedLabelColorProperty, value);
        }

        public string FontFamily
        {
            get => (string)GetValue(FontFamilyProperty);
            set => SetValue(FontFamilyProperty, value);
        }
    }
}
