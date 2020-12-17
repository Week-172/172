using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirborneSpawnScript : MonoBehaviour
{
    
    [SerializeField]
    Transform FirstPoint;
    [SerializeField]
    Transform LastPoint;
    public Rigidbody2D[] AirEnemies;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int enemyno= Random.Range(0,AirEnemies.Length);
        float randomSpawnPoint= Random.Range(LastPoint.position.y,FirstPoint.position.y);
        Rigidbody2D Enemy;
        Enemy=Instantiate(AirEnemies[enemyno],new Vector3(FirstPoint.position.x,randomSpawnPoint,FirstPoint.position.z),transform.rotation);
    }
}
