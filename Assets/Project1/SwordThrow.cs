using UnityEngine;

public class SwordThrow : MonoBehaviour
{

    public GameObject Sword;
    public GameObject Player;
    public int spawnAmount = 1;
    // Update is called once per frame
    public void spawnSword()
    {
        Instantiate(Sword, Player.transform.position, Quaternion.identity);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnSword();
        }
    }
}

