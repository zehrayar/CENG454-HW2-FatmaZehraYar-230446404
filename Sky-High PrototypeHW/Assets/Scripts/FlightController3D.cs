using UnityEngine; 
 
public class FlightController : MonoBehaviour 
{ 
    [SerializeField] private float pitchSpeed  = 45f;  // degrees/second 
    [SerializeField] private float yawSpeed    = 45f;  // degrees/second 
    [SerializeField] private float rollSpeed   = 45f;  // degrees/second 
    [SerializeField] private float thrustSpeed = 5f;   // units/second 
 
    private Rigidbody rb; 
 
    void Start() 
    { 
        // TODO (Task 3-B): Cache GetComponent<Rigidbody>() into 'rb'. 
        //                  Then set rb.freezeRotation = true. 
        //                  Why is freezeRotation needed? Answer in your PDF. 
    } 
 
    void Update()// or FixedUpdate() 
    { 
        HandleRotation(); 
        HandleThrust(); 
    } 
 
    private void HandleRotation() 
    { 
        // TODO (Task 3-C): 
        // Pitch   
        // Roll    
 
    } 
 
    private void HandleThrust() 
    { 
        // TODO (Task 3-D): 
    } 
} 

