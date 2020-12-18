using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class AddScore : MonoBehaviour
{
    public AudioClip coin;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;
        audioSource.PlayOneShot(coin, 0.7f);
    }
}
