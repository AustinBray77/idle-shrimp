using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Main : UI
{
    public TextMeshProUGUI ScoreText;

    public void Update()
    {
        ScoreText.text = Player.Coins.ToString();
    }
}
