using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public Crystal crystal;

    public GameObject enemy;
    public int xPos;
    public int yPos;
    public int minX;
    public int maxX;
    public int minZ;
    public int maxZ;
    public int height;
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
        if ((playerPos.x > minX && playerPos.x < maxX) &&
        (playerPos.z > minZ && playerPos.z < maxZ)) {
            if (spawnedEnemies.Count < maxNumEnemies && !crystal.limitReached) {
                xPos = Random.Range(minX, maxX);
                yPos = Random.Range(minZ, maxZ);
                spawnedEnemies.Add(Instantiate(enemy, new Vector3(xPos, height, yPos), Quaternion.identity));
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
