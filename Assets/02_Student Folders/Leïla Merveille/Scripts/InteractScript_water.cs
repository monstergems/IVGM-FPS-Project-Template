using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript_water : MonoBehaviour
{
    public GameObject water;
    public float interactDistance=5f;

    private float variableToChange;
    private float changePerSecond;

    void Update()
    {
        // we need the water level to rise when we pull a lever
        //      - pull lever
        //          - detect lever
        //          - turn on water level rising switch
        //      - increase the water level
        variableToChange += changePerSecond * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = new Ray(transform.position,transform.forward);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit,interactDistance))
            {
                if(hit.collider.gameObject.tag == "Switch_Lever")
                {
                    Debug.Log("TESTESTESTEST");
                    // Destroy(hit.collider.gameObject);
                }
            }
        }
        // Debug.Log(Time.deltaTime);

    }
}
