using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Freeze : MonoBehaviour
{  

    // Start is called before the first frame updat
    // Update is called once per frame
    public void allFreeze()
    {

        Time.timeScale = 0;

        StartCoroutine(freezing());

        IEnumerator freezing()
        {
            yield return new WaitForSecondsRealtime(3f);
            Time.timeScale = 1;
        }

        gameObject.GetComponent<Image>().enabled = false;

        StartCoroutine(reloadBomb());

        IEnumerator reloadBomb()
        {
            yield return new WaitForSeconds(10f);
            gameObject.GetComponent<Image>().enabled = true;
        }
    }
}
