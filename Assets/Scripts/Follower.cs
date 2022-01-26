using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;
using UnityEngine.Windows.WebCam;

public class Follower : MonoBehaviour
{
    public PathCreator pathCreator;
    private GameObject citybase;
    private float basespeed = 3f;
    public float speed = 5;
    public float offset;
    private float scratchMultiplier;
   
    private float distanceTravelled;
    // Start is called before the first frame update
    void Start()
    {
        distanceTravelled = offset * 1000;
        citybase = GameObject.FindGameObjectWithTag("base");
    }

    // Update is called once per frame
    void Update()
    {
        scratchMultiplier = citybase.GetComponent<rotateWorld>().multiplier;
        speed = basespeed + (speed * scratchMultiplier);
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
    }
}
    