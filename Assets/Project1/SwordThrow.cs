using UnityEngine;

public class SwordThrow : MonoBehaviour
{

    public Rigidbody2D Sword;
    public GameObject Player;
    public int spawnAmount = 1;
    public float throwSpeed = 10;
    
    // Update is called once per frame
    public void throwSword()
    {
       Rigidbody2D projectile = Instantiate(Sword, Player.transform.position, Quaternion.Euler(0, 0, -90));
        projectile.linearVelocity = transform.right * throwSpeed;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            throwSword();
        }
    }
}

