using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{

    public GameObject enemy;
    public int xPos;
    public int yPos;
    public int maxNumEnemies;
    public int killedEnemies;
    public float spawnIntervalShort = 2f;
    public List<GameObject> spawnedEnemies = new List<GameObject>();

    
    private GameObject player;
    private Vector3 playerPos;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        StartCoroutine(spawnEnemy(spawnIntervalShort));
    }

    IEnumerator spawnEnemy(float spawnIntervalShort) {
        if ((playerPos.x > -17 && playerPos.x < 21) &&
        (playerPos.z > -5 && playerPos.z < 22)) {
            if (spawnedEnemies.Count < maxNumEnemies) {
                xPos = Random.Range(-17, 21);
                yPos = Random.Range(-5, 22);
                spawnedEnemies.Add(Instantiate(enemy, new Vector3(xPos, 1, yPos), Quaternion.identity));
            }
        }

        yield return new WaitForSeconds(spawnIntervalShort);
        StartCoroutine(spawnEnemy(spawnIntervalShort));
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = player.transform.position;
        for (int i = 0; i < spawnedEnemies.Count; i++) {
            if (spawnedEnemies[i] == null) {
                spawnedEnemies.RemoveAt(i);
                killedEnemies++;
            }
        }
    }
}
