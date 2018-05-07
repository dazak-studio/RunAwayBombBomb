using UnityEngine;

public class GameManager : Singleton<GameManager> {

	private void Awake()
	{
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		Screen.SetResolution(1280, 720, true);
	}

	private void Start()
	{
		Initialize();	
	}

	private void Initialize()
	{
		BoardManager.GetInstance.Initialize();
				
	}		
}