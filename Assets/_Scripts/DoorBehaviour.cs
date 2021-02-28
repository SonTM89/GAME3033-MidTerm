using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    public GameObject player;
    private CollectionManager colmgr;

    private void Start()
    {
        colmgr = player.GetComponent<CollectionManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Door")
        {
            if(colmgr != null)
            {
                if(colmgr.canWin == true)
                {
                    Debug.Log("Enter");
                    Animator _animator = other.gameObject.GetComponentInChildren<Animator>();
                    _animator.SetBool("isOpen", true);
                }
            }
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Door")
        {
            if (colmgr != null)
            {
                if (colmgr.canWin == true)
                {
                    Debug.Log("Enter");
                    Animator _animator = other.gameObject.GetComponentInChildren<Animator>();
                    _animator.SetBool("isOpen", false);
                }
            }
        }
    }
}
