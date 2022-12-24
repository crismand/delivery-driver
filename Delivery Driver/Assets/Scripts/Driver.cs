using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Driver : MonoBehaviour
{
    [FormerlySerializedAs("speed")] [SerializeField]
    private float moveSpeed;
    
    [FormerlySerializedAs("rotateSpeed")] [SerializeField]
    private float steerSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputForward = Input.GetAxis("Vertical");
        float inputSteer = Input.GetAxis("Horizontal");
        
        transform.Translate(0, moveSpeed * inputForward * Time.deltaTime, 0);
        transform.Rotate(0.0f, 0.0f, -steerSpeed * inputSteer * Time.deltaTime);
    }
}
