using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;
    public AudioClip coinPickupSound; // Add a public AudioClip field for the sound effect
    public float soundVolume = 1.0f; // Volume control for the sound effect

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Using CompareTag for efficiency
        {
            Debug.Log("Player picked up a coin");

            // Play the sound effect at the coin's position
            if (coinPickupSound != null)
            {
                AudioSource.PlayClipAtPoint(coinPickupSound, transform.position, soundVolume);
            }
            else
            {
                Debug.LogWarning("Coin pickup sound is not assigned in the Inspector!");
            }

            // Update the coin count in the manager
            Manager.instance.UpdateCoinCount(coinValue);

            // Destroy the coin game object
            Destroy(gameObject);
        }
    }
}
