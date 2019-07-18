﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    //TODO Expand on the stats contained below, make sure you have some that are class-specific.
    public string myName;
    public Sprite mySprite;
   // public int health;
   // public int damage;

    [Header("Base Stats")]
    public int Str;
    public int Agi;
    public int Int;
    [Header("Sub Stats")]
    public int MaxHP;
    public int health;
    public int damage;
    public int Def;

    //gittest

    #region VFX & SFX
    public void ShowDamage()
    {
        GetComponent<AudioSource>().Play();
        GetComponent<SpriteRenderer>().color = Color.red;
        Invoke("StopDamage", 0.2f);
    }

    void StopDamage()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }
    #endregion
}
