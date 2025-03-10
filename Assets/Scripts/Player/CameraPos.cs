using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum CameraTag
{
    MainCamera,
    SubCamera
}

public class CameraPos : MonoBehaviour
{
    public Camera mainCamera;
    public Camera Camera3rd;

    private void Start()
    {
        mainCamera.tag = CameraTag.MainCamera.ToString();
        Camera3rd.tag = CameraTag.SubCamera.ToString();
        Camera3rd.gameObject.SetActive(false);
    }

    public void ChangeCamera()
    {
        if(mainCamera.tag ==  CameraTag.MainCamera.ToString())
        {
            Camera3rd.gameObject.SetActive(true);
            Camera3rd.tag = CameraTag.MainCamera.ToString();
            mainCamera.tag = CameraTag.SubCamera.ToString();
        }
        else
        {
            Camera3rd.gameObject.SetActive(false);
            Camera3rd.tag = CameraTag.SubCamera.ToString();
            mainCamera.tag = CameraTag.MainCamera.ToString();
        }
    }
}
