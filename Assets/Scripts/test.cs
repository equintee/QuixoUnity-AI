using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        QLearningTrain qLearningTrain = new QLearningTrain();
        qLearningTrain.Train(1000000);
        this.enabled = false;
        
    }

}
