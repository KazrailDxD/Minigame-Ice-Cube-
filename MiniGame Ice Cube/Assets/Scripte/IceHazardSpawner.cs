using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceHazardSpawner : MonoBehaviour
{

    [SerializeField] GameObject smallIceHazardPrefab = null;  //35% Spawnwahrscheinlichkeit
    [SerializeField] GameObject IceHazardPrefab = null;       // 50% Spawnwahrscheinlichkeit
    [SerializeField] GameObject BigIceHazardPrefab = null;  // 15% Spawnwahrscheinlichkeit

    [SerializeField] float spawnTime = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnIceHazards());
    }

    IEnumerator SpawnIceHazards() 
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);

            Vector3 spawnPosition = new Vector3(Random.Range(-8.5f, 8.5f), transform.position.y, Random.Range(-8.5f, 8.5f));
           
            if(spawnPosition.magnitude > 8.5f) 
            {
                spawnPosition = spawnPosition.normalized * 8.5f;
                spawnPosition.y = transform.position.y;
            }

            GameObject prefabToSpawn = null;
            float chance = Random.Range(0.0f, 100.0f);

            if(chance <= 15.0f) 
            {

                prefabToSpawn = BigIceHazardPrefab;

            }
            else if(chance <= 50.0f) 
            {

                prefabToSpawn = IceHazardPrefab;

            }
            else 
            {
                prefabToSpawn = smallIceHazardPrefab;
            }

            Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
        }
    }
}
