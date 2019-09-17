using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parkingLots : MonoBehaviour
{
    public static int truckLotCount=2;
    public static int carLotCount=10;
    public static int bicycleLotCount=8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log("BicycleLots:"+bicycleLotCount+"CarLots:"+carLotCount+"TruckLots"+truckLotCount);
    }
    public static void  setCarLotCount(int count)
    {
        carLotCount=count;
    }
    public  int  getCarLotCount(){
        return carLotCount;
    }
    public static void  setTruckLotCount(int count)
    {
        truckLotCount=count;
    }
    public  int  getTruckLotCount(){
        return truckLotCount;
    }
    public static void  setBicycleLotCount(int count)
    {
        bicycleLotCount=count;
    }
    public  int  getBicycleLotCount(){
        return bicycleLotCount;
    }

    
}
