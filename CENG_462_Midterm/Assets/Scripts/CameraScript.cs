using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
     private Camera camera;
     [SerializeField] private float cameraSize = 5;

    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Camera>();
        camera.orthographicSize = cameraSize;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
