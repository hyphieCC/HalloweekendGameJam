using UnityEngine;

[System.Serializable]
public class PlayerInventory
{
    public int coins;
    public int keys;
    public int gems;
    public int stamina;
    public int currentFloor = 1;

    // Add resources
    public void AddCoins(int amount) => coins += amount;
    public void AddKeys(int amount) => keys += amount;
    public void AddGems(int amount) => gems += amount;
    public void AddStamina(int amount) => stamina += amount;


    // Spend resources
    public bool CanAfford(RoomDefinition room)
    {
        if (gems < room.gemCost) return false;
        return true;
    }

    public void PayCost(RoomDefinition room)
    {
        gems -= room.gemCost;
    }

    // Modify stamina
    public void RecoverStamina(int amount)
    {
        stamina += amount;
    }

    public void LoseStamina(int amount)
    {
        stamina -= amount;
    }

    public void ResetForNewRun()
    {
        coins = 0;
        gems = 0;
        stamina = 10;
        currentFloor = 1;
    }

    public void AdvanceFloor()
    {
        currentFloor++;
    }
}