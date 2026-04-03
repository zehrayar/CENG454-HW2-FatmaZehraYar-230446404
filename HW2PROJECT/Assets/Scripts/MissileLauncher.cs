using UnityEngine; 
public class MissileLauncher : MonoBehaviour 
{ 
    [SerializeField] private GameObject missilePrefab; 
    [SerializeField] private Transform launchPoint; 
    [SerializeField] private AudioSource launchAudioSource; 
 
    public GameObject activeMissile; 
 
    public GameObject Launch(Transform target) 
    { 
        activeMissile = Instantiate(missilePrefab, launchPoint.position, launchPoint.rotation);
        launchAudioSource?.Play();
        return activeMissile;
    } 
 
    public void DestroyActiveMissile() 
    { 
        if (activeMissile == null) return;
        Destroy(activeMissile);
        activeMissile = null;
    } 
} 
