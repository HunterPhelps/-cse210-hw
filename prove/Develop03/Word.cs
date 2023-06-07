using System;

namespace develop03
{
    public class Word
    {
        public string _word;
        private bool _hidden;

        /*
        int wordLength(word)
        {
            int count = 0;
            foreach (char c in word)
            {
                count++;
            }
            return count;
        }
        */

        public void Hide()
        {
            _hidden = true;
        }

        public void Unhide()
        {
            _hidden = false;
        }

        public string Display()
        {
            string shown;
            if (_hidden == false)
            {
                shown = _word;
            }
            else
            {
                shown = "";
                foreach (char c in _word)
                {
                    shown = shown + "_";
                }
            }
            return shown;
        }
    }
}