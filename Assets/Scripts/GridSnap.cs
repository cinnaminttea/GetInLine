using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GridSnap : MonoBehaviour
{
    public int gridSizeX = 15;
    public int gridSizeY = 13;
    public Vector3[,] gridArray;


    void Start()
    {
        gridArray = new Vector3[gridSizeX, gridSizeY];
        gridArray[0, 0] = new Vector3(-5.75f, 4.11f, 0);
    }
    

    void Update()
    {

        //get coordinates of bead; find closest array position; snap to position
        if (gameObject.GetComponent < beadMovement> ().canMove == true)
        {

            if (Input.GetMouseButtonUp (0))
            {
                Vector3 bead = gameObject.transform.position;
            }
        }

    }
}
