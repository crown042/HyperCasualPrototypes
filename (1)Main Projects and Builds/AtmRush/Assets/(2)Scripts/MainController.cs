using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{

    [SerializeField] float[] camPosValues = new float[3] { 5.75f, 3.1f, 0f };
    public Camera mainCam;
    Transform camPos;

    private void Awake() {
        camPos = mainCam.transform;

    }


    void Update()
    {
        mainCam.transform.position = new Vector3(transform.position.x + camPosValues[0], transform.position.y + camPosValues[1], transform.position.z + camPosValues[2]);
    }
}
