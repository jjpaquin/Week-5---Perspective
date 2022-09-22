using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator10 : MonoBehaviour
{
    // Added serializefield
    [SerializeField] GameObject objectToActivate;
    [SerializeField] GameObject otherObjectToActivate;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Corrected name of script being enabled
    private void OnTriggerEnter(Collider other)
    {
        objectToActivate.GetComponent<MoveObject10>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject10>().enabled = true;
    }
    private void OnTriggerExit(Collider other)
    {
        objectToActivate.GetComponent<MoveObject10>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject10>().enabled = true;
    }
}
