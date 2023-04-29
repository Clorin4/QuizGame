using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    
        public List<Question> questions;

        private int currentQuestion = 0;
        private int score = 0;

        void Start()
        {
            DisplayQuestion();
        }

        public void AnswerQuestion(int answerIndex)
        {
            if (answerIndex == questions[currentQuestion].correctAnswer)
            {
                score++;
            }

            currentQuestion++;

            if (currentQuestion < questions.Count)
            {
                DisplayQuestion();
            }
            else
            {
                DisplayScore();
            }
        }

        private void DisplayQuestion()
        {
            Question question = questions[currentQuestion];
            // Mostrar la pregunta y las opciones en la pantalla
        }

        private void DisplayScore()
        {
            // Mostrar el puntaje final al jugador
        }
    
}
