using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace tetrisWPF
{
    public partial class optionsView : Window
    {
        mainView parent;

        public optionsView()
        {
            InitializeComponent();
        }

        public void getParent(mainView view)
        {
            parent = view;
            this.Activate();
        }

        private void closeOptButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Activate();
            parent.MTEnabled();
        }

        private void speedTrackBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (e.NewValue > 0 && e.NewValue <= 120)
                this.speedInfo.Text = "Медленно";
            if (e.NewValue > 120 && e.NewValue <= 240)
                this.speedInfo.Text = "Средне";
            if (e.NewValue > 240)
                this.speedInfo.Text = "Быстро";
            parent.timerSpeed(e.NewValue);
        }

        private void blueFone_Click(object sender, RoutedEventArgs e)
        {
                this.blueFone.IsChecked = true;
                this.redFone.IsChecked = false;
                this.greenFone.IsChecked = false;
                this.blackFone.IsChecked = false;
                parent.changeFoneColor(new ImageBrush(new BitmapImage(new Uri("skins/blue.jpg", UriKind.Relative))));
        }

        private void redFone_Click(object sender, RoutedEventArgs e)
        {
                this.redFone.IsChecked = true;
                this.greenFone.IsChecked = false;
                this.blueFone.IsChecked = false;
                this.blackFone.IsChecked = false;
                parent.changeFoneColor(new ImageBrush(new BitmapImage(new Uri("skins/Red.jpg", UriKind.Relative))));
        }

        private void greenFone_Click(object sender, RoutedEventArgs e)
        {
            this.greenFone.IsChecked = true;
            this.redFone.IsChecked = false;
            this.blueFone.IsChecked = false;
            this.blackFone.IsChecked = false;
            parent.changeFoneColor(new ImageBrush(new BitmapImage(new Uri("skins/green.jpg", UriKind.Relative))));
        }

        private void blackFone_Click(object sender, RoutedEventArgs e)
        {
            this.blackFone.IsChecked = true;
            this.redFone.IsChecked = false;
            this.blueFone.IsChecked = false;
            this.greenFone.IsChecked = false;
            parent.changeFoneColor(new ImageBrush(new BitmapImage(new Uri("skins/black.jpg", UriKind.Relative))));
        }

        private void options_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

    }
}
