using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightStats : CharacterStats
{
    // Start is called before the first frame update
    void Start()
    {
        MaxHP = Str + Agi * 2;
        health = MaxHP;

        damage = Str + Agi;
        Def = Agi * 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
