using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Crystal : MonoBehaviour
{

    public GenerateEnemies enemyGenerator;
    public GameObject crystal;
    public GameObject crystalLight;
    public int limit;
    public int killCount;
    public int minX;
    public int maxX;
    public int minZ;
    public int maxZ;
    public bool limitReached = false;
    
    // // remember that static attributes are shared for all object instations of a class
    // private static int killCount;
    private GameObject player;
    private Vector3 playerPos;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        // if player is within premises and if the killcount increases
        // change something about the crystal
        playerPos = player.transform.position;

        if (killCount == limit) {
            // change crystal properties

            // Get the Renderer component from the new cube  
            var crystalRenderer = crystal.GetComponent<Renderer>();
            crystalLight.GetComponent<Light>().color = Color.green;

            // Call SetColor using the shader property name "_Color" and setting the color to red
            crystalRenderer.material.SetColor("_Color", Color.green);
            limitReached = true;

            // open all entries
            
            Destroy(GameObject.Find("entrance_1_lock"));
            Destroy(GameObject.Find("entrance_2_lock"));
        } else {
            killCount = enemyGenerator.killedEnemies;
            crystalLight.GetComponent<Light>().intensity = 2 * killCount;
            killCount = enemyGenerator.killedEnemies;
            crystalLight.GetComponent<Light>().range = killCount;
        }
        // in the bot script only keep spawing bots whenever the killcount is not crossed in here is not crossed
    }
}
