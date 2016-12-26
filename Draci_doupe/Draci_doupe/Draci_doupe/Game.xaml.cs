using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Draci_doupe
{
    /// <summary>
    /// Interakční logika pro Game.xaml
    /// </summary>
    public partial class Game : Page
    {
        Chapter chapter = new Chapter(0);
        Task task = new Task(0);
        public Game()
        {
            InitializeComponent();
            Title.Text = chapter.Name_Chapter;
            Text.Text = chapter.Text_Chapter;
            Task_title.Text = task.Name_task;
            List<string> Task_option = new List<string>();
            Task_option = task.TaskSplit(task.Text_Task);
            Task_1.ItemsSource = Task_option;
        }

        private void HintButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HelperButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void InventoryButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
