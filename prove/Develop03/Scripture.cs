using System;

class Scripture
{
    // Attributes
    private Reference _scriptureReference;
    private List<Word> _words;

    // Constructor
    public Scripture(Reference scriptureReference, string scriptureText)
    {
        _scriptureReference = scriptureReference;
        _words = new List<Word>();
        // use the method CreateWords
        CreateWords(scriptureText);
    }

    // Methods
    public string GetScripture()
    {
        string _scriptureText = "";
        foreach (Word word in _words)
        {
            // If the word is not hidden, display it
            if (word.GetIsHidden() == false)
            {
                _scriptureText += word.GetWord() + " ";
            }
            // If the word is hidden, replace it with underscores
            else
            {
                _scriptureText += new string('_', word.GetWord().Length) + " ";
            }
        }
        return ($"{_scriptureReference.GetReference()} {_scriptureText}");
    }
    
    public void RemoveWords()
    {
        // Create a variable that returns a random integer
        // that is within a specified range (in this case, 2-4)
        int numWordsToRemove = new Random().Next(2, 4);
        // Create a variable with an initial value to be used in the function
        int wordsRemoved = 0;

        do
        {
            // Create a variable that returns a random integer
            // that is between 0 and the number of words in the list.
            // In other words, pick a random word (by index) from the scripture
            int randIndex = new Random().Next(0, _words.Count());
            // Only replace the word if it hasn't been replaced yet
                // If the word that matches the random index (randIndex)
                // is not hidden, hide it.
            if (_words[randIndex].GetIsHidden() == false)
            {
                _words[randIndex].SetIsHidden(true);
                // ++ operator increments by 1 after wordsRemoved count
                // to keep track of how many words are left in the scripture
                wordsRemoved++;
            }
        }
        // Continue to loop while the number of words removed does not equal
        // the number of words left to remove AND there are words left.
        while (wordsRemoved != numWordsToRemove && this.HasWordsLeft());
    }
    
    public bool HasWordsLeft()
    {
        bool retValue = false;

        foreach (Word _word in _words)
        {
            // If the word is not hidden, return true (meaning yes, it has words left)
            if (_word.GetIsHidden() == false)
            {
                retValue = true;
            }
        }
        // Otherwise it will just return the default value of false
        // (meaning it has no words left) and the program will end
        return retValue;
    }
    
    private void CreateWords(string scriptureText)
    {
        List<string> allWords = scriptureText.Split(' ').ToList();
        foreach (string item in allWords)
        {
            Word word = new Word(item);
            _words.Add(word);
        }
    }

}