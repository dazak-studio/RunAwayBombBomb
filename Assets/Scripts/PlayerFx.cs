using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFx : MonoBehaviour {
	
	private void Awake()
	{		
		_emotionFxGroup = new ParticleSystem[_emotionFxPrefabGroup.Length];
		_castFxGroup = new ParticleSystem[_castFxPrefabGroup.Length];		
	}

	private void Start()
	{
		OnCreate();
	}

	private void OnCreate()
	{
		PlayCast(Cast.Confetti);
	}

	public void PlayEmotion(Emotion emotion)
	{
		var emotionCode = (int) emotion;
		
		if (_emotionFxGroup[emotionCode] == null)
		{
			var getLastInstantiatedObject = Instantiate(_emotionFxPrefabGroup[emotionCode], transform);
			getLastInstantiatedObject.transform.parent = transform;
			_emotionFxGroup[emotionCode] = getLastInstantiatedObject.GetComponent<ParticleSystem>();
		}
		else
		{
			if (_emotionFxGroup[emotionCode].isPlaying)
			{
				_emotionFxGroup[emotionCode].Stop();
				_emotionFxGroup[emotionCode].Clear();				
			}

			_emotionFxGroup[emotionCode].transform.position = transform.position;			
		}		
		_emotionFxGroup[emotionCode].Play();
	}
	
	public void PlayCast(Cast cast)
	{
		var castCode = (int) cast;
		
		if (_castFxGroup[castCode] == null)
		{
			var getLastInstantiatedObject = Instantiate(_castFxPrefabGroup[castCode], transform);
			getLastInstantiatedObject.transform.parent = transform;
			_castFxGroup[castCode] = getLastInstantiatedObject.GetComponent<ParticleSystem>();
		}
		else
		{
			if (_castFxGroup[castCode].isPlaying)
			{
				_castFxGroup[castCode].Stop();
				_castFxGroup[castCode].Clear();				
			}

			_castFxGroup[castCode].transform.position = transform.position;			
		}		
		_castFxGroup[castCode].Play();
	}
	
	public enum Emotion
	{
		Angry,
		Cool,
		Cry, 
		Disappointed, 
		Drool, 
		Happy, 
		Kiss, 
		Sad, 
		Shocked, 
		Sick, 
		Silly, 
		Smile
	}

	public enum Cast
	{
		Confetti,		
	}

	[SerializeField] private GameObject[] _castFxPrefabGroup;
	[SerializeField] private GameObject[] _emotionFxPrefabGroup;
	private ParticleSystem[] _emotionFxGroup;
	private ParticleSystem[] _castFxGroup;
}
