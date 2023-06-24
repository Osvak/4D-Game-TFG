using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public AudioSource source;
    public AudioClip hoverFX;
    public AudioClip pressedFX;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    public void HoverSound()
    {
        source.PlayOneShot(hoverFX);
    }

    public void PressedSound()
    {
        source.PlayOneShot(pressedFX);
    }
}
