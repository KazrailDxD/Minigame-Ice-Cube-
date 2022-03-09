using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watersplash : MonoBehaviour
{

    [SerializeField] GameObject waterSplashPrefab = null;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("IceHazard")) 
        {
            Instantiate(waterSplashPrefab, other.transform.position, Quaternion.identity);
        }
    }

}
