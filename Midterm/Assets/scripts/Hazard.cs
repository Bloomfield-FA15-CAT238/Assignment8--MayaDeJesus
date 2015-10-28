using UnityEngine;
using System.Collections;

public class Hazard : MonoBehaviour
{
    public GameObject respawnPoint;

    void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = respawnPoint.transform.position;
    }
}
