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
        MCQ mcq1;
        public FinalExam(int time, int questions_Number) : base(time, questions_Number)
        {
            QuestionList MCQs = new QuestionList("mcq1", "Multiple Choise Questions");
            Answer a1 = new Answer("egypt", true);
            Answer a2 = new Answer("china", true);
            Answer a3 = new Answer("japan", true);
            Answer a4 = new Answer("india", true);
            AnswerList answers = new AnswerList("1");
            answers.Add(a1);
            answers.Add(a2);
            answers.Add(a3);
            answers.Add(a4);
             mcq1 = new MCQ(10,  "where are you from?",answers);


        }
        public override void ShowExam()
        {
            base.ShowExam();
           
                Console.WriteLine(mcq1.ToString());

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