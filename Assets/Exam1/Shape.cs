using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected string shapeName;

    public void Init(string name)
    {
        shapeName = name;
    }

    public abstract float CalculateArea();

    public virtual void Resize()
    {
        Debug.Log("Resizing Shape ...");
    }

    public void Draw()
    {
        Debug.Log($"Drawing {name}");
    }

    void Start()
    {
        
    }
}
