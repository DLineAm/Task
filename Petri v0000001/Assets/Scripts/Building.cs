using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Building : MonoBehaviour
{   
    private SpriteRenderer MainRenderer;
    public Vector2Int Size = Vector2Int.one;

    private void Awake()
    {
        MainRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void OnDrawGizmosSelected()
    {
        for (int x = 0; x < Size.x; x++)
        {
            for (int y = 0; y < Size.y; y++)
            {
                Gizmos.color = new Color(8f, 1f, 0f, 0.3f);
                Gizmos.DrawCube(transform.position + new Vector3(x, 0, y), new Vector3(1, 1f, 1));
            }
        }
    }

    public void SetNormal()
    {
        MainRenderer.material.color = Color.white;
    }

    public void SetTransperent(bool available)
    {
        if (available)
        {
            MainRenderer.material.color = Color.green;
        }
        else
        {
            MainRenderer.material.color = Color.red;
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("Zdarova");
    }

}
