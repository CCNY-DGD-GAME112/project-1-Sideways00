using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI timerText;
    public float elapsedTime;
    public float threshold;
    private void Start()
    {
        elapsedTime = 0f;
    }

    // Update is called once per frame
    private void Update()
    {
        elapsedTime += Time.deltaTime;
        if(elapsedTime > threshold)
        {
            Debug.Log("Time out!");
        }
    }
}
