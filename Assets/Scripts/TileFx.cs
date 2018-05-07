using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileFx : MonoBehaviour
{
	public void Play()
	{
		if (_boomFx == null)
		{
			var getLastInstantiatedObject = Instantiate(_boomFxPrefab, transform);
			getLastInstantiatedObject.transform.parent = transform;
			_boomFx = getLastInstantiatedObject.GetComponent<ParticleSystem>();
		}
		else
		{
			if (_boomFx.isPlaying)
			{
				_boomFx.Stop();
				_boomFx.Clear();				
			}
			
			_boomFx.transform.position = transform.position;
		}		
		_boomFx.Play();
	}
	
	[SerializeField] private GameObject _boomFxPrefab;
	private ParticleSystem _boomFx;
}
