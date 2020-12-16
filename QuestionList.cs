using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExaminationSystem
{
    class QuestionList : List<Question>
    {
        private string _id;
        private  StreamWriter writer;
        public string _title { set; get; }
       
        public QuestionList(string id,string title)
        {
            _title = title;
            _id = id;
        }
        public new void Add(Question q)
        {
            base.Add(q);
             writer = File.AppendText("questionlist.txt");
            writer.WriteLine(q.ToString());
            writer.Close();
            writer.Dispose();
                }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in this)
                stringBuilder.Append(item.ToString());
            return stringBuilder.ToString();

        }

    }
}
