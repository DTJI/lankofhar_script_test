using UnityEngine;
using System.Collections;

public class damageMath : Monobehavior{

float damageType;
public void damage(atkItem, atkChar, defChar){

    string armor = defChar.armorType;
    string weapon = atkItem.type;
    
    
    atkDmg = (((atkChar.acceleration * atkChar.str)/10) * ((atkItem.quality)*(atkItem.abrasion)) /10);
    
    defResistence = ((defChar.armorQuality)*(defChar.armorAbrasion)/10);
    

    if(weapon == pierce){
        if(armor == rwLeather){
            damageType = 0.9;
        }
        else if(armor == leather){
            damageType = 0.7;
        }
        else if(armor == lghtPlate){
            damageType = 0.5;
        }
        else if(armor == Plate){
            damageType = 0.3;
        }
        else if(armor == heavyPlate){
            damageType = 0.2;
        }
    }
    if(weapon == cut){
        if(armor == rwLeather){
            damageType = 0.8;
        }
        else if(armor == leather){
            damageType = 0.8;
        }
        else if(armor == lghtPlate){
            damageType = 0.7;
        }
        else if(armor == Plate){
            damageType = 0.5;
        }
        else if(armor == heavyPlate){
            damageType = 0.3;
        }
    }
        if(weapon == blunt){
        if(armor == rwLeather){
            damageType = 0.7;
        }
        else if(armor == leather){
            damageType = 0.7;
        }
        else if(armor == lghtPlate){
            damageType = 0.7;
        }
        else if(armor == Plate){
            damageType = 0.5;
        }
        else if(armor == heavyPlate){
            damageType = 0.3;
        }
    }


    
    
    finalDmg = (atkDmg - defResistence) * damageType;
    
    }
    
    return finalDmg;

}