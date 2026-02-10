using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIIdolTracker : MonoBehaviour
{
    public int idolCounter = 0;
    public TMP_Text idol_tmp;
    public void GetIdol()
    {
        idolCounter++;
        idol_tmp.SetText("x " + idolCounter.ToString());
    }
}
