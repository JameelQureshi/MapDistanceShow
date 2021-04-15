using System;
using System.Collections;
using System.Collections.Generic;
using Mapbox.Unity.Location;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LocationDataManager : MonoBehaviour
{
    
   
    public string[] m_locationsData;


    void Start()
    {
        LocationProviderFactory.Instance.DeviceLocationProvider.OnLocationUpdated += OnUpdateLocationCalled;
    }

    private void OnUpdateLocationCalled(Location location)
    {
        if (m_locationsData != null)
        {
            MapPointsPlacement.instance.PlacePoints(m_locationsData);
           // ListDataCreator.instance.Populate(locationData);
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        LocationProviderFactory.Instance.DeviceLocationProvider.OnLocationUpdated -= OnUpdateLocationCalled;
    }

   

  

}





