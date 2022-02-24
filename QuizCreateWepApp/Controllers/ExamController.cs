using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

using HtmlAgilityPack;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net;
using System.Text;
using QuizCreateWepApp.Entities;
using QuizCreateWepApp.VM;
using Microsoft.AspNetCore.Authorization;

namespace QuizCreateWepApp.Controllers
{
    [Authorize]
    public class ExamController : BaseController
    {

        private DatabaseContext databaseContext;
        public ExamController(DatabaseContext _databaseContext)
        {
            databaseContext = _databaseContext;
        }


        public IActionResult Index()
        {

            var MostRecentPost = GetMostRecent();
            ViewBag.MostRecentPost = MostRecentPost;

            return View(MostRecentPost);
        }

   
        public IActionResult CreateExam()
        {
            var MostRecentPost = GetMostRecent();

            CreateExamVM createExamVM = new CreateExamVM();
            createExamVM.drpTitles = MostRecentPost;
            createExamVM.Descriptions = MostRecentPost;

            return View(createExamVM);
        }
        [HttpPost]
        public IActionResult CreateExam(CreateExamVM createExamVM)
        {
            if (ModelState.IsValid)
            {

            Exam exam = new Exam();

            exam.Title = createExamVM.Title;
            exam.Description = createExamVM.Description;

            exam.Question1 = createExamVM.Q1;
            exam.Answer1a = createExamVM.answer1a;
            exam.Answer1b = createExamVM.answer1b;
            exam.Answer1c = createExamVM.answer1c;
            exam.Answer1d = createExamVM.answer1d;
            exam.CorrectAnswerQ1 = createExamVM.correctAnswerQ1;

            exam.Question2 = createExamVM.Q2;
            exam.Answer2a = createExamVM.answer2a;
            exam.Answer2b = createExamVM.answer2b;
            exam.Answer2c = createExamVM.answer2c;
            exam.Answer2d = createExamVM.answer2d;
            exam.CorrectAnswerQ2 = createExamVM.correctAnswerQ2;

            exam.Question3 = createExamVM.Q3;
            exam.Answer3a = createExamVM.answer3a;
            exam.Answer3b = createExamVM.answer3b;
            exam.Answer3c = createExamVM.answer3c;
            exam.Answer3d = createExamVM.answer3d;
            exam.CorrectAnswerQ3 = createExamVM.correctAnswerQ3;

            exam.Question4 = createExamVM.Q4;
            exam.Answer4a = createExamVM.answer4a;
            exam.Answer4b = createExamVM.answer4b;
            exam.Answer4c = createExamVM.answer4c;
            exam.Answer4d = createExamVM.answer4d;
            exam.CorrectAnswerQ4 = createExamVM.correctAnswerQ4;

            databaseContext.Exams.Add(exam);
            databaseContext.SaveChanges();

            return RedirectToAction("CreateExam","Exam");


            }
            else
            {

                var MostRecentPost = GetMostRecent();

                createExamVM.drpTitles = MostRecentPost;
                createExamVM.Descriptions = MostRecentPost;
                return View(createExamVM);
            }

            


        }


        public IActionResult ExamList()
        {
            List<ExamListVM> examListVM = databaseContext.Exams.ToList().Select(q => new ExamListVM()
            {
                Id=q.Id,
                Title=q.Title,
                AddDate=q.AddDate
            }).ToList();
                        

            return View(examListVM);
        }

        public IActionResult Delete(int id)
        {
           
            Exam exam = databaseContext.Exams.FirstOrDefault(x=>x.Id==id);

            databaseContext.Exams.Remove(exam);
            databaseContext.SaveChanges();

            return Json("Ok");
        }

        public IActionResult Exam(int id)
        {
            ExamVM examVM = new ExamVM();
            Exam exam = databaseContext.Exams.FirstOrDefault(x=>x.Id==id);

            examVM.Id = exam.Id;
            examVM.Title = exam.Title;
            examVM.Description = exam.Description;

            examVM.Question1 = exam.Question1;
            examVM.Answer1a = exam.Answer1a;
            examVM.Answer1b = exam.Answer1b;
            examVM.Answer1c = exam.Answer1c;
            examVM.Answer1d = exam.Answer1d;

            examVM.Question2 = exam.Question2;
            examVM.Answer2a = exam.Answer2a;
            examVM.Answer2b = exam.Answer2b;
            examVM.Answer2c = exam.Answer2c;
            examVM.Answer2d = exam.Answer2d;

            examVM.Question3 = exam.Question3;
            examVM.Answer3a = exam.Answer3a;
            examVM.Answer3b = exam.Answer3b;
            examVM.Answer3c = exam.Answer3c;
            examVM.Answer3d = exam.Answer3d;

            examVM.Question4 = exam.Question4;
            examVM.Answer4a = exam.Answer4a;
            examVM.Answer4b = exam.Answer4b;
            examVM.Answer4c = exam.Answer4c;
            examVM.Answer4d = exam.Answer4d;


            return View(examVM);

        }

        [HttpPost]
        public IActionResult FinishExam(ExamAnswerVM examAnswerVM)
        {

            Exam exam = databaseContext.Exams.FirstOrDefault(x => x.Id == examAnswerVM.Id);

            examAnswerVM.CorrectAnswer1 = exam.CorrectAnswerQ1;
            examAnswerVM.CorrectAnswer2 = exam.CorrectAnswerQ2;
            examAnswerVM.CorrectAnswer3 = exam.CorrectAnswerQ3;
            examAnswerVM.CorrectAnswer4 = exam.CorrectAnswerQ4;


            if (examAnswerVM.Answer1 == exam.CorrectAnswerQ1)
            {
                examAnswerVM.ResultAnswer1 = 1;
            }
            else if (examAnswerVM.Answer1==null)
            {
                examAnswerVM.ResultAnswer1 = 2;
            }
             if (examAnswerVM.Answer2 == exam.CorrectAnswerQ2)
            {
                examAnswerVM.ResultAnswer2 = 1;
            }
            else if (examAnswerVM.Answer2 == null)
            {
                examAnswerVM.ResultAnswer2 = 2;
            }
            if (examAnswerVM.Answer3 == exam.CorrectAnswerQ3)
            {
                examAnswerVM.ResultAnswer3 = 1;
            }
            else if (examAnswerVM.Answer3 == null)
            {
                examAnswerVM.ResultAnswer3 = 2;
            }
            if (examAnswerVM.Answer4 == exam.CorrectAnswerQ4)
            {
                examAnswerVM.ResultAnswer4 = 1;

            }
            else if (examAnswerVM.Answer4 == null)
            {
                examAnswerVM.ResultAnswer4 = 2;
            }


            return Json(examAnswerVM);
        }





        public static async Task<string> CallUrl()
        {
            string fullUrl = "https://www.wired.com/most-recent/";
            HttpClient client = new HttpClient();
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            client.DefaultRequestHeaders.Accept.Clear();
            var response = client.GetStringAsync(fullUrl);
            return await response;
        }

        public List<WiredItem> GetMostRecent()
        {
            string html = CallUrl().Result;

            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);
            var programmerLinks = htmlDoc.DocumentNode.Descendants("li").Where(node => node.GetAttributeValue("class", "").Contains("archive-item-component")).Take(5).ToList();

            List<WiredItem> MostRecentPost = new List<WiredItem>();

            foreach (var link in programmerLinks)
            {

                var title = link.SelectSingleNode(".//h2[@class='archive-item-component__title']").InnerText;
                var url = link.SelectSingleNode(".//a[@class='archive-item-component__link']").GetAttributeValue("href", string.Empty);
                
                WiredItem item = new WiredItem();

                item.title = title.ToString();
                item.url = url.ToString();
                

                MostRecentPost.Add(item);
            }            

            return GetDescription(MostRecentPost);
        }

        public List<WiredItem> GetDescription(List<WiredItem> MostRecentPost)
        {
            foreach (var item in MostRecentPost)
            {
                string link = "http://wired.com" + item.url;  //link değişkenine çekeceğimiz web sayafasının linkini yazıyoruz.
                Uri url = new Uri(link); //Uri tipinde değişeken linkimizi veriyoruz.
                WebClient client = new WebClient(); // webclient nesnesini kullanıyoruz bağlanmak için.
                client.Encoding = Encoding.UTF8; //türkçe karakter sorunu yapmaması için encoding utf8 yapıyoruz.
                string html = client.DownloadString(url); // siteye bağlanıp tüm sayfanın html içeriğini çekiyoruz.
                HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument(); //kütüphanemizi kullanıp htmldocument oluşturuyoruz.
                document.LoadHtml(html);//documunt değişkeninin html ine çektiğimiz htmli veriyoruz

                HtmlNodeCollection secilenHtmlList = document.DocumentNode.SelectNodes("/html/body/div[1]/div/main/article/div[2]/div[1]/div[1]/div/div[1]/div"); //selectnodes methoduyla verdiğimiz xpathin htmlini getiriyoruz.
                HtmlNodeCollection nodes = document.DocumentNode.SelectNodes("//*[contains(@class,' body__container ')]");

                if (nodes != null)
                {

                    foreach (var items in nodes)
                    {
                        item.desc += items.InnerText;                        
                    }
                }
                else
                {
                    foreach (var items in secilenHtmlList)
                    {
                        item.desc += items.InnerText;                        
                    }
                }
            }
            
            return MostRecentPost;
        }

    }
}
