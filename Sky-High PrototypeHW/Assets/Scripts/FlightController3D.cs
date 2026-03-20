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
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    } 
 
    void Update()// or FixedUpdate() 
    { 
        HandleRotation(); 
        HandleThrust(); 
    } 
 
    private void HandleRotation() 
    { 
        float upDown = Input.GetAxis("Vertical");    
        float leftRight = Input.GetAxis("Horizontal"); 
        float spin = 0f;

        
        if (Input.GetKey(KeyCode.Q)) spin = 1f;
        if (Input.GetKey(KeyCode.E)) spin = -1f;

        
        transform.Rotate(Vector3.right * upDown * pitchSpeed * Time.deltaTime); 
        transform.Rotate(Vector3.up    * leftRight * yawSpeed * Time.deltaTime); 
        transform.Rotate(Vector3.forward * spin * rollSpeed * Time.deltaTime); 
    } 
 
    private void HandleThrust() 
    { 
        // TODO (Task 3-D): 
    } 
} 

