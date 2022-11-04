using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    public float timeLeft;
    public float resetTime;
    public GameObject LuzBlanca;
    public GameObject LuzRoja;

    void Start()
    {
        
    }

    void Update()
    {
        Temporizador();
        TurnWhiteLight();
        TurnRedLight();
        
    }

    private void TurnWhiteLight()
    {
        if(timeLeft >= 5f)
        {
            LuzBlanca.SetActive(true);
            LuzRoja.SetActive(false);
        } else 
        {
            LuzBlanca.SetActive(false);
            LuzRoja.SetActive(true);
        }
    }

    private void TurnRedLight()
    {
        if(timeLeft < 5f)
        {
            LuzBlanca.SetActive(false);
            LuzRoja.SetActive(true);
        } else 
        {
            LuzBlanca.SetActive(true);
            LuzRoja.SetActive(false);
        }
    }

    public void Temporizador()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft <= 0)
        {
            timeLeft = resetTime;
        }
    }
}
