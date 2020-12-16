using System;
namespace ExaminationSystem
{
    abstract class Question
    {
        public string _body { set; get; }
        public int _marks { set; get; }
        public int _grade { protected set; get; }
        public string _header { set; get; }
        public AnswerList _answers{get;protected set;}
        public override string ToString()
        {
            return $"{_body},{_header},{_marks}";
            //TODO add the answerlist to it to be added to the log File
        }

    }
    class MCQ : Question
    {
       public MCQ(int marks,string body, string header ,AnswerList answers)
        {
            _marks = marks;
            _body=body;
            _header=header;
            _answers=answers;


        }
        class TrueAndFalse:Question{
            TrueAndFalse(int marks,string body, string header,AnswerList answers )
        {
            _marks = marks;
            _body=body;
            _header=header;
            _answers=answers;
        }
        }
    }
}