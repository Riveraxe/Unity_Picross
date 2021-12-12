using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneFreedom : MonoBehaviour
{
    // Start is called before the first frame update]
    public float rotateSpeed = 5;
    private static Vector3 centerPoint = Vector3.zero;
    private float mouseX;
    private float mouseY;
    public void CameraRotate(float mouseX,float mouseY)
    {
//注意!!! 此处是 GetMouseButton() 表示一直长按鼠标左键；不是 GetMouseButtonDown()
        if (Input.GetMouseButton(1))
        {
//控制相机绕中心点(centerPoint)水平旋转
            Camera.main.transform.RotateAround(centerPoint, Vector3.up, mouseX * rotateSpeed);
//记录相机绕中心点垂直旋转的总角度
//控制相机绕中心点垂直旋转(！注意此处的旋转轴时相机自身的x轴正方向！)
            Camera.main.transform.RotateAround(centerPoint, Camera.main.transform.right, -mouseY * rotateSpeed);
        }
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
        CameraRotate(mouseX, mouseY);
    }
}
