using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using Ink.Runtime;

public class Lvl2Npc : MonoBehaviour
{
    // Start is called before the first frame update
    public void Interact()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene("InkDialog(Level2)", LoadSceneMode.Additive);
        if (StaticManager.playerLives == 3)
        {
            AchievementManager.instance.Unlock("_9Lives");
        }
        if (StaticManager.finalTime <= 55)
        {
            AchievementManager.instance.Unlock("timeTrial");
        }
        Debug.Log("Interact");
    }
}
