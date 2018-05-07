using System.Collections.Generic;
using UnityEngine;

public class BoardManager : Singleton<BoardManager> {
    
    public void Initialize()
    {
        _tileGroup = new List<Transform>();
        Rows = 3;
        Cols = 3;
        
        // Allocate the tiles on the stage board in 3 by 3.
        for (var row = 0; row < Rows; ++row)
        {
            for (var col = 0; col < Cols; ++col)
            {
                // TODO: Managed with Object Pool.
                var prefabObject = _tilePrefab[(row + col) % 2];
                var prefabScale = prefabObject.transform.localScale.x;
                var getLastInstantiatedObject = Instantiate(prefabObject);
                getLastInstantiatedObject.name = "Tile (" + col + ", " + row + ")";
                getLastInstantiatedObject.transform.position = new Vector3(col, row) * prefabScale;
                getLastInstantiatedObject.transform.parent = transform;                
                _tileGroup.Add(getLastInstantiatedObject.transform);                
            }
        }                
    }        

    [SerializeField] private GameObject[] _tilePrefab;
    private List<Transform> _tileGroup = null;
    public int Rows { get; private set; }
    public int Cols { get; private set; }
}
