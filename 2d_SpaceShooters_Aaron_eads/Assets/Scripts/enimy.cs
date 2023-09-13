using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enimy : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] gameManager Manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0,speed,0)*Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.instance.IncreaseScore(10);
        Destroy(gameObject);
        Destroy(collision.gameObject);
    }
}
