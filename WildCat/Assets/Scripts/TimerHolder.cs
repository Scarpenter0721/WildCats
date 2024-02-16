 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerHolder : MonoBehaviour//, IDataPersistence
{
    //public float timer = 0;
    public TextMeshProUGUI timeKeep;
    

  

    // Update is called once per frame
    void Update()
    {
        StaticManager.myTimer += Time.deltaTime;
        int seconds = ((int)StaticManager.myTimer % 60);
        int minutes = ((int)StaticManager.myTimer / 60);
        timeKeep.text = string.Format("{0:00}:{1:00}", minutes, seconds);
       
    }
    //public void LoadData(GameData data)
    //{
    //    this.timer = data.myTimer;
    //}

    //public void SaveData(ref GameData data)
    //{
    //    data.myTimer = this.timer;
    //}
}
