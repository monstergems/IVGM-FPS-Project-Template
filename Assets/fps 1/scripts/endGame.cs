using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGame : MonoBehaviour
{
    public GameObject player;
    public GameObject EndDoor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(player.transform.position.x-EndDoor.transform.position.x)<0.5&&Mathf.Abs(player.transform.position.y-EndDoor.transform.position.y)<0.5&&Mathf.Abs(player.transform.position.z-EndDoor.transform.position.z)<0.5)
            // here should the level ended and go to the next level
            Debug.Log("end of the game");
    }
}
