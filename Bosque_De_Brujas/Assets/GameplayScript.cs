using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayScript : MonoBehaviour
{
    
    public static int worldsVisited;
    public Animator anim;
    
    public GameObject TiervoGO;

    public static bool Zorraguila;
    public GameObject luzZorroaguila1;
    public GameObject luzZorroaguila2;
    public static bool Patrilote;
    public GameObject luzPatrilote1;
    public GameObject luzPatrilote2;
    public static bool Elefzal;
    public GameObject luzElefzal1;
    public GameObject luzElefzal2;
    public static bool Pinguoso;
    public GameObject luzPinguoso1;
    public GameObject luzPinguoso2;
    public static bool Zocosa;
    public GameObject luzZocosa1;
    public GameObject luzZocosa2;
    public static bool Torpiena;
    public GameObject luzTorpiena1;
    public GameObject luzTorpiena2;
    public static bool Tortiguana;
    public GameObject luzTortiguana1;
    public GameObject luzTortiguana2;
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

       
     
    }

    
    // Update is called once per frame
    void Update()
    {

        Estatuas();
        Debug.Log("WorldsVisited" + worldsVisited);
       
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
        if (other.tag == "Anim" && worldsVisited >= 7)
        {
            anim.SetTrigger("Entrance");
            anim.SetBool("Entrada",true);
        }

        
    }

    public void Estatuas()
    {
        if (Zorraguila)
        {
            luzZorroaguila1.SetActive(true);
            luzZorroaguila2.SetActive(true);
            Debug.Log("BeenTOZorraguila");
        }
        else
        {
            luzZorroaguila1.SetActive(false);
            luzZorroaguila2.SetActive(false);
        }
        if (Patrilote)
        {
            luzPatrilote1.SetActive(true);
            luzPatrilote2.SetActive(true);
        }
        else
        {
            luzPatrilote1.SetActive(false);
            luzPatrilote2.SetActive(false);
        }
        if (Elefzal)
        {
            luzElefzal1.SetActive(true);
            luzElefzal2.SetActive(true);
        }
        else
        {
            luzElefzal1.SetActive(false);
            luzElefzal2.SetActive(false);
        }
        if (Pinguoso)
        {
            luzPinguoso1.SetActive(true);
            luzPinguoso2.SetActive(true);
        }
        else
        {
            luzPinguoso1.SetActive(false);
            luzPinguoso2.SetActive(false);
        }
        if (Zocosa)
        {
            luzZocosa1.SetActive(true);
            luzZocosa2.SetActive(true);
        }
        else
        {
            luzZocosa1.SetActive(false);
            luzZocosa2.SetActive(false);
        }
        if (Torpiena)
        {
            luzTorpiena1.SetActive(true);
            luzTorpiena2.SetActive(true);
        }
        else
        {
            luzTorpiena1.SetActive(false);
            luzTorpiena2.SetActive(false);
        }
        if (Tortiguana)
        {
            luzTortiguana1.SetActive(true);
            luzTortiguana2.SetActive(true);
        }
        else
        {
            luzTortiguana1.SetActive(false);
            luzTortiguana2.SetActive(false);
        }
    }
}
