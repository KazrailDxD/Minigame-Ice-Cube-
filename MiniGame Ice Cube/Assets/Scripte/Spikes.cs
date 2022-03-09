using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{

    [SerializeField] GameObject[] spikes = null;
    [SerializeField] GameObject spikeexplodeParticles = null;

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.CompareTag("Player") && spikes != null) 
        {
            Destroy(collision.gameObject);
        }

        if(collision.transform.CompareTag("Plattform") && spikes != null) 
        {
            foreach(GameObject spike in spikes) 
            {
                Destroy(spike);
            }

            spikes = null;

            Instantiate(spikeexplodeParticles, transform.position, Quaternion.identity);

        }
    }
}
