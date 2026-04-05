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
        if (!currentTarget)
        {
            return;
        }

       
        Vector3 targetDirection = currentTarget.position - transform.position;

       
        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);

        
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

       
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));
    }
}
