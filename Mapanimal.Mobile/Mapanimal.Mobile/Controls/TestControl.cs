using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Mapanimal.Mobile.Controls
{
    public class TestControl : View
    {
        public static readonly BindableProperty NameProperty = BindableProperty.Create("Name", typeof(string), typeof(TestControl), "test");

        public string Name
        {
            get { return GetValue(TestControl.NameProperty) as string; }
            set { SetValue(TestControl.NameProperty, value); }
        }

    }
}
