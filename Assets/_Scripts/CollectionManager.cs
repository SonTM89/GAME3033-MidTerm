using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionManager : MonoBehaviour
{
    public Collection collection;

    public GameObject RedCheck;
    public GameObject OrangeCheck;
    public GameObject YellowCheck;
    public GameObject GreenCheck;
    public GameObject BlueCheck;
    public GameObject IndigoCheck;
    public GameObject VioletCheck;

    public bool canWin;

    // Start is called before the first frame update
    void Start()
    {
        canWin = false;

        collection.red = 0;
        collection.orange = 0;
        collection.yellow = 0;
        collection.green = 0;
        collection.blue = 0;
        collection.indigo = 0;
        collection.violet = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(collection.red == 1)
        {
            RedCheck.SetActive(true);
        }

        if (collection.orange == 1)
        {
            OrangeCheck.SetActive(true);
        }

        if (collection.yellow == 1)
        {
            YellowCheck.SetActive(true);
        }

        if (collection.green == 1)
        {
            GreenCheck.SetActive(true);
        }

        if (collection.blue == 1)
        {
            BlueCheck.SetActive(true);
        }

        if (collection.indigo == 1)
        {
            IndigoCheck.SetActive(true);
        }

        if (collection.violet == 1)
        {
            VioletCheck.SetActive(true);
        }

        if (collection.red == 1 &&
            collection.orange == 1 &&
            collection.yellow == 1 &&
            collection.green == 1 &&
            collection.blue == 1 &&
            collection.indigo == 1 &&
            collection.violet == 1)
        {
            canWin = true;
        }
    }
}
