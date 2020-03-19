using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHandler : MonoBehaviour
{

    public GameObject doorHandler;
    public bool drag;


    private Animator anime;

    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            if (drag)
            {

            }
            else
            {

            }




        }
    }



}
