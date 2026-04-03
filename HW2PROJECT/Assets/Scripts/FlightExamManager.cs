using UnityEngine; 
using TMPro; 
 
public class FlightExamManager : MonoBehaviour 
{ 
    [SerializeField] private TMP_Text statusText; 
    [SerializeField] private TMP_Text missionText; 
 
    public bool hasTakenOff;
    public bool threatCleared; 
    public bool missionComplete;
    public bool missileActive;

    public void EnterDangerZone() 
    { 
        threatCleared = false;
        missionText.text = "Threat detected!";
        statusText.text = "DANGER";
    } 
 
    public void ExitDangerZone() 
    { 
        threatCleared = true;
        missionText.text = "Threat cleared.";
        statusText.text = "SAFE";
    } 
}