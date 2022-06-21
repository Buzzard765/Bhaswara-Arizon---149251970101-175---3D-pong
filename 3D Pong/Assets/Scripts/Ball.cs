using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
     public Rigidbody rb;
    [SerializeField] float speed, maxSpeed;
    private float returnSpeed;
    public Vector2 balldirection;
    private Core GameManager;
    private FourCannons spawner;
    
    public Collider coll;
    // Start is called before the first frame update
    void Start()
    {
        returnSpeed = speed;
        rb = GetComponent<Rigidbody>();
        coll = GetComponent<Collider>();
        GameManager = FindObjectOfType<Core>();
        spawner = FindObjectOfType<FourCannons>();
        //launch(new Vector3(2,0,2));
        //movement(Vector3.forward);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.hasWinner_Acc == true){
            Destroy(gameObject);
        }
    }

    public void launch(Vector3 LaunchDir){
        speed = returnSpeed;     
        int[] angle = new int[]{2,1,-2,-1};                                
        movement(LaunchDir);

        //return speed;
    }

    void movement(Vector3 direction){
            rb.velocity = direction * speed;
            Debug.Log(speed);
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.name.Contains("Pad") ||
        other.gameObject.name.Contains("Wall")){
            rb.velocity *= 2f;
        }

        if(other.gameObject.CompareTag("OB")){
            returnBall();
        }
        
         //+1 Score to which player    
        /*if(other.gameObject.name.Contains("Goal P1")){
            returnBall();   
        }else if(other.gameObject.name.Contains("Goal P2")){
            returnBall();         
        }else if(other.gameObject.name.Contains("Goal P3")){
            returnBall();     
        }else if(other.gameObject.name.Contains("Goal P4")){
            returnBall();   
        }*/
    }

    public void returnBall(){       
        spawner.shotsAmount_acc++;
        spawner.randomShots();
        Destroy(gameObject);
    }
}
