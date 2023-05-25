using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMananger : MonoBehaviour
{
    // Start is called before the first frame update
    public bool kör;
    public bool Ninjalås;
    void Start()
    {
        kör = false;
        Ninjalås = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeKör()
    {
        if (kör == true)
            kör = false;
        else
            kör = true;
    }
    public void changeNinjalås()
    {
        if (Ninjalås == true)
            Ninjalås = false;
        else
            Ninjalås = true;
    }
    public bool PlayerStatus()
    {
        return Ninjalås;
    }
    public bool AxeManStatus()
    {
        return kör;
    }
}
