using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI numCollected;
    // Start is called before the first frame update 
    void Start()
    {
        numCollected = GetComponent<TextMeshProUGUI>();
    }
    public void UpdateDiamondText(PlayerInventory playerInventory)
    {
        numCollected.text = StaticManager.numDiamonds.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
