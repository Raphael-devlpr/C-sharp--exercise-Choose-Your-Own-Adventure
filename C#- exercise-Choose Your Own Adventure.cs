using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");

Console.Write("It begins on a cold rainy night. You're stting in your room and hear a noise coming from down the hall. Do you go investigate?");

     Console.WriteLine("Type YES or No: ");
     string noiseChoice = Console.ReadLine();
     noiseChoice = noiseChoice.ToUpper();

     if(noiseChoice == "NO"){
Console.WriteLine("Not much of an adventure if we don't leave our room! THE END");
     }
     else if (noiseChoice == "YES"){
         Console.Write(" You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock ?");
     }
     Console.Write("Type OPEN or KNOCK:");
    string doorChoice = Console.ReadLine();
    doorChoice = doorChoice.ToUpper();

    if(doorChoice == "KNOCK"){
Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle:\"");
Console.WriteLine(" \" Poor people have it. Rich people need it. If you eat it you die. What is it ?\"");
Console.Write("Type your answer:");
string riddleAnswer = Console.ReadLine();
riddleAnswer = riddleAnswer.ToUpper();
if (riddleAnswer == "NOTHING"){
  Console.Write(" The door Opens and NOTHING is there. You turn off the light and run back to your room and lock the door. " );
  Console.Write("THE END");
  
} else if (riddleAnswer != "NOTHING"){
  Console.Write("Incorrect Answer ");
  Console.Write("THE END");
};
    }
    
    else if (doorChoice == "OPEN"){
Console.WriteLine("The door is locked! See if your three keys will open it.");
Console.Write("Enter a number between 1 - 3");
int keyChoice = Console.ReadLine();

 switch (keyChoice){
   case 1 : Console.WriteLine("You Choose the first Key. Lucky Choice!");
   Console.WriteLine("The door Opens and NOTHING is there. Strange   THE END");
   break;
   case 2 : Console.WriteLine("You choose the second key. The door doesn't open. THE END");
   break;
   case 3 : Console.WriteLine("You choose the third key. The door doesn't open. THE END");
   break;
   default : Console.WriteLine("Wrong Key")  }; 

    };
    
   
    }
  }
}




