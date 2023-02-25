using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Selectable : MonoBehaviour
{
    public static Selectable CurrentlySelected = null;

    private void Awake()
    {
        gameObject.tag = "Selectable";
        _Awake();
    }

    protected abstract void _Awake();

    public void Select()
    {
        if (CurrentlySelected != null)
        {
            CurrentlySelected.Deselect();
        }

        CurrentlySelected = this;

        _Select();
    }

    protected abstract void _Select();

    public virtual void Deselect()
    {
        CurrentlySelected = null;
    }
}
