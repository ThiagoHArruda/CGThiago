using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptMainCamera : MonoBehaviour
{

   private float rotX=0;
    private Quaternion rotIni;

    public float velRot =35;
    // Start is called before the first frame update
    void Start()
    {
        rotIni = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
         rotX = rotX+Input.GetAxis("Mouse Y")*Time.deltaTime*velRot;
         rotX = Mathf.Clamp(rotX, -20, 60);
        Quaternion rotMouse = Quaternion.AngleAxis(rotX, Vector3.left);
        transform.localRotation = rotIni* rotMouse;
    }
}
