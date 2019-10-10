//Dylan Cox
//October 9 2019
//Create a game of pig using random number generation
using System;
using Random;
class turn1
{
 public static void Main()
 {
  Random rnd = new Random();
  int  dice = rnd.Next(1, 7);
  int score;
  int humanTurn;
  int turnScore;
  humanTurn(score)
  {
    while 0 <= (score+turnScore) <= 100
    {
      Console.WriteLine("Your score is",score+turnScore);
      Console.WriteLine("Would you like to roll again, (y)es or (n)0");
      playerAnswer=Console.ReadLine();
      if playerAnswer != "y"
      {
        return False;
      }
      Console.WriteLine(dice);
      if dice == 1
      {
        turnScore = 0;
        return False;
      }
      turnScore +- dice;
    Console.WriteLine("Your score is"score+turnScore);
    Console.WriteLine("It's the other player's turn");
    return turnScore;
    }
    int score1;
    score1 = 0;
    while score1 < 100
    {
      score1 += humanTurn(score1);
    }
  }
  int humanTurn2;
  int turnScore2;
  int score2;
  humanTurn2(score2)
  {
    while 0 <= (score2+turnScore2) <= 100
    {
      Console.WriteLine("Your score is",score2+turnScore2);
      Console.WriteLine("Would you like to roll again, (y)es or (n)0");
      playerAnswer=Console.ReadLine();
      if playerAnswer != "y"
      {
        return False;
      }
      Console.WriteLine(dice);
      if dice == 1
      {
        turnScore = 0;
        return False;
      }
      turnScore +- dice;
    Console.WriteLine("Your score is"score+turnScore);
    Console.WriteLine("It's the other player's turn");
    return turnScore;
    }
    int score1;
    score1 = 0;
    while score1 < 100
    {
      score1 += humanTurn(score1);
    }
  }
 }
 if score1 < turnScore2{
   Console.WriteLine("Player 2 wins")
   else Console.WriteLine("Player 1 wins")
 }
}
