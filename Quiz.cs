﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defaultwinform
{
    internal class Quiz
    {
        List<Question> questions = new List<Question>();
        String imageURL;
        String topic;

        String quizID;

        Boolean autoGrade;
        Boolean allowPowers;
        Boolean allowRetakes;
        Boolean rewardsStars;
        Boolean showCorrect;
        Boolean randomize;

        public Quiz(Boolean shuffle)
        {
            randomize = shuffle;
        }

        public Quiz()
        {

        }

        public void setTopic(String topic)
        {
            this.topic = topic; 
        }

        public String getTopic()
        {
            return topic;
        }

        public void setImage(String imageURL)
        {
            this.imageURL = imageURL;
        }

        public String getImage()
        {
            return imageURL;
        }

        public void addQuestion(Question question)
        {
            questions.Add(question);
        }

        public void removeQuestion(Question question)
        {
            if (questions.Contains(question))
            {
                questions.Remove(question);
            }
        }

        public Question getQuestion(Question question)
        {
            if (questions.Contains(question))
            {
                return question;
            }

            return null;
        }

        public Question getQuestion(int i)
        {
            if (questions.Count >= i)
            {
                return questions[i];
            }

            return null;
        }

        public List<Question> getQuestions()
        {
            return questions;
        }

        public List<Question> shuffleQuestions()
        {
            Random random = new Random();
            questions = questions.OrderBy(x => random.Next()).ToList();

            return questions.OrderBy(x => random.Next()).ToList();
        }

        public void setQuestions(List<Question> questions)
        {
            this.questions = questions;
        }

        public int getQuestionPosition(Question question)
        {

            for (int i = 0; i < questions.Count; i++)
            {
                if (questions[i].Equals(question))
                {
                    return i;
                }
            }

            return -1;
        }

        public Boolean shouldShuffle()
        {
            return randomize;
        }
    }
}
