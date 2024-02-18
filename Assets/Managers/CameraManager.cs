using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private GameObject cameraPlayer; //Camera #1
    [SerializeField] private GameObject cameraBird; //Camera #2
    private int currentCamera = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            if(currentCamera < 2){
                currentCamera += 1;
            } else{ //currentCamera == 2
                currentCamera = 1;
            }
            switchCamera(currentCamera);
        }
    }

    private void switchCamera(int desiredCamera){
        if(desiredCamera == 1){
            cameraPlayer.SetActive(true);
            cameraBird.SetActive(false);
        } else if(desiredCamera == 2){
            cameraPlayer.SetActive(false);
            cameraBird.SetActive(true);
        }
    }
}