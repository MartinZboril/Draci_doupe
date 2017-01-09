using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Draci_doupe.Properties;
using Draci_doupe.Classes;
using Draci_doupe.Shop;
using Draci_doupe.ProgressBar;

namespace Draci_doupe
{
    /// <summary>
    /// Interakční logika pro Game.xaml
    /// </summary>
    public partial class Game : Page
    {
        //---- Instance tříd ----
        Person person = new Person();
        Inventory inventory = new Inventory();
        Chapter chapter = new Chapter(0);
        Task task = new Task(0);
        Item item = new Item(1);
        Enemy player = new Enemy();
        Enemy enemy = new Enemy();
        Market market = new Market();
        Bank money = new Bank();
        LivesProgressBar lives = new LivesProgressBar();
        LevelProgressBar levels = new LevelProgressBar();

        bool healer;
        int marketnum = 0;
        int enemynum = 0;

        public Game()
        {
            InitializeComponent();
            inventory.AddItem(item.ItemId, item.ItemName);
            ItemSource();
        }

        //---- Ověření hodnot z checkboxu ----

        //Metoda pro ověření hodnoty z checkboxu úkolu
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox chkZone = (CheckBox)sender;
            if (task.Type_task.Equals("vyber_hrdiny"))
            {
                Continue_button.Content = person.GetHelper(chkZone.Tag.ToString());
                if (!person.Helper.Equals("Neni") && !person.Helper1.Equals("Neni"))
                {
                    healer = person.Healer(person.Helper, person.Helper1);
                    Continue();
                    Continue_button.Visibility = System.Windows.Visibility.Hidden;
                }

            } else if (task.Type_task.Equals("vyber"))
            {
                if (chkZone.Tag.ToString().Equals("Ano"))
                {
                    item = new Item(task.Reward_Task);
                    if (item.ItemName.Contains("kamínků"))
                    {
                        money = new Bank(item.ItemName);
                    }
                    else
                    {
                        inventory.AddItem(item.ItemId, item.ItemName);
                    }
                }
                Continue();
            }
            else if (task.Type_task.Equals("boj"))
            {
                int num = 1;                
                if (chkZone.Tag.ToString().Equals("Ano"))
                {
                    player = new Enemy(person.Name, person.Lives, person.Attack, person.Defense);
                    enemy = new Enemy(enemynum);
                    StartBattle();
                    GameInfo();
                    AttackPopUp.IsOpen = true;
                } else
                {
                    num = 2;
                }
                enemynum += 1;
                chapter = new Chapter(chapter.ID_Chapter + num);
                task = new Task(task.Id_Task + num);
            }
            else if (task.Type_task.Equals("velitel")) {
                player = new Enemy(person.Name, person.Lives, person.Attack, person.Defense);
                enemy = new Enemy(enemynum);
                StartBattle();
                AttackPopUp.IsOpen = true;
                enemynum += 1;
                Continue();
            }
            else if (task.Type_task.Equals("odmena"))
            {
                item = new Item(task.Reward_Task);
                if (item.ItemName.Contains("kamínků"))
                {
                    money = new Bank(item.ItemName);
                }
                else
                {
                    inventory.AddItem(item.ItemId, item.ItemName);
                }
                Continue();
            }
            else if (task.Type_task.Equals("hospoda"))
            {
                int num = 1;
                if (chkZone.Tag.ToString().Equals("Ano"))
                {
                    market = new Market(marketnum);
                    List<int> MarketItemsId = item.GetItemsId();
                    List<string> MarketItemsName = item.GetItemsName();
                    List<string> MarketItemsType = item.GetItemsType();
                    List<int> MarketItemsPrice = item.GetItemsPrice();
                    market.MarketItems(MarketItemsId, MarketItemsName, MarketItemsType, MarketItemsPrice, market.MarketType);
                    MarketButtonUI();
                }
                else
                {
                    num = 2;
                }
                marketnum += 1;
                chapter = new Chapter(chapter.ID_Chapter + num);
                task = new Task(task.Id_Task + num);
            }
            else
            {
                Continue();
            }
            ItemSource();
        }

        //Metoda pro použití předmětu
        private void Checkbox_ItemUse_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox chkZone = (CheckBox)sender;
            int num = int.Parse(chkZone.Tag.ToString());
            string ItemBonusType = item.GetItemBonusType(num);
            int ItemBonus = item.GetItemBonus(num);

            if (chkZone.Content.Equals("Pouzit"))
            {
                if (ItemBonusType.Equals("Životy"))
                {
                    person.Lives += ItemBonus;
                    if (person.Lives > LivesProgressbar.Maximum)
                    {
                        person.Lives = person.Lives - (person.Lives - LivesProgressbar.Maximum);
                    }
                }
                else if (ItemBonusType.Equals("Útok"))
                {
                    person.Attack += ItemBonus;
                }
                else if (ItemBonusType.Equals("Obrana"))
                {
                    person.Defense += ItemBonus;
                }
            }
            //inventory.ItemUse(num);
            chkZone.Content = "Použito";
            chkZone.Cursor = Cursors.No;
            InventoryPopUp.IsOpen = false;
        }

        //Metoda pro nákup zboží
        private void Checkbox_Pay_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox chkZone = (CheckBox)sender;            
            int Id = item.GetItemId(chkZone.Content.ToString());
            money.Money -= item.GetItemPrice(chkZone.Content.ToString(), money.Money);
            inventory.AddItemMarket(Id, chkZone.Content.ToString(), money.Money, item.GetItemPrice(chkZone.Content.ToString(), money.Money));
            Money.Text = money.Money.ToString();
        }

        //---- Útok ----

        //Metoda pro útok na nepřítele, po stisknutí tlačítka
        private void AttackButton_Click(object sender, RoutedEventArgs e)
        {
            AttackButton.Content = "Útok";           
            FighterButton.Visibility = person.Fighter(person.Helper, person.Helper1);
            ArcheryButton.Visibility = person.Archer(person.Helper, person.Helper1);
            Player.Text = player.EnemyName;
            Enemy.Text = enemy.EnemyName;
            PlayerLives.Text = player.EnemyLives.ToString();
            EnemyLives.Text = enemy.EnemyLives.ToString();
            GameInfo();
            player.AttackEnemy(enemy, player.EnemyAttackStrength);
            enemy.AttackEnemy(player, enemy.EnemyAttackStrength);
            enemy.EnemyLives = Math.Round((Double)enemy.EnemyLives, 2);
        }

        //Metoda pro útok na nepřítele, šermířem, po stisknutí tlačítka
        private void FigtherButton_Click(object sender, RoutedEventArgs e)
        {
            player.FighterAttackEnemy(enemy, player.EnemyAttackStrength);
            PlayerLives.Text = player.EnemyLives.ToString();
            enemy.EnemyLives = Math.Round((Double)enemy.EnemyLives, 2);
            EnemyLives.Text = enemy.EnemyLives.ToString();
            GameInfo();
        }

        //Metoda pro útok na nepřítele, lučištníkem, po stisknutí tlačítka
        private void ArcheryButton_Click(object sender, RoutedEventArgs e)
        {
            player.ArcherAttackEnemy(enemy, player.EnemyAttackStrength);
            PlayerLives.Text = player.EnemyLives.ToString();
            enemy.EnemyLives = Math.Round((Double)enemy.EnemyLives, 2);
            EnemyLives.Text = enemy.EnemyLives.ToString();
            GameInfo();
        }

        //Metoda pro přidání dalšího levelu
        private void LevelUp(int Experience, int Level, int Maximum)
        {
            int num = levels.LevelUp(person.Experience, person.Level, levels.Maximum);
            if (num == 1)
            {
                person.Experience = 0;
                person.Level += 1;
                person.Attack += 10;
            }
        }

        //---- PopUp ---- 

        //---- PopUp pro nápovědu ----
        private void HintButton_Click(object sender, RoutedEventArgs e)
        {

        }

        //---- PopUp pro spolubojovníky ----
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

        //---- PopUp pro profil ----
        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
            LevelUp(person.Experience, person.Level, levels.Maximum);
            lives = new LivesProgressBar(person.Lives, person.Level);
            levels = new LevelProgressBar(person.Experience, person.Level);
            LivesProgressbar.DataContext = lives;
            LevelsProgressbar.DataContext = levels;
            ProfilePopUp.IsOpen = true;
            Name.Text = person.Name;
            Level.Text = person.Level.ToString();
            HelpersInfo.DataContext = person;
            attack.DataContext = person.Attack;
            defense.DataContext = person.Defense;
            experienceinfo.DataContext = person.Experience;
        }

        private void ProfilePopUpClose_Click(object sender, RoutedEventArgs e)
        {
            ProfilePopUp.IsOpen = false;
        }

        //---- PopUp pro inventář ----
        private void InventoryButton_Click(object sender, RoutedEventArgs e)
        {
            InventoryPopUp.IsOpen = true;
        }

        private void InventoryPopUpClose_Click(object sender, RoutedEventArgs e)
        {
            InventoryPopUp.IsOpen = false;
        }

        //----- PopUp pro útok
        private void AttackPopUpClose_Click(object sender, RoutedEventArgs e)
        {
            AttackPopUp.IsOpen = false;
        }

        //---- PopUp pro obchod -----
        private void MarketButton_Click(object sender, RoutedEventArgs e)
        {
            MarketPopUp.IsOpen = true;
            Money.Text = money.Money.ToString();
        }

        private void MarketPopUpClose_Click(object sender, RoutedEventArgs e)
        {
            MarketPopUp.IsOpen = false;
            InventoryButton.Visibility = System.Windows.Visibility.Visible;
            ProfileButton.Visibility = System.Windows.Visibility.Visible;
            HelperButton.Visibility = System.Windows.Visibility.Visible;
            MarketButton.Visibility = System.Windows.Visibility.Hidden;
        }

        //---- Design ----
        //Metoda pro zpracování výsledku bitvu
        private void GameInfo()
        {
            if (player.EnemyLives <= 0 || enemy.EnemyLives <= 0)
            {
                AttackPopUpClose.Content = "Pokracovat";
                if (player.EnemyLives <= 0 && enemy.EnemyLives <= 0)
                {
                    Result.Text = "Zemreli oba";
                    AttackButton.Visibility = System.Windows.Visibility.Hidden;
                    ArcheryButton.Visibility = System.Windows.Visibility.Hidden;
                    FighterButton.Visibility = System.Windows.Visibility.Hidden;
                    GameEndButton.Visibility = System.Windows.Visibility.Visible;
                }
                else if (player.EnemyLives <= 0)
                {
                    Result.Text = "Vyhrál " + enemy.EnemyName;
                    AttackButton.Visibility = System.Windows.Visibility.Hidden;
                    ArcheryButton.Visibility = System.Windows.Visibility.Hidden;
                    FighterButton.Visibility = System.Windows.Visibility.Hidden;
                    GameEndButton.Visibility = System.Windows.Visibility.Visible;
                }
                else if (enemy.EnemyLives <= 0)
                {
                    person.AddExperience(150);
                    Result.Text = "Vyhrál " + player.EnemyName;
                    AttackButton.Visibility = System.Windows.Visibility.Hidden;
                    ArcheryButton.Visibility = System.Windows.Visibility.Hidden;
                    FighterButton.Visibility = System.Windows.Visibility.Hidden;
                    AttackPopUpClose.Visibility = System.Windows.Visibility.Visible;

                    if (healer)
                    {
                        person.Lives = player.EnemyLives + (0.25 * player.EnemyLives);
                    }
                    else
                    {
                        person.Lives = player.EnemyLives;
                    }
                    AttackPopUpClose.Content = "Zavrit";
                }
            }
        }

        //Metoda pro skrytí/odkrytí tlačítek při nákupu
        private void MarketButtonUI()
        {
            InventoryButton.Visibility = System.Windows.Visibility.Hidden;
            ProfileButton.Visibility = System.Windows.Visibility.Hidden;
            HelperButton.Visibility = System.Windows.Visibility.Hidden;
            MarketButton.Visibility = System.Windows.Visibility.Visible;
        }

        //Metoda pro viditelnost tlačítek při zahájení bitvy
        private void StartBattle()
        {
            Player.Text = player.EnemyName;
            Enemy.Text = enemy.EnemyName;
            PlayerLives.Text = player.EnemyLives.ToString();
            EnemyLives.Text = enemy.EnemyLives.ToString();
            PlayerAttackBox.DataContext = player.EnemyAttackStrength;
            EnemyAttackBox.DataContext = enemy.EnemyAttackStrength;
            PlayerDefenseBox.DataContext = player.EnemyDefense;
            EnemyDefenseBox.DataContext = enemy.EnemyDefense;
            AttackButton.Visibility = System.Windows.Visibility.Visible;
            ArcheryButton.Visibility = System.Windows.Visibility.Hidden;
            FighterButton.Visibility = System.Windows.Visibility.Hidden;
            AttackPopUpClose.Visibility = System.Windows.Visibility.Hidden;
            Result.Text = "";
        }

        //---- DataBinding ---- 
        private void ItemSource()
        {
            Title.DataContext = chapter;
            Text.DataContext = chapter;
            Task_title.DataContext = task;
            List<string> Task_option = new List<string>();
            Task_option = task.TaskSplit(task.Text_Task);
            Task_1.ItemsSource = Task_option;
            Inventory_List.ItemsSource = inventory.GetCollection();
            InventoryID_List.ItemsSource = inventory.GetCollectionID();
            Market_List.ItemsSource = market.MarketItemName;
            Market_Price_List.ItemsSource = market.MarketItemPrice;
            LevelUp(person.Experience, person.Level, levels.Maximum);
            lives = new LivesProgressBar(person.Lives, person.Level);
            LivesProgressbar.DataContext = lives;
            levels = new LevelProgressBar(person.Experience, person.Level);
            LevelsProgressbar.DataContext = levels;
        }

        //---- Ostatní ----
        //Metoda pro pokračování, přidá další kapitolu
        private void Continue()
        {
            chapter = new Chapter(chapter.ID_Chapter + 1);
            task = new Task(task.Id_Task + 1);
        }

        //Metoda pro ukončení hry, když hráč umře
        private void GameEndButton_Click(object sender, RoutedEventArgs e)
        {
            AttackPopUp.IsOpen = false;
            Application.Current.Windows[Application.Current.Windows.Count - 2].Close();
        }

    }
}
