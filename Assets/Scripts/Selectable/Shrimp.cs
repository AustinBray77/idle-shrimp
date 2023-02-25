using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrimp : Selectable
{
    public float Power;
    public int Size;
    public Station CurrentStation;

    public float Value => Power * Size;

    protected override void _Awake()
    {
        CurrentStation = null;
    }

    protected override void _Select()
    {

    }
}
