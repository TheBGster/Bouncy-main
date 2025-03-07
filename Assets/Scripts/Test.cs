using UnityEngine;

public class Test : MonoBehaviour
{
    private bool Mybool = false;

    float Maxsize = 10f;
    float MinSize = 1.0f;

    private void Awake()
    {

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.transform.Rotate(new Vector3(0.0f, -1f, 0.0f));
    }

    // Update is called once per frame
    void Update()
    {
        

        if(Mybool)
        {
            Debug.Log("hi");
        }

        gameObject.transform.Rotate(new Vector3(0.0f, -1f, 0.0f));

        //gameObject.transform 
    }
}
