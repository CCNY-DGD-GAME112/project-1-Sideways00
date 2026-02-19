using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class SwordBehavior : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        { // Checking if colliding with enemy
            Destroy(collision.gameObject); // Destorying enemy if its an enemy
        }
    }
    public GameObject Sword;
    public void Update()
    {
        Sword.transform.position = new Vector3(1, 0,0);
    }
}
