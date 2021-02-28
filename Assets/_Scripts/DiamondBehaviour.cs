using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondBehaviour : MonoBehaviour
{
    public Resource type;

    //private int randomtype;
    // Start is called before the first frame update
    void Start()
    {
        //randomtype = UnityEngine.Random.Range(1, 8);
        //Debug.Log(randomtype);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Raaaa");

            CollectionManager colmgr = other.gameObject.GetComponent<CollectionManager>();
            MeshRenderer meshRenderer = gameObject.GetComponent<MeshRenderer>();

            if (colmgr != null)
            {
                switch(type)
                {
                    case Resource.RED:
                        colmgr.collection.red = 1;
                        meshRenderer.material = colmgr.collection.RedMaterial;
                        break;
                    case Resource.ORANGE:
                        colmgr.collection.orange = 1;
                        meshRenderer.material = colmgr.collection.OrangeMaterial;
                        break;
                    case Resource.YELLOW:
                        colmgr.collection.yellow = 1;
                        meshRenderer.material = colmgr.collection.YellowMaterial;
                        break;
                    case Resource.GREEN:
                        colmgr.collection.green = 1;
                        meshRenderer.material = colmgr.collection.GreenMaterial;
                        break;
                    case Resource.BLUE:
                        colmgr.collection.blue = 1;
                        meshRenderer.material = colmgr.collection.BlueMaterial;
                        break;
                    case Resource.INDIGO:
                        colmgr.collection.indigo = 1;
                        meshRenderer.material = colmgr.collection.IndigoMaterial;
                        break;
                    case Resource.VIOLET:
                        colmgr.collection.violet = 1;
                        meshRenderer.material = colmgr.collection.VioletMaterial;
                        break;
                    default:
                        break;
                }
            }

            // Destroy(gameObject);
        }
    }
}
