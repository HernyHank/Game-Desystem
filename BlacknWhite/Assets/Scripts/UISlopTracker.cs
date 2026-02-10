using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UISlopTracker : MonoBehaviour
{
    public int slopCounter = 0;
    public TMP_Text slop_tmp;
    public void GetCoin()
    {
        slopCounter++;
        slop_tmp.SetText("x " + slopCounter.ToString());
    }
}
