using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour//, IDataPersistence
{
    // [SerializeField] private string id;
    // private bool collected = false;
    //[ContextMenu("Generate guid for id")]

    //private void GenerateGuid()
    //{
    //    id = System.Guid.NewGuid().ToString();
    //}
   

    
    void Start()
    {
        gameObject.SetActive(true);
    }
  private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
        
        if (playerInventory != null)
        {
            playerInventory.DiamondCollected();
            //collected = true;
            gameObject.SetActive(false);
        }
        
    }
    //public void LoadData(GameData data)
    //{
    //   data.numCollected.TryGetValue(id, out collected);
    //    if(collected)
    //    {
    //        gameObject.SetActive(false);
    //    }
    //}

    //public void SaveData(ref GameData data)
    //{
    //    if(data.numCollected.ContainsKey(id))
    //    {
    //        data.numCollected.Remove(id);
    //    }
    //    data.numCollected.Add(id, collected);
    //}
}
