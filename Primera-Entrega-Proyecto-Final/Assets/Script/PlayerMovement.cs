using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 200.0f;
    private Animator anim;
    public float x, y;
    public int CoinsCollected = 0;
    public GameObject PuertaAbierta;
    public GameObject PuertaCerrada;
    public float timeLeft;
    public float resetTime;
    Vector3 posInicial;

    void Start()
    {
        posInicial = transform.position;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        OpenDoor();
        GameTime();

        x = Input.GetAxis("Horizontal");
        y= Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * movementSpeed);
        // rb.AddForce(transform.forward * y * movementSpeed, ForceMode.Force);

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }

    private void OnTriggerEnter(Collider col) 
    {
        if(col.transform.gameObject.tag == "Coin")
        {
            CoinsCollected++;
            Destroy(col.transform.gameObject);
        }
    }

    void OpenDoor()
    {
        if(CoinsCollected == 22)
        {
            PuertaAbierta.SetActive(true);
            PuertaCerrada.SetActive(false);
        } else 
        {
            PuertaAbierta.SetActive(false);
            PuertaCerrada.SetActive(true);
        }
    }

    void GameTime()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft <= 0)
        {
            Debug.Log("Has Perdido");
            Respawn();
            timeLeft = resetTime;
        }
    }

    void Respawn()
    {
        transform.position = posInicial;
    }

}
