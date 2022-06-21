using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourCannons : MonoBehaviour
{
    [SerializeField]private GameObject Panel;
    public int RemainingPlayer;   
    public BallSpawner[] allSpawner;
    private int shotsAmount = 5;

    //public Action Winner;
    Core GameManager;
    private void OnEnable() {
        GameManager = FindObjectOfType<Core>();
        GameManager.FindWinner += Winner;
    }
    public int shotsAmount_acc{
        get{return shotsAmount;}
        set{shotsAmount = value;}
    }
    public float shotsDelay;
    private float returnShotsDelay;

    private bool HasWinner;
    public bool hasWinner_Acc{
        get{return HasWinner;}
        set{HasWinner = value;}
    }
    // Start is called before the first frame update
    void Start()
    {       
        returnShotsDelay = shotsDelay;
        shotsDelay = 3;
    }

    // Update is called once per frame
    void Update()
    {
        shotsDelay -=Time.deltaTime;
        if(shotsDelay <= 0 && shotsAmount > 0){
            randomShots();
            shotsDelay = returnShotsDelay;
        }
        
    }


    public void randomShots(){
        allSpawner[Random.Range(0,allSpawner.Length)].SpawnBall();
        shotsAmount--;
    }

    public void Winner(){
        Panel.SetActive(true);
    }
   
}
