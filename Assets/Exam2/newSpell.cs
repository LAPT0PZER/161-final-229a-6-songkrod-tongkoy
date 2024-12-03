using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newSpell : Spell
{
    void Start()
    {
        Cast();
        Cast("GeGe");
        Cast("Thunder", 5);
    }
    public void Cast(string target)
    {
        Debug.Log($"Casting a spell on target: {target}");
    }

    public void Cast(string spellName, int damage)
    {
        Debug.Log($"Casting a {spellName} hit the enemy!!!");
        Debug.Log($"Casting a spell on GeGe! with power level: {damage}");
    }
}
