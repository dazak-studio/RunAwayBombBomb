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
		_player = Instantiate(_playerPrefab,
			new Vector3((int) (BoardManager.GetInstance.Cols / 2.0f), 
				(int) (BoardManager.GetInstance.Rows / 2.0f), -1.0f) 
			* BoardManager.GetInstance.IntervalScale, Quaternion.identity);
	}

	[SerializeField] private GameObject _playerPrefab;
	private GameObject _player;
}