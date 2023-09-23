namespace JaggedArrayChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] myFriends = new string[][]
        {
            new string[] {"Julia", "Jezvy"},
            new string[] {"Maxine", "Ryle"},
            new string[] {"Paul", "Gwimz"}
        };
            Console.WriteLine("{0}, helped {1} to confess her feelings with me <3", myFriends[0][1], myFriends[0][0]);
            Console.WriteLine("{0} has huge difference with {1}, she is so loud while {1} needs to be forced to spill some tea =,=", myFriends[1][0], myFriends[1][1]);
            Console.WriteLine("I remember when {0} asked {1} to draw my son {2} hsdfjasd it was so cute!", myFriends[0][0], myFriends[2][0], myFriends[2][1]);

            Console.ReadKey();
        }
    }
}