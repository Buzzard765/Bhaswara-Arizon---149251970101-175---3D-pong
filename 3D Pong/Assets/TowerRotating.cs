using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerRotating : MonoBehaviour
{
    public float radius;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.rotateY(gameObject, radius, 2).setLoopPingPong();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
