using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;
using Ink.Runtime;
public class npcInteract : MonoBehaviour
{

    public TMP_Text pressE;

   public void Interact()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene("InkDialog(Level1)", LoadSceneMode.Additive);
        Debug.Log("Interact");
    }



    void Update()
    {
       
    }
}
