using UnityEngine;

public abstract class Character : MonoBehaviour
{
    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value)) { name = "Unknown Hero"; }
            else name = value;
        }

    }

    private int health;
    public int Health
    {
        get { return health; }
        set
        {
            if (value >= 0) health = value;
            else health = 0;
        }
    }

    



    //Constructor to create an Object
    public void Init(string newName, int newHP, int newAttackPower)
    {
        Name = newName;
        Health = newHP;
        AttackPower = newAttackPower;

       
    }

    public void takeDamage(int damageValue)
    {
        Health -= damageValue;

    }
    public bool isAlive()
    {
        return Health > 0;
    }
    
    public int AttackPower { get;  set; }
    public virtual void ShowStats()
    {
        Debug.Log($"Character name: {Name} | Character Health: {Health} | Character Gold: {Gold} ");
    }
    public void Attack(Monster target)
    {
        Debug.Log($"{Name} attacks {target.Name} for {AttackPower} damage!");
        target.takeDamage(AttackPower);
    }
    private int gold;
    public int Gold
    {
        get { return gold; }

        set
        {
            if (value > 999) gold = 999;
            else if (value <= 0) { gold = 0; }
            else gold = value;
        }
    }
}
