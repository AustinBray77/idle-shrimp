using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrimp : MonoBehaviour
{
    public float Power;
    public int Size;
    public Station CurrentStation;

    public float Value => Power * Size;

    private void Awake()
    {
        CurrentStation = null;
    }
}
