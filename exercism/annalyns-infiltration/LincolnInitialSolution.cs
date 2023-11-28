using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if(knightIsAwake){
            return false;
        }
        else{
            return true;
        }
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if(knightIsAwake || archerIsAwake || prisonerIsAwake){
            return true;
        }
        else{
            return false;
        }
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (archerIsAwake){
            return false;
        }
        else{
            if(prisonerIsAwake){
                return true;
            }
            else{
                return false;
            }
        }
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(petDogIsPresent){
            if(archerIsAwake == false){
                return true;
            }
            else{
                return false;
            }
        }
        else{
            if(prisonerIsAwake && archerIsAwake == false && knightIsAwake == false){
                return true;
            }
            else{
                return false;
            }
        }
    }
}
