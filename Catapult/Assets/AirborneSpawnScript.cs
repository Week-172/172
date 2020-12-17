using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirborneSpawnScript : MonoBehaviour
{
    float timer;
    
    [SerializeField]
    Transform FirstPoint;
    [SerializeField]
    Transform LastPoint;
    [SerializeField]
    Rigidbody2D MC;
    public Rigidbody2D[] AirEnemies;
    public float SpawnCooldown; 

    // Start is called before the first frame update
    void Start()
    {
        timer=0;
    }

    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        if(MC.isKinematic&&CanSpawn())
            StartSpawning();
    }
    
    bool CanSpawn()
    {
        if(timer>SpawnCooldown)
        {
            timer=0;
            return true;
        }
        else return false;
    }

    void StartSpawning()
    {
        int enemyno= Random.Range(0,AirEnemies.Length);
        float randomSpawnPoint= Random.Range(LastPoint.position.y,FirstPoint.position.y);
        Rigidbody2D Enemy;
        Enemy=Instantiate(AirEnemies[enemyno],new Vector3(FirstPoint.position.x,randomSpawnPoint,-0.5f),transform.rotation);
        Enemy.velocity=new Vector2(25f,0f);
    }
}
