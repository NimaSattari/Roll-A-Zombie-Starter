using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public GameManager gameManager;
    public AudioClip hit;
    AudioSource source;

    private void OnTriggerEnter(Collider other)
    {
        gameManager.AddPoint();
        source = this.GetComponent<AudioSource>();
        source.PlayOneShot(hit);
    }
}
