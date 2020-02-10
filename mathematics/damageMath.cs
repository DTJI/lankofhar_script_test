using UnityEngine;
using System.Collections;

public class damageMath : Monobehavior{

float damage;
public void damage(object atkItem,object atkChar,object defChar){

    string armor = defChar.armorType;
    string weapon = atkItem.type;
    
    
    atkDmg = (((atkChar.acceleration * atkChar.str)/10) * ((atkItem.quality)*(atkItem.abrasion)) /10);
    
    defResistence = ((defChar.armorQuality)*(defChar.armorAbrasion)/10);
    

    if(weapon == pierce){
        if(armor == rwLeather){
            damage = 0.9;
        }
        else if(armor == leather){
            damage = 0.7;
        }
        else if(armor == lghtPlate){
            damage = 0.5;
        }
        else if(armor == Plate){
            damage = 0.3;
        }
        else if(armor == heavyPlate){
            damage = 0.2;
        }
    }
    if(weapon == cut){
        if(armor == rwLeather){
            damage = 0.8;
        }
        else if(armor == leather){
            damage = 0.8;
        }
        else if(armor == lghtPlate){
            damage = 0.7;
        }
        else if(armor == Plate){
            damage = 0.5;
        }
        else if(armor == heavyPlate){
            damage = 0.3;
        }
    }
        if(weapon == blunt){
        if(armor == rwLeather){
            damage = 0.7;
        }
        else if(armor == leather){
            damage = 0.7;
        }
        else if(armor == lghtPlate){
            damage = 0.7;
        }
        else if(armor == Plate){
            damage = 0.5;
        }
        else if(armor == heavyPlate){
            damage = 0.3;
        }
    }

    finalDmg = (atkDmg - defResistence) * damage;

    return finalDmg;

    }
}