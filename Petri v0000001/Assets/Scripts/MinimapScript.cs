using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapScript : MonoBehaviour
{

    public Transform player;

    // Update is called once per frame
    void LateUpdate() // LastUpdate = обновление после обновления скрипта привязанного объекта
    {
        UpdateCamPosition();
    }

    void UpdateCamPosition()
    {
        Vector3 position = player.position;

        //position.x = transform.position.x;

        transform.position = position;
    }
}
