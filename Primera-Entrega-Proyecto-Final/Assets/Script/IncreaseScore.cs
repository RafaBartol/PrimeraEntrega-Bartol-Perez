using UnityEngine;

public class IncreaseScore : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

     private void OnTriggerEnter(Collider col)
    {
        if(col.transform.gameObject.tag == "Coin")
        {
            Score.CoinsCollected++;
            Destroy(col.transform.gameObject);
        }
    }
}
