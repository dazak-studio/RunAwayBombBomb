using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFx : MonoBehaviour {

	private void OnCreate()
	{
		
	}
	
	[SerializeField] private GameObject[] _emotionFxPrefabGroup;
	private List<ParticleSystem> _emotionFxGroup;
}
