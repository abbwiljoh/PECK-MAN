using System.Collections;
using UnityEngine;

public class PocmanMove : MonoBehaviour
{
    public float speed = 0.4f;
    Vector2 dest = Vector2.zero;
    [SerializeField] private Transform spawnpoint;

    // Start is called before the first frame update
    void Start()
    {
        dest = transform.position;
    }

    // FixedUpdate is called in a fixed time interval
    void FixedUpdate()
    {
        // Move closer to Destination
        Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
        GetComponent<Rigidbody2D>().MovePosition(p);

        // Check for Input if not moving, if we have not recently respawned
        if ((Vector2)transform.position == dest)
        {
            if (Input.GetKey(KeyCode.W) && valid(Vector2.up))
                dest = (Vector2)transform.position + Vector2.up;
            if (Input.GetKey(KeyCode.D) && valid(Vector2.right))
                dest = (Vector2)transform.position + Vector2.right;
            if (Input.GetKey(KeyCode.S) && valid(-Vector2.up))
                dest = (Vector2)transform.position - Vector2.up;
            if (Input.GetKey(KeyCode.A) && valid(-Vector2.right))
                dest = (Vector2)transform.position - Vector2.right;
        }
        if (GlobalVariables.respawn2)
        {
            transform.position = spawnpoint.transform.position;
            dest = transform.position;
            GlobalVariables.respawn2 = false;
        }



        // Animation Parameters
        Vector2 dir = dest - (Vector2)transform.position;
        GetComponent<Animator>().SetFloat("DirX", dir.x);
        GetComponent<Animator>().SetFloat("DirY", dir.y);
    }

    bool valid(Vector2 dir)
    {
        // Cast Line from 'next to Poc-Man' to 'Poc-Man'
        Vector2 pos = transform.position;
        RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);
        return (hit.collider == GetComponent<Collider2D>());
    }
}