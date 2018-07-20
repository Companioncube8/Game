using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    [SerializeField]public GameObject player;
    private float offset;
    public float duration = 10.0F;
 //   [SerializeField]Camera cam;
   // private Color color1 = new Color32(66, 65, 101, 0);
   // private Color color2 = new Color32(23, 200, 246, 0);
   // float t = 0;

    void Start () {
        offset = transform.position.x - player.transform.position.x;
       // cam.clearFlags = CameraClearFlags.SolidColor;
    }
	
	// Update is called once per frame
	void Update () {
        //float t = Mathf.PingPong(Time.time, duration) / duration;
        //cam.backgroundColor = Color.Lerp(color1, color2, t);
        Vector3 pos;
        pos = transform.position;
        pos.x = player.transform.position.x;
        pos.x += offset;
        transform.position = pos;
    }
}
