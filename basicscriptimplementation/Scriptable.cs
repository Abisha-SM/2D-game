using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Object")]

public class Scriptable : ScriptableObject
{
    public GameObject gameObject;
    public Object Feature;

}
[System.Serializable]
public class materialproperties
{
    public Material ModelPartMaterial;
    
    public Features type;

}
[System.Serializable]
public class features
{
    public GameObject modelObject;
    public GameObject size;
    public Material colour;
   
}
[System.Serializable]
public class Category
{
    public Features type;
    public Object Feature;
    public features features;
}
[System.Serializable]
public class Object
{
    
    public List<Color> colours;
    public List<Features> gameobject;

}
public enum Features
{
    cube,cylinder,circle
}