using System;
using System.Formats.Asn1;

Main();



void Main()

{
Console.WriteLine("SUPER DUPER ABSOLUTELY SECRET CONFIDENTIAL NOBODY KNOWS NUMBER");
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine();

int userAnswer = 0;
int secretnumber = 0;
bool result = false;
int counter = 0;
Random rand = new Random();
int number = rand.Next(0, 100);
int guesses = 4;
string difficulty = "";

void Difficulty ()

{
    Console.Write("CHOOSE A DIFFICULTY - TYPE 'EASY', 'MEDIUM', OR 'HARD' TO START =======>>>   ");
    difficulty = Console.ReadLine().ToLower();
    if (difficulty == "easy") 
    {
        guesses = 8;
    }
    else if (difficulty == "medium") 
    {
        guesses = 6;
    }
    else 
    {
        guesses = 4;
    }

}


bool GuessNumber ()
{
    Console.Write($"GUESS THE SECRET NUMBER YOU ABSOLUTELY PSYCHIC NERD (Your Guess: {counter + 1} - You Have {guesses - counter} Guesses Left)---->   ");
    string answer = Console.ReadLine();
    Console.WriteLine();
    Console.Write($"YOU THINK THE SECRET NUMBER IS {answer}?????");
    int stringnum = Convert.ToInt32(answer);
    secretnumber = number;
    if (stringnum == secretnumber) 
    {
        result = true;
        userAnswer = stringnum;
        return true;
    }
    else
    {
        userAnswer = stringnum;
        return false;
    }
};

void Cheater ()
{
    Console.WriteLine();
    Console.Write($"GUESS THE SECRET NUMBER YOU ABSOLUTELY PSYCHIC NERD (Your Guess: {counter + 1} - You Have Infinite Guesses Left)---->   ");
    string answer = Console.ReadLine();
    Console.WriteLine();
    Console.Write($"YOU THINK THE SECRET NUMBER IS {answer}?????");
    int stringnum = Convert.ToInt32(answer);
    secretnumber = number;
    if (stringnum == secretnumber) 
    {
        result = true;
        userAnswer = stringnum;
    }
    else
    {
        userAnswer = stringnum;
    }
    
    Console.WriteLine();
    Console.Write($@"
    
    Let me see here.... 
    
    And that was your BEST GUESS??? 
    
    Hmmm ooooooooook buddy.");
    Console.WriteLine();
    if (result) 
    {
        Console.WriteLine();
        Console.Write("Actually holy MF shizz doggy, you really got it!!! We praise you as an almighty god!!!!");
        Console.WriteLine();
        Console.WriteLine();
    }
    else if (userAnswer - number < -15)
    {
        Console.WriteLine();
        Console.WriteLine("You're wayyyy off. You're too low by more than 15. Step it UPPPPPPPPPPPP!!!");
        Console.WriteLine();
        Console.WriteLine();
    }
    else if (userAnswer - number > 15)
    {
        Console.WriteLine();
        Console.WriteLine("You're wayyyy off. You're too high by more than 15. Drop it DOWWWWWNNNNNNNNN BUCKAROO BONZAI!!!");
        Console.WriteLine();
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine();
        Console.Write("You're a faker and we knew it all along, everybody talks about it. YOU'RE NOT PSYCHIC AT ALL!!!! YOU COULDN'T EVEN GUESS THIS FRIGGIN NUMBER!!!!");
        Console.WriteLine();
        Console.WriteLine();
    }


}

void MoreGuesses ()
{   Console.WriteLine();
    Console.Write($@"
    
    Let me see here.... 
    
    And that was your BEST GUESS??? 
    
    Hmmm ooooooooook buddy.");
    Console.WriteLine();
    if (result) 
    {
        Console.WriteLine();
        Console.Write("Actually holy MF shizz doggy, you really got it!!! We praise you as an almighty god!!!!");
        Console.WriteLine();
        Console.WriteLine();
    }
    else if (userAnswer - number < -15)
    {
        Console.WriteLine();
        Console.WriteLine("You're wayyyy off. You're too low by more than 15. Step it UPPPPPPPPPPPP!!!");
        Console.WriteLine();
        Console.WriteLine();
    }
    else if (userAnswer - number > 15)
    {
        Console.WriteLine();
        Console.WriteLine("You're wayyyy off. You're too high by more than 15. Drop it DOWWWWWNNNNNNNNN BUCKAROO BONZAI!!!");
        Console.WriteLine();
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine();
        Console.Write("You're a faker and we knew it all along, everybody talks about it. YOU'RE NOT PSYCHIC AT ALL!!!! YOU COULDN'T EVEN GUESS THIS FRIGGIN NUMBER!!!!");
        Console.WriteLine();
        Console.WriteLine();
    }
}


Difficulty();

if (difficulty == "cheater")
{
    while (!result)
    {
        Cheater();
    }

counter = guesses + 1;
}

while (counter < guesses + 1)

{

if (counter < guesses && !result) 
    {
        GuessNumber();
        MoreGuesses();
        counter = counter + 1;
    }
    else if (result) 
    {
        Console.Write("God damn you got it right you son of a bitch!!!! Get the hell out of here!!!");
        counter = guesses + 1;
    }
    else
    {
        Console.Write($"You ran out of guesses, turns out you're not good at this. Such a shame. It was actually {number}.");
        counter = guesses + 1;
    }
}

}