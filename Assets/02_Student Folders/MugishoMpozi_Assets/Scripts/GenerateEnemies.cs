using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{

    public GameObject enemy;
    public GameObject player;
    public int xPos;
    public int yPos;
    public int enemyCount;
    public float spawnIntervalShort = 2f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(spawnIntervalShort));
    }

    IEnumerator spawnEnemy(float spawnIntervalShort) {
        var playerPostionX = player.transform.position.x;
        var playerPostionY = player.transform.position.y;
        if (playerPostionX > -17 && playerPostionX < 21 &&
        playerPostionY > -5 && playerPostionY < 22) {
            xPos = Random.Range(-17, 21);
            yPos = Random.Range(-5, 22);
            Instantiate(enemy, new Vector3(xPos, 1, yPos), Quaternion.identity);
            yield return new WaitForSeconds(spawnIntervalShort);
        }

        StartCoroutine(spawnEnemy(spawnIntervalShort));
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
