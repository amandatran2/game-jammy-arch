using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubes : MonoBehaviour
{
    public int len = 50;
    public int wid = 50;
    public int hgt = 50;
    public GameObject cube;
    public Vector3 startpoint = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        

        for(int i =0; i<len; i++)
        {
            for (int j = 0; j < wid; j++)
            {
                for (int k = 0; k < hgt; k++)
                {
                    Instantiate(cube, new Vector3(startpoint.x+i, startpoint.y+j, startpoint.z+k), Quaternion.identity);
                }
            }
        }
    }


}
