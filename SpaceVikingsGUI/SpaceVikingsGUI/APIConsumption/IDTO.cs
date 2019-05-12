namespace SpaceVikingsGUI.APIConsumption
{
    public interface ILogin
    {
        int LoginId { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        Game[] Games { get; set; }
    }

    public interface IGame
    {
        int GameId { get; set; }
        string Name { get; set; }
        Character[] Characters { get; set; }
        Progress Progress { get; set; }
        int ProgressId { get; set; }
    }

    public interface IProgress
    {
        int ProgressId { get; set; }
        int Level { get; set; }
        int Checkpoint { get; set; }
        int TimePlayed { get; set; }
    }

    public interface ICharacter
    {
        int CharacterId { get; set; }
        string Name { get; set; }
        string EquippedWeapon { get; set; }
        string EquippedShield { get; set; }
        string EquippedHelmet { get; set; }
        string EquippedBody { get; set; }
        string EquippedLegs { get; set; }
        string EquippedFeet { get; set; }
        Inventory Inventory { get; set; }
        int InventoryId { get; set; }
        Stats1 Stats { get; set; }
        int StatsId { get; set; }
        int Credit { get; set; }
    }

    public interface IInventory
    {
        int InventoryId { get; set; }
        int Size { get; set; }
        Item[] Items { get; set; }
    }

    public interface IItem
    {
        int ItemId { get; set; }
        string Name { get; set; }
        string Category { get; set; }
        Stats Stats { get; set; }
        int StatsId { get; set; }
    }

    public interface IStats
    {
        int StatsId { get; set; }
        int Attack { get; set; }
        int Defense { get; set; }
        int Stamina { get; set; }
        int Agility { get; set; }
    }

    public interface IStats1
    {
        int StatsId { get; set; }
        int Attack { get; set; }
        int Defense { get; set; }
        int Stamina { get; set; }
        int Agility { get; set; }
    }
}