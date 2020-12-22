using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using ExitGames.Client.Photon;
using System;
using UnityEngine.UI;

public class GameManager : MonoBehaviourPunCallbacks
{
    [Header("Префаб игрока")]
    public GameObject PlayerPrefab;

    public Text LogText;
    // Start is called before the first frame update
    void Start()
    {
        //Vector3 pos = new Vector3(2,4,0);
        PhotonNetwork.Instantiate(PlayerPrefab.name, new Vector3(0, 0, 0), Quaternion.identity);
        PhotonPeer.RegisterType(typeof(Vector2Int), 235, SeserializeVector2Int, DeserializeVector2Int); //235 - random chislo
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Leave()
    {
        PhotonNetwork.LeaveRoom();
    }

    public override void OnJoinedRoom()
    {
        Log("Zdarova");
    }

    public override void OnLeftRoom() //Когда МЫ покидаем комнату
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public override void OnPlayerEnteredRoom(Photon.Realtime.Player newPlayer)
    {
        
        //Debug.LogFormat();
        Log($"Player {newPlayer.NickName} entered room");
    }
    public override void OnPlayerLeftRoom(Photon.Realtime.Player otherPlayer)
    {
        //Debug.LogFormat($"Player {otherPlayer.NickName} left room");
        Log($"Player {otherPlayer.NickName} left room");
    }


    public static object DeserializeVector2Int(byte[] data)
    {
        Vector2Int result = new Vector2Int();

        result.x = BitConverter.ToInt32(data, 0); //конвертируем массив байтов в инт32(4 байта) х и у для того
        result.y = BitConverter.ToInt32(data, 4); //чтобы не было исключеия

        return result;
    }

    public static byte[] SeserializeVector2Int(object obj)
    {
        Vector2Int vector = (Vector2Int)obj;
        byte[] result = new byte[8]; //8 = x(4 byte) + y(4 byte)

        BitConverter.GetBytes(vector.x).CopyTo(result, 0);
        BitConverter.GetBytes(vector.y).CopyTo(result, 4);

        return result;
    }

    private void Log(string message)
    {
        Debug.Log(message);
        LogText.text += "\n";
        LogText.text += message;
    }
}
