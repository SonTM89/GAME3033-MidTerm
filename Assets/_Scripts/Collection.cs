using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCollection", menuName = "Collection")]
public class Collection : ScriptableObject
{
    public int red = 0;
    public int orange = 0;
    public int yellow = 0;
    public int green = 0;
    public int blue = 0;
    public int indigo = 0;
    public int violet = 0;

    public Material RedMaterial;
    public Material OrangeMaterial;
    public Material YellowMaterial;
    public Material GreenMaterial;
    public Material BlueMaterial;
    public Material IndigoMaterial;
    public Material VioletMaterial;

    public GameObject RedEffect;
    public GameObject OrangeEffect;
    public GameObject YellowEffect;
    public GameObject GreenEffect;
    public GameObject BlueEffect;
    public GameObject IndigoEffect;
    public GameObject VioletEffect;
}
