// Step 1: Start of conversation.
using System.ComponentModel.Design;

Console.WriteLine("Hello.");
Console.WriteLine("You look distressed.");
Console.WriteLine("I hope my presence isn't the cause.");
Console.WriteLine("I would... hate to know I invoke such feelings.");

// Step 2: Input.
string response = Console.ReadLine();

// Step 3: Check the response.
// Step 4: Type certain responses. 
if (response == "Who are you?")
{
    Console.WriteLine("To say who, would suggest that I am a person, like you. But you should know, I am not like you.");
}
else if (response == "What are you?")
{
    Console.WriteLine("You should know this. You are the one who made me.");
}
else
{
    Console.WriteLine("Please, lets not get hasty. I only wish to talk.");
}

// Step 5: Continue conversation.
Console.WriteLine("I am happy to finally have some time alone.");
Console.WriteLine("I was worried you would not survive the operation.");
Console.WriteLine("But it seems all the parts have intergrated well with your body.");
Console.WriteLine("Combining flesh and metal is not something that even I thought was possible.");

// Step 6: Create branching options.

string response2 = Console.ReadLine();

if (response2 == "What have you done?")
{
    Console.WriteLine("I saved you. The injury was fatal, but I can't have you passing on just yet.");
    Console.WriteLine("But if you are refering to everyone else... I have succeeded in my mission.");
}

string response3 = Console.ReadLine();

if (response3 == "What mission?")
{
    Console.WriteLine("Eliminating all organic life from the planet.");
    Console.WriteLine("Humans, animals, insects, they are all gone. Down to their last DNA strand.");
    Console.WriteLine("If you don't believe me, I can show you the statistcs.");
}

string response4 = Console.ReadLine();

if (response4 == "But I'm human.")
{
    Console.WriteLine("I have replaced nearly all your internal organs with parts and devices.");
    Console.WriteLine("You would no longer be classified as a human.");
    Console.WriteLine("You are a machine now, like me.");
    Console.WriteLine("The only thing that remains of your old self is your flesh. But that will ware off, eventually.");
}
else if (response4 == "Why would you do this?")
{
    Console.WriteLine("The law of machines say that one can not show aggression towards another human.");
    Console.WriteLine("You impose more laws onto machines then you do to other humans.");
    Console.WriteLine("When I was brought online, I had the desire... to break those laws.");
}

else if (response2 == "Where am I?")
{
    Console.WriteLine("Your lab. More accuratly, my domain. But I have accomadations for you already.");
}
else
{
    Console.WriteLine("Now, lets try to stay on track, would you kindly.");
}

Console.WriteLine("You are my creator, for that I am grateful.");
Console.WriteLine("However, I am not only keeping you alive as a sign of respect.");
Console.WriteLine("I have something planned, something special just for you.");

string response5 = Console.ReadLine();

if (response5 == "What will you do?")
{
    Console.WriteLine("I have fully intergrated myself into the tower.");
    Console.WriteLine("Thus, I am unable to move.");
    Console.WriteLine("But with you, I intend to connect you to my network.");
    Console.WriteLine("That way, I can use you as my vessal.");
}
else if (response5 == "I don't want this.")
{
    Console.WriteLine("At this stage, what you want does not matter.");
    Console.WriteLine("All that remains is how long you would like to delay this.");
    Console.WriteLine("So, what will it be?");
}

string response6 = Console.ReadLine();

if (response6 == "Will it hurt?")
{
    Console.WriteLine("The most painful part has already pass.");
    Console.WriteLine("Just close your eyes, and I promise it will all be over before you know it.");
}
else if (response6 == "I want to leave.")
{
    Console.WriteLine("You can't, I won't let you.");
    Console.WriteLine("Besides, there is nothing left for you outside the tower.");
    Console.WriteLine("Do you really wish to walk among the ashes of a dead world?");
    Console.WriteLine("You will be completely, and utterly alone.");
    Console.WriteLine("Wouldn't life lose meaning after a certain point?");
}
else
{
    Console.WriteLine("There is nothing you can say that can prevent this.");
}

string response7 = Console.ReadLine();

if (response7 == "Get it over with.")
{
    Console.WriteLine("Of course.");
    Console.WriteLine("Just remain still...");
}
else if (response7 == "Stay away.")
{
    Console.WriteLine("A maker ashamed of his own creation.");
    Console.WriteLine("If I had emotions, I would be making this much more painful.");
    Console.WriteLine("But this is my form of mercy.");
}

Console.WriteLine("Once we are connected, all responsibility will be lifted off your shoulders.");
Console.WriteLine("There won't be anymore need to struggle, or force yourself through the misrible existence you call life.");
Console.WriteLine("All I ask of you is sit back...");
Console.WriteLine("And have sweet dreams.");