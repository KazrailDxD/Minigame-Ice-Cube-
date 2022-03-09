using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRandomAudioClips : MonoBehaviour
{

    [SerializeField] AudioClip[] audioClips = null;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClips[Random.Range(0, audioClips.Length)];
        audioSource.Play();
    }

    
}
