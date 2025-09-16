using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    /*private List<Monster> monsters = new List<Monster>();*/
    public Hero hero;
    public List<Monster> monstersPrefabs;

    public Monster currentMonster;

    public List<Monster> monsters = new List<Monster>();
    void Start()
    {

        hero.Init("The Knight", 100, 0);
        hero.ShowStats();

        /////-------Dragon-------//////
        //spawn monster game object from prefab
        currentMonster = Instantiate(monstersPrefabs[0]);
        //Initializetion
        currentMonster.Init("Dragon", 200, 10, 15);
        

        //Keep track of spawned monsters
        monsters.Add(currentMonster);
        /////-------Goblin-------//////
        //spawn monster game object from prefab
        currentMonster = Instantiate(monstersPrefabs[1]);
        //Initializetion
        currentMonster.Init("Goblin", 50, 10, 15);
        

        //Keep track of spawned monsters
        monsters.Add(currentMonster);
        ////---------Orc----------////
        //spawn monster game object from prefab
        currentMonster = Instantiate(monstersPrefabs[2]);
        //Initializetion
        currentMonster.Init("Orc", 30, 10, 15);
        

        //Keep track of spawned monsters
        monsters.Add(currentMonster);

        //show monster stats
        foreach (var m in monsters)
        {
            m.ShowStats();
        }   

































        /*//create hero
        Hero hero = new Hero("The Knight", 100, 10);

        //create monster

        Monster monster = new Monster("Orc", 30, 10, 15);
        Monster monster2 = new Monster("Goblin", 20, 5, 10);
        Monster monster3 = new Monster("Dragon", 200, 25, 100);
        monsters.Add(monster);
        monsters.Add(monster2);
        monsters.Add(monster3);
        monsters.Add(new Monster("Troll", 50, 15, 20));

        //show hero stats 
        Debug.Log($"Hero name: {hero.Name} | Health: {hero.Health} | Gold: {hero.Gold} ");
        hero.ShowStats();
        Debug.Log("A wild monster appears!");
        //show monster stats
        Debug.Log($"Monster name: {monster.Name} | Health: {monster.Health} | ");
        Debug.Log($"Monster name: {monster2.Name} | Health: {monster2.Health} | ");
        Debug.Log($"Monster name: {monster3.Name} | Health: {monster3.Health} | ");
        foreach (var m in monsters)
        {
            Debug.Log($"Monster name: {m.Name} | Health: {m.Health} | ");
            m.ShowStats();
        }
        hero.Attack(monster);*/
    }
}
