using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetupGame : MonoBehaviour
{
    public int numberToSpawn = 1;

    private int enemiesKilled = 0;


    public GameObject enemy;
    //private GameObject[] enemyArray;
    private List<GameObject> enemyList = new List<GameObject>();

    public GameOverScreen gameOverScreen;
    public HealthPlayer healthPlayer;

    public GameObject respawnPoint1;
    public GameObject respawnPoint2;
    public GameObject respawnPoint3;
    public GameObject respawnPoint4;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies(numberToSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        CheckEnemies();
        //SpawnEnemies(numberToSpawn);
        
        if (healthPlayer.isDead == true)
        {
            GameOver();

            /*
            if (Input.GetKeyDown(KeyCode.R))
            {
                //gameOverScreen.RestartButton();
                Debug.Log("R");
                SceneManager.LoadScene("Base Scene");
            }
            */
        }
    }


    private void SpawnEnemies(int number)
    {
        /*
        foreach (GameObject e in enemyList)
        {
            Destroy(e);
        }
        
        
        */
        //enemyList.Clear();

        for (int i = 0; i < number; i++)
        {
            GameObject newEnemy = Instantiate(enemy);
            newEnemy.GetComponentInChildren<Health>().Respawn();
            enemyList.Add(newEnemy);
        }
        foreach (GameObject e in enemyList)
        {
            //e.SetActive(true);
            e.transform.position = EnemySpawnLocation();
            //GameObject e1 = e.transform.Find("Enemy1");
        }

        //Delete old ragdolls
        List<int> indexList = new List<int>();
        for (int i = 0; i < enemyList.Count; i++)
        {
            if (enemyList[i].GetComponentInChildren<Health>().currentHealth <= 0) //isDead)
            {
                indexList.Add(i);
            }
        }

        int temp = 0;
        foreach(int i in indexList)
        {
            GameObject go = enemyList[i - temp];
            enemyList.Remove(go);
            Destroy(go);
            temp++;
        }
    }

    private void CheckEnemies()
    {
        
        bool allDead = true;
        
        foreach (GameObject e in enemyList)
        {
            if (!(e.GetComponentInChildren<Health>().currentHealth <= 0)) //isDead)
            {
                //enemiesKilled++;
                //numberToSpawn++;
                allDead = false;
            }
            
            /*
            else
            {
                enemyList.Remove(e);
                Destroy(e);
            } //maybe destroy after spawning 
            */
            
        }

        Debug.Log(allDead);

        if(allDead)
        {
            numberToSpawn++;
            SpawnEnemies(numberToSpawn);
            allDead = false;
        }
        Debug.Log(numberToSpawn);

        allDead = false;

        /*
        if (enemyList.Count == 0)
        {
            numberToSpawn++;
            SpawnEnemies(numberToSpawn);
        }
        */

        //if(allDead)
        //{

        //}
    }


    public void GameOver()
    {
        //if (healthPlayer.isDead)
        //{
        foreach (GameObject e in enemyList)
        {
            if (e.GetComponentInChildren<Health>().isDead)
            {
                enemiesKilled++;
            }
        }
        numberToSpawn = 1;
        gameOverScreen.Setup(enemiesKilled);
        //}

        
    }


    private Vector3 EnemySpawnLocation()
    {
        int location = Random.Range(1, 4);
        Vector3 spawnPosition = new Vector3(-8f,10f,0);

        switch (location)
        {
            case (1):
                //spawnPosition = new Vector3(5.6f, 0f, 0f);
                //spawnPosition = new Vector3(-9.91f, 10.81f, -2.68f);
                spawnPosition = respawnPoint1.transform.position;
                break;
            case (2):
                //spawnPosition = new Vector3(-35f, 0f, 45f);
                //spawnPosition = new Vector3(-9.91f, 10.81f, -2.68f);
                spawnPosition = respawnPoint2.transform.position;
                break;
            case (3):
                //spawnPosition = new Vector3(-85f, 0f, 0f);
                //spawnPosition = new Vector3(-9.91f, 10.81f, -2.68f);
                spawnPosition = respawnPoint3.transform.position;
                break;
            case (4):
                //spawnPosition = new Vector3(-35f, 0f, -45f);
                //spawnPosition = new Vector3(-9.91f, 10.81f, -2.68f);
                spawnPosition = respawnPoint4.transform.position;
                break;
        }

        return spawnPosition;
    }
}
