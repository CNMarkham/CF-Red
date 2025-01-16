using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Throwable direction;
    public float speed;
    public Teleport teleport;
    public ReturnToMenu returnToMenu;

    // Start is called before the first frame update
    void Start()
    {
        direction = GameObject.FindGameObjectWithTag("Player").GetComponent<Throwable>();
        teleport = GameObject.FindGameObjectWithTag("Exit").GetComponent<Teleport>();
        returnToMenu = GameObject.FindGameObjectWithTag("Exit").GetComponent<ReturnToMenu>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction.offset * Time.deltaTime * speed;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            teleport.enemyCount -= 1;
            returnToMenu.enemyCount -= 1;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        Invoke("destroyThrowable", 4);

    }



    private void destroyThrowable()
    {
        Destroy(gameObject);
    }
}
