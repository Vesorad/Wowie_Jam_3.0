using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OhhButton : MonoBehaviour
{
   public GameObject goodBut;
   public GameObject BadBut;
    public GameObject ohhBut;
    int click = 0;
    void Start()
    {
        
    }
   public void addClick()
    {
        click += 1;
    }
    // Update is called once per frame
    void Update()
    {
        if (click ==2)
        {
            goodBut.SetActive(false);
            BadBut.SetActive(false);
            ohhBut.SetActive(true);
        }
          
          
    }
}
