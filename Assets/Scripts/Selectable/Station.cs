using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Station : Selectable
{
    public Shrimp WorkingShrimp;
    public float MinimumPowerRequirement;
    public float BaseStationWorkTime;
    public double BaseValue;

    protected override void _Awake()
    {
        WorkingShrimp = null;
        StartCoroutine(Work());
    }

    public bool AssignShrimp(Shrimp s)
    {
        if (s.Power >= MinimumPowerRequirement)
        {
            if (WorkingShrimp != null)
            {
                WorkingShrimp.CurrentStation = null;
            }

            s.CurrentStation = this;
            WorkingShrimp = s;
            return true;
        }

        return false;
    }

    private IEnumerator Work()
    {
        while (true)
        {
            yield return new WaitUntil(() => WorkingShrimp != null);
            Player.AddCoins(BaseValue * WorkingShrimp.Value);
            yield return new WaitForSeconds(BaseStationWorkTime / (WorkingShrimp.Power * WorkingShrimp.Size));
        }
    }

    protected override void _Select()
    {

    }
}
