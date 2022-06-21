using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] GameObject Ball;
    Transform point;
    // Start is called before the first frame update
    void Start()
    {
        point = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnBall(){
        //Instantiate(Ball, transform.position, transform.rotation);
        var ball =  Instantiate(Ball, transform.position, transform.rotation);
        ball.GetComponent<Rigidbody>().velocity = transform.forward * 10;
    }
}
