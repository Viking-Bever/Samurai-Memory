using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMananger : MonoBehaviour
{
    // Start is called before the first frame update
    public bool k�r;
    public bool Ninjal�s;
    void Start()
    {
        k�r = false;
        Ninjal�s = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeK�r()
    {
        if (k�r == true)
            k�r = false;
        else
            k�r = true;
    }
    public void changeNinjal�s()
    {
        if (Ninjal�s == true)
            Ninjal�s = false;
        else
            Ninjal�s = true;
    }
    public bool PlayerStatus()
    {
        return Ninjal�s;
    }
    public bool AxeManStatus()
    {
        return k�r;
    }
}
