using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{

    public AudioSource impactSound;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 2) {
            Debug.Log("Bang");
            impactSound.volume = Mathf.Min(1.0f, Mathf.Sqrt(collision.relativeVelocity.magnitude/200));
            impactSound.Play();
        }
    }
}

