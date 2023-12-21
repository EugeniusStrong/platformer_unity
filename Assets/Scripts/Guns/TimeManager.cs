using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float TimeScale = 0.2f;
    private float _startFixedDeltaTime;
    public GameObject WhiteBackGround;

    private void Start()
    {
        _startFixedDeltaTime = Time.fixedDeltaTime;
    }
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Time.timeScale = TimeScale;
            WhiteBackGround.SetActive(true);
        }
        else
        {
            Time.timeScale = 1f;
            WhiteBackGround.SetActive(false);
        }

        Time.fixedDeltaTime = 0.02f * Time.timeScale;
    }
    private void OnDestroy()
    {
        Time.fixedDeltaTime = _startFixedDeltaTime;
    }
}
