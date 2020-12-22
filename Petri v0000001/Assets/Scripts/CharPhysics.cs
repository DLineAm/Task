using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System;
using ExitGames.Client.Photon;
using UnityEngine.AI;

public class CharPhysics : MonoBehaviour, IPunObservable
{
    private Rigidbody2D rb;

    private PhotonView photonView;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        photonView = GetComponent<PhotonView>();

        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.identity;
        if (photonView.IsMine)
        {

            if (Input.GetMouseButtonDown(1) && !BuildingsGrid.IsAliveFlyingBuilding)
            {
                var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                agent.SetDestination(new Vector3(mousePos.x, mousePos.y, 0));
                //Debug.Log("Click");
            }
        }

    }

    private void FixedUpdate()
    {
       

            /*rb.MovePosition(new Vector2
            (rb.position.x + Vector2.right.x 
            * moveX * speed 
            * Time.deltaTime, rb.position.y 
            + Vector2.up.y * moveY * speed 
            * Time.deltaTime));

            if (moveX > 0)
            {
                direction = Vector2Int.right;                
            }
            else if (moveX < 0)
            {                
                direction = Vector2Int.right;
            }

            if (moveY > 0)
            {
                direction = Vector2Int.up;
            }
            else if (moveY < 0)
            {               
                direction = Vector2Int.down;
            }
            */
        
        //if (direction == Vector2Int.up)
        //    spriteRenderer.flipY = true;
        //if (direction == Vector2Int.down)
        //    spriteRenderer.flipY = false;
        //if (direction == Vector2Int.right)
        //    spriteRenderer.flipX = false;
        //if (direction == Vector2Int.right)
        //    spriteRenderer.flipX = true;
    }



    private void OnMouseDown()
    {
        
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            //stream.SendNext(transform.position);
        }
        else
        {
            //var kavo = stream.ReceiveNext();
            //Debug.Log(kavo.ToString());
            //transform.position = (Vector3)kavo;
        }
    }


}
