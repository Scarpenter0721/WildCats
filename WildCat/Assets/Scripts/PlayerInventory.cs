using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class PlayerInventory : MonoBehaviour//, IDataPersistence
{
    public TextMeshProUGUI numCollect;
    public int NumberOfDiamonds;
    //public UnityEvent<PlayerInventory> OnDiamondCollected; 

    public void DiamondCollected()
    {
        NumberOfDiamonds = StaticManager.numDiamonds;
        NumberOfDiamonds++;
        StaticManager.numDiamonds = NumberOfDiamonds;
        if(StaticManager.numDiamonds == 9)
        {
            AchievementManager.instance.Unlock("allCollected");
        }
        //StaticManager.numDiamonds = NumberOfDiamonds;
        //OnDiamondCollected.Invoke(this);
    }
    //public void LoadData(GameData data)
    //{
    //    foreach(KeyValuePair<string, bool> pair in data.numCollected)
    //    {
    //        if(pair.Value)
    //        {
    //            NumberOfDiamonds++;
    //        }
    //    }
    //}

    //public void SaveData(ref GameData data)
    //{
        
    //}
    public void Update()
    {
        numCollect.text = StaticManager.numDiamonds.ToString();
    }
}
