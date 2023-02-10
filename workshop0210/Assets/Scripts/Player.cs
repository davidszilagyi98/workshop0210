using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpSpeed = 12f;
    public float moveSpeed = 5f;
    public int maxJumps = 2;

    private Vector2 moveVelocity;
    private int jumpCounter = 0;
    private Rigidbody2D myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 tempVel = myRigidbody.velocity;

        // Jump
        if(Input.GetKeyDown(KeyCode.Space) && jumpCounter < maxJumps) {            
            tempVel.y = jumpSpeed;
            jumpCounter++;
        }
        
        // Move
        moveVelocity = Vector2.zero;
        if(Input.GetKey(KeyCode.A)) {
            moveVelocity.x -= moveSpeed;
        }
        if(Input.GetKey(KeyCode.D)) {
            moveVelocity.x += moveSpeed;
        }
        myRigidbody.AddForce(moveVelocity);
        
        // Drag
        if(moveVelocity.magnitude == 0f) {
            tempVel.x *= 0.98f * (1 - Time.deltaTime);
        }

        if(Mathf.Abs(tempVel.x) > moveSpeed) {
            tempVel.x = moveSpeed * Mathf.Sign(tempVel.x);
        }

        myRigidbody.velocity = tempVel;
    }

    void OnTriggerEnter2D(Collider2D coll) {
        if(coll.gameObject.tag.Equals("Wall")) {
            jumpCounter = 0;
        }
    }

}
