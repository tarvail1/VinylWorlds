using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinMovement : MonoBehaviour
{
    public float timePeriod = 2;
    public float height = 30f;
    private float timeSinceStart;
    private Vector3 pivot;
    

    private void Start()
    {
        height = Random.Range(1, 3);
        timePeriod = Random.Range(5, 12);
        pivot = transform.position;
        height /= 2;
        timeSinceStart = (3 * timePeriod) / 4;
        
    }

    void Update()
    {
        Vector3 nextPos = transform.position;
        nextPos.y = pivot.y + height + height * Mathf.Sin(((Mathf.PI * 2) / timePeriod) * timeSinceStart);
        timeSinceStart += Time.deltaTime;
        transform.position = nextPos;
    }

}