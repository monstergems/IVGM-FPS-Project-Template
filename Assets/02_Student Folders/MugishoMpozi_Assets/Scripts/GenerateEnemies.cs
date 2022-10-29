using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{

    public GameObject enemy;
    public GameObject player = GameObject.Find("Player");
    public int xPos;
    public int yPos;

    public int roomMinXPos;

    public int roomMinZPos;
    public int roomMaxXPos;
    public int roomMaxZPos;
    public int enemyCount;

    private float spawnIntervalShort = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(spawnIntervalShort));
    }

    IEnumerator spawnEnemy(float spawnIntervalShort) {
        var playerPostionX = GameObject.Find("Player").transform.position.x;
        var playerPostionY = GameObject.Find("Player").transform.position.y;
        if (playerPostionX > roomMinXPos && playerPostionX < roomMaxXPos &&
        playerPostionY > roomMinYPos && playerPostionY < roomMaxYPos) {
            xPos = Random.Range(roomMinXPos, roomMaxXPos);
            yPos = Random.Range(roomMinYPos, roomMaxYPos);
            Instantiate(enemy, new Vector3(xPos, 1, yPos), Quaternion.identity);
            yield return new WaitForSeconds(spawnIntervalShort);
        }

    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
