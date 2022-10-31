using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targets : MonoBehaviour
{

    public GameObject target_one;
    public GameObject target_two;
    public GameObject target_three;
    public GameObject target_four;
    public GameObject target_five;
    public GameObject door;
    // Start is called before the first frame update
    // Vector3 myPosition = target_one.transform.position;
    // Transform myTransform = target_one.transform;
    void start(){

    }
    

    // Update is called once per frame
    // public float speed = 2;
    void Update()
    {
        if (target_five==null&&target_four==null&&target_four==null&&target_one==null&&target_three==null&&target_two==null)
            // Debug.Log("hit");
            Destroy(door);
            // door.transform.position = new Vector3 (0,0,0);
            // gearOne.transform.Rotate(0, 0, 1)
        // float x = Input.GetAxis("Horizontal");
        // float z = Input.GetAxis("Vertical");
        // Vector3 movement = new Vector3(x, 0, z);
        // transform.Translate(movement * speed * Time.deltaTime);
    }
}
