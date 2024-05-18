using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Sound : MonoBehaviour
{
    public AudioClip[] Sounds;

    private AudioSource _audioSource => GetComponent<AudioSource>();

    public void PlaySound(AudioClip audioClip, float volume = 1f, bool destroyed = false)
    {
        _audioSource.PlayOneShot(audioClip, volume);
        if (destroyed) AudioSource.PlayClipAtPoint(audioClip, transform.position, volume);
        else _audioSource.PlayOneShot(audioClip, volume);
    }
}
