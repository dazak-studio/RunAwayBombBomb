using UnityEngine;

public class GameManager : MonoBehaviour {
		
	private void Awake()
	{
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		Screen.SetResolution(1280, 720, true);		
	}		
}