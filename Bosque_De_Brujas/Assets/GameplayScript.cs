using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayScript : MonoBehaviour
{
    public static int hints;
    public static int hintsFound;
    public static int worldsVisited;

    // public GameObject Salida;
    public GameObject TiervoGO;

    public static bool Zorraguila;
    public static bool Patrilote;
    public static bool Elefzal;
    public static bool Pinguoso;
    public static bool Zocosa;
    public static bool Torpiena;
    public static bool Tortiguana;
    public static bool Tiervo;

    // Start is called before the first frame update
    void Start()
    {

        
        Scene currenScene = SceneManager.GetActiveScene();
        string sceneName = currenScene.name;

        if (sceneName == "01_Santuario")
        {
            TiervoGO = GameObject.Find("Pedestal_Tiervo");
            TiervoGO.GetComponent<CapsuleCollider>().enabled = false;
        }
            if (sceneName == "02_Zorraguila")
        {
            Zorraguila = true;
            worldsVisited++;
            Debug.Log("AumentoWorld");
        }
        else if (sceneName == "03_Patrilote")
        {
            Patrilote = true;
            worldsVisited++;
        }
        else if (sceneName == "04_Elefzal")
        {
            Elefzal = true;
            worldsVisited++;
        }
        else if (sceneName == "05_Pinguoso")
        {
            Pinguoso = true;
            worldsVisited++;
        }
        else if (sceneName == "06_Zocosa")
        {
            Zocosa = true;
            worldsVisited++;
        }
        else if (sceneName == "07_Torpiena")
        {
            Torpiena = true;
            worldsVisited++;
        }
        else if (sceneName == "08_Tortiguana")
        {
            Tortiguana = true;
            worldsVisited++;
        }

        hintsFound = 0;
     //   Salida = GameObject.FindGameObjectWithTag("Salida");
       // Salida.SetActive(false);
    }

    
    // Update is called once per frame
    void Update()
    {
        if (Zorraguila)
        {
            Debug.Log("BeenTOZorraguila");
        }
        if (Patrilote)
        {

        }
        if (Elefzal)
        {

        }
        if (Pinguoso)
        {

        }
        if (Zocosa)
        {

        }

        Debug.Log("WorldsVisited" + worldsVisited);
        if (hintsFound == hints)
        {
            //Salida.SetActive(true);
        }
        Scene currenScene = SceneManager.GetActiveScene();
        string sceneName = currenScene.name;
        if (sceneName == "01_Santuario")
        {
            if (worldsVisited >= 7)
        {
            TiervoGO = GameObject.Find("Pedestal_Tiervo");
            TiervoGO.GetComponent<CapsuleCollider>().enabled = true;
        }
        }
            
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pista" && Input.GetKeyDown(KeyCode.X))
        {
            hintsFound++;
            Destroy(other.gameObject);
        }

        
    }


}
