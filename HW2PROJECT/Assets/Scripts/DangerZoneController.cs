
using System.Collections;
using UnityEngine; 
 
public class DangerZoneController : MonoBehaviour 
{ 
    [SerializeField] private FlightExamManager examManager; 
    [SerializeField] private MissileLauncher missileLauncher; 
    [SerializeField] private float missileDelay = 5f;

    private Coroutine activeCountdown;
  
 
    private void OnTriggerEnter(Collider collision) 
    { 
        if (!collision.CompareTag("Player")) return; 
        examManager.EnterDangerZone(); 
        activeCountdown = StartCoroutine(MissileCountdown()); 
    }

    private IEnumerator MissileCountdown()
    {
        float timer = missileDelay;
        examManager.missileActive = false;

        while (timer > 0)
        {
            timer -= Time.deltaTime;
            yield return null;

            if (examManager.threatCleared)
                yield break;
        }

        missileLauncher.Launch(transform);
        examManager.missileActive = true;
    }

    private void OnTriggerExit(Collider collision) 
    { 
        if (!collision.CompareTag("Player")) return;  
        if (activeCountdown != null)
            StopCoroutine(activeCountdown); 
        missileLauncher.DestroyActiveMissile();
        examManager.ExitDangerZone(); 
    } 
} 
 
