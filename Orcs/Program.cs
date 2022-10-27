using System.Data.SqlTypes;

namespace Orcs;

public class Program
{
    private Game _game = new Game();
    
    public static void Main(string[] args)
    {
        ScreenMessage.ShowTitle();
        while (true)
        {
            ScreenMessage.ShowMainMenu();

        }
        
        

        return;
    }
    
}