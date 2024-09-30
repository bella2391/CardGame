using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        new Deck().AddCard(new Card("Copper", 0, "+1 Money"));
        Logger logger = new Logger(Debug.unityLogger.logHandler);
        logger.Log("Adds Draw Card");
    }

    // Update is called once per frame
    void Update() {

    }
}
