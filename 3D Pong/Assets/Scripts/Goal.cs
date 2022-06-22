using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField]private Pad PlayerPad;
    MeshRenderer Wall;
    private int Score = 0;
    public int score_Acc{
        get{return Score;}
        set{Score = value;}
    }
    // Start is called before the first frame update
    void Start()
    {
        Wall = GetComponent<MeshRenderer>();
        Wall.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Score>=15){
           PlayerPad.gameObject.SetActive(false);
            Wall.enabled = true;
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.name.Contains("Ball")){
            if(Score <15){
                Ball returnball = other.gameObject.GetComponent<Ball>();
                returnball.returnBall();
                Score++;
            }else if (Score >=15){
                Score = 15;
                Debug.Log(PlayerPad.gameObject.name + "is Out!");                               
            }
        }
    }

    private void stopPlaying(){
        //FindObjectOfType<Core>().RemainingPlayer--;
           
    }
}
