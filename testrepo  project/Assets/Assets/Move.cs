using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
  public float speed = 1;
    public float Rotatespeed;

    Animation ani;
    void Start()
    {
        ani = GetComponent<Animation>();
    }
    void Update()
    {
        Cam_Move();

        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
    void Cam_Move()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            // ani.Play("pose_03");
            ani.Play("walk_00");
        }
        else if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
            ani.Play("walk_00");

        }
        else
        {
            ani.Play("pose_03");

        }
        if (Input.GetKey("a"))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * speed* Rotatespeed);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * speed* Rotatespeed);
        }
     

        
    }
}