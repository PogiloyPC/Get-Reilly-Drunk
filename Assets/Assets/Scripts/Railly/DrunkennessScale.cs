using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrunkennessScale : MonoBehaviour
{
    [SerializeField] private GameObject gameOver;
    [SerializeField] private Image drunkennessScale;
    [SerializeField] private Image drunkennessScaleBlack;
    [SerializeField] private Text textDrunkScale;
    public float distanceY;
    public float drunkScale;
    public float soberingSpeed;

    void Start()
    {
        
    }
    
    void FixedUpdate()
    {
        int drkScl = Mathf.RoundToInt(drunkScale); 
        drunkennessScale.transform.position = new Vector2(transform.position.x, transform.position.y + distanceY);
        drunkennessScaleBlack.transform.position = new Vector2(transform.position.x, transform.position.y + distanceY);
        textDrunkScale.text = drkScl.ToString();            
        drunkScale -= soberingSpeed * Time.fixedDeltaTime;
        drunkennessScale.fillAmount = drunkScale / 1000f;
        if (drunkScale <= 0)
        {
            gameOver.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void Binge(float drink)
    {
        drunkScale = Mathf.Clamp(drunkScale + drink, 0f, 1000f);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        MovingEnemy enemy = collision.gameObject.GetComponent<MovingEnemy>();
        EnemyGremlin gremlin = collision.gameObject.GetComponent<EnemyGremlin>();
        DragonEnemy dragon = collision.gameObject.GetComponent<DragonEnemy>();
        if (enemy != null)
        {
            drunkScale -= enemy.damageDrunkennessScale;
            Destroy(collision.gameObject);
        }
        if (gremlin != null)
        {
            drunkScale -= gremlin.damageDrunkennessScale;
            Destroy(collision.gameObject);
        }
        if (dragon != null)
        {
            drunkScale -= dragon.damageDrunkennessScale;
            Destroy(collision.gameObject);
        }
    }
}
