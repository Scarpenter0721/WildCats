using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    private GameObject player;
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;
    public float zMin;
    public float zMax;
    public float zOffset= -15f;
    private float secOffset = -10f;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Cat"); 
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.z > player.transform.position.z + secOffset)
        {
            zMin = player.transform.position.z + zOffset;
            zMax = player.transform.position.z + secOffset;
        }
        
        float x = Mathf.Clamp(player.transform.position.x, xMin, xMax);
        float y = Mathf.Clamp(player.transform.position.y, yMin, yMax);
        float z = Mathf.Clamp(player.transform.position.z, zMin, zMax);
       
        gameObject.transform.position = new Vector3(x, y, z);
    }
}
