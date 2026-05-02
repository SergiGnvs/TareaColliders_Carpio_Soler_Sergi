using UnityEngine;

public class ControlCamara : MonoBehaviour
{
    public Rigidbody bola;
    Vector3 distancia = new Vector3(-7, 4, 0);
    Vector3 posicionCamara;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        posicionCamara = distancia;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = bola.position + distancia;
    }
}
