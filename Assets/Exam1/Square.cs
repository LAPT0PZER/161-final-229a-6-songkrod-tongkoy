using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    void Start()
    {
        Init("Square");
        Draw();
        Resize();
        CalculateArea();
    }

    private int side;

    public override float CalculateArea()
    {
        side = 4;
        Debug.Log($"Square side {side}");
        float area = side * side;
        Debug.Log($"Square area {area}");
        return area;
    }

    public override void Resize()
    {
        base.Resize();
        Debug.Log("Square is resized.");
    }

}
