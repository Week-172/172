using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirborneSpawnScript : MonoBehaviour
{
    float timer;
    
    //[SerializeField]
    //ScoreCode ScoreCode;
    [SerializeField]
    Transform FirstPoint;
    [SerializeField]
    Transform LastPoint;
    [SerializeField]
    Rigidbody2D MC;
    public GameObject[] AirEnemies;
    public float SpawnCooldown; 
    public int IncreaseEnemyType;

    void Start()
    {
        IncreaseEnemyType=0;
        timer=0;
    }

    void Update()
    {
        timer+=Time.deltaTime;
        if(MC.isKinematic&&CanSpawn())
        StartSpawning();
        //if(ScoreCode.Score.text=="2000")
        //IncreaseEnemyType=1;
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
        int enemyno= Random.Range(0,IncreaseEnemyType);
        float randomSpawnPoint= Random.Range(LastPoint.position.y,FirstPoint.position.y);
        Instantiate(AirEnemies[enemyno],new Vector3(FirstPoint.position.x,randomSpawnPoint,-0.5f),transform.rotation);
    }
}