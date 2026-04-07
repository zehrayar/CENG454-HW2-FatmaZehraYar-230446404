using UnityEngine;

public class MissileHoming : MonoBehaviour
{
    [SerializeField] private float speed = 25f;
    [SerializeField] private float rotationSpeed = 4f;

    public Transform currentTarget;

    public void SetTarget(Transform targetTransform)
    {
        currentTarget = targetTransform;
    }

    private void Update()
    {
       
        if (!currentTarget) return;

       
        Vector3 direction = (currentTarget.position - transform.position).normalized;

     
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

       
        transform.position += transform.forward * (speed * Time.deltaTime);
    }

 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("MISSILE HIT!");
            Destroy(gameObject);
        }
    }
}