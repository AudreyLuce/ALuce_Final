using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGScroller : MonoBehaviour
{
    public float scrollSpeed;
    public float tileSizeZ;
    public Text winText;
    public ParticleSystem mainPS;
    public ParticleSystem distantPS;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
        transform.position = startPosition + Vector3.forward * newPosition;


        var main = mainPS.main;
        var distant = distantPS.main;

        if (winText.text.Equals(""))
        {

        }
        else
        {
            scrollSpeed = -6;
            main.simulationSpeed = 50;
            distant.simulationSpeed = 50;
        }
    }
}
