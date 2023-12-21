using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishActivator : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Finish finish = other.gameObject.GetComponent<Finish>();
        if (finish)
        {
            finish.FinishScreen();
            finish.GameFinish();
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
