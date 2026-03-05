using UnityEngine;

public class CoinBehavior : MonoBehaviour
{
    public GameObject Coin;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.Instance.AddScore(3);
            Destroy(Coin); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
