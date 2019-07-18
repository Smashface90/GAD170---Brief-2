using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    //TODO Expand on the stats contained below, make sure you have some that are class-specific.
    public string myName;
    public Sprite mySprite;

    [Header("Base Stats")]
    public int Str;
    public int Agi;
    public int Int;
    [Header("Sub Stats")]
    public int health;
    public int damage;

    private void Start()
    {
        damage = Agi *2 + Int;
        health = Str * 3;
    }

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
