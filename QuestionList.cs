using System;
using System.Collections.Generic;
using System.IO;

namespace ExaminationSystem
{
    class QuestionList : List<Question>
    {
        private string _id;
        private  StreamWriter writer;
       
        public QuestionList(string id)
        {
            _id = id;
        }
        public new void Add(Question q)
        {
            //do other things

            base.Add(q);
             writer = File.AppendText("questionlist.txt");
            writer.WriteLine(q.ToString());


        }
        ~QuestionList()
        {
            writer.Close();
            writer.Dispose();
        }


    }
}
