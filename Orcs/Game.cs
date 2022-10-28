

using Orcs.Actors;
using Orcs.Levels;
using Orcs.Stores;
using Orcs.Vitality;

namespace Orcs;

public static class Game
{
<<<<<<< Updated upstream
 
    public static void Start()
    {
        Orcs.GameState.Players.Add(CreatePlayer("BasicPlayer"));
        _gameState.Store = Game.CreateStore("BasicStore");
        _gameState.Levels = Game.AddLevel("Level1");
        _gameState.Levels = Game.AddLevel("Level2");
        _gameState.Levels = Game.AddLevel("Level3");
        _gameState.Levels = Game.AddLevel("Level4");
        _gameState.Levels = Game.AddLevel("Level5");
    }

    public static List<Level> AddLevel(string level1)
    {
        throw new NotImplementedException();
    }

    public static List<Player> CreatePlayer(string basicplayer)
    {
        throw new NotImplementedException();
    }

    public static Store CreateStore(string basicstore)
    {
        throw new NotImplementedException();
    }

    public static void Run()
    {
        throw new NotImplementedException();
    }

    public static void Stop()
    {
        throw new NotImplementedException();
    }
=======
    private Store _store = new Store();
    private List<Level> _levels = new List<Level>();
    private List<Monster> _monsters = new List<Monster>();
    private Player _player;
    private List<Weapon> _weapons = new List<Weapon>();
    private Strength _strength = new Strength();
    private BasicHealth _health = new BasicHealth();
    private List<InventoryItem> Inventory = new List<InventoryItem>();
    private Money _money = new Money();
>>>>>>> Stashed changes
}