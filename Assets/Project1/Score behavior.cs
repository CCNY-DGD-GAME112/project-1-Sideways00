using UnityEngine;
using TMPro;
public class ScoreBehavior : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static GameManager Instance;
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
    public GameObject Zombie;
    public GameObject Coin;

    
}

