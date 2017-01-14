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
    /*   
     *   Dračí doupě - Popis projektu
     *   Cíl hry: Získat zpátky ukradenou věc => hra končí, když je poražen faraón.
     *   Porážka hráče: Pokud je hráč v souboji poražen zobrazí se pomocí GameInfo tlačítko konec a po kliknutí na něj se okno zavře, to samé se děje, když se hra ukončí.
     *   Ovládání: Hráč dostane text, dle kterého si v pravém nabídce výběru, vybere možnost jakou chce.
     *   Hrací kostka(symbol náhody): Ve hře ztvárněna třídou Dice a slouží pro speciální útok. Je-li číslo z 10 čísel rovno 5 provede se speciální útok.
     *   Soubojový systém: Hráč útočí na nepřítele. Pokud je jeho síla větší než obrana soubeře útočí plným útokem. Pokud ne, útočí polovičním. Toto samé platí pro útok nepřítele.
     *   Interface: Interface se vyskytuje v programu 4x, dle zadání. Je zde pro útok(klasický, lučištníke,...), market(hospoda, jeskynní obchod,...), progressbar(životy, level) a pro osobu(hráč, nepřítel).  
    */
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
        Dice dice = new Dice();

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
        //Pomocí task typu se provede daná akce
        //Řeší se zde přidání věcí do inventáře, výběr hrdiny, boj,...
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox chkZone = (CheckBox)sender;
            //Výběr pomocníka
            if (task.Type_task.Equals("vyber_hrdiny"))
            {
                Continue_button.Content = person.GetHelper(chkZone.Tag.ToString());
                if (!person.Helper.Equals("Neni") && !person.Helper1.Equals("Neni"))
                {
                    //Zda-li je léčitel pomocníkem
                    healer = person.Healer(person.Helper, person.Helper1);
                    //Zda-li je šermíř pomocníkem
                    person.Fighter(person.Helper, person.Helper1);
                    Continue();
                    Continue_button.Visibility = System.Windows.Visibility.Hidden;
                }

            }
            //Vyber akci pokud se rovná ano přidá item do inventáře
            else if (task.Type_task.Equals("vyber"))
            {
                if (chkZone.Tag.ToString().Equals("Ano"))
                {
                    item = new Item(task.Reward_Task);
                    //Pokud jsou kamínky(penize), musí se přidat do banky
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
            //Vyvolá bojové okno, pokud je odpověď ano, vytvoří nepřítele, hráč je také nepřítel
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
            //Vyvolá boj, ovšem bez možnosti souhlasu
            else if (task.Type_task.Equals("velitel")) {
                player = new Enemy(person.Name, person.Lives, person.Attack, person.Defense);
                enemy = new Enemy(enemynum);
                StartBattle();
                AttackPopUp.IsOpen = true;
                enemynum += 1;
                Continue();
            }
            //Odměna za boj, funguje stejně jako - vyber - , ovšem jenom přidává
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
            //Vyvolá prostředí pro nákup, pokud souhlasí
            else if (task.Type_task.Equals("hospoda"))
            {
                int num = 1;
                if (chkZone.Tag.ToString().Equals("Ano"))
                {
                    //Věci marketu
                    market = new Market(marketnum);
                    List<int> MarketItemsId = item.GetItemsId();
                    List<string> MarketItemsName = item.GetItemsName();
                    List<string> MarketItemsType = item.GetItemsType();
                    List<int> MarketItemsPrice = item.GetItemsPrice();
                    market.MarketItems(MarketItemsId, MarketItemsName, MarketItemsType, MarketItemsPrice, market.MarketType);
                    MarketPopUp.IsOpen = true;
                }
                else
                {
                    num = 2;
                }
                marketnum += 1;
                chapter = new Chapter(chapter.ID_Chapter + num);
                task = new Task(task.Id_Task + num);
            }
            else if (task.Type_task.Equals("konec"))
            {
                //Zavře herní okno
                Application.Current.Windows[Application.Current.Windows.Count - 2].Close();
            }
            else
            {
                //Pokračování ve hře
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
            person.PersonItemUse(ItemBonusType, ItemBonus, LivesProgressbar.Maximum);
            inventory.Remove(num);
            Inventory_List.Items.Refresh();
            InventoryID_List.Items.Refresh();
            ItemSource();
        }

        //Metoda pro nákup zboží
        private void Checkbox_Pay_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox chkZone = (CheckBox)sender;            
            int Id = item.GetItemId(chkZone.Content.ToString());
            money.Money -= item.GetItemPrice(chkZone.Content.ToString(), money.Money);
            inventory.AddItemMarket(Id, chkZone.Content.ToString(), money.Money, item.GetItemPrice(chkZone.Content.ToString(), money.Money));
            ItemSource();
        }

        //---- Útok ----

        //Metoda pro útok na nepřítele, po stisknutí tlačítka
        private void AttackButton_Click(object sender, RoutedEventArgs e)
        {
            AttackButton.Content = "Útok";
            player.AttackEnemy(enemy, player.Attack);
            ArcheryButton.Visibility = person.Archer(person.Helper, person.Helper1);
            RandomAttackButton.Visibility = System.Windows.Visibility.Visible;
            Player.Text = player.Name;
            Enemy.Text = enemy.Name;
            EnemiesLivesInfo();
        }

        //Metoda pro útok na nepřítele, lučištníkem, po stisknutí tlačítka
        private void ArcheryButton_Click(object sender, RoutedEventArgs e)
        {
            
            player.ArcherAttackEnemy(enemy, player.Attack);
            enemy.AttackEnemy(player, (enemy.Attack));
            EnemiesLivesInfo();
        }

        //Metoda pro útok na nepřítele, speciální útok, symbolizuje hrací kostku
        private void RandomAttackButton_Click(object sender, RoutedEventArgs e)
        {
            dice.DiceAttackEnemy(enemy, player.Attack);
            EnemiesLivesInfo();
        }

        //Metoda pro kontrolu zda-li nemá být další level
        private void ControlLevelUp(int Experience, int Level, int Maximum)
        {
            int num = levels.LevelUp(person.Experience, person.Level, levels.Maximum);
            if (num == 1)
            {
                person.LevelUp();
            }
        }

        //---- PopUp ---- 

        //---- PopUp pro profil ----
        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
            ControlLevelUp(person.Experience, person.Level, levels.Maximum);
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
            ItemSource();
            Inventory_List.Items.Refresh();
            InventoryID_List.Items.Refresh();
            InventoryPopUp.IsOpen = true;
        }

        private void InventoryPopUpClose_Click(object sender, RoutedEventArgs e)
        {
            InventoryPopUp.IsOpen = false;
        }

        //----- PopUp pro útok ----
        private void AttackPopUpClose_Click(object sender, RoutedEventArgs e)
        {
            AttackPopUp.IsOpen = false;
        }

        //---- PopUp pro obchod ----
        private void MarketPopUpClose_Click(object sender, RoutedEventArgs e)
        {
            MarketPopUp.IsOpen = false;
            InventoryButton.Visibility = System.Windows.Visibility.Visible;
            ProfileButton.Visibility = System.Windows.Visibility.Visible;
            ItemSource();
        }

        //---- Design ----
        //Metoda pro zpracování výsledku bitvu
        private void GameInfo()
        {
            if (player.Lives <= 0 || enemy.Lives <= 0)
            {
                if (player.Lives <= 0 && enemy.Lives <= 0)
                {
                    Result.Text = "Zemreli oba";
                    AttacksButtons();
                    GameEndButton.Visibility = System.Windows.Visibility.Visible;
                }
                else if (player.Lives <= 0)
                {
                    Result.Text = "Vyhrál " + enemy.Name;
                    AttacksButtons();
                    GameEndButton.Visibility = System.Windows.Visibility.Visible;
                }
                else if (enemy.Lives <= 0)
                {
                    person.AddExperience(enemy.EnemyExperience);
                    Result.Text = "Vyhrál " + player.Name;
                    AttacksButtons();
                    if (healer)
                    {
                        person.Lives = player.Lives + (0.25 * player.Lives);
                    }
                    else
                    {
                        person.Lives = player.Lives;
                    }
                    AttackPopUpClose.Visibility = System.Windows.Visibility.Visible;
                    AttackPopUpClose.Content = "Zavrit";
                }
            }
        }

        //Metoda pro viditelnost tlačítek při zahájení bitvy
        private void StartBattle()
        {
            Player.Text = player.Name;
            Enemy.Text = enemy.Name;
            PlayerLives.Text = player.Lives.ToString();
            EnemyLives.Text = enemy.Lives.ToString();
            PlayerAttackBox.DataContext = player.Attack;
            EnemyAttackBox.DataContext = enemy.Attack;
            PlayerDefenseBox.DataContext = player.Defense;
            EnemyDefenseBox.DataContext = enemy.Defense;
            AttackButton.Visibility = System.Windows.Visibility.Visible;
            ArcheryButton.Visibility = System.Windows.Visibility.Hidden;
            AttackPopUpClose.Visibility = System.Windows.Visibility.Hidden;
            RandomAttackButton.Visibility = System.Windows.Visibility.Hidden;
            Result.Text = "";
        }

        //Metoda pro skrytí/odkrytí tlačítek po boji
        private void AttacksButtons()
        {
            AttackButton.Visibility = System.Windows.Visibility.Hidden;
            ArcheryButton.Visibility = System.Windows.Visibility.Hidden;
            RandomAttackButton.Visibility = System.Windows.Visibility.Hidden;
        }

        //Metoda pro zobrazení životů, při boji
        private void EnemiesLivesInfo()
        {
            enemy.AttackEnemy(player, enemy.Attack);
            player.Lives = Math.Round((Double)player.Lives, 2);
            PlayerLives.Text = player.Lives.ToString();
            enemy.Lives = Math.Round((Double)enemy.Lives, 2);
            EnemyLives.Text = enemy.Lives.ToString();
            GameInfo();
        }

        //---- Obsahuje zdroje, pro většinu věcí v programu ---- 
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
            ControlLevelUp(person.Experience, person.Level, levels.Maximum);
            lives = new LivesProgressBar(person.Lives, person.Level);
            LivesProgressbar.DataContext = lives;
            levels = new LevelProgressBar(person.Experience, person.Level);
            LevelsProgressbar.DataContext = levels;
            Money.Text = money.Money.ToString();
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
