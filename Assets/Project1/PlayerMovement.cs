using UnityEngine;

public class PLayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public float speed = 0.0001f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0,1,0)* speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1,0,0)* speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0,-1,0)* speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1,0,0)* speed;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        SwordBehavior Zombie = other.gameObject.GetComponent<SwordBehavior>();

        if (Zombie != null)
        {
            GameManager.Instance.AddScore(5);
        }
        CoinBehavior coin = other.gameObject.GetComponent<CoinBehavior>();
        if (coin != null)
        {
            GameManager.Instance.AddScore(1);
        }

    }
}

