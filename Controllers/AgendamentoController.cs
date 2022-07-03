using HeathCheck1.Database;
using HeathCheck1.Models;
using HeathCheck1.Repositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HeathCheck1.Controllers
{
    public class AgendamentoController : Controller
    {

         public class calenderEvent
        {
            public string Summary { get; set; }
            public string Organizer { get; set; }
            public string Description { get; set; }
            public string StartTime { get; set; }
            public string EndTime { get; set; }

        }
        public List<calenderEvent> GoogleEvents = new List<calenderEvent>();
        static string[] Scopes = { CalendarService.Scope.CalendarReadonly };
        static string ApplicationName = "Google Calendar API .NET Quickstart";

       

        private readonly Context _bancocontext;


        
        
      
        

        // GET: AgendamentoController/Salvar
        public ActionResult Salvar()
        {

            CallenderEvents();
            ViewBag.EventList = GoogleEvents;

            return View();
        }

        // POST: EspecialistaController/Create
   
        public void CallenderEvents()
        {

            UserCredential credential;
            // Load client secrets.
            using (var stream =
                   new FileStream("credential.json", FileMode.Open, FileAccess.Read))
            {
                /* The file token.json stores the user's access and refresh tokens, and is created
                 automatically when the authorization flow completes for the first time. */
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;

            }

            // Create Google Calendar API service.
            var service = new CalendarService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName
            });

            // Define parameters of request.
            EventsResource.ListRequest request = service.Events.List("primary");
            request.TimeMin = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 10;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            // List events.
            Events events = request.Execute();
            Console.WriteLine("Upcoming events:");
            if (events.Items == null || events.Items.Count == 0)
            {
                Console.WriteLine("No upcoming events found.");
                return;
            }
            foreach (var eventItem in events.Items)
            {
                var calenderevent = new calenderEvent();

                calenderevent.Organizer = eventItem.Organizer.Email;
                calenderevent.Summary = eventItem.Summary;
                calenderevent.StartTime = eventItem.Start.DateTime.ToString();
                calenderevent.EndTime = eventItem.End.DateTime.ToString();
                calenderevent.Description = eventItem.Description;
                GoogleEvents.Add(calenderevent);

            }
        }

    }
}
