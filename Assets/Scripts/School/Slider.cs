using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Slider : MonoBehaviour
{

    int numberOfSlide = 0;

    public GameObject slider;

    public Sprite[] slides;

    public Text textOnLesson;

    public static int countSlides = 0;

    string[] TextOnSlides = {
        "Использование энергосберегающих лампочек помогает экономить электричество.Правда-правда.",
        "Во время дождя поменьше пользоваться электроприборами в помещении и не пользоваться ими на улице. Не рекомендую проверять это.",
        "В холодильник нельзя ставить горячие предметы, а в микроволновку металлические. Им это не нравится.",
        "Не нужно ставить холодильник рядом с плитой, последствия могут быть страшными.",
        "Если окна будут чистыми, то нужно будет меньше тратить электричества, да и так красивее.",
        "Выключайте электроприборы, если их не используете. Ну зачем им просто так работать?" };

    private void Start()
    {
        ChangeSlides(numberOfSlide);
    }
    public void LeftButtonTap()
    {
        try
        {
            numberOfSlide--;
            ChangeSlides(numberOfSlide);
        }
        catch (IndexOutOfRangeException)
        {
            numberOfSlide = slides.Length-1;
            ChangeSlides(numberOfSlide);
        }

    }
    public void RightButtonTap()
    {
        try
        {
            numberOfSlide++;
            ChangeSlides(numberOfSlide);
        }
        catch (IndexOutOfRangeException)
        {
            numberOfSlide = 0;
            ChangeSlides(numberOfSlide);
        }
    }
    private void ChangeSlides(int numberOfSlide)
    {
        slider.GetComponent<SpriteRenderer>().sprite = slides[numberOfSlide];
        textOnLesson.text = TextOnSlides[numberOfSlide];

        if (numberOfSlide == 1 || numberOfSlide == 2 || numberOfSlide == 3 || numberOfSlide == 4|| numberOfSlide == 5 )
        {
            countSlides++;
        }
        
    }
}
