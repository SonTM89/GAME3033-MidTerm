using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AwardBehaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Award")
        {
            Debug.Log("Win");
            StartCoroutine(Win("GameOverScene", 0.3f));
        }
        
    }

    IEnumerator Win(string _name, float _delay)
    {
        yield return new WaitForSeconds(_delay);
        SceneManager.LoadScene(_name);
    }
}
