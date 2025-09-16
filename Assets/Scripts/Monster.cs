
using UnityEngine;
public class Monster : Character
{
    //Attributes
    public bool defeated = false;
   
    private int lootReward;
    public int LootReward
    {
        get { return lootReward; }
        set
        {
            if (value < 0)
                lootReward = 0;
            else
                lootReward = value;
        }

    }

    //Constructor to create an Object
    public void Init(string newName, int newHP,int newAttackPower ,int newLootReward  )
    {
        /*Name = newName;
        Health = newHP;
        attackPower = newAttackPower;*/
        base.Init(newName, newHP, newAttackPower);
        LootReward = newLootReward;
    }

    public override void ShowStats()
    {
        base.ShowStats();
        Debug.Log($"Loot Reward: {LootReward}");
    }





    public int DropReward()
    {

        return LootReward;
    }
   
}



