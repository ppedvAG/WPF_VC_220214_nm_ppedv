using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Multithreading
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Btn_LongTask_Click(object sender, RoutedEventArgs e)
        {
            Btn_LongTask.IsEnabled = false;

            //var task = Task.Run(() =>
            //{
            //    Thread.Sleep(2000);

            //    return "Long Task Completed";

            //});

            //task.ContinueWith(t =>
            //{
            //    Dispatcher.Invoke(() =>
            //    {
            //        Btn_LongTask.IsEnabled = true;

            //        Tbl_LongTask.Text = t.Result;
            //    });
            //});

            string taskResult = "";

            try
            {
                taskResult = await Task.Run(() =>
                {
                    Thread.Sleep(2000);

                    return "Long Task Completed";
                });
            }
            catch { }

            Btn_LongTask.IsEnabled = true;

            Tbl_LongTask.Text = taskResult;
        }

        public int Counter { get; set; } = 0;

        private void Btn_ShortTask_Click(object sender, RoutedEventArgs e)
        {
            Counter++;

            Tbl_ShortTask.Text = Counter.ToString();
        }
    }
}
