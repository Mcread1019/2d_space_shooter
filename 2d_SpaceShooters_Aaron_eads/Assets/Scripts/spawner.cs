using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] float spawnrate = 2f;
    [SerializeField] GameObject enemyPrefab;

    float Xmin;
    float Xmax;
    float YSpawn;

    // Start is called before the first frame update
    void Start()
    {
        Xmin = Camera.main.ViewportToWorldPoint(new Vector3(.1F,0,0)).x;
        Xmax = Camera.main.ViewportToWorldPoint(new Vector3(.9F,0,0)).x;
        YSpawn = Camera.main.ViewportToWorldPoint(new Vector3(9,1.25f,0)).y;


        InvokeRepeating("spawnEnemy",0,spawnrate); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnEnemy()
    {
        float randX = Random.Range(Xmin, Xmax);
        Instantiate(enemyPrefab,new Vector3(randX,YSpawn,0),Quaternion.identity);
    }
}
