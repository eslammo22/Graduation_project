using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public float TimeOfDeath = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Die", TimeOfDeath);
    }

   
    void Die()
    {
        Destroy(gameObject);
    }


}
