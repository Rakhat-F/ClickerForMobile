using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bomb : MonoBehaviour
{
    [SerializeField] 
    ParticleSystem bombRadius = null;

    public Score score;

    private void Awake()
    {
        bombRadius.Stop();
    }

    // Start is called before the first frame update
    public void allDestroy()
    {
        GameObject[] Cubes = (GameObject.FindGameObjectsWithTag("Cube") as GameObject[]);

        for (int i = 0; i < Cubes.Length; i++)
        {
            Destroy(Cubes[i]);
        }

        score = GameObject.FindGameObjectWithTag("Text").GetComponent<Score>();
        score.score += 1000;

        bombRadius.Play();

        gameObject.GetComponent<Image>().enabled = false;

        StartCoroutine(reloadBomb());

        IEnumerator reloadBomb()
        {
            yield return new WaitForSeconds(10f);
            gameObject.GetComponent<Image>().enabled = true;
        }
    }
}
