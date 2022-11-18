using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject PuertaAbierta;
    public GameObject PuertaCerrada;

    void Start()
    {
        
    }

    void Update()
    {
        openDoor();
    }

    void openDoor()
    {
        if(Score.CoinsCollected == 22)
        {
            PuertaAbierta.SetActive(true);
            PuertaCerrada.SetActive(false);
        } else 
        {
            PuertaAbierta.SetActive(false);
            PuertaCerrada.SetActive(true);
        }
    }
}
