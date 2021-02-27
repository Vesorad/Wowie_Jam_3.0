using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool redKey;
    public bool yellowKey;
    public bool blueKey;
   

   public void SetActiveKey(string color)
    {
        switch (color)
        {
            case "Red":
                redKey = true;
                break;
            case "Yellow":
                yellowKey = true;
                break;
            case "Blue":
                blueKey = true;
                break;
            default:
                break;
        }
    }
  
}
