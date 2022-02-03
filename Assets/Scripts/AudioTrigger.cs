using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject s;
    void Start()
    {
       
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        s.GetComponent<AudioSource>().Play();
        Debug.Log("bang");
    }
}
