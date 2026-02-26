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
}

