using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BottomBar
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton my = sender as RadioButton;
            switch (my.ClassId)
            {
                case "r1":
                    label1.Text = "Burger Page";
                    break;

                case "r2":
                    label1.Text = "Drink Page";
                    break;

                case "r4":
                    label1.Text = "Ice Cream Page";
                    break;

                case "r5":
                    label1.Text = "Fish Page";
                    break;


                default:
                    break;
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (path1.Rotation == 0)
            {
                var parentAnimation = new Animation();
                var Animation1 = new Animation(v => path1.Rotation = v, 0, 45, Easing.CubicOut);
                var Animation2 = new Animation(v => grid1.HeightRequest = v, 0, 300, Easing.CubicOut);
                parentAnimation.Add(0, 0.5, Animation1);
                parentAnimation.Add(0, 0.5, Animation2);
                parentAnimation.Commit(this, "ChildAnimations", 16, 1000, null, null);
            }
            else
            {
                var parentAnimation = new Animation();
                var Animation1 = new Animation(v => path1.Rotation = v, 45, 0, Easing.CubicOut);
                var Animation2 = new Animation(v => grid1.HeightRequest = v, 300, 0, Easing.CubicOut);
                parentAnimation.Add(0, 0.5, Animation1);
                parentAnimation.Add(0, 0.5, Animation2);
                parentAnimation.Commit(this, "ChildAnimations1", 16, 1000, null, null);
            }

        }
    }
}
