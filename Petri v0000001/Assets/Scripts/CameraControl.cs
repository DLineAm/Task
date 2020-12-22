using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    #region Variables
    float ZoomAmount = 0;
    float MaxToClamp = 10;
    float ROTSpeed = 10;

    private Vector2 startPos;
    private Camera cam;
    #endregion

    private void Start()
    {
        cam = GetComponent<Camera>();
    }

    private void Update()
    {        
       /* ZoomAmount += Input.GetAxis("Mouse ScrollWheel");
        ZoomAmount = Mathf.Clamp(ZoomAmount, -MaxToClamp, MaxToClamp);
        var translate = Mathf.Min(Mathf.Abs(Input.GetAxis("Mouse ScrollWheel")), MaxToClamp - Mathf.Abs(ZoomAmount));
        if (Camera.main.orthographicSize < 5 && Camera.main.orthographicSize + translate * ROTSpeed * Mathf.Sign(Input.GetAxis("Mouse ScrollWheel")) < Camera.main.orthographicSize
             || (Camera.main.orthographicSize > 17 && Camera.main.orthographicSize + translate * ROTSpeed * Mathf.Sign(Input.GetAxis("Mouse ScrollWheel")) > Camera.main.orthographicSize))
        {
            return;
        }
        Camera.main.orthographicSize += translate * ROTSpeed * Mathf.Sign(Input.GetAxis("Mouse ScrollWheel"));
        if (Camera.main.orthographicSize < 0)
        {
            Camera.main.orthographicSize *= -1;
        }*/
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        else if (Input.GetMouseButton(0))
        {
            float posX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - startPos.x;
            float posY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - startPos.y;
            transform.position = new Vector3(transform.position.x - posX, transform.position.y - posY, transform.position.z);
        }

    }
   
}
