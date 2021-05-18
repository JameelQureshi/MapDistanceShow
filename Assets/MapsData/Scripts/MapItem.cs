
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class MapItem : MonoBehaviour {
    
 
    public void Init(string location)
    {
       // GetComponent<Button>().onClick.AddListener(delegate { TaskOnClick(location); });
    }

    private void TaskOnClick(string location)
    {
        PathDrawer.instance.popup.SetActive(true);
        PathDrawer.instance.targetLocation = location;
        PathDrawer.instance.target = transform;
    }
    void OnMouseDown()
    {
        //PathDrawer.instance.popup.SetActive(true);
       // PathDrawer.instance.targetLocation = location;
        //PathDrawer.instance.target = transform;
    }

}
