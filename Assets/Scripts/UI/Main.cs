using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Main : UI
{
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI SelectText;

    public void Update()
    {
        ScoreText.text = Player.Coins.ToString();
        SelectText.text = Selectable.CurrentlySelected != null ? Selectable.CurrentlySelected.gameObject.name : "";
    }
}
