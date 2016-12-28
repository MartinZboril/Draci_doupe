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
        Person person = new Person();
        List<Inventory> inventory = new List<Inventory>();
        Chapter chapter = new Chapter(0);
        Task task = new Task(0);
        Item item = new Item(1);
        
        public Game()
        {
            InitializeComponent();
            inventory.Add(new Inventory(item.ItemId, item.ItemName));
            Title.Text = chapter.Name_Chapter;
            Text.Text = chapter.Text_Chapter;
            Task_title.Text = task.Name_task;
            ItemSource();
        }

        private void HintButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HelperButton_Click(object sender, RoutedEventArgs e)
        {

            HelperPopUp.IsOpen = true;
            Helper.Text = person.Helper;
            Helper1.Text = person.Helper1;
        }

        private void HelperPopUpClose_Click(object sender, RoutedEventArgs e)
        {
            HelperPopUp.IsOpen = false;
        }

        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
            ProfilePopUp.IsOpen = true;
        }

        private void ProfilePopUpClose_Click(object sender, RoutedEventArgs e)
        {
            ProfilePopUp.IsOpen = false;
        }

        private void InventoryButton_Click(object sender, RoutedEventArgs e)
        {
            InventoryPopUp.IsOpen = true;
        }

        private void InventoryPopUpClose_Click(object sender, RoutedEventArgs e)
        {
            InventoryPopUp.IsOpen = false;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox chkZone = (CheckBox)sender;
            if (task.Type_task.Equals("vyber_hrdiny"))
            {
                Continue_button.Content = person.GetHelper(chkZone.Tag.ToString());
                if (!person.Helper.Equals("Neni") && !person.Helper1.Equals("Neni"))
                {
                    chapter = new Chapter(chapter.ID_Chapter + 1);
                    task = new Task(task.Id_Task + 1);
                    Continue_button.Visibility = System.Windows.Visibility.Hidden;
                }

            } else if(task.Type_task.Equals("vyber"))
            {
                if (chkZone.Tag.ToString().Equals("Ano"))
                {
                    Item item = new Item(task.Reward_Task);
                    inventory.Add(new Inventory(item.ItemId, item.ItemName));
                }
                chapter = new Chapter(chapter.ID_Chapter + 1);
                task = new Task(task.Id_Task + 1);
            }
            Title.Text = chapter.Name_Chapter;
            Text.Text = chapter.Text_Chapter;
            Task_title.Text = task.Name_task;
            ItemSource();
        }
        private void ItemSource()
        {
            List<string> Task_option = new List<string>();
            Task_option = task.TaskSplit(task.Text_Task);
            Task_1.ItemsSource = Task_option;
            Inventory_List.ItemsSource = inventory;
        }
    }
}
