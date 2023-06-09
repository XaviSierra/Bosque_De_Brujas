using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{

    void update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyUp(KeyCode.X))
        {
            Destroy(gameObject);

        }
    }
}