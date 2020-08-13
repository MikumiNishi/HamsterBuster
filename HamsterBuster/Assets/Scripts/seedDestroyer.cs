using System.Collections;
using UnityEngine;

public class seedDestroyer : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "seed")
        {
            Destroy(other.gameObject);
        }
    }
}