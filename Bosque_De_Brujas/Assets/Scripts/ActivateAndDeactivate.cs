using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivateAndDeactivate : MonoBehaviour
{
    public GameObject interaction;

    public bool PuedeCambiar;

    public void OnTriggerStay(Collider other)
    {
        PuedeCambiar = true;
        interaction.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        PuedeCambiar = false;
        interaction.SetActive(false);
    }

}

