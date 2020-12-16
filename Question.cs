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
            return $"{_header} \n{_body} \n{_marks}";
        }

    }
    class MCQ : Question
    {
       public MCQ(int marks, string header ,AnswerList answers)
        {
            _marks = marks;
            _body = answers.ToString(); _header =header;
            _answers=answers;


        }
        class TrueAndFalse:Question{
            TrueAndFalse(int marks, string header,AnswerList answers )
        {
            _marks = marks;
            _body=answers.ToString();
            _header=header;
            _answers=answers;
        }
        }
    }
}