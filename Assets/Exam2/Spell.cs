using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    void Start()
    {
        
    }

    public virtual void Cast()
    {
        Debug.Log("Spell-Casting Simulation Started!");
        Debug.Log("Casting a generic spell!!");
    }

    public void Cast(string target)
    {

    }

    public void Cast(string spellName, int damage)
    {

    }
}
