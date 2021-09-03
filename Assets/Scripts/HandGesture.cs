using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandGesture : MonoBehaviour
{
    private OVRHand hand;
    private Text text;
    
    // Start is called before the first frame update
    void Start()
    {
        hand = GetComponent<OVRHand>();
        text = GameObject.Find("Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isIndexFingerPinching = hand.GetFingerIsPinching(OVRHand.HandFinger.Index);
        float indexFingerPinchStrength = hand.GetFingerPinchStrength(OVRHand.HandFinger.Index);
        OVRHand.TrackingConfidence confidence = hand.GetFingerConfidence(OVRHand.HandFinger.Index);
        
        Debug.Log("isIndexFingerPinching: " + isIndexFingerPinching);
        Debug.Log("indexFingerPinchStrength: " + indexFingerPinchStrength);
        Debug.Log("index confidence: " + confidence);
        text.text = "isIndexFingerPinching: " + isIndexFingerPinching + "\n" +
                    "indexFingerPinchStrength: " + indexFingerPinchStrength + "\n" +
                    "index confidence: " + confidence;
    }
}
