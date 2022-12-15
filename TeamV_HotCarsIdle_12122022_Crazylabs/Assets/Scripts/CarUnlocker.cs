using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarUnlocker : MonoBehaviour
{
    [SerializeField] List<GameObject> unlockedCarImages = new List<GameObject>();
    List<bool> isUnlockedBeforeList = new List<bool>();
    bool car1Unlocked;
    bool car2Unlocked;
    bool car3Unlocked;
    bool car4Unlocked;
    bool car5Unlocked;
    bool car6Unlocked;
    bool car7Unlocked;
    

    private void Start()
    {
        isUnlockedBeforeList.Add(car1Unlocked);
        isUnlockedBeforeList.Add(car2Unlocked);
        isUnlockedBeforeList.Add(car3Unlocked);
        isUnlockedBeforeList.Add(car4Unlocked);
        isUnlockedBeforeList.Add(car5Unlocked);
        isUnlockedBeforeList.Add(car6Unlocked);
        isUnlockedBeforeList.Add(car7Unlocked);
        UnlockCar(0);

    }

    public void UnlockCar(int unlockedCarIndex)
    {
        if (isUnlockedBeforeList[unlockedCarIndex])
            return;


        isUnlockedBeforeList[unlockedCarIndex] = true;
        unlockedCarImages[unlockedCarIndex].SetActive(true);
        StartCoroutine(CloseUnlocCarDelay(unlockedCarIndex));
    }

    IEnumerator CloseUnlocCarDelay(int unlockedCarIndex)
    {
        yield return new WaitForSeconds(2f);
        unlockedCarImages[unlockedCarIndex].SetActive(false);
    }

}
