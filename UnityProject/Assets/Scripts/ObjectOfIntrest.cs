using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOfIntrest : MonoBehaviour
{

    [SerializeField]
    private GameObject poi;
    [SerializeField]
    private GameObject poi2;

    [SerializeField]
    private bool disableOnLeave = false;
    [SerializeField]
    private bool enableOnEnter = true;

    public void OnPointerEnter()
    {
        if (enableOnEnter){
            poi.SetActive(true);
            poi2.SetActive(true);
        }
    }

    public void OnPointerExit() {
        if (disableOnLeave){
            poi.SetActive(false);
            poi2.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
