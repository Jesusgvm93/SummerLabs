using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARPlacement1 : MonoBehaviour
{

    public GameObject arObject;
    public GameObject arObject2;
    public GameObject arObject3;
    public GameObject markerIndicator;
    public GameObject shoot;
    private GameObject spawendObject;
    private GameObject spawendObject2;
    private GameObject spawendObject3;
    private Pose placementPose;
    private Pose placementPose2;
    private Pose placementPose3;
    private ARRaycastManager aRRaycastManager;
    private bool placementPoseIsValid = false;
    private bool placementPoseIsValid2 = false;
    private bool placementPoseIsValid3 = false;
    public AudioSource setMarker;
    public AudioSource findMarker;


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

        if (spawendObject2 == null && placementPoseIsValid2 && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            ARPlaceObject2();
            shoot.SetActive(true);
        }

        if (spawendObject3 == null && placementPoseIsValid3 && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            ARPlaceObject3();
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
            //findMarker.Play();


        }
        else if (spawendObject2 == null && spawendObject3 == null && placementPoseIsValid2 && placementPoseIsValid3)
        {
            markerIndicator.SetActive(true);
            markerIndicator.transform.SetPositionAndRotation(placementPose2.position, placementPose2.rotation);
            markerIndicator.transform.SetPositionAndRotation(placementPose3.position, placementPose3.rotation);

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

        placementPoseIsValid2 = hits.Count > 0;
        if (placementPoseIsValid2)
        {
            placementPose2 = hits[0].pose;
        }

        placementPoseIsValid3 = hits.Count > 0;
        if (placementPoseIsValid3)
        {
            placementPose3 = hits[0].pose;
        }
    }


    void ARPlaceObject()
    {
        spawendObject = Instantiate(arObject, placementPose.position, placementPose.rotation);
        setMarker.Play();

    }

    void ARPlaceObject2()
    {
        spawendObject2 = Instantiate(arObject2, placementPose2.position, placementPose2.rotation);
    }

    void ARPlaceObject3()
    {
        spawendObject3 = Instantiate(arObject3, placementPose3.position, placementPose3.rotation);
    }

}