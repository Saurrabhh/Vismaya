using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dooranim : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator dooranimator;
    void Awake()
    {
        dooranimator = GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        dooranimator.SetTrigger("opendoor");
    }
}
