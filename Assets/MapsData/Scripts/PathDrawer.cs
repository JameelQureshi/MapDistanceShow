using System.Collections;
using System.Collections.Generic;
using Mapbox.Unity.Location;
using Mapbox.Unity.Map;
using Mapbox.Unity.Utilities;
using Mapbox.Utils;
using UnityEngine;

public class PathDrawer : MonoBehaviour {

    public GameObject popup;
    public string targetLocation;


    public static PathDrawer instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    private void Start()
    {
        popup.SetActive(false);
    }
    
    public void DrawPath()
    {
        Debug.Log(targetLocation);
    }


}
