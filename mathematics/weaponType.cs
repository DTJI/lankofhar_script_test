using UnityEngine;
using System.Collections;

public class weapon : Monobehavior{

    public object piercer;
    public object cutter;
    public object blunter;
    string type;

    public void onTriggerEnter(){

        switch (triggerObject)
        {
            case piercer:
                type = pierce;
            
            case cutter:
                type = cut;
            
            case blunter:
                type = blunt;
                                    
            default:
        }

    }
    
}