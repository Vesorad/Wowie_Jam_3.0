using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScaneManager : MonoBehaviour
{
   public int ActtualScene;
   PlayerHealth playerHealth;
    private void Start()
    {
        if (FindObjectOfType<PlayerHealth>() !=null)
        {
            playerHealth = FindObjectOfType<PlayerHealth>();
        }    
    }
    private void Update()
    {
        if (FindObjectOfType<PlayerHealth>() != null)
        {
            if (playerHealth.currentHealth == 0)
            {
                ResetScene();
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    void ResetScene()
    {
        SceneManager.LoadScene(ActtualScene);
    }
    private void OnLevelWasLoaded()
    {
        if (ActtualScene == 1 ||ActtualScene==7||ActtualScene==4)
        {
            StartCoroutine(StartMainGame());
        }
    }
    IEnumerator StartMainGame()
    {
        yield return new WaitForSeconds(5);
        NextScene();
    }
    public void NextScene()
    {
        SceneManager.LoadScene(ActtualScene + 1);
    }
    public void StartAgainGame()
    {
        SceneManager.LoadScene(0);
    }
}
