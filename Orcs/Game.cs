using Orcs.Levels;
using Orcs.Monsters;
using Orcs.Players;
using Orcs.Stores;

namespace Orcs;

public class Game
{
    private Store _store = new Store();
    private List<Level> _levels = new List<Level>();
    private List<Monster> _monsters = new List<Monster>();
    private Player _player;
    private List<Weapon> _weapons = new List<Weapon>();
    private Strength _strength = new Strength();
    private Health _health = new Health();
    private List<InventoryItem> Inventory = new List<InventoryItem>();
    private Money _money = new Money();
}