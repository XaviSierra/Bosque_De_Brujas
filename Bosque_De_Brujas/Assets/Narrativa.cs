using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narrativa : MonoBehaviour
{
    public GameObject narrativa;
    public bool canActive = false;

    private void OnTriggerEnter(Collider other)
    {
       
    }

    private void OnTriggerStay(Collider other)
    {
        if (!canActive)
        {
            if (other.tag == "Player" && Input.GetKey(KeyCode.X))
            {
                narrativa.SetActive(true);
                canActive = true;
                Debug.Log("ActivoNarrativa");
            }
        }
        

        if (narrativa.activeSelf)
        {
            if (other.tag == "Player" && narrativa.activeSelf)
            {
                if (Input.GetKey(KeyCode.X))
                {
                    Invoke("DesactivarNarrativa", 20);
                }
                
            }
        }

    }
    private void DesactivarNarrativa()
    {
        if (narrativa.activeSelf)
        {
            narrativa.SetActive(false);
            Debug.Log("desactivoNarrativa");
        }
    }
}
