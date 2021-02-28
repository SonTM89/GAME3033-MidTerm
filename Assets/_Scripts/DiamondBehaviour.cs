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
                        GameObject effectRed = (GameObject)Instantiate(colmgr.collection.RedEffect, transform.position, transform.rotation);
                        Destroy(effectRed, 2.0f);
                        break;
                    case Resource.ORANGE:
                        colmgr.collection.orange = 1;
                        meshRenderer.material = colmgr.collection.OrangeMaterial;
                        GameObject effectOrange = (GameObject)Instantiate(colmgr.collection.OrangeEffect, transform.position, transform.rotation);
                        Destroy(effectOrange, 2.0f);
                        break;
                    case Resource.YELLOW:
                        colmgr.collection.yellow = 1;
                        meshRenderer.material = colmgr.collection.YellowMaterial;
                        GameObject effectYellow = (GameObject)Instantiate(colmgr.collection.YellowEffect, transform.position, transform.rotation);
                        Destroy(effectYellow, 2.0f);
                        break;
                    case Resource.GREEN:
                        colmgr.collection.green = 1;
                        meshRenderer.material = colmgr.collection.GreenMaterial;
                        GameObject effectGreen = (GameObject)Instantiate(colmgr.collection.GreenEffect, transform.position, transform.rotation);
                        Destroy(effectGreen, 2.0f);
                        break;
                    case Resource.BLUE:
                        colmgr.collection.blue = 1;
                        meshRenderer.material = colmgr.collection.BlueMaterial;
                        GameObject effectBlue = (GameObject)Instantiate(colmgr.collection.BlueEffect, transform.position, transform.rotation);
                        Destroy(effectBlue, 2.0f);
                        break;
                    case Resource.INDIGO:
                        colmgr.collection.indigo = 1;
                        meshRenderer.material = colmgr.collection.IndigoMaterial;
                        GameObject effectIndigo = (GameObject)Instantiate(colmgr.collection.IndigoEffect, transform.position, transform.rotation);
                        Destroy(effectIndigo, 2.0f);
                        break;
                    case Resource.VIOLET:
                        colmgr.collection.violet = 1;
                        meshRenderer.material = colmgr.collection.VioletMaterial;
                        GameObject effectViolet = (GameObject)Instantiate(colmgr.collection.VioletEffect, transform.position, transform.rotation);
                        Destroy(effectViolet, 2.0f);
                        break;
                    default:
                        break;
                }
            }

            // Destroy(gameObject);
        }
    }
}
