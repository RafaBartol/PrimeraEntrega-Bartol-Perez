using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeRest : MonoBehaviour
{
    private float timer = 180f;
    private float resetTime = 180f;
    public TMP_Text time;

    void Update()
    {
        timer -= Time.deltaTime;
        time.text = "Time Left: " + timer.ToString("f0") + " seg";
 
        if(timer <= 0)
        {
            timer = resetTime;
        }
    }
}
