using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("AAAAAAAAAAAAA");
        if (other.transform.gameObject.CompareTag("PlayerCapsule"))
        {
            Debug.Log("Hey");
            
        }
        SceneManager.LoadScene("Main");
    }
}

