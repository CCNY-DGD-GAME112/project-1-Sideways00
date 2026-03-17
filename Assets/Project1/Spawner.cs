using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject Zombie;
    public GameObject Coin;
    public float Radius = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        SpawnZombieRandom();
        SpawnCoinRandom();
    }
    void SpawnZombieRandom()
    {
        Vector2 randomPos = randomPos.insideUnitCircle * Radius;
        Instantiate(Zombie,randomPos,Quuaternion.ideentity);
    }
    void SpawnCoinRandom()
    {
        Vector2 randomPos = randomPos.insideUnitCircle * Radius;
        Instantiate(Coin,randomPos,Quaternion.ideentity);
    }
}
