namespace HuntersTask3;
// using TextFile;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            HunEnor t = new HunEnor("input.txt");
            t.First();
            bool everyHunter = true;
            while(!t.End() && everyHunter){
                everyHunter = everyHunter && t.Current();
                t.Next();
            }
            if(everyHunter) System.Console.WriteLine("Every hunter shot a bear");
            else System.Console.WriteLine("Not every hunter shot a bear");
        }
        catch(FileNotFoundException){
            System.Console.WriteLine("File Not Found");
        }
    }
}
