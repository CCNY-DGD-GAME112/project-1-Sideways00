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
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0,1,0)* speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1,0,0)* speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0,-1,0)* speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1,0,0)* speed;
        }
    }
}

