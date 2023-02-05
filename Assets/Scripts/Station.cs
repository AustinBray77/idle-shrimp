using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Station : MonoBehaviour
{
    public Shrimp WorkingShrimp;
    public float MinimumPowerRequirement;
    public float BaseStationWorkTime;
    public double BaseValue;

    private void Awake()
    {
        WorkingShrimp = null;
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
            Player.AddCoins(BaseValue * WorkingShrimp.Value);
            yield return new WaitForSeconds(BaseStationWorkTime / (WorkingShrimp.Power * WorkingShrimp.Size));
        }
    }
}
