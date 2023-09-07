using System.Diagnostics.Eventing.Reader;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;

namespace AllForOneReview.Controllers;

[ApiController]
[Route("[controller]")]
public class ChallengeController : ControllerBase
{
    [HttpGet]
    [Route("One/{name}")]
    public string One(string name)
    {
        return $"What's up {name}! I hope you have a great day! <3";
    }

    [HttpGet]
    [Route("Two/{numOne}/{numTwo}")]
    public string Two(string numOne, string numTwo)
    {
        bool successOne = int.TryParse(numOne, out int numberOne);
        bool successTwo = int.TryParse(numTwo, out int numberTwo);

        if (successOne && successTwo)
        {
            return $"The sum of your numbers is {numberOne + numberTwo}.";
        }
        else
        {
            return "We were unable to read your request. Please try again.";
        }
    }

    [HttpGet]
    [Route("Three/{animal}")]
    public string Three(string animal)
    {
        return $"Your favorite animal is {animal}? That's nice! My favorite animal is the domestic rat.";
    }

    [HttpGet]
    [Route("Four/{numOne}/{numTwo}")]
    public string Four(int numOne, int numTwo)
    {
        if (numOne > numTwo)
        {
            return $"Your first number, {numOne}, is greater than your second number, {numTwo}.";
        }
        else if (numOne < numTwo)
        {
            return $"Your first number, {numOne}, is lesser than your second number, {numTwo}";
        }
        else
        {
            return $"Your first number, {numOne}, and your second number, {numTwo}, are equal.";
        }
    }

    [HttpGet]
    [Route("Five/{place1}/{adjective2}/{animal3}/{verbing4}/{person5}/{verbed6}/{noise7}/{person8}/{object9}/{verbing10}")]
    public string Five(string place1, string adj2, string animal3, string verbing4, string person5, string verbed6, string noise7, string person8, string object9, string verbing10)
    {
        return $"Once in a place called {place1} there was a/n {adj2} {animal3}. They were {verbing4} around, when suddenly, {person5} blocked the way. The little guy {verbed6} at them, and in response they only heard a {noise7}. So they turned around, intending to leave. But behind them, they found {person8}. They were surrounded. Suddenly everyone simultaneously whipped out a/n {object9}. It was a stand off. This little guy was clearly not going down without a fight. After a tense moment, the people retreated, and satisfied with their victory, the creature spent the rest of its evening {verbing10}.";
    }

    [HttpGet]
    [Route("Six/{input}")]
    public string Six(int input)
    {
        if (input % 2 == 0)
        {
            return $"{input} is an even number.";
        }
        else
        {
            return $"{input} is an odd number.";
        }
    }

    [HttpGet]
    [Route("Seven/{input}")]
    public string Seven(string input)
    {
        string reverse = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reverse = reverse + input[i];
        }
        return $"The reverse of '{input}' is '{reverse}'";
    }

    [HttpGet]
    [Route("Eight")]
    public string Eight()
    {
        Random rnd = new Random();
        string[] pick = { "This sounds like a personal problem.", "The magic 8 ball is busy right now, try again later", "I think you already know the answer", "Yes! Yes. Absolutely, 100%, yes", "Maybe..?", "Oh heck no, nuh-uh", "Are you really asking a BALL for answers? Come on dude.", "...Oh, huh? Sorry I wasn't paying attention, try again", "To be honest I have no idea", "Uhhhh.. please leave a message after the beep. Beeeeeeeep-" };
        int index = rnd.Next(pick.Length);
        return pick[index];
    }

    [HttpGet]
    [Route("Nine/{input}")]
    public string Nine(string input)
    {
        Random rnd = new Random();
        string pick = input.ToLower();
        if (pick == "random")
        {
            string[] pickRandom = { "Starbucks", "Dutch Bros", "Poppy Coffee", "Scooter's", "Empresso", "Terra Coffee", "House of Shaw", "Cafe Acacia", "Color Me Coffee", "Lollicup", "Squeeze Burger", "The Habit", "Flip's Burgers", "Victory Grill", "In-n-Out Burger", "Burger King", "Midnightrue at Burnie's", "Five Star Burger", "Super Burger", "Wendy's", "Little Caesar's", "Round Table", "Domino's", "Pizza Hut", "Mountain Mike's", "David's Pizza", "BJ's", "Eddie's Pizza", "VIP Pizza", "Michael's New York Style Pizza" };
            int index = rnd.Next(pickRandom.Length);
            return $"You should go to {pickRandom[index]}!";
        }
        else if (pick == "burgers")
        {
            string[] pickBurger = { "Squeeze Burger", "The Habit", "Flip's Burgers", "Victory Grill", "In-n-Out Burger", "Burger King", "Midnightrue at Burnie's", "Five Star Burger", "Super Burger", "Wendy's" };
            int index = rnd.Next(pickBurger.Length);
            return $"You should go to {pickBurger[index]}!";
        }
        else if (pick == "pizza")
        {
            string[] pickPizza = { "Little Caesar's", "Round Table", "Domino's", "Pizza Hut", "Mountain Mike's", "David's Pizza", "BJ's", "Eddie's Pizza", "VIP Pizza", "Michael's New York Style Pizza" };
            int index = rnd.Next(pickPizza.Length);
            return $"You should go to {pickPizza[index]}!";
        }
        else if (pick == "coffee")
        {
            string[] pickCoffee = { "Starbucks", "Dutch Bros", "Poppy Coffee", "Scooter's", "Empresso", "Terra Coffee", "House of Shaw", "Cafe Acacia", "Color Me Coffee", "Lollicup" };
            int index = rnd.Next(pickCoffee.Length);
            return $"You should go to {pickCoffee[index]}!";
        }
        else
        {
            return "Umm... no.";
        }
    }

}
