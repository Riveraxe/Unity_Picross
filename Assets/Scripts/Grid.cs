using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    // Start is called before the first frame update
    public int cols;
    public int rows;
    public GameObject ItemEmpty;
    public GameObject ItemTrue;
    public float SizeX;
    public float SizeY;
    private int[] gameCubeArray = {0, 0, 1, 0, 1, 0, 0, 1, 0};
    public static List<CubeItem> cubeInfoList = new List<CubeItem>();
    //public float padding;
    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid();
    }
    
    void GenerateGrid()
    {
        int count = 0;
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                CubeItem cube = gameObject.AddComponent(typeof(CubeItem)) as CubeItem;
                cubeInfoList.Add(cube);
                if (gameCubeArray[count] == 0)
                {
                    cube.cubeObj = (GameObject)Instantiate(ItemEmpty, transform);
                    cube.cubeObj.name = "Cube" + count.ToString();
                    cube.cubeObj.tag = "empty";
                    cube.identify = count;
                    float x = col * SizeX;
                    float y = row * -SizeY;
                    cube.cubeObj.transform.position = new Vector3(x, y, 0);
                }
                else
                {
                    cube.cubeObj = (GameObject)Instantiate(ItemTrue, transform);
                    cube.cubeObj.name = "Cube" + count.ToString();
                    cube.cubeObj.tag = "true";
                    cube.identify = count;
                    float x = col * SizeX;
                    float y = row * -SizeY;
                    cube.cubeObj.transform.position = new Vector3(x, y, 0);
                }
                    count += 1;
            }
        }

        float GridH = cols * SizeX;
        float GridW = rows * SizeY;
        transform.position = new Vector2(-GridH/2 + SizeX/2, GridW/2 - SizeY/2);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
