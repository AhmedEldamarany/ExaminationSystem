using System;
using System.Collections.Generic;
namespace ExaminationSystem
{
    enum Mode
    {
        starting,
        queued,
        finished
    }
    enum Subject
    {
        maths,
        physics,
        advanced_mathematics,
        physics_201,
        maths_101,

    }
    class Exam
    {
        public int _time { get; }
        protected Mode examMode;
        public int _questions_Number { set; get; }
        Dictionary<Question, Answer> _qustion_Answer_Dictionary { set; get; }
        public Exam(int time, int questions_Number)
        {
            _time = time;
            _questions_Number = questions_Number;

            // QuestionList MCQs=new QuestionList("mcq1");
            // QuestionList Trues=new QuestionList("tf1");
        }
        public virtual void ShowExam() { examMode = Mode.starting; }

    }
    class FinalExam : Exam
    {
        public FinalExam(int time, int questions_Number) : base(time, questions_Number)
        {
            //Todo initialize the dictionary and get the qustions and all the answers 
        }
        public override void ShowExam()
        {
            base.ShowExam();
            //TODO show all questions and all answers 
        }
    }
    class PracticeExam : Exam
    {
        public PracticeExam(int time, int questions_Number) : base(time, questions_Number)
        {
            //Todo initialize the dictionary and get the qustions and all the answers 
            //get the subject 
        }
        public override void ShowExam()
        {
            base.ShowExam();
            //TODO show all questions and all answers 
        }
    }
}