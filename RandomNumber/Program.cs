

Random rnd= new Random();

int myRandomNum;  //saab hiljem ka väärtuse kätte

int randomSum = 0;

for( int i = 0;i < 5; i++)
{

    myRandomNum = rnd.Next(0, 11);  // genereeritakse 0 - 10, 1 vähem kui sulgudes.
    randomSum = randomSum+ myRandomNum;
    Console.WriteLine($"My random number is {myRandomNum}");
}

Console.WriteLine($"Random sum total: {randomSum}");