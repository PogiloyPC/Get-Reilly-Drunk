using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriticleHit : MonoBehaviour
{    
    [SerializeField] private Transform player;
    [SerializeField] private GameObject playerClone;
    public int chance;
    private bool timeSlow;
    public float startTimer;
    private float finishTimer;
    public float spawnPlayerCloneStartTimer;
    private float spawnPlayerCloneFinishTimer;

    private void Start()
    {
        finishTimer = startTimer;
        spawnPlayerCloneFinishTimer = spawnPlayerCloneStartTimer;
    }

    private void Update()
    {
        if (timeSlow == true)
        {
            if (finishTimer >= 0f)
            {
                finishTimer -= 1f * Time.deltaTime;
                if (spawnPlayerCloneFinishTimer >= 0f)
                {
                    spawnPlayerCloneFinishTimer -= 1f * Time.deltaTime;
                }
                else
                {
                    Instantiate(playerClone, player.position, Quaternion.identity);
                    if (player.localScale == new Vector3(1f, 1f, 1f))
                    {
                        playerClone.transform.localScale = new Vector3(1f, 1f, 1f);
                    }
                    if (player.localScale == new Vector3(-1f, 1f, 1f))
                    {
                        playerClone.transform.localScale = new Vector3(-1f, 1f, 1f);
                    }
                    spawnPlayerCloneFinishTimer = spawnPlayerCloneStartTimer;
                }
            }
            else
            {
                timeSlow = false;
                Time.timeScale = 1f;
            }
        }
    }

    public void CriticleAttack()
    {
        if (gameObject.activeSelf == true)
        {
            chance = Random.Range(1, 15);
            if (chance == 4)
            {
                finishTimer = startTimer;
                timeSlow = true;
            }
        }
    }
}
