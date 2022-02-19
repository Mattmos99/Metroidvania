using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private PlayerController player;
    public BoxCollider2D boundsbox;

    private float halfHeight, halfWidth;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        halfHeight = Camera.main.orthographicSize;
        halfWidth = halfHeight * Camera.main.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            transform.position = new Vector3(
               Mathf.Clamp (player.transform.position.x, boundsbox.bounds.min.x + halfWidth,boundsbox.bounds.max.x - halfWidth),
               Mathf.Clamp (player.transform.position.y, boundsbox.bounds.min.y + halfHeight,boundsbox.bounds.max.y - halfHeight),
                transform.position.z);
        }
    }
}
