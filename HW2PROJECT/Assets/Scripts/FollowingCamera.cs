using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    public Transform target; 
        public Vector3 offset = new Vector3(0, 5, -10);
    
        void LateUpdate()
        {
            transform.position = target.position + target.TransformDirection(offset);
            transform.LookAt(target);
        }
}
