using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScaneManager : MonoBehaviour
{
   public int ActtualScene;

    private void OnLevelWasLoaded()
    {
        if (ActtualScene == 1)
        {
            StartCoroutine(StartMainGame());
        }
    }
    IEnumerator StartMainGame()
    {
        yield return new WaitForSeconds(2);
        NextScene();
    }
    public void NextScene()
    {
        SceneManager.LoadScene(ActtualScene + 1);
    }
    
}
