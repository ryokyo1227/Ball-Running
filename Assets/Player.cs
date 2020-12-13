using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float timeCount;
    public Vector3 StartPosition;
    Rigidbody rb;
    bool isJump;
    bool StopTime;
    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
        rb = GetComponent<Rigidbody>();
        isJump = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos;
        pos = rb.position;
        //pos.x = Camera.main.ScreenToWorldPoint(Input.mousePosition + Camera.main.transform.forward * 3).x;
        rb.MovePosition(pos);

        Vector3 vel;
        vel = rb.velocity;
        vel.x = Input.GetAxis("Horizontal") * 4;
        if (isJump == true)
        {
            vel.y = 7;
            isJump = false;
        }
        vel.z = Input.GetAxis("Vertical") * 4;
        rb.velocity = vel;

    }
    public void Jump()
    {
        isJump = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        StartCoroutine(PlayerDeath());
    }
    IEnumerator PlayerDeath()//繰り返しにはwhileを使いたい
    {
        timeCount = 7;
        StopTime = false;
        while (true)
        {
            if (StopTime)
            {
                print("stop");
                yield break;
            }
            print("looping");
            timeCount -= Time.deltaTime;
            if (timeCount <= 0)
            {
                transform.position = StartPosition;
                rb.velocity = Vector3.zero;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                yield break;
            }
            
            yield return null;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        StopTime = true;
    }
    public void ReturnPosition()
    {
        transform.position = StartPosition;
        rb.velocity = Vector3.zero;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
