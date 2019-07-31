using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WOM_AuthenticationPortalPrototype2.Controllers
{
    public class SurveyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TakeSurvey()
        {
            return View();
        }

        public IActionResult SurveyFeedback()
        {
            return View();
        }

        public static int getFirstQuestion(int surveyID)
        {
            int linkID = 0, returnValue = 0;
            try
            {
                linkID = DBL.Tables.linkSurveysQuestions.SelectKeysWhere("surveyID=" + surveyID, "displayOrder", 1)[0];
            }
            catch
            {
                linkID = 0;
            }
            
            DBL.Tables.linkSurveysQuestions Link = new DBL.Tables.linkSurveysQuestions(linkID);
            returnValue = Link.questionID;
            return returnValue;
        }

        public static int getNextQuestion(int surveyID, int currentQuestionID)
        {
            int returnValue = 0;
            int linkID = getLinkID(surveyID, currentQuestionID);
            DBL.Tables.linkSurveysQuestions Link = new DBL.Tables.linkSurveysQuestions(linkID);
            int DisplayOrder = Link.displayOrder;

            List<DBL.Tables.linkSurveysQuestions> sqs = DBL.Tables.linkSurveysQuestions.SelectWhere("surveyID = " + surveyID + " AND displayOrder > " + DisplayOrder,"DisplayOrder", 1);
            try
            {
                returnValue = sqs[0].questionID;
            }
            catch
            {
                returnValue = 0;
            }
         
            return returnValue;
        }

        public static int getPreviousQuestion(int surveyID, int currentQuestionID)
        {
            int returnValue = 0;
            int linkID = getLinkID(surveyID, currentQuestionID);
            DBL.Tables.linkSurveysQuestions Link = new DBL.Tables.linkSurveysQuestions(linkID);
            int DisplayOrder = Link.displayOrder;

            List<DBL.Tables.linkSurveysQuestions> sqs = DBL.Tables.linkSurveysQuestions.SelectWhere("surveyID = " + surveyID + " AND displayOrder < " + DisplayOrder, "DisplayOrder DESC", 1);
            try
            {
                returnValue = sqs[0].questionID;
            }
            catch
            {
                returnValue = 0;
            }

            return returnValue;
        }

        public static List<DBL.Tables.datQuestionOptions> getQuestionOptions(int questionID)
        {
            return DBL.Tables.datQuestionOptions.SelectWhere(DBL.Tables.datQuestionOptions.Columns.questionID + " = " + questionID, "displayOrder");
        }

        public Boolean setQuestionResponseText(int clientID, int surveyID, int questionID, string responseText)
        {
            Boolean returnValue = false;

            DBL.Tables.datClientResponsesMain rm = new DBL.Tables.datClientResponsesMain(0);
            rm.clientID = clientID;
            rm.dtStarted = DateTime.Now;
            rm.isActive = true;
            rm.numberCorrect = 0;
            int responseID = DBL.Tables.datClientResponsesMain.Save(rm);

            DBL.Tables.datClientResponsesText rt = new DBL.Tables.datClientResponsesText(0);
            rt.clientResponseID = responseID;
            rt.responseText = responseText;
            rt.surveyQuestionID = questionID;
            if (DBL.Tables.datClientResponsesText.Save(rt) > 0)
            {
                returnValue = true;
            }



            return returnValue;
        }
        public static int getLinkID(int surveyID, int questionID)
        {
            int returnValue = 0;
            returnValue = DBL.Tables.linkSurveysQuestions.SelectKeysWhere("surveyID = " + surveyID + " AND questionID = " + questionID, "displayOrder", 1)[0];
            return returnValue;

        }

        public static DBL.Tables.datSurveyQuestions getQuestion(int questionID)
        {
            DBL.Tables.datSurveyQuestions returnObject = new DBL.Tables.datSurveyQuestions(questionID);
            return returnObject;
        }
    }
}