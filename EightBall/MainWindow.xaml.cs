using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace EightBall
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmdAnswer_Click(object sender, RoutedEventArgs e)
        {
            Cursor = Cursors.Wait;

            Task.Delay(TimeSpan.FromSeconds(3)).GetAwaiter().GetResult();

            var generator = new AnswerGenerator();
            txtAnswer.Text = generator.GetRandomAnswer(txtQuestion.Text);
            Cursor = null;
        }
    }
}
