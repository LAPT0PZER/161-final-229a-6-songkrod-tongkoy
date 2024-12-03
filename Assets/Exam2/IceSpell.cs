using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    void Start()
    {
        Cast();
        Cast("Goblin");
        Cast("Ice shard", 5);
    }
    public void Cast(string target)
    {
        Debug.Log($"Casting a spell on target: {target}");
    }

    public void Cast(string spellName, int damage)
    {
        Debug.Log($"Casting a {spellName} Freeze the enemy!!!");
        Debug.Log($"Casting a spell on Goblin! with power level: {damage}");
    }
}
