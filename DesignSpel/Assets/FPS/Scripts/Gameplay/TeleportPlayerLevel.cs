using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayerLevel : MonoBehaviour
{
    int index = 0;
    [SerializeField] List<GameObject> teleportLocation = new List<GameObject>() ;
    Rigidbody rigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Teleport"))
        {
            TeleportOrb teleportOrb = other.gameObject.GetComponent<TeleportOrb>();
            if (teleportOrb != null)
            {
                Vector3 teleportPosition = teleportLocation[index].gameObject.transform.position;
                rigidbody.position = teleportPosition + new Vector3(0, 1, 0); // Offset to avoid clipping into the ground
            }
        }
    }

}
