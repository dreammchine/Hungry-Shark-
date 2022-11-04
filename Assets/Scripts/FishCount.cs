using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishCount : MonoBehaviour
{
    public int Fishtotal = 0;
    public Text FishText;
    
   

    // Update is called once per frame
    void Update()
    {
        Fishtotal = FishAI.totalFish;
        FishText.text = ("Yummy Fish " + Fishtotal);
    }
}
