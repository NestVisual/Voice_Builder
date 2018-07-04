using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class SpeechManager : MonoBehaviour
{

    KeywordRecognizer keywordRecognizer = null;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    // Use this for initialization
    void Start()
    {
        keywords.Add("Reset world", () =>
        {
            this.BroadcastMessage("OnReset");
        });

        keywords.Add("Up", () =>
        {
            this.BroadcastMessage("OnUp");
        });

        keywords.Add("Down", () =>
        {
            this.BroadcastMessage("OnDown");
        });

        keywords.Add("Take", () =>
        {
            this.BroadcastMessage("OnTake");
        });

        keywords.Add("Delete", () =>
        {
            this.BroadcastMessage("OnDelete");
        });

        keywords.Add("Nest", () =>
        {
            this.BroadcastMessage("OnDrop");
        });

        keywords.Add("Green", () =>
        {
            this.BroadcastMessage("OnGreen");
        });

        keywords.Add("Blue", () =>
        {
            this.BroadcastMessage("OnBlue");
        });

        keywords.Add("Hello", () =>
        {
            this.BroadcastMessage("OnHello");
        });

        keywords.Add("Love", () =>
        {
            this.BroadcastMessage("OnLove");
        });

        keywords.Add("Peace", () =>
        {
            this.BroadcastMessage("OnPeace");
        });

        keywords.Add("Red", () =>
        {
            this.BroadcastMessage("OnRed");
        });

        // Tell the KeywordRecognizer about our keywords.
        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());

        // Register a callback for the KeywordRecognizer and start recognizing!
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizer_OnPhraseRecognized;
        keywordRecognizer.Start();
    }

    private void KeywordRecognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        System.Action keywordAction;
        if (keywords.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke();
        }
    }
}
