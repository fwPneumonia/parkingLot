using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carLots : MonoBehaviour
{
    parkingLots parkingLots;
    // Start is called before the first frame update
    void Start()
    {
        parkingLots=transform.parent.GetComponent<parkingLots>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col){
        if(col.transform.tag=="CarTag"){
                parkingLots.setCarLotCount((parkingLots.getCarLotCount())-1);

        }else{
            Debug.Log("You can't park here!");
        }
    }
    private void OnTriggerExit(Collider col){
        if(col.transform.tag=="CarTag"){
            parkingLots.setCarLotCount((parkingLots.getCarLotCount())+1);
        }
    }
    
}
