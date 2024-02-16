using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tutorial : MonoBehaviour
{
    public TextMeshProUGUI movement;
    public TextMeshProUGUI menus;
    public TextMeshProUGUI extra;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(StaticManager.myTimer > 0)
        {
            movement.text = "Use W,A,S, and D to get around and Space to jump.";
        }
        if(StaticManager.myTimer >= 2)
        {
            movement.text = "Press P to Pause And Tab for Achievements.";
        }
        if (StaticManager.myTimer >= 6)
        {
            movement.text = "Press E to interact \r\nPress K to reset Achievements";
        }
        if(StaticManager.myTimer >= 10)
        {
            movement.text = "";
        }


    }
}
