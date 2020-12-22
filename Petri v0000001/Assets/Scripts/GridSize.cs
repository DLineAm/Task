using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSize : MonoBehaviour
{
    [Header("Размер допустимой области")]
    public Vector2Int _GridSize = new Vector2Int(10, 10);
    [Header("Смещение")]
    public Vector2Int Offset = new Vector2Int(0, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmosSelected()
    {        
        for (int x = 0 + Offset.x; x < _GridSize.x + Offset.x; x++)
        {
            for (int y = 0 + Offset.y; y < _GridSize.y + Offset.y; y++)
            {
                Gizmos.color = new Color(8f, 1f, 0f, 0.3f);
                Gizmos.DrawCube(transform.position + new Vector3(x, y, 0), new Vector3(1, 1f, 1));
            }
        }
    }
}
