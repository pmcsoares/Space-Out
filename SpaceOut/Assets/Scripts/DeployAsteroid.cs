using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployAsteroid : MonoBehaviour
{
    public GameObject meteoroAPrefab;
    public float respawnTime = 10.0f;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
    }
    private void spawnEnemy()
    {
        GameObject a = Instantiate(meteoroAPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range (-screenBounds.x, screenBounds.x), -screenBounds.y );
    }
    IEnumerator asteroidWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
        spawnEnemy();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
