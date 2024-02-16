using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInteractLvl2 : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.E))
        {
            float interactRange = 2.5f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray)
            {
                if (collider.TryGetComponent(out Lvl2Npc Lvl2Npc))
                {
                    Lvl2Npc.Interact();
                }

            }
        }
    }
}
