
Random rnd= new Random();
int cpuRandom;

bool loopActive = true;  // 

while (loopActive)
{
    cpuRandom= rnd.Next(1, 4); // vahemik mille hulgast numbreid genereeritakse, viimast numbrit jälle ei arvestata
    Console.WriteLine("Make a guess. Enter a number 1-3");
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulation, you won!");
        loopActive = false; // et lõpetada võidu puhul mäng võib ka BREAKi kasutada.
    }
    else
    {
        Console.WriteLine("Oops. Try Again!");
    }
}