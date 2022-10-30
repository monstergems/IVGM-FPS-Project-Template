using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterScript_v2 : MonoBehaviour
{
    public bool rise= false;
    public Transform low_level_position;
    public Transform high_level_position;
    public float frac;

    void Start()
    {
        
    }


    public void ChangeWaterLevel()
    {
        rise=!rise;
        
    }

    void Update()
    {
        if(rise)
        {
            //transform.position=Vector3.Lerp(low_level_position,high_level_position,frac);
        }
        else
        {
            //transform.position=Vector3.Lerp(high_level_position,low_level_position,frac);
        }
    }
}
