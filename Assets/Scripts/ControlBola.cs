using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlBola : MonoBehaviour
{
    [SerializeField] float fuerza;
    [SerializeField] float velocidadRotacion;
    private float rotacionBola;
    Rigidbody rb;
    Vector3 posicionInicial;
    //Vector3 direccion = new Vector3(1, 0, 0);




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        posicionInicial = transform.position;
        
    }

    void Update()
    {
        Debug.DrawRay(transform.position, rb.rotation * Vector3.right * 3f, Color.blue);
        rotacionBola = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.right * fuerza, ForceMode.Impulse);
        }

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Quaternion rot = Quaternion.Euler(0f, rotacionBola * velocidadRotacion * Time.fixedDeltaTime, 0f);
        rb.MoveRotation(rb.rotation * rot);

        if (transform.position.y < -5f)
        {
            SceneManager.LoadScene("Ejercicio Colliders");
        }

    }
}
