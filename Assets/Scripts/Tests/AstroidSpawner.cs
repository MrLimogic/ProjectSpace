using UnityEngine;
using System.Collections;

public class AstroidSpawner : MonoBehaviour {


    public GameObject asteroid;
    public Vector3 spawnValue;
    public int asteroidCounter;
    public float spawnRate;
    public float startWait;


	// Use this for initialization
	void Start () {

        StartCoroutine(asteroidSpawner());
	}

    IEnumerator asteroidSpawner(){
        yield return new WaitForSeconds(startWait);
        while (true) {
            for (int i = 0; i > asteroidCounter; i++){
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValue.x, spawnValue.x), spawnValue.y, spawnValue.z);
                Quaternion spawnRotation = new Quaternion();
                Instantiate(asteroid, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnRate);
            }
        }
    }
    

	
	// Update is called once per frame
	void Update () {
	
	}
}
