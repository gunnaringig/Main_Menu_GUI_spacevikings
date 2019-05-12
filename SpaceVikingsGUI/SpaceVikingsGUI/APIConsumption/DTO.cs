namespace SpaceVikingsGUI.APIConsumption
{
    // Step 1 paste special json to classes

    public class Login : ILogin
    {
        public int LoginId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Game[] Games { get; set; }
    }

    public class Game : IGame
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public Character[] Characters { get; set; }
        public Progress Progress { get; set; }
        public int ProgressId { get; set; }
    }

    public class Progress : IProgress
    {
        public int ProgressId { get; set; }
        public int Level { get; set; }
        public int Checkpoint { get; set; }
        public int TimePlayed { get; set; }
    }

    public class Character : ICharacter
    {
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public string EquippedWeapon { get; set; }
        public string EquippedShield { get; set; }
        public string EquippedHelmet { get; set; }
        public string EquippedBody { get; set; }
        public string EquippedLegs { get; set; }
        public string EquippedFeet { get; set; }
        public Inventory Inventory { get; set; }
        public int InventoryId { get; set; }
        public Stats1 Stats { get; set; }
        public int StatsId { get; set; }
        public int Credit { get; set; }
    }

    public class Inventory : IInventory
    {
        public int InventoryId { get; set; }
        public int Size { get; set; }
        public Item[] Items { get; set; }
    }

    public class Item : IItem
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public Stats Stats { get; set; }
        public int StatsId { get; set; }
    }

    public class Stats : IStats
    {
        public int StatsId { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Stamina { get; set; }
        public int Agility { get; set; }
    }

    public class Stats1 : IStats1
    {
        public int StatsId { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Stamina { get; set; }
        public int Agility { get; set; }
    }

}