// Evan Waters 1017144
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleLogic : MonoBehaviour
{
    // "heroes" and "monsters" lists are where the chosen characters spawn in
    // "heroPrefab" and monsterPrefab" lists are where the characters are held

    public List<CharacterStats> heroes = new List<CharacterStats>();
    public List<CharacterStats> monsters = new List<CharacterStats>();

    public List<GameObject> heroPrefab = new List<GameObject>();
    public List<GameObject> monsterPrefab = new List<GameObject>();

    public Transform[] heroSpawn = new Transform[3];
    public Transform[] monsterSpawn = new Transform[3];

    public WriteText ouputLog;

    public int currentPlayerIndex =0;

    public AudioClip hurt, atack;

    private void Start()
    {
        //This will call the SpawnIn function when the game starts

        SpawnIn();

        //This will repeat the Attack function once every four seconds indefinitely
        InvokeRepeating("Attack", 4, 4);

        //An example of how to write a string to the screen"

        ouputLog.OutputText("Oh no, " + monsters[0].myName + ", " + monsters[1].myName + " and a " + monsters[2].myName + " approache!");
    }

    void SpawnIn()
        //choose 3 random heroes and monsters and spawn them into the spawnpoints
    {
        for (int h = 0; h < 3; h++)
        {
            GameObject g = Instantiate(heroPrefab[Random.Range(0, heroPrefab.Count)], heroSpawn[h]) as GameObject;
            heroes.Add(g.GetComponent<CharacterStats>());
        }
        for (int m = 0; m < 3; m++)
        {
            GameObject g = Instantiate(monsterPrefab[Random.Range(0, monsterPrefab.Count)], monsterSpawn[m]) as GameObject;
            monsters.Add(g.GetComponent<CharacterStats>());
        }        
    }
    public bool isMonster = false;
    void Attack()
    {
        //TODO Rewrite the code below to work for three heroes & three monsters (choosing one per side each round)

        // The following code serves as an example of combat, but it is far too simplistic and does not meet all
        // the requirements, you will need to modify this heavily based on the system you want to implement.


        CharacterStats currentPlayer = null;
        CharacterStats currentTarget = null;
        isMonster = false;

        if (currentPlayerIndex >= heroes.Count)
        {
            isMonster = true;
        }

        //who will fight?
        if (isMonster)
        {
            currentPlayer = monsters[currentPlayerIndex -heroes.Count];
            currentTarget = heroes[Random.Range(0, heroes.Count)];

        }
        else
        {
            currentPlayer = heroes[currentPlayerIndex];
            currentTarget = monsters[Random.Range(0, monsters.Count)];
        }


        Debug.Log(currentPlayer.myName + ": " + currentPlayerIndex);
        int simpleRandomChance = Random.Range(0, 2);
        string log = "";

        //Hero or monster hits based on a flat 50% chance
        if(simpleRandomChance == 0)
        {
            //actually modifies damage value
           // currentPlayer.health -= currentTarget.damage;

            //runs function controlling SFX and VFX
           // currentPlayer.ShowDamage();

            //writes the result to the output string
            log = "The " + currentPlayer.myName + " missed the target";
        }
        else
        {
            currentTarget.health -= currentPlayer.damage;

            currentTarget.ShowDamage();

            log = "The " + currentPlayer.myName + " hits the " + currentTarget.myName + " for " + currentPlayer.damage + " damage! It has " + currentTarget.health + " HP remaining";
        }
        
        //These end the game if either character's hp drops below 0
        if (currentTarget.health <= 0)
        {

            if (isMonster)
            {
                heroes.Remove(currentTarget);
            }
            else
            {
                monsters.Remove(currentTarget);
            }


            Destroy(currentTarget.gameObject);

            log = "The " + currentTarget.myName + " has been defeated!";

            //This must be called when combat finishes.
        }

        if (heroes.Count <= 0)
        {
            log = "Defeat! The heores have been defeated!";
        }
        else if (monsters.Count <= 0)
        {
            log = "Victory! The monsters have been defeated!";
        }

        if (log.Length != 0)
        {

            ouputLog.OutputText(log);
        }
        currentPlayerIndex++;

        if (currentPlayerIndex >= heroes.Count + monsters.Count) 
        {
            currentPlayerIndex = 0;
        }
    }
}
