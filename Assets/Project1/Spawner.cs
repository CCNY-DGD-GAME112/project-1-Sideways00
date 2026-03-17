using UnityEngine;


public class Spawner : MonoBehaviour
{
    public GameObject Zombie;
    public float timeToSpawn;
    public float spawnCountdown;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnCountdown = timeToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        spawnCountdown -= Time.deltaTime;
        if (spawnCountdown <= 0)
        {
            spawnCountdown = timeToSpawn;
            Instantiate(Zombie, transform.position, transform.rotation);
        }

    }

}

