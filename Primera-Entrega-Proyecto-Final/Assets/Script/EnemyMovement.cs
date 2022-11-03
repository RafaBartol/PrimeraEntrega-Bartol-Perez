using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 200.0f;
    private Animator anim;
    public float x, y;
    public Transform PlayerPos;

    public enum Behaviour 
    {
        LookAt,
        Follow,
    };

    public Behaviour behaviour;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        switch(behaviour)
        {
            case Behaviour.LookAt:
            LookAtPlayer();
            break;

            case Behaviour.Follow:
            FollowPlayer();
            LookAtPlayer();
            break;

            default:
            break;
        } 
    }

    void FollowPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, PlayerPos.position, movementSpeed * Time.deltaTime);
    }

    void DistanceBetweenPlayer()
    {
        float dist = Vector3.Distance(PlayerPos.position, transform.position);  

        if(dist < 5)
        {
            movementSpeed = 0f;
        } else
        {
            movementSpeed = 5f;
        }
    }

     void LookAtPlayer()
    {
        transform.LookAt(PlayerPos);
    }

}
