using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System;
using UnityEngine.UI;


public class Fuzzy : MonoBehaviour//, IDataPersistence
{
    //[SerializeField]
    //private AnimationCurve good;
    //[SerializeField]
    //private AnimationCurve grey;
    //[SerializeField]
    //private AnimationCurve bad;

    //public int triggeredEvents;
    //public float triggeredEventsTotal = 9;
    //public float triggeredAverage;

    ////public void LoadData(GameData data)
    ////{
       
    ////    foreach (KeyValuePair<string, bool> pair in data.numCollected)
    ////    {
    ////        if (pair.Value)
    ////        {
    ////            triggeredEvents++;
    ////        }
    ////    }
    ////}
    ////public void SaveData(ref GameData data)
    ////{
        

    ////}

    //// Start is called before the first frame update
    //void Start()
    //{
    //    triggeredEvents = StaticManager.numDiamonds;
    //    EvaluateFuzzy();
    //}

    //// Update is called once per frame
    //void Update()
    //{
       
    //}

    //private void EvaluateFuzzy()
    //{

      

    //    triggeredAverage = triggeredEventsTotal / triggeredEvents;

    //    float goodValue = good.Evaluate(triggeredAverage);
    //    float greyValue = grey.Evaluate(triggeredAverage);
    //    float badValue = bad.Evaluate(triggeredAverage);

    //    Debug.Log("Good: " + goodValue);
    //    Debug.Log("Grey: " + greyValue);
    //    Debug.Log("Bad: " + badValue);

    //    if(goodValue > greyValue)
    //    {
    //        GetComponent<Renderer>().material.color = Color.green;
    //    }
    //    else if (greyValue > badValue)
    //    {
    //        GetComponent<Renderer>().material.color = Color.yellow;
    //    }
    //    else
    //    {
    //        GetComponent<Renderer>().material.color = Color.red;
    //    }
        
    //}
    

   

}
