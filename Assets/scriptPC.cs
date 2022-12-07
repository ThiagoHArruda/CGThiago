using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPC : MonoBehaviour
{

    float unidadesZ, unidadesX;
    private float rotY = 0;
    private Quaternion rotIni;
    public float velRot = 60;
   
    float vT;
    // Start is called before the first frame update
    void Start()
    {
        vT = 17.5f;
        rotIni = transform.localRotation;
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
        mover();
         rotacaoY();
        
        

    }
     void mover(){
        unidadesZ = vT*Input.GetAxis("Vertical")*Time.deltaTime;
        unidadesX = vT*Input.GetAxis("Horizontal")*Time.deltaTime;
        transform.Translate(unidadesX,0,unidadesZ);
    }
     void rotacaoY()
    {
        rotY = rotY+Input.GetAxis("Mouse X")*Time.deltaTime* velRot;
        Quaternion rotMouse = Quaternion.AngleAxis(rotY, Vector3.up);
        transform.localRotation = rotIni* rotMouse;
    }
}
