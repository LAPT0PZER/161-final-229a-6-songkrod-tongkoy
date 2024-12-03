using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Circle : Shape
{
    void Start()
    {
        Init("Circle");
        Draw();
        Resize();
        CalculateArea();
    }

    private float radius;

    public override float CalculateArea()
    {
        radius = 2.0f;
        Debug.Log($"Circle radius {radius}.");
        float area = (float)(3.14 * radius * radius);
        Debug.Log($"Circle area {area}");
        return area;

    }

    public override void Resize()
    {
        base.Resize();
        Debug.Log($"Circle is resized.");
    }

}
