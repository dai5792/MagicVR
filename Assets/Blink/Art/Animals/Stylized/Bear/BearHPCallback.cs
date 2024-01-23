using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearHPCallback : MonoBehaviour
{
    // Start is called before the first frame update

    private void Awake()
    {
        HP hp = gameObject.GetComponent<HP>();
        hp.OnChangeHandler += OnHPChange;
    }

    void OnHPChange(object target,double value)
    {
        if (value == 0) {
            //Destroy(gameObject);
            Debug.Log(value);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
