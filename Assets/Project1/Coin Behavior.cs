using UnityEngine;

public class CoinBehavior : MonoBehaviour
{
    public GameObject Coin;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        { // Checking if colliding with enemy
            Destroy(Coin); // Destorying enemy if its an enemy
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
