using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
            writer.Close();
            writer.Dispose();
            base.Add(a);

        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
           
            
            
            foreach (var item in this)
                stringBuilder.Append( item.ToString());
         
            return stringBuilder.ToString() ;
        }

      


    }
}
