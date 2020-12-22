using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingsGrid : MonoBehaviour
{
    //[Header("Размер допустимой области")]
    //public Vector2Int GridSize = new Vector2Int(10, 10);
    //[Header("Смещение")]
    //public Vector2Int Offset = new Vector2Int(0, 0);

    private List<GameObject> GridBuilderPlatforms = new List<GameObject>();
    private GameObject towerPrefab;

    public static bool IsAliveFlyingBuilding = false;
    //private GameObject[] gridBuilderPlatforms;
    //public Plane plane;


    //public Building[,] grid;
    private Building flyingBuilding;
    private Camera mainCamera;

    private void Awake()
    {
        //grid = new Building[GridSize.x, GridSize.y];
        mainCamera = Camera.main;
        //plane = GetComponent<Plane>();
    }
    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            GridBuilderPlatforms.Add(transform.GetChild(i).gameObject); //получение всех дочерних объектов (зон постройки башни)
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (flyingBuilding != null)
        {
            IsAliveFlyingBuilding = true;
            StartTracingBuilding();
        }
        else
        {
            IsAliveFlyingBuilding = false;
        }

        //Debug.Log(IsAliveFlyingBuilding);
    }

    private bool IsAviable(List<GameObject> gridList, int mouseX, int mouseY, Vector3 worldPosition)
    {
        bool available = false;

        foreach (var build in gridList)
        {
            var gridSize = build.GetComponent<GridSize>();
            if (!(mouseX < build.transform.position.x + gridSize.Offset.x
                || mouseX > build.transform.position.x + gridSize._GridSize.x + gridSize.Offset.x - flyingBuilding.Size.x)
                && !(mouseY < build.transform.position.y + gridSize.Offset.y
                || mouseY > build.transform.position.y + gridSize._GridSize.y + gridSize.Offset.y - flyingBuilding.Size.y))
            {
                available = true;
                break;
            }
           
        }
        return available;
    }

    private void StartTracingBuilding()
    {
        var groupPlane = new Plane(Vector3.forward, Vector3.zero);
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        if (groupPlane.Raycast(ray, out float position))
        {
            Vector3 worldPosition = ray.GetPoint(position);

            int x = Mathf.RoundToInt(worldPosition.x);
            int y = Mathf.RoundToInt(worldPosition.y);

            bool available = IsAviable(GridBuilderPlatforms, x, y, worldPosition);

            flyingBuilding.transform.position = new Vector3(x, y, 0);
            flyingBuilding.SetTransperent(available);

            if (available && Input.GetMouseButtonDown(0))
            {
                //var buildingPrefab = towerPrefab.GetComponent<Building>();
                PhotonNetwork.Instantiate(towerPrefab.name, new Vector3(x, y, 0), Quaternion.identity);
                flyingBuilding.SetNormal();
                Destroy(flyingBuilding.gameObject);
            }
        }
    }

    public void StartPlacingBuilding(GameObject buildingPrefab)
    {
        if (flyingBuilding != null)
        {
            Destroy(flyingBuilding.gameObject);
        }

        towerPrefab = buildingPrefab;
        flyingBuilding = Instantiate(buildingPrefab.GetComponent<Building>());//PhotonNetwork.Instantiate(buildingPrefab.name, worldposition.GetPoint(), Quaternion.identity);
    }
}
