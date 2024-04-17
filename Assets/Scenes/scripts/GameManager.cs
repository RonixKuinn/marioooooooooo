using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //PARA
    public list<gameObject> enemiesInScreen;

    public void enemiesInScreen()
    {
        foreach (gameObject enemy in enemies)
        {
            Destroy(enemy);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R));
        {
            DestroyenemiesInScreen();
        }
    }
}
