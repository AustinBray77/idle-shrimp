using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    private static UI _instance;

    public static UI Instance
    {
        get
        {
            return _instance;
        }
    }

    public void Awake()
    {
        _instance = this;
    }
}
