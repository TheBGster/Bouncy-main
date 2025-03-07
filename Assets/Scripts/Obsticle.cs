using UnityEngine;

public class Obsticle : MonoBehaviour
{
    public bool isReal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int temp = Random.Range(0, 2);
        if (temp == 0)
        {
            isReal = true;
            Debug.Log("Survived");
        }
        else
        {
            isReal = false;
            Debug.Log("Died");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Tried");
        if(collision.gameObject.CompareTag("player"))
        {
            if(isReal == true)
            {
                
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
