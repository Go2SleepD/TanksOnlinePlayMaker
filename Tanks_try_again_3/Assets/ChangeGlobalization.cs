using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;
using System.Threading;

public class ChangeGlobalization : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(840, 600, false);
        var culture = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentCulture = culture;
        Thread.CurrentThread.CurrentUICulture = culture;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
