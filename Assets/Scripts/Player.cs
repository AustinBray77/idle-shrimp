using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class Player : MonoBehaviour
{
    private static Currency s_coins = new Currency();

    [Range(0.0f, 1000000.0f)]
    public float testCoins;

    private Camera _camera;

    public static Currency Coins
    {
        get
        {
            return s_coins;
        }
    }

    private void Start()
    {
        s_coins = new Currency((double)testCoins);
        _camera = GetComponent<Camera>();
    }

    private void Update()
    {
        InputHandler();
    }

    private void InputHandler()
    {
        if (SEnvironment.CurrentPlatform == SEnvironment.Platform.Windows)
        {
            Input_WIN();
        }
        else if (SEnvironment.CurrentPlatform == SEnvironment.Platform.Android)
        {
            Input_AND();
        }
        else if (SEnvironment.CurrentPlatform == SEnvironment.Platform.Editor)
        {
            Input_WIN();
            Input_AND();
        }
    }

    public static void AddCoins(double coins)
    {
        s_coins += coins;
    }

    public static void RemoveCoins(double coins)
    {
        s_coins -= coins;
    }

    private void SelectObject(Selectable s)
    {
        s.Select();
    }

    private void DeselectObject()
    {
        Selectable.CurrentlySelected.Deselect();
    }

    #region Windows Specific Code
    public void Input_WIN()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(_camera.ScreenToWorldPoint(Input.mousePosition), Vector3.forward);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.tag == "Selectable")
                {
                    SelectObject(hit.collider.gameObject.GetComponent<Selectable>());
                }
            }
            else if (Selectable.CurrentlySelected != null)
            {
                DeselectObject();
            }
        }
    }
    #endregion

    #region Android Specific Code
    public void Input_AND()
    {

    }
    #endregion
}
