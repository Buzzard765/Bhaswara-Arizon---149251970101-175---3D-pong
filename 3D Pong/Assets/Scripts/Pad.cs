using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb2d;
    [SerializeField] Vector3 BoundaryMax, BoundaryMin;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.name.Contains("P1")){
            movement1();
        }else if(gameObject.name.Contains("P2")){
            movement2();
        }else if(gameObject.name.Contains("P3")){
            movement3();
        }else if(gameObject.name.Contains("P4")){
            movement4();
        }

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, BoundaryMin.x, BoundaryMax.x),
            Mathf.Clamp(transform.position.y, BoundaryMin.y, BoundaryMax.y),
            Mathf.Clamp(transform.position.z, BoundaryMin.z, BoundaryMax.z)
        );
    }

    void movement1(){
        if(Input.GetKey(KeyCode.A)){
            transform.position += transform.forward * Time.deltaTime * speed;
        }
        if(Input.GetKey(KeyCode.D)){
            transform.position -= transform.forward * Time.deltaTime * speed;
        }
    }

    void movement2(){
         if(Input.GetKey(KeyCode.I)){
            transform.position += transform.right * Time.deltaTime * speed;
        }
        if(Input.GetKey(KeyCode.K)){
            transform.position -= transform.right * Time.deltaTime * speed;
        }
    }

    void movement3(){
        if(Input.GetKey(KeyCode.Keypad4)){
            transform.position += transform.forward * Time.deltaTime * speed;
        }
        if(Input.GetKey(KeyCode.Keypad6)){
            transform.position -= transform.forward * Time.deltaTime * speed;
        }
        
    }
    void movement4(){
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.position += transform.right * Time.deltaTime * speed;
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.position -= transform.right * Time.deltaTime * speed;
        }
    }
}
