using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe.Classes
{
    public class Chapters
    {
        List<int> Chapter_ID = new List<int>();
        List<string> Chapter_Title = new List<string>();
        List<string> Chapter_Text = new List<string>();

        public Chapters()
        {
            //---- 1. část ----

            //---- 1. kapitola
            Chapter_ID.Add(0);
            Chapter_ID.Add(1);
            Chapter_ID.Add(2);
            Chapter_ID.Add(3);
            //---- 2. kapitola
            Chapter_ID.Add(4);
            Chapter_ID.Add(5);
            Chapter_ID.Add(6);
            Chapter_ID.Add(7);
            Chapter_ID.Add(8);
            Chapter_ID.Add(9);
            //---- 3. kapitola
            Chapter_ID.Add(10);
            Chapter_ID.Add(11);
            Chapter_ID.Add(12);
            Chapter_ID.Add(13);
            Chapter_ID.Add(14);

            //---- 2. část ----
            //---- 4. kapitola ----
            Chapter_ID.Add(15);
            Chapter_ID.Add(16);
            Chapter_ID.Add(17);
            Chapter_ID.Add(18);
            Chapter_ID.Add(19);
            //---- 5. kapitola ----
            Chapter_ID.Add(20);
            Chapter_ID.Add(21);
            Chapter_ID.Add(22);
            Chapter_ID.Add(23);
            Chapter_ID.Add(24);
            //---- 6. kapitola ----
            Chapter_ID.Add(25);
            Chapter_ID.Add(26);
            Chapter_ID.Add(27);

            //---- 3. část ----
            //---- 7. kapitola ----
            Chapter_ID.Add(28);
            Chapter_ID.Add(29);
            Chapter_ID.Add(30);
            Chapter_ID.Add(31);
            //---- 8. kapitola ----
            Chapter_ID.Add(32);
            Chapter_ID.Add(33);
            Chapter_ID.Add(34);
            Chapter_ID.Add(35);
            Chapter_ID.Add(36);
            //---- 9. kapitola ----
            Chapter_ID.Add(37);
            Chapter_ID.Add(38);
            Chapter_ID.Add(39);
            Chapter_ID.Add(40);
            Chapter_ID.Add(41);
            Chapter_ID.Add(42);

            //---- 4. část ---- 
            //---- 10. kapitola
            Chapter_ID.Add(43);
            Chapter_ID.Add(44);
            Chapter_ID.Add(45);

            //---- 1. kapitola
            Chapter_Title.Add("Úvod");
            Chapter_Title.Add("Výběr pomocníků");
            Chapter_Title.Add("Štít");
            Chapter_Title.Add("Kamínky");
            Chapter_Title.Add("Pochod");
            //---- 2. kapitola
            Chapter_Title.Add("Pomoc");
            Chapter_Title.Add("Odměna");
            Chapter_Title.Add("Rozhodnutí");
            Chapter_Title.Add("Občerstvení");
            Chapter_Title.Add("Na cestě");
            Chapter_Title.Add("U hor");
            //---- 3. kapitola
            Chapter_Title.Add("Vstup do hor");
            Chapter_Title.Add("Jeskynní lidé");
            Chapter_Title.Add("Tábor jeskynních lidí");
            Chapter_Title.Add("Strážce");
            Chapter_Title.Add("Boj o postup");

            //---- 4. kapitola ----
            Chapter_Title.Add("Překročení hor");
            Chapter_Title.Add("Pytel s potravinami");
            Chapter_Title.Add("Vesnice v údolí");
            Chapter_Title.Add("Domorodci");
            Chapter_Title.Add("Možnost cestovat lodí");
            //---- 5. kapitola ----
            Chapter_Title.Add("Na moři");
            Chapter_Title.Add("Piráti");
            Chapter_Title.Add("Den a noc");
            //---- 6. kapitola ----
            Chapter_Title.Add("Vylodění");
            Chapter_Title.Add("Přátelská vesnice");
            Chapter_Title.Add("Poslední nákup");
            Chapter_Title.Add("Přepadení");
            //---- 7. kapitola ----
            Chapter_Title.Add("Pochod na Egypt");
            Chapter_Title.Add("Zkrotit slona");
            Chapter_Title.Add("Odměna");
            Chapter_Title.Add("Klíčník");
            Chapter_Title.Add("Klíč");
            //---- 8. kapitola ----
            Chapter_Title.Add("Velitel armády");
            Chapter_Title.Add("Postupuješ");
            Chapter_Title.Add("Další poschodí");
            Chapter_Title.Add("Skoro u konce");
            Chapter_Title.Add("Hodně štěstí");
            Chapter_Title.Add("Výhra");
            //---- 9. kapitola
            Chapter_Title.Add("Konec");

            Chapter_Text.Add("Vítám tě ve hře. Včera nás přepadli zlý bojovnící, sebrali nám skoro vše. To nejdůležitější je, že vza-li kámen, který pohánní náš strom života. Je tedy na tobě, aby si ho získal zpět. Budeš muset jít, až do země, které se říká svět Chrámů.");
            Chapter_Text.Add("Záchrana nebude vůbec jednoduchá, proto si vem sebou 2 ze 3 nabízených pomocníků. Šermíř ti přidá 50 bodů obrany, lučištník útok zdvojnásobí, ale soupeř ten tah útočí 2x. Léčitel přidá na konci tahu 1/4 tvých životů.");
            Chapter_Text.Add("Po výběru ti vůdce tvé vesnice nabídnul štít. Cheš ho nebo ne? Rozhodni se a můžeme pokračovat.");
            Chapter_Text.Add("Ještě než si vyšel zastavil tě tvůj kamarád a nabízí ti kamínky, za které si můžeš v budoucnu něco koupit. Vem si je budou se hodit.");
            Chapter_Text.Add("Teď, když máš základní výbavu můžeme se vydat na výpravu.");

            Chapter_Text.Add("Tak to je nemilé, hned co jsi vyrazil, narazil jsi na přepadení karavany. Můžeš se vyhnout nebo bojovat. Pokud se vyhneš cesta bude pokračovat. Pokud budeš chtít bojovat, ztratíš sice životy, ale můžeš dostat odměnu. Je to jen na tobě.");
            Chapter_Text.Add("Získal jsi jako odměnu kožich, vem si ho.");
            Chapter_Text.Add("Ušel jsi už poměrně dlouhou cestu. Jestli chceš můžeme si odpočinout v támhle v posezení u druida, které je nedaleko odsuď, neboť další cesta bude náročná. Obsahuje spoustu nebezpečí.");
            Chapter_Text.Add("Doufám, že jsi si nakoupil, jak si chtěl. Na cestě nás můžou potkat jěště další možnosti pro nákup.");
            Chapter_Text.Add("To není dobré, potkal nás medvěd. Můžeš bojovat, sice utrpíš nějaké ztráty, ale dostaneš odměnu nebo se můžeš vyhnout.");
            Chapter_Text.Add("Dostal jsi kůži. Nyní se nacházíš u hor. Stiskni pokračovat");

            Chapter_Text.Add("Začal si výšlap přes hory. Cesta bude poměrně náročná, proto by jsi měl být pozorný.");
            Chapter_Text.Add("Seš v půlce cesty. Můžeš se zastavit u jeskenních lidí na nákup zboží. Jeskynní lidé mají tzv. kouzelné náhrdelníky, které přidávají zajímavé bonusy a za dobrou cenu.");
            Chapter_Text.Add("Jeskynní lidé ti děkují za nákup a přejí ti hodně štestí do budoucna.");
            Chapter_Text.Add("Stoupáš dál a dál, najednou uvidíš na vrcholu světlo. Jsou to strážci hor musíš proti nim bojovat.");
            Chapter_Text.Add("A vyhrál jsi dostaneš tento meč, který jsi našel u velitele. Lepší věc je, že jsi se dozvěděl kudy a kdy šli bojovníci co napadli naši vesnici. Prošli tudy před 2 dny a mají namířeno do údolí a odsuď do světa Chrámů.");

            Chapter_Text.Add("Úspěšně jsi překročil horu, nyní půjdeš dál a dál. Dávej si bacha tyto končiny, už moc neznáš...");
            Chapter_Text.Add("Štestí je k tobě nakloněné, našel jsi pytel s jídlem. Vem si ho jídlo budeš potřebovat.");
            Chapter_Text.Add("Nalezl jsi vesnici domorodců, můžeš se jít představit, ale je to na tobě, nevíš co jsou zač. Ovšem něco nakoupit by jsi potřeboval.");
            Chapter_Text.Add("Domorodci se ti představili jsou přátelští a řekli ti, že tam kam máš namířeno se jmenuje Egypt.");
            Chapter_Text.Add("Našel jsi přístav, odtuď se nalodíš a pojedeš přes moře do Egypta.");

            Chapter_Text.Add("Cesta potrvá nejméňě, tak 4 dny. Musíš být připravený, neboť je zde spousta zlých pirátů...Jako třeba támhle jdou po nás, musíme bojovat.");
            Chapter_Text.Add("Výberně jsi vzdoraval a našel si po jejich kapitánovi, tento výborný kloubouk, vem si ho.");
            Chapter_Text.Add("Kapitán má dobrou zprávu za jeden den a jednu noc jsme v Egyptě.");

            Chapter_Text.Add("Vyšlo Slunce a my jsme v Egyptě, zde už jde naše cesta do finále. Zde se rozhodne o osudu tvého národa.");
            Chapter_Text.Add("Hned co jsi se vylodil jsi našel vesnici, lidi jsou zde přátelští a můžou mít skvělé věci na prodej a bude to poslední zastávka či-li povinná, před hlavním boje. Jdi tam.");
            Chapter_Text.Add("Výborně, nakoupil jsi a můžeme se dát do boje, teď si zdřímneme. Počkat co je to támhle? To jsou poslové zla musíme bojovat.");
            Chapter_Text.Add("Vyhrál jsi a získal meč kapitána, kteří nás napadli, ovšem nepřátelé vědi, že jsi tady. To nám ubírá moment překvapení. Našteští jsi ohromil místní domorodce a ty ti přislíbili pomoc.");

            Chapter_Text.Add("Pochoduješ na Egypt, pro získání svého dědictví.");
            Chapter_Text.Add("Jeden z našich slonů se nedá zkrotit, můžeš pomoct a odměna tě nemine.");
            Chapter_Text.Add("Dostal jsi za pomoc, tento štít ze slonoviny. Velmi lehký a odolný, vem si ho.");
            Chapter_Text.Add("A je to tu! Jsme před branami hlavní města Egypta. Musíš zabít tohoto klíčníka, abychom se dostali dovnitř.");
            Chapter_Text.Add("Klíčníka si zníčil a získal si klíč od brány. Domorodci způsobí chaos ve městě, ty se mezitím přemísti do chrámu.");

            Chapter_Text.Add("A nyní to přichází, bodou tě čekat tři klíčové poschodí v každém se nacházejí ti nejlepší bojovníci Egypta. Musíš se pořádně vyzbrojit, první z nich je velitel armády.");
            Chapter_Text.Add("Porazil jsi ho, ale to nejtězší teprve přijde, pokračuj dál");
            Chapter_Text.Add("Jak jdeš dalším poschodí, zjistíš, že ve města začínají mít převoha tvý spojenci. To je velmi dobře, teď musíš splnit ty svojí část.");
            Chapter_Text.Add("Dalším nepřítelem je velitel města. Tento válečník je starší, ale za to velmi zkušený. Bacha na něj!");
            Chapter_Text.Add("Vyhrál jsi a nyní tě čeká to nejtěžší tvé cesty. Další nepřítel je totiž faraón. Do něj!");
            Chapter_Text.Add("Porazil jsi faraóna, gratuluji ti k výhře v této hře. Získal jsi od faraóna tvé dědictví tvojí vesnice.");

            Chapter_Text.Add("A nejen ty jsi vyhrál, město obsadili i domorodci a svrhli krutou vládu, která tu panovala. Tvoji lidé tu budou vždy vítání. Toto je konec tvého příběhu.");
        }
        /// <summary>
        /// Metoda pro získání názvu kapitoly
        /// </summary>
        /// <param name="num">ID kapitoly</param>
        /// <returns>Název kapitoly</returns>
        public string GetChapterName(int num)
        {
            string name = Chapter_Title[num];
            return name;
        }
        /// <summary>
        /// Metoda pro získání textu kapitoly
        /// </summary>
        /// <param name="num">ID kapitoly</param>
        /// <returns>Text kapitoly</returns>
        public string GetChapterText(int num)
        {
            string text = Chapter_Text[num];
            return text;
        }
    }
}
