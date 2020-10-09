using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFloor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeColor());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.gameObject);
        }
    }
    IEnumerator ChangeColor()//繰り返しにはwhileを使いたい
            {
        while(true)
        {

                GetComponent<Renderer>().material.color = new Color32(0, 89, 255, 255);

                yield return new WaitForSeconds(2.0f);

                GetComponent<Renderer>().material.color = new Color32(0, 141, 200, 255);

            yield return new WaitForSeconds(2.0f);
        }
     }
}
