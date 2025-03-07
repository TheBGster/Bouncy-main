using UnityEngine;

public class Accelorater : MonoBehaviour
{
    public float speed = 25;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("We have collided");
        collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(speed, 0, 0), ForceMode.Impulse);

    }
}
