using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClientSpawner : MonoBehaviour
{
    //public toygiveaway toywt;
    public enum SpawnState { SPAWNING, WAITING, COUNTING, FINISHED};
    [System.Serializable]
    public class Wave
    {
        public string name;
        public Transform client;
        public int count;
        public float rate;
        public string toywant;
    }
    public Wave[] waves;
    private int nextWave = 0;

    public float timeBetweenWaves = 5f;
    public float waveCountdown;
    private float searchCountdown = 1f;
    private SpawnState state = SpawnState.COUNTING;

    void Start()
    {
        waveCountdown = timeBetweenWaves;
    }

    void Update()
    {
       
        if (state == SpawnState.FINISHED)
        {
            return;
        }
        if(state == SpawnState.WAITING)
        {
            if (!ClientIsAlive())
            {
               WaveCompleted();
            }
            else
            {
                return;
            }
        }

        if(waveCountdown <= 0)
        {
           if(state != SpawnState.SPAWNING)
            {
                StartCoroutine(SpawnWave(waves[nextWave]));
              
            } 
        }
        else
        {
            waveCountdown -= Time.deltaTime;
        }
    }
    void WaveCompleted()
    {
        Debug.Log("Wave Completed");
        state = SpawnState.COUNTING;
        waveCountdown = timeBetweenWaves;
        if(nextWave +1 > waves.Length - 1)
        {
            state = SpawnState.FINISHED;
            Debug.Log("Você atendeu todos os clientes hoje.");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);

        }
        else
        {
            nextWave++;
        }

       
    }
    bool ClientIsAlive()
    {
        searchCountdown -= Time.deltaTime;
        if (searchCountdown <= 0f)
        {
            searchCountdown = 1f;
            if (GameObject.FindGameObjectWithTag("Enemy") == null)
            {
                return false;
            }
        }
        return true;
    }
    IEnumerator SpawnWave (Wave _wave)
    {
        
        Debug.Log("Spawning Wave: "+ _wave.name);
        state = SpawnState.SPAWNING;
        for (int i = 0; i < _wave.count; i++)
        {
            SpawnClient(_wave.client, _wave.toywant);
            yield return new WaitForSeconds(1f / _wave.rate); 
        }

        state = SpawnState.WAITING;
        yield break;
    }

    void SpawnClient (Transform _client, string toyWant)
    {
        ClientInteraction NovoCLiente = Instantiate (_client, transform.position, transform.rotation).GetComponent<ClientInteraction>();
        NovoCLiente.toywant = toyWant;

        Debug.Log("Spawning Client"+ _client.name);
    }
}
