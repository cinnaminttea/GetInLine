using UnityEngine;
using UnityEngine.UIElements;

public class mouseClickRaycast : MonoBehaviour
{
    public Vector3 clickedBead;
    public Vector3 highlightArea;
    public GameObject highlight;
    public Canvas canvas;
    public Rect creationArea1;
    public Rect creationArea2;

    private void Start()
    {
        creationArea1 = new Rect(0, 0, 80.006f, 30.015f);
        creationArea2 = new Rect(0, 0, 40.311f, 60.634f);
    }
    // Update is called once per frame
    void Update()
    {
        // Check if the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Convert the mouse position to world point
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Create a 2D raycast hit variable
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            // Check if the raycast hit a collider
            if (hit.collider != null)
            {
                // Output the position of the hit game object

                clickedBead = hit.transform.position;
                
                    for (int i = 0; i < 3; i++)
                    {

                        for (int j = 0; j < 3; j++)
                        {

                        highlightArea = clickedBead + new Vector3(0.702f * (i - 1), 0.694f * (j - 1), 0);

                        Debug.Log(highlightArea.ToString());
                        //if (creationArea1.Contains(highlightArea) || creationArea2.Contains(highlightArea))
                            if (highlightArea.x>-4.5 && highlightArea.x < 4.5 && highlightArea.y > -4 && highlightArea.y < 4)
                            {
                                Instantiate(highlight, highlightArea, Quaternion.identity, canvas.transform);
                            }
                        }

                    }
                
            }
        }
    }
}
