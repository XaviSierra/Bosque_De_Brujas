using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
public class CambioEscena : MonoBehaviour
{
    public int NumEscena;
    public UnityEvent evento;
    public void CambiarEscena()

    {
        SceneManager.LoadScene(NumEscena);
        Debug.Log("Papito");
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.X))
        {
            evento.Invoke();
           // SceneManager.LoadScene(NumEscena);
        }
    }
}
