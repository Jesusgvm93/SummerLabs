using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARPlacement1 : MonoBehaviour
{

    public GameObject arObject;
    public GameObject markerIndicator;
    public GameObject shoot;
    private GameObject spawendObject;
    private Pose placementPose;
    private ARRaycastManager aRRaycastManager;
    private bool placementPoseIsValid = false;

    void Start()
    {
        aRRaycastManager = FindObjectOfType<ARRaycastManager>();
        shoot.SetActive(false);
    }


    void Update()
    {
        if (spawendObject == null && placementPoseIsValid && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            ARPlaceObject();
            shoot.SetActive(true);
        }
        
        
        UpdatePlacementPose();
        UpdatemakerIndicator();
    }

    void UpdatemakerIndicator()
    {
        if (spawendObject == null && placementPoseIsValid)
        {
            markerIndicator.SetActive(true);
            markerIndicator.transform.SetPositionAndRotation(placementPose.position, placementPose.rotation);
        }
        else
        {
            markerIndicator.SetActive(false);
        }
    }

    void UpdatePlacementPose()
    {
        var screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        var hits = new List<ARRaycastHit>();
        aRRaycastManager.Raycast(screenCenter, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);

        placementPoseIsValid = hits.Count > 0;
        if (placementPoseIsValid)
        {
            placementPose = hits[0].pose;
        }
    }

    void ARPlaceObject()
    {
        spawendObject = Instantiate(arObject, placementPose.position, placementPose.rotation);
    }
}
