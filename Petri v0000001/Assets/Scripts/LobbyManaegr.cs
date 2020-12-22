using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class LobbyManaegr : MonoBehaviourPunCallbacks
{
    public Text LogText;
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.NickName = "Player"+Random.Range(1, 9999);
        Log("Player's name is set to " + PhotonNetwork.NickName);

        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.GameVersion = "0.0000001";
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Log("Connected to master");
    }

    public void CreateRoom() {
        if (PhotonNetwork.IsConnected)
        {
            PhotonNetwork.CreateRoom(null, new Photon.Realtime.RoomOptions { MaxPlayers = 2 });
        }
    }

    public void JoinRoom() {

        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinedRoom()
    {
        Log("Joined the room");

        PhotonNetwork.LoadLevel("SampleScene");
    }

    private void Log(string message)
    {
        Debug.Log(message);
        LogText.text += "\n";
        LogText.text += message;
    }
}
