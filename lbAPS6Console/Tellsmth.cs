﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lbAPS6Console
{
    class AskMe:IAskable
    {
        public AskMe(string ask,string answer)
        {
            this._ask = ask;
            this._answer = answer;
        }
        private string _ask;
        private string _answer;
        private string _useranswer;
        public ITalkable talk { get; set; }

        public void Ask()
        {
            talk.ShowAsk(_ask);
            _useranswer=talk.GetUserAnswer();
            talk.ShowAnswer(_answer);
        }                
    }

    #region LetMeTellYou

    class ConsoleTell : ITalkable
    {
        public string GetUserAnswer()
        {
            var variable = Console.ReadLine();
            return variable;
        }

        public void ShowAnswer(string answer)
        {
            Console.WriteLine(answer);
        }

        public void ShowAsk(string ask)
        {
            Console.Write(ask);
        }
    }

    class WebTell : ITalkable
    {
        public string GetUserAnswer()
        {
            var variable = Console.ReadLine();
            return variable;
        }

        public void ShowAnswer(string answer)
        {
            Console.WriteLine("<input value='"+answer+"'>");
        }

        public void ShowAsk(string ask)
        {
            Console.Write("<input value='"+ask+"'>");
        }
    }

    #endregion
}
