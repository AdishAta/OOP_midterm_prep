using TextFile;

namespace HuntersTask3;

public struct Trophy{
    public string name;
    public double weight;
    public string species;
}

public class HunEnor
{
    private enum Status { norm, abnorm };

    private TextFileReader x;
    private Status sx;

    private Trophy dx;
    private bool curr;

    private bool end;

    public HunEnor(string fileName)
    {
        x = new TextFileReader(fileName);
    }
    private void Read()
    {
        
        sx = x.ReadString(out dx.name)&& x.ReadString(out dx.species) && x.ReadDouble(out dx.weight) ? Status.norm : Status.abnorm;

    }

    public void First()
    {
        Read();
        Next();
    }
    public bool Current()
    {
        return curr;
    }
    public void Next()
    {
        end = sx == Status.abnorm;
        if (!end)
        {
          string hunterName = dx.name;
          curr = false;
          while (hunterName == dx.name){
            curr = curr || dx.species == "bear";
            Read();
          }
        }
    }

    public bool End()
    {
        return end;
    }


}