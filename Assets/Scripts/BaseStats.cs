using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStats : MonoBehaviour
{
    public int playerLevel = 1;
    public int EXP = 0;

    [Header("Base Stats")]
    public int Str;
    public int Agi;
    public int Int;
    [Header("Sub Stats")]
    public int MaxHP;
    public int CurHP;
    public int Atk;
    public int Def;


    //References
    randomiser randomiser_Script;


    // Start is called before the first frame update
    void Start()
    {
        randomiser_Script = FindObjectOfType<randomiser>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
