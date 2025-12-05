using UnityEngine;
using UnityEngine.SceneManagement;

public class teleportscript : MonoBehaviour
{
    //variables
    public string destination;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter (Collider other)
    {
        SceneManager.LoadScene(destination);
    }




}
