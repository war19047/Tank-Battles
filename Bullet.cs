using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speedOfBullet = 30f;
    public Rigidbody2D rb;
    public float timeToDie = 3;
    public string target;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speedOfBullet;
        player = GameObject.Find("/TwoTanksOnFlat/red_player/tankBody");
    }
    void Update()
    {
        if (timeToDie > 0)
        {
            timeToDie -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //*Debug.Log(player.gameObject.GetComponent<HealthPlayerRed>().slider.value);
        //*player.gameObject.GetComponent<HealthPlayerRed>().slider.value = 10;
        //*Debug.Log(player.gameObject.GetComponent<HealthPlayerRed>().slider.value);
        //*Debug.Log(collision.name);
        if("blue_collider" == collision.name || "red_collider"== collision.name){
            if(collision.name =="blue_collider"){
                Debug.Log("blue was hit");
                BlueHealth.currentHealth = BlueHealth.currentHealth-10; 
                //BlueHealth blueH = new BlueHealth();
                //BlueHealth blueH = gameObject.GetComponent(typeof(BlueHealth)) as BlueHealth;
                //BlueHealth blueH = gameObject.GetComponent<BlueHealth>();
                //blueH.TakeDamage();
                //blueH.currentHealth -= 10;
                // GameObject blueH = GameObject.FindWithTag("health");
                // GameComponent blue = blueH.GetComponent<BlueHealth>();
                // blue.currentHealth -= 10;
                // blueHealth.TakeDamage();
                //*Debug.Log(player.gameObject.GetComponent<HealthPlayerRed>().slider.value);
                //*player.gameObject.GetComponent<HealthPlayerRed>().slider.value = 10;
                //*Debug.Log(player.gameObject.GetComponent<HealthPlayerRed>().slider.value);
                
                Destroy(gameObject);
            }else if (collision.name =="red_collider"){
                Debug.Log("red was hit");
                redHealth.currentHealth = --redHealth.currentHealth-10; 
                //public redHealth redH = new redHealth();
                //*redHealth redH = gameObject.GetComponent(typeof(redHealth)) as redHealth;
                
                //*redH.TakeDamage();
                Destroy(gameObject);
            }
        }
        else{
            Destroy(gameObject);
        }
    }

    private void Awake()
    {
        
    }
    public void OnControllerColliderHit(ControllerColliderHit hit) {
        
    }
}    