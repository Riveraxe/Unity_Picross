using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCube : MonoBehaviour
{
    // Start is called before the first frame update
    private RaycastHit hit;

    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(ray, out hit))
            {
                hit.collider.gameObject.GetComponent<Clicked>().ClickedCube();
            }
        }
        
    }
}
