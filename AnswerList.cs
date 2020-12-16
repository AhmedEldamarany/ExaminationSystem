using System;
using System.Collections.Generic;
using System.IO;

namespace ExaminationSystem
{
    class AnswerList : List<Answer>
    {
        private string _id;
        private StreamWriter writer;

      
        public AnswerList(string id)
        {
            _id = id;
        }
        public new void Add(Answer a)
        {

            writer = File.AppendText("answerlist.txt");
            writer.WriteLine(a.ToString());
            base.Add(a);

        }
        // public Question Get(){
        //     return 
        // }
        ~AnswerList(){
            writer.Close();
            writer.Dispose();
        }


    }
}
