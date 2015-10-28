using UnityEngine;
using System.Collections;

public class Hazard2 : MonoBehaviour
{

    public GameObject player;
    public PlayerHealthBar playerHealth;

    // Use this for initialization
    void Awake()
    {
        playerHealth = player.GetComponent<PlayerHealthBar>();
    }

    void OnTriggerEnter(Collider other)
    {
        playerHealth.takeDamage();
    }

    void OnTriggerStay(Collider other)
    {
        playerHealth.takeDamage();
    }
}