using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    //cam = this;

    public Rigidbody2D frog; 

    // Update is called once per frame
    void Update () {

        //if (GameManager.GameIsOver){
        //  this.enabled = false;
        //  return;
        //}

        //Vector2 bottomRight = new Vector2(Screen.width/20, Screen.height/20);

        //if (Input.GetKey("down") || Input.mousePosition.y <= panBorderThickness){
        //  transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
        //}

        //.

        //float scroll = Input.GetAxis("Mouse ScrollWheel");

        Vector3 pos = transform.position;

        Vector2 mousePos = new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y);

    }
}