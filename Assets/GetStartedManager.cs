using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetStartedManager : MonoBehaviour
{
    // Start is called before the first frame update
   public  GameObject signuppanel,getstartedpanel;
    public void ButtonClick()
    {
        getstartedpanel.SetActive(false);
        signuppanel.SetActive(true);
    }
}
