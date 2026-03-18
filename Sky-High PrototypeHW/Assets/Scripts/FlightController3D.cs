using UnityEngine;

public class FlightController3D : MonoBehaviour
{
    public float rotationSpeed = 45f; 
    public float moveSpeed = 5f;      
    private Rigidbody planeRb;

    void Start()
    {
        planeRb = GetComponent<Rigidbody>();
        planeRb.freezeRotation = true; 
    }

    void Update()
    {
        HandleRotation();
        HandleForward();
    }

    private void HandleRotation()
    {
        float upDown = 0f;    
        float leftRight = 0f; 
        float roll = 0f;     

        // UP and DOWN
        if (Input.GetKey(KeyCode.UpArrow))
            upDown = rotationSpeed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.DownArrow))
            upDown = -rotationSpeed * Time.deltaTime;

        // RIGHT and LEFT
        if (Input.GetKey(KeyCode.RightArrow))
            leftRight = rotationSpeed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.LeftArrow))
            leftRight = -rotationSpeed * Time.deltaTime;

        // ROLL
        if (Input.GetKey(KeyCode.Q))
            roll = rotationSpeed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.E))
            roll = -rotationSpeed * Time.deltaTime;

       
        transform.Rotate(upDown, leftRight, roll, Space.Self);
    }

    private void HandleForward()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 forwardMove = transform.forward * moveSpeed * Time.deltaTime;
            planeRb.MovePosition(planeRb.position + forwardMove);
        }
    }
}

