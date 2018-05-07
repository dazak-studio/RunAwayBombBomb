using System.Collections.Generic;
using UnityEngine;

public class BoardManager : Singleton<BoardManager> {
    
    public void Initialize()
    {
        _tileGroup = new List<Transform>();
        
        // Allocate the tiles on the stage board in 3 by 3.
        for (var row = 0; row < 3; ++row)
        {
            for (var col = 0; col < 3; ++col)
            {
                // TODO: Managed with Object Pool.
                var getLastInstantiatedObject = Instantiate(_tilePrefab[(row + col) % 2]);
                getLastInstantiatedObject.name = "Tile (" + col + ", " + row + ")";
                getLastInstantiatedObject.transform.position = new Vector3(col, row) * 3;
                getLastInstantiatedObject.transform.parent = transform;
                //getLastInstantiatedObject.SetActive(false);                
                _tileGroup.Add(getLastInstantiatedObject.transform);
                
            }
        }
    }

    [SerializeField] private GameObject[] _tilePrefab;
    private List<Transform> _tileGroup = null;
}
