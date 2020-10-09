using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalFloor : MonoBehaviour
{
    public string StageName = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            SceneManager.LoadScene(StageName);
        }
    }
}
