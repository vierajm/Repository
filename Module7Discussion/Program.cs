using System;

Console.WriteLine("What is your favorite fruit?");
string favoritefruit = Console.ReadLine();

switch (favoritefruit)
{
    case "Bananas":
        Console.WriteLine("Nice! Bananas are high in potassium.");
        break;
    case "Apples":
        Console.WriteLine("Great! Apples contain a lot of fiber.");
        break;
    case "Grapes":
        Console.WriteLine("Good! Grapes are good for bone health.");
        break;
    default:
        Console.WriteLine("That's great! Do you know what health benefits your favorite fruit provides?");
        break;

}
