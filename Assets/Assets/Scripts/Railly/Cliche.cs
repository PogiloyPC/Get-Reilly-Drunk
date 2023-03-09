using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cliche : MonoBehaviour
{        
    [SerializeField] private GameObject imagePhrases;
    [SerializeField] private Text textPhrases;
    public float distanceY;
    public float distanceZ;
    public string[] clichePhrases;
    public float timerStartPhrases;
    public float timerFinishPhrases;
    
    void Start()
    {
        imagePhrases.SetActive(false);
        textPhrases.gameObject.SetActive(false);        
        StartCoroutine(CreatePhrases());
    }
    
    void Update()
    {        
        imagePhrases.transform.position = new Vector3(transform.position.x, transform.position.y + distanceY, transform.position.z + distanceZ);       
    }

    private IEnumerator CreatePhrases()
    {
        while (true)
        {
            yield return new WaitForSeconds(timerStartPhrases);
            int idPhrases = Random.Range(0, 10);
            for (int i = 0; i < clichePhrases.Length; i++)
            {
                if (i == idPhrases)
                {
                    imagePhrases.SetActive(true);
                    textPhrases.gameObject.SetActive(true);
                    textPhrases.text = clichePhrases[i];                    
                }
            }
            yield return new WaitForSeconds(timerFinishPhrases);
            imagePhrases.SetActive(false);
            textPhrases.gameObject.SetActive(false);
        }
    }
}
