using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class FireSpell : Spell
{
    void Start()
    {
        Cast();
        Cast("Slime");
        Cast("Fireball",5);
    }
    public void Cast(string target)
    {
        Debug.Log($"Casting a spell on target: {target}");
    }

    public void Cast(string spellName, int damage)
    {
        Debug.Log($"Casting a {spellName} Burn them all!!!");
        Debug.Log($"Casting a spell on Slime! with power level: {damage}");
    }
}
