using System;
namespace ExaminationSystem
{
    class Answer
    {
        public string _answer{ get;}
        public bool _isCorect {get;}
        public bool _chosen{set; get;}
        
        public Answer(string answer,bool isCorect)
        {
            _answer = answer;
            _isCorect=isCorect;
        }
        public override string ToString()
        {
            return $" {_answer} ";
        }
    }
}