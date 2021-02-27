using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerMovment : MonoBehaviour
{
    public bool cameraMove = false;
   public bool back = false;
    Camera camera;
    Vector3 oldCameraPos;
    public Vector3 newVector = new Vector3 (0,0,-1);
    [SerializeField] int speed;

    PlayerMovment player;
    void Start()
    {
        player = FindObjectOfType<PlayerMovment>();
        camera = FindObjectOfType<Camera>(); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.tag == "Player")
        {
            oldCameraPos = new Vector3(newVector.x - 18, 0, -1);
            cameraMove = true;
            StartCoroutine(WaitForSeconds());
        }
        
    }    
    IEnumerator WaitForSeconds()
    {
        player.rigidbody2D.constraints = RigidbodyConstraints2D.FreezePosition;
        yield return new WaitForSeconds(1);
        player.rigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;

        cameraMove = false;
  
        if(back == false)
        {
            back = true;
        }
        else
        {
            back = false;
        }
    }
    void Update()
    {

        if (cameraMove == true)
        {
            if (back == false)
            {
                camera.transform.position = Vector3.MoveTowards(camera.transform.position, newVector, speed * Time.deltaTime);
            }
            if (back)
            {
                camera.transform.position = Vector3.MoveTowards(camera.transform.position, oldCameraPos, speed * Time.deltaTime);
            }
           
        }
    }
}
