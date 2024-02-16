using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GGFinalTime : MonoBehaviour//, IDataPersistence
{
    public TextMeshProUGUI ggFinalTime;
    public TextMeshProUGUI collectedItems;
    public float finalTime = 0;
    public float collected = 0;
    // FuzzyLogic
    [SerializeField]
    private AnimationCurve good;
    [SerializeField]
    private AnimationCurve grey;
    [SerializeField]
    private AnimationCurve bad;

    public int triggeredEvents;
    public float triggeredEventsTotal = 9;
    public float triggeredAverage;

    // Start is called before the first frame update


    //public void LoadData(GameData data)
    //{
    //    this.finalTime = data.myTimer;
    //    foreach (KeyValuePair<string, bool> pair in data.numCollected)
    //    {
    //        if (pair.Value)
    //        {
    //            collected++;
    //        }
    //    }
    //}

    //public void SaveData(ref GameData data)
    //{

    //}
    void Start()
    {
        triggeredEvents = StaticManager.numDiamonds;
        EvaluateFuzzy();
        StaticManager.finalTime = StaticManager.myTimer;
        collected = StaticManager.numDiamonds;
        Format();
        collectedItems.text = collected.ToString();
        
    }
    void Format()
    {
        int seconds = ((int)StaticManager.finalTime % 60);
        int minutes = ((int)StaticManager.finalTime / 60);
        ggFinalTime.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    private void EvaluateFuzzy()
    {



        triggeredAverage = triggeredEvents / triggeredEventsTotal;

        float goodValue = good.Evaluate(triggeredAverage);
        float greyValue = grey.Evaluate(triggeredAverage);
        float badValue = bad.Evaluate(triggeredAverage);

        Debug.Log("Good: " + goodValue);
        Debug.Log("Grey: " + greyValue);
        Debug.Log("Bad: " + badValue);

        if (goodValue > greyValue)
        {
            if (goodValue > badValue)
            {
                collectedItems.color = Color.green;
            }
            else
            {
                collectedItems.color = Color.red;
            }
        }
        else
        {
            if (greyValue > badValue)
            {
                collectedItems.color = Color.grey;
            }
            else
            {
                collectedItems.color = Color.red;
            }
        }
       

    }
}
