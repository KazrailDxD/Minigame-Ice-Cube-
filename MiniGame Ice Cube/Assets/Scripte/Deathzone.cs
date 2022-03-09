using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathzone : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            Destroy(other.gameObject);        
        }

        if (other.CompareTag("IceHazard")) 
        {
            Destroy(other.gameObject);
        }
    }

}
