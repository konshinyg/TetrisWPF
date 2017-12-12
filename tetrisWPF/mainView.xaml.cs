using System;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using System.Windows.Shapes;
using System.Windows.Media.Imaging;

namespace tetrisWPF
{
    public partial class mainView : Window
    {
        double currentSpeed;
        string path = Directory.GetCurrentDirectory();
        bool pushAble = true;
        Brush currentColor = new ImageBrush(new BitmapImage(new Uri("skins/black.jpg", UriKind.Relative)));
        background fone;
        optionsView optView;
        DispatcherTimer mainTimer;

        public mainView()
        {
            InitializeComponent();

        }

        private void mainView_Initialized(object sender, EventArgs e)
        {
            fone = new background(gameSpace, previewSpace);
            optView = new optionsView();
            optView.getParent(this);
            mainTimer = new DispatcherTimer();
            mainTimer.Tick += new EventHandler(encreaseStep);
            mainTimer.Interval = new TimeSpan(0, 0, 0, 0, 400);
            this.fone.FigureBackgroundColor = currentColor;
            mainTimer.Start();
        }

        private void gameReload()
        {
            pushAble = false;
            for (int i = 0; i < gameSpace.RowDefinitions.Count; ++i)
            {
                for (int j = 0; j < gameSpace.ColumnDefinitions.Count; ++j)
                    gameSpace.Children.Remove(this.fone.foneMatrix[i, j]);
            }

            for (int i = 0; i < previewSpace.RowDefinitions.Count; ++i)
            {
                for (int j = 0; j < previewSpace.ColumnDefinitions.Count; ++j)
                    previewSpace.Children.Remove(this.fone.prevMatrix[i, j]);
            }

            fone = new background(gameSpace, previewSpace);
            this.fone.FigureBackgroundColor = currentColor;
            optView = new optionsView();
            optView.getParent(this);
            mainTimer.Start();
        }

        private void encreaseStep(object sender, EventArgs e)
        {
            if (fone.Loose == true)
            {
                mainTimer.Stop();
                if (MessageBox.Show("Повторим?", "Вы проиграли!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                    Application.Current.Shutdown();
                else
                    gameReload();
            }
            score.Text = fone.CurrentScore.ToString();
            fone.encreaseStepDown();
            pushAble = true;
        }

        // метод для запуска таймера при выхода из окна настроек
        public void MTEnabled()
        {
            mainTimer.IsEnabled = true;
        }

        public void timerSpeed(double t)
        {
            currentSpeed = t;
            mainTimer.Interval = new TimeSpan(0, 0, 0, 0, 400 - (int)currentSpeed);
        }

        // метод для изменения цвета фона
        public void changeFoneColor(Brush figureColor)
        {
            currentColor = figureColor;
            this.fone.FigureBackgroundColor = currentColor;
            this.fone.checkFieldColor();
            this.fone.checkPreviewColor();
        }

        private void view_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.A:
                case Key.Down:
                    if (e.KeyboardDevice.IsKeyDown(Key.Down))
                        mainTimer.Interval = new TimeSpan(0, 0, 0, 0, 20);
                    break;
                case Key.Space:
                    if (optView.IsActive == true)
                        mainTimer.IsEnabled = false;
                    else
                        mainTimer.IsEnabled = !mainTimer.IsEnabled;
                    break;

                case Key.Q:
                case Key.Up:
                    if (mainTimer.IsEnabled == true && pushAble == true)
                        fone.foneTurnShape();
                    break;

                case Key.O:
                case Key.Left:
                    if (mainTimer.IsEnabled == true && pushAble == true)
                        fone.foneMoveShape('L');
                    break;

                case Key.P:
                case Key.Right:
                    if (mainTimer.IsEnabled == true && pushAble == true)
                        fone.foneMoveShape('R');
                    break;
                default:
                    break;
            }
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            optView.Show();
            mainTimer.IsEnabled = false;
            optView.speedTrackBar.Value = currentSpeed;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void main_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyboardDevice.IsKeyUp(Key.Down) || e.KeyboardDevice.IsKeyUp(Key.A))
                timerSpeed(currentSpeed);
        }
    }
}
