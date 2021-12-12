using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicked : MonoBehaviour
{
    public void ClickedCube()
    {
        if (this.tag == "empty")
        {
            this.gameObject.SetActive(false);
        }
        else
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.red;
            Invoke("ChangeColor",1f);
        }
    }

    private void ChangeColor()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
}
