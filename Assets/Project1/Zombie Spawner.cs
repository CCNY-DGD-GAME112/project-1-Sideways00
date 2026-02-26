using UnityEngine;
using System.Collections.Generic;
public class ZombieSpawner : MonoBehaviour
{
    public List<GameObject> Zombie = new List<GameObject>();
    public GameObject Spawner;
    public int spawnAmount = 0;
    public float spawnTime = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SpawZombie()
    {
        Instantiate(Zombie[0]);
    }
    void Update()
    {
        if
    }
}




    