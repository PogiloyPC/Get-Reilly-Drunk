using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public float spawnTime;
    [SerializeField] private GameObject[] enemys;
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject enemyRonin;
    [SerializeField] private GameObject enemySword;
    [SerializeField] private GameObject enemyArmor;
    [SerializeField] private GameObject enemyHunter;
    [SerializeField] private GameObject enemyOni;
    [SerializeField] private GameObject enemyOniSword;
    [SerializeField] private GameObject enemyDragon;

    void Start()
    {
        StartCoroutine(Spawn());
    }
    
    void Update()
    {
        
    }

    private IEnumerator Spawn()
    {
        /*for (int i = 0; i < 20; i++)
        {
            yield return new WaitForSeconds(spawnTime);
            spawnTime = Random.Range(3, 9);
            float speedEnemy = Random.Range(2f, 4f);
            EnemyGremlin enemyObjEnemy = enemy.GetComponent<EnemyGremlin>();
            enemyObjEnemy.speedEnemy = speedEnemy;
            Instantiate(enemy, transform.position, Quaternion.identity);
        }
        yield return new WaitForSeconds(15f);
        for (int i = 0; i < 20; i++)
        {           
            yield return new WaitForSeconds(spawnTime);
            spawnTime = Random.Range(3, 9);
            float speedSword = Random.Range(1f, 3f);
            MovingEnemy enemyObjSword = enemySword.GetComponent<MovingEnemy>();
            enemyObjSword.speedEnemy = speedSword;
            Instantiate(enemySword, transform.position, Quaternion.identity);        
        }
        yield return new WaitForSeconds(15f);
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(spawnTime);
            spawnTime = Random.Range(3, 9);
            float speedSword = Random.Range(1f, 3f);
            MovingEnemy enemyObjSword = enemySword.GetComponent<MovingEnemy>();
            enemyObjSword.speedEnemy = speedSword;
            Instantiate(enemySword, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
            float speedRonin = Random.Range(1f, 3f);
            MovingEnemy enemyObjRonin = enemyRonin.GetComponent<MovingEnemy>();
            enemyObjRonin.speedEnemy = speedRonin;
            Instantiate(enemyRonin, transform.position, Quaternion.identity);
        }
        yield return new WaitForSeconds(15f);*/
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(spawnTime);
            spawnTime = Random.Range(3, 9);
            float speedRonin = Random.Range(1f, 3f);
            MovingEnemy enemyObjRonin = enemyRonin.GetComponent<MovingEnemy>();
            enemyObjRonin.speedEnemy = speedRonin;
            Instantiate(enemyRonin, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
            float speedArmor = Random.Range(1f, 3f);
            MovingEnemy enemyObjArmor = enemyArmor.GetComponent<MovingEnemy>();
            enemyObjArmor.speedEnemy = speedArmor;
            Instantiate(enemyArmor, transform.position, Quaternion.identity);
        }
        yield return new WaitForSeconds(15f);
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(spawnTime);
            spawnTime = Random.Range(3, 9);
            float speedArmor = Random.Range(1f, 3f);
            MovingEnemy enemyObjArmor = enemyArmor.GetComponent<MovingEnemy>();
            enemyObjArmor.speedEnemy = speedArmor;
            Instantiate(enemyArmor, transform.position, Quaternion.identity);
            if (i == 3 || i == 6 || i == 9)
            {
                yield return new WaitForSeconds(spawnTime);
                float speedHunter = Random.Range(1f, 3f);
                HunterEnemy enemyObjHunter = enemyHunter.GetComponent<HunterEnemy>();
                enemyObjHunter.speedEnemy = speedHunter;
                Instantiate(enemyHunter, transform.position, Quaternion.identity);
            }
        }
        yield return new WaitForSeconds(15f);
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(spawnTime);
            spawnTime = Random.Range(3, 9);
            float speedSword = Random.Range(1f, 3f);
            MovingEnemy enemyObjSword = enemySword.GetComponent<MovingEnemy>();
            enemyObjSword.speedEnemy = speedSword;
            Instantiate(enemySword, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
            float speedOni = Random.Range(1f, 2f);
            MovingEnemy enemyObjOni = enemyOni.GetComponent<MovingEnemy>();
            enemyObjOni.speedEnemy = speedOni;
            Instantiate(enemyOni, transform.position, Quaternion.identity);
        }
        yield return new WaitForSeconds(15f);
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(spawnTime);
            spawnTime = Random.Range(3, 9);
            float speedArmor = Random.Range(1f, 3f);
            MovingEnemy enemyObjArmor = enemyArmor.GetComponent<MovingEnemy>();
            enemyObjArmor.speedEnemy = speedArmor;
            Instantiate(enemyArmor, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
            float speedOniSword = Random.Range(1f, 2f);
            MovingEnemy enemyObjOniSword = enemyOniSword.GetComponent<MovingEnemy>();
            enemyObjOniSword.speedEnemy = speedOniSword;
            Instantiate(enemyOniSword, transform.position, Quaternion.identity);
        }
        yield return new WaitForSeconds(15f);
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(spawnTime);
            spawnTime = Random.Range(3, 9);
            float speedSword = Random.Range(1f, 3f);
            MovingEnemy enemyObjSword = enemySword.GetComponent<MovingEnemy>();
            enemyObjSword.speedEnemy = speedSword;
            Instantiate(enemySword, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
            float speedDragon = Random.Range(1f, 2f);
            DragonEnemy enemyObjDragon = enemyDragon.GetComponent<DragonEnemy>();
            enemyObjDragon.speedEnemy = speedDragon;
            Instantiate(enemyDragon, transform.position, Quaternion.identity);
        }
        yield return new WaitForSeconds(15f);
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(spawnTime);
            spawnTime = Random.Range(3, 9);
            float speedSword = Random.Range(1f, 3f);
            MovingEnemy enemyObjSword = enemySword.GetComponent<MovingEnemy>();
            enemyObjSword.speedEnemy = speedSword;
            Instantiate(enemySword, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
            float speedDragon = Random.Range(1f, 2f);
            DragonEnemy enemyObjDragon = enemyDragon.GetComponent<DragonEnemy>();
            enemyObjDragon.speedEnemy = speedDragon;
            Instantiate(enemyDragon, transform.position, Quaternion.identity);
        }
        yield return new WaitForSeconds(15f);
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(spawnTime);
            spawnTime = Random.Range(3, 9);
            float speedEnemy = Random.Range(2f, 4f);
            EnemyGremlin enemyObjEnemy = enemy.GetComponent<EnemyGremlin>();
            enemyObjEnemy.speedEnemy = speedEnemy;
            Instantiate(enemy, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
            float speedSword = Random.Range(1f, 3f);
            MovingEnemy enemyObjSword = enemySword.GetComponent<MovingEnemy>();
            enemyObjSword.speedEnemy = speedSword;
            yield return new WaitForSeconds(spawnTime);
            Instantiate(enemySword, transform.position, Quaternion.identity);
            float speedRonin = Random.Range(1f, 3f);
            MovingEnemy enemyObjRonin = enemyRonin.GetComponent<MovingEnemy>();
            enemyObjRonin.speedEnemy = speedRonin;
            Instantiate(enemyRonin, transform.position, Quaternion.identity);
        }
        yield return new WaitForSeconds(15f);
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(spawnTime);
            spawnTime = Random.Range(3, 9);            
            float speedEnemy = Random.Range(2f, 4f);
            EnemyGremlin enemyObjEnemy = enemy.GetComponent<EnemyGremlin>();
            enemyObjEnemy.speedEnemy = speedEnemy;
            Instantiate(enemy, transform.position, Quaternion.identity);
            if (i == 3 || i == 6 || i == 9)
            {
                yield return new WaitForSeconds(spawnTime);
                float speedHunter = Random.Range(1f, 3f);
                HunterEnemy enemyObjHunter = enemyHunter.GetComponent<HunterEnemy>();
                enemyObjHunter.speedEnemy = speedHunter;
                Instantiate(enemyHunter, transform.position, Quaternion.identity);
            }
            yield return new WaitForSeconds(spawnTime);
            float speedOniSword = Random.Range(1f, 2f);
            MovingEnemy enemyObjOniSword = enemyOniSword.GetComponent<MovingEnemy>();
            enemyObjOniSword.speedEnemy = speedOniSword;
            Instantiate(enemyOniSword, transform.position, Quaternion.identity);
        }
        yield return new WaitForSeconds(15f);
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(spawnTime);
            spawnTime = Random.Range(3, 9);            
            float speedEnemy = Random.Range(2f, 4f);
            EnemyGremlin enemyObjEnemy = enemy.GetComponent<EnemyGremlin>();
            enemyObjEnemy.speedEnemy = speedEnemy;
            Instantiate(enemy, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
            float speedDragon = Random.Range(1f, 2f);
            DragonEnemy enemyObjDragon = enemyDragon.GetComponent<DragonEnemy>();
            enemyObjDragon.speedEnemy = speedDragon;
            Instantiate(enemyDragon, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);            
            float speedArmor = Random.Range(1f, 2f);
            MovingEnemy enemyObjArmor = enemyArmor.GetComponent<MovingEnemy>();
            enemyObjArmor.speedEnemy = speedArmor;
            Instantiate(enemyArmor, transform.position, Quaternion.identity);
        }
        yield return new WaitForSeconds(15f);
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(spawnTime);
            spawnTime = Random.Range(3, 9);
            float speedOniSword = Random.Range(1f, 2f);
            MovingEnemy enemyObjOniSword = enemyOniSword.GetComponent<MovingEnemy>();
            enemyObjOniSword.speedEnemy = speedOniSword;
            Instantiate(enemyOniSword, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
            float speedDragon = Random.Range(1f, 2f);
            DragonEnemy enemyObjDragon = enemyDragon.GetComponent<DragonEnemy>();
            enemyObjDragon.speedEnemy = speedDragon;
            Instantiate(enemyDragon, transform.position, Quaternion.identity);
            if (i == 4 || i == 8)
            {
                yield return new WaitForSeconds(spawnTime);
                float speedHunter = Random.Range(1f, 3f);
                HunterEnemy enemyObjHunter = enemyHunter.GetComponent<HunterEnemy>();
                enemyObjHunter.speedEnemy = speedHunter;
                Instantiate(enemyHunter, transform.position, Quaternion.identity);
            }
        }
        yield return new WaitForSeconds(15f);
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(spawnTime);
            spawnTime = Random.Range(3, 9);
            float speedEnemy = Random.Range(2f, 4f);
            EnemyGremlin enemyObjEnemy = enemy.GetComponent<EnemyGremlin>();
            enemyObjEnemy.speedEnemy = speedEnemy;
            Instantiate(enemy, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
            float speedSword = Random.Range(1f, 3f);
            MovingEnemy enemyObjSword = enemySword.GetComponent<MovingEnemy>();
            enemyObjSword.speedEnemy = speedSword;
            yield return new WaitForSeconds(spawnTime);
            Instantiate(enemySword, transform.position, Quaternion.identity);
            float speedRonin = Random.Range(1f, 3f);
            MovingEnemy enemyObjRonin = enemyRonin.GetComponent<MovingEnemy>();
            enemyObjRonin.speedEnemy = speedRonin;
            Instantiate(enemyRonin, transform.position, Quaternion.identity);
            float speedArmor = Random.Range(1f, 2f);
            MovingEnemy enemyObjArmor = enemyArmor.GetComponent<MovingEnemy>();
            enemyObjArmor.speedEnemy = speedArmor;
            Instantiate(enemyArmor, transform.position, Quaternion.identity);
        }
        yield return new WaitForSeconds(15f);
        while(true)
        {
            yield return new WaitForSeconds(3f);
            int i = Random.Range(0, 7);
            Instantiate(enemys[i], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(5f);
            int x = Random.Range(0, 7);
            Instantiate(enemys[x], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(7f);
            int y = Random.Range(0, 7);
            Instantiate(enemys[y], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(9f);
            int z = Random.Range(0, 7);
            Instantiate(enemys[z], transform.position, Quaternion.identity);
        }
    }
}
