Console.Clear();
//Zackary Santos
//Last Saved: 9/17/2026 4:15 PM
//Mini Challenge #10 - Resturaunt Picker
// I made a game where the user has to enter in a answer, which will let the game select a resturant for them.
//Peer Review Name:Brandon Langehennig
//Review: code runs great with no issues good job. 

string replay;

string Pizza1 = "Mountain Mike's";
string Pizza2 = "Little Ceasar's";
string Pizza3 = "Dominos";
string Pizza4 = "Round Table";
string Pizza5 = "Papa John's";
string Pizza6 = "Eric's Pizza";
string Pizza7 = "Micheal's New York Style Pizza";
string Pizza8 = "AP's Pizza";
string Pizza9 = "Freddy Fazbear's Pizza";
string Pizza10 = "Eddie's Pizza Cafe";

string[] pizzaBox = [Pizza1, Pizza2, Pizza3, Pizza4, Pizza5, Pizza6,
                     Pizza7, Pizza8, Pizza9, Pizza10];

string Burger1 = "Five Guys";
string Burger2 = "Moo Moo's Burger Farm";
string Burger3 = "Habbit Burger and Grill";
string Burger4 = "Bob's at the Marina";
string Burger5 = "Chilli's";
string Burger6 = "AppleBee's";
string Burger7 = "Lumberjack's Resturant";
string Burger8 = "Garlic Brothers";
string Burger9 = "Carl's Jr.";
string Burger10 = "Red Robin";

string[] burgerBox = [Burger1, Burger2, Burger3, Burger4, Burger5, Burger6,
                     Burger7, Burger8, Burger9, Burger10];

string Chinese1 = "China Village";
string Chinese2 = "China Palace";
string Chinese3 = "Luu's Chicken Bowl";
string Chinese4 = "Sherman's Chinese Buffet";
string Chinese5 = "Panda Express";
string Chinese6 = "Sam's Cafe";
string Chinese7 = "Prosperity Szechuan Cuisine";
string Chinese8 = "East Garden Chinese Express";
string Chinese9 = "GK Mongolian BBQ";
string Chinese10 = "Yen Du Resturant";

string[] chineseFoodBox = [Chinese1, Chinese2, Chinese3, Chinese4, Chinese5, Chinese6, Chinese7,
                           Chinese8, Chinese9, Chinese10];

do
{
    Random userResponse;
    userResponse = new Random();

    Console.Write("I want to reccomend you a resturant! Do you you like? 'burgers', 'pizza', or 'chinese'?: ");
    string response = Console.ReadLine().ToLower();

    int randBurgerChoice = userResponse.Next(burgerBox.Length);
    int randPizzaChoice = userResponse.Next(pizzaBox.Length);
    int randChineseFoodChoice = userResponse.Next(chineseFoodBox.Length);
    while (response != "burgers" && response != "pizza" && response != "chinese")
    {
        Console.Write("Invalid Answer. Please type 'burgers', 'pizza', or 'chinese': ");
        response = Console.ReadLine();
    }

    if (response == "burger")
    {
        Console.WriteLine("Since you like Burgers, I reccomend to you " + burgerBox[randBurgerChoice] + "!");
    }

    if (response == "pizza")
    {
        Console.WriteLine("Since you like Pizza, I reccomend to you " + pizzaBox[randPizzaChoice] + "!");    
    }

    if (response == "chinese")
    {
        Console.WriteLine("Since you like Chinese Food, I reccomend to you " + chineseFoodBox[randChineseFoodChoice] + "!");
    }

    Console.Write("Do you want to Play Again? (Answer 'yes' or 'no'): ");
    replay = Console.ReadLine().ToLower();

    while (replay != "yes" && replay != "no")
    {
        Console.Write("Invalid Answer. Please type 'yes' or 'no': ");
        replay = Console.ReadLine();
    }

    if (replay == "no")
    {
        Console.WriteLine("See You Later!");
        break;
    }

} while (replay == "yes");
