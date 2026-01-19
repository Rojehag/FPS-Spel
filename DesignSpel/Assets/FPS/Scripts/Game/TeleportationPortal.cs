using System.Collections.Generic;
using UnityEngine;

public class TeleportationPortal : MonoBehaviour
{
    [SerializeField] GameObject teleportLocation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (teleportLocation == null)
        {
            Debug.LogWarning("TeleportationPortal: Teleport location is not set.");
            return;
        }
        if (other.gameObject.CompareTag("Player"))
        {
            
            Vector3 targetPosition = teleportLocation.transform.position;
            other.gameObject.transform.position = targetPosition + new Vector3(0, 1, 0); // Offset to avoid clipping into the ground
        }
    }
}
