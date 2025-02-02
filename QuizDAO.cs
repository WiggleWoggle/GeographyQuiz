using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Notice.Frame.Types;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace defaultwinform
{
    internal class QuizDAO
    {

        public static int expectedQueuedQuizzes = 0;
        private static int queueProgress = 0;

        private static List<Task> totalTasks = new List<Task>();

        public static Boolean hasCompletedQueue = false;

        private static List<QuizPanel> quizPanels = new List<QuizPanel>();

        private static List<Quiz> assignedQuizzes = new List<Quiz>();

        private static Quiz currentQuiz = null;

        private static string ServiceAccountJsonPath = "key.json"; 
        private static string folderId = "1CAEl8_9X2kugGUYdAkd088jXmpPMVDhp";

        private static string decryptionKey = "geomind";

        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=geography;";

        public async static void retrieveQuizzes()
        {
            //database call

            //createQuizObjectsFromFile();

            createQuizObjectsFromFile();


            Console.WriteLine("COMPLETED QUEUE");
        }

        public static void addQuiz(Quiz quiz)
        {
            assignedQuizzes.Add(quiz);
        }

        public static void tempQuiz()
        {
            Quiz quiz = new Quiz(true);
            quiz.setTopic("State Geography");
            quiz.setTitle("TESTQUIZ");
            quiz.setImage("https://cdn.britannica.com/13/197813-138-3CF1CCFA/state-more-president-Washington-economy-geography-history.jpg?w=800&h=450&c=crop");

            quiz.addQuestion(new MultipleChoice("Which state is known as the \"Grand Canyon State\"?", 1, "https://www.americanrivers.org/wp-content/uploads/2022/12/AmyMartin_GC_from_above.jpg", new List<String> { "Nevada", "Arizona", "New Mexico", "Utah" }, "Arizona"));
            quiz.addQuestion(new MultipleChoice("Which state shares borders with the most other states?", 2, "https://i.natgeofe.com/k/a5c3ea4f-e7cd-44dd-960c-2042c743e4b6/Great-Smoky-smlandscape21_square.jpg", new List<String> { "Missouri", "Kentucky", "Tennessee", "Colorado" }, "Tennessee"));
            quiz.addQuestion(new MultipleChoice("The Great Salt Lake is located in which state?", 2, "https://cdn.britannica.com/98/197598-050-28DA45BC/Stansbury-Island-Utah-Great-Salt-Lake-foreground.jpg", new List<String> { "Nevada", "Idaho", "Utah", "Montana" }, "Utah"));
            quiz.addQuestion(new MultipleChoice("Which state is the only one divided into two peninsulas?", 2, "https://www.michiganbusiness.org/4a6231/contentassets/4a61083db1cf471e93fb6d023ce9dfcd/water-rankings-tji-750.jpg", new List<String> { "Florida", "Michigan", "Maine", "Alaska" }, "Michigan"));
            quiz.addQuestion(new MultipleChoice("The Chesapeake Bay is primarily located in which two states?", 3, "https://assets.simpleviewinc.com/simpleview/image/upload/c_fill,f_jpg,g_xy_center,h_514,q_65,w_640,x_501,y_449/v1/clients/virginia/CB20030903P_007_4ff985e4-0a4a-45ed-9405-7577ea625a37.jpg", new List<String> { "VA and MD", "DE and NJ", "NC and VA", "MD and DE" }, "VA and MD"));
            quiz.addQuestion(new MultipleChoice("Which state has the most coastline?", 3, "https://afar.brightspotcdn.com/dims4/default/40bdfb1/2147483647/strip/false/crop/4032x2016+0+0/resize/1486x743!/quality/90/?url=https%3A%2F%2Fk3-prod-afar-media.s3.us-west-2.amazonaws.com%2Fbrightspot%2Fa5%2F76%2F7d733fb1419fb4fff5fec8d7aa0a%2Falaska-guide-lede-supriya-kalidas.jpg", new List<String> { "Florida", "California", "Alaska", "Hawaii" }, "Alaska"));

            quiz.addQuestion(new MultipleAnswer("Which states border Mexico?", 1, "https://media.cntraveler.com/photos/640b605c63c7e54952eb4d22/1:1/w_3413,h_3413,c_limit/Mexico%20City_GettyImages-638920569.jpg", new List<String> { "California", "Arizona", "New Mexico", "Texas" }, new List<String> { "California", "Arizona", "New Mexico", "Texas" }));
            quiz.addQuestion(new MultipleAnswer("Which states have portions of Yellowstone National Park?", 2, "https://npf-prod.imgix.net/uploads/shutterstock_1565388232028129.jpg?auto=compress%2Cformat&fit=max&q=80&w=1600", new List<String> { "Wyoming", "Montana", "Idaho", "Utah" }, new List<String> { "Wyoming", "Montana", "Idaho" }));
            quiz.addQuestion(new MultipleAnswer("Which states are part of New England?", 2, "https://bucketlistlists.com/wp-content/uploads/2021/06/new-england-bucket-list-6.jpg", new List<String> { "Maine", "Vermont", "New Hampshire", "New York" }, new List<String> { "Maine", "Vermont", "New Hampshire" }));
            quiz.addQuestion(new MultipleAnswer("Which states have no natural lakes?", 2, "https://res.cloudinary.com/rebbix/image/upload/f_auto,q_auto,fl_progressive.force_strip,w_1280/yzr4t7e7lpxnkouqakoc.jpg", new List<String> { "Maryland", "West Virginia", "Kentucky", "Ohio" }, new List<String> { "Maryland", "West Virginia" }));
            quiz.addQuestion(new MultipleAnswer("Which states share borders with the most Canadian provinces?", 3, "https://matrix.in/cdn/shop/articles/canada3_960x.jpg?v=1709210626", new List<String> { "Maine", "Montana", "Minnesota", "New York" }, new List<String> { "Montana", "New York" }));
            quiz.addQuestion(new MultipleAnswer("Which states contain parts of the Appalachian Mountains?", 3, "https://www.travelandleisure.com/thmb/uUuLH31xCpCzD-4kc4bnhQ_1LL8=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/header-APPALACHIA0722-ea4c6442310d4a4e8e96c24ae3856e25.jpg", new List<String> { "Georgia", "Tennessee", "North Carolina", "Kentucky" }, new List<String> { "Georgia", "Tennessee", "North Carolina", "Kentucky" }));

            quiz.addQuestion(new TrueFalseQuestion("Rhode Island is the smallest U.S. state by total area.", 1, true, "https://www.travelandleisure.com/thmb/Ff_lDL4jp8QXINBIcFEJ1GV3lIc=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/newport-rhode-island-RITG0221-b6154231bf5d44b99bd561660af11cc1.jpg"));
            quiz.addQuestion(new TrueFalseQuestion("Texas is the largest state in the continental United States.", 1, true, "https://res.cloudinary.com/simpleview/image/upload/v1546900426/clients/texas/PLACES_Cities_H_HEADER_65a9a668-687e-4dfb-84b6-b4e497aad266.jpg"));
            quiz.addQuestion(new TrueFalseQuestion("Hawaii is composed of exactly 50 islands.", 2, false, "https://cdn.aarp.net/content/dam/aarp/travel/Domestic/2021/12/1140-oahu-hero.jpg"));
            quiz.addQuestion(new TrueFalseQuestion("Four states meet at a single point called the Four Corners.", 2, true, "https://assets.simpleviewinc.com/simpleview/image/upload/c_limit,h_1200,q_75,w_1200/v1/clients/utahvalley/temp_42c6b1d3-8ab3-4028-b8bf-78f7b92dede9.jpg"));
            quiz.addQuestion(new TrueFalseQuestion("Alaska has both the northernmost and westernmost points of the United States.", 3, true, "https://img2.10bestmedia.com/Images/Photos/408179/GettyImages-1395096013_55_660x440.jpg"));
            quiz.addQuestion(new TrueFalseQuestion("California shares a border with five other states.", 3, false, "https://www.savoredjourneys.com/wp-content/uploads/2021/11/san-francisco.jpg"));


            quiz.addQuestion(new ShortResponse("Explain why Hawaii's geography makes it unique among U.S. states. List at least three specific geographical features in your response.", 2, new List<String> { "Volcanic", "Tropical", "Pacific", "Pacific Ocean", "Volcano", "Volcanoes", "Island", "Islands" }, "https://i.natgeofe.com/n/5c6b3a4b-7b1a-410b-bcb2-7a2e83afd409/22328.jpg"));
            quiz.addQuestion(new ShortResponse("Describe how the Mississippi River impacts the geography and borders of U.S. states. Name at least four states affected and explain how the river influences their boundaries.", 2, new List<String> { "Tennessee", "Arkansas", "Mississippi", "Louisiana", "Minnesota", "Wisconsin", "Iowa", "Illinois", "Missouri", "Kentucky" }, "https://www.jsonline.com/gcdn/presto/2023/09/19/PMJS/481b3316-cf67-4f2d-ab1a-0fe13270d3b8-Mississippi_Wisconsin_River_LightHawk_Flight_052523_080.jpg?crop=5958,4469,x336,y0"));

            //assignedQuizzes.Add(quiz);
        }

        public static List<Quiz> getQuizzes()
        {
            return assignedQuizzes;
        }

        public static List<QuizPanel> getQuizPanels()
        {
            return quizPanels;
        }

        public static void addQuizPanel(QuizPanel quizPanel)
        {

            if (!quizPanels.Contains(quizPanel))
            {
                quizPanels.Add(quizPanel);
            }
        }

        public static void setCurrentQuiz(Quiz quiz)
        {
            currentQuiz = quiz;
        }

        public static Quiz getCurrentQuiz()
        {
            return currentQuiz;
        }

        public static void uploadToDrive(Quiz quiz)
        {

            String filePath = createQuizFile(Guid.NewGuid().ToString(), quiz);

            var service = authenticateDriveService();

            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = Path.GetFileName(filePath),
                Parents = new string[] { folderId } 
            };

            FilesResource.CreateMediaUpload request;
            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                request = service.Files.Create(fileMetadata, stream, "text/plain");
                request.Fields = "id";
                request.Upload();
            }

            var file = request.ResponseBody;

        }

        private static String createQuizFile(String fileName, Quiz quiz)
        {
            string filePath = Path.Combine(Path.GetTempPath(), fileName);

            String content = "TITLE: " + quiz.getTitle();
            content = content + "\nTOPIC: " + quiz.getTopic();
            content = content + "\nSHUFFLE: ";

            if (quiz.shouldShuffle())
            {
                content = content + "true";
            } else
            {
                content = content + "false";
            }

            content = content + "\nDISPLAYURL: " + quiz.getImage() + "\n\n";

            int questionProgress = 1;

            foreach (Question question in quiz.getQuestions())
            {
                content = content + questionProgress + ". ";

                if (question is MultipleChoice mc)
                {
                    content = content + "MCQ " + "(" + mc.getQuestion() + ")";
                    content = content + "\na. " + mc.getFirstChoice();
                    content = content + "\nb. " + mc.getSecondChoice();
                    content = content + "\nc. " + mc.getThirdChoice();
                    content = content + "\nd. " + mc.getFourthChoice();

                    if (mc.getAnswer().Equals(mc.getFirstChoice()))
                    {
                        content = content + "\nANSWER: " + "a";
                    } else if (mc.getAnswer().Equals(mc.getSecondChoice()))
                    {
                        content = content + "\nANSWER: " + "b";
                    } else if (mc.getAnswer().Equals(mc.getThirdChoice()))
                    {
                        content = content + "\nANSWER: " + "c";
                    } else
                    {
                        content = content + "\nANSWER: " + "d";
                    }
                }
                else if (question is MultipleAnswer ma)
                {
                    content = content + "MAQ " + "(" + ma.getQuestion() + ")";
                    content = content + "\na. " + ma.getFirstChoice();
                    content = content + "\nb. " + ma.getSecondChoice();
                    content = content + "\nc. " + ma.getThirdChoice();
                    content = content + "\nd. " + ma.getFourthChoice();

                    content = content + "\nANSWER:";

                    if (ma.getAnswers().Contains(ma.getFirstChoice()))
                    {
                        content = content + " a";
                    }
                    
                    if (ma.getAnswers().Contains(ma.getSecondChoice()))
                    {
                        content = content + " b";
                    }
                    
                    if (ma.getAnswers().Contains(ma.getThirdChoice()))
                    {
                        content = content + " c";
                    }
                    
                    if (ma.getAnswers().Contains(ma.getFourthChoice()))
                    {
                        content = content + " d";
                    }
                }
                else if (question is TrueFalseQuestion tf)
                {
                    content = content + "TFQ " + "(" + tf.getQuestion() + ")";

                    if (tf.IsTrue())
                    {
                        content = content + "\nANSWER: true";
                    } else
                    {
                        content = content + "\nANSWER: false";
                    }
                }
                else if (question is ShortResponse sr)
                {
                    content = content + "SRQ " + "(" + question.getQuestion() + ")";
                    content = content + "\nANSWER: ";

                    foreach (String answer in sr.getPhrases())
                    {
                        content = content + " " + answer;
                    }
                }

                content = content + "\nVALUE: " + question.getStarValue();
                content = content + "\nURL: " + question.getURLString() + "\n\n";

                questionProgress++;
            }

            File.WriteAllText(filePath, content);
            return filePath;
        }

        public static DriveService authenticateDriveService()
        {
            GoogleCredential credential;
            using (var stream = new FileStream(ServiceAccountJsonPath, FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream)
                    .CreateScoped(DriveService.ScopeConstants.Drive);
            }

            return new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "GeomindClient",
            });
        }

        public static async Task<List<Google.Apis.Drive.v3.Data.File>> retrieveDriveFiles()
        {
            var service = authenticateDriveService();
            var request = service.Files.List();
            request.Q = $"'{folderId}' in parents and mimeType='text/plain'";

            request.Fields = "files(id, name)";

            var result = request.Execute();

            return result.Files.ToList();
        }

        public async static Task createQuizObjectsFromFile()
        {
            List<Google.Apis.Drive.v3.Data.File> files = await retrieveDriveFiles(); 

            List<Task> tasks = new List<Task>();

            foreach (var file in files)
            {
                tasks.Add(processFile(file.Id));
                expectedQueuedQuizzes++;
            }

            await Task.WhenAll(tasks);  
        }

        private static async Task processFile(string fileId)
        {
            string content = await readQuizFileAsync(fileId);
            await Task.Run(() => buildQuizObject(content));
        }

        public static async Task<string> readQuizFileAsync(String fileID)
        {
            var service = authenticateDriveService();
            var request = service.Files.Get(fileID);

            using (var stream = new MemoryStream())
            {
                await request.DownloadAsync(stream);
                stream.Position = 0; 
                using (var reader = new StreamReader(stream))
                {
                    return await reader.ReadToEndAsync(); 
                }
            }
        }

        public static async Task buildQuizObject(String content)
        {
            Quiz quiz = new Quiz();


            await Task.Run(() => readLines(quiz, content));

        }

        public static async Task readLines(Quiz quiz, String content)
        {
            using (StringReader reader = new StringReader(content))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("TITLE"))
                    {
                        quiz.setTitle(formatTitle(line));
                    }

                    if (line.Contains("TOPIC"))
                    {
                        quiz.setTopic(formatTopic(line));
                    }

                    if (line.Contains("SHUFFLE"))
                    {
                        quiz.setShuffle(formatShuffle(line));
                    }

                    if (line.Contains("DISPLAYURL"))
                    {
                        quiz.setImage(formatURL(line));
                    }

                    if (line.Contains("MCQ"))
                    {
                        quiz.addQuestion(generateMultipleChoiceQuestion(line, reader));
                    }

                    if (line.Contains("TFQ"))
                    {
                        quiz.addQuestion(generateTrueFalseQuestion(line, reader));
                    }

                    if (line.Contains("MAQ"))
                    {
                        quiz.addQuestion(generateMultipleAnswerQuestion(line, reader));
                    }

                    if (line.Contains("SRQ"))
                    {

                        quiz.addQuestion(generateShortResponseQuestion(line, reader));
                    }
                }
            }
            
            Console.ReadLine();

            assignedQuizzes.Add(quiz);

            queueProgress++;
        }

        public static String formatTitle(String line)
        {
            line = line.Replace("TITLE: ", "");

            return line;
        }

        public static String formatURL(String line)
        {
            line = line.Replace("URL: ", "");

            return line;
        }

        public static String formatTopic(String line)
        {
            line = line.Replace("TOPIC: ", "").Replace("  ", " ");

            return line;
        }

        public static Boolean formatShuffle(String line)
        {
            if (line.Contains("true"))
            {
                return true;
            } 

            return false;
        }

        public static MultipleChoice generateMultipleChoiceQuestion(String line, StringReader reader)
        {

            String question = line.Remove(0, 8);
            question = question.Replace("(", "");
            question = question.Replace(")", "");


            String answerChoiceOne = reader.ReadLine();
            answerChoiceOne = answerChoiceOne.Replace("a. ", "");

            String answerChoiceTwo = reader.ReadLine();
            answerChoiceTwo = answerChoiceTwo.Replace("b. ", "");

            String answerChoiceThree = reader.ReadLine();
            answerChoiceThree = answerChoiceThree.Replace("c. ", "");

            String answerChoiceFour = reader.ReadLine();
            answerChoiceFour = answerChoiceFour.Replace("d. ", "");

            //
            String correctAnswer = reader.ReadLine();
            correctAnswer = correctAnswer.Replace("ANSWER: ", "");

            if (correctAnswer.Equals("a"))
            {
                correctAnswer = answerChoiceOne;
            } else if (correctAnswer.Equals("b"))
            {
                correctAnswer = answerChoiceTwo;
            } else if (correctAnswer.Equals("c"))
            {
                correctAnswer = answerChoiceThree;
            } else
            {
                correctAnswer = answerChoiceFour;
            }

            String value = reader.ReadLine();
            value = value.Replace("VALUE: ", "");
            value = value.Replace(" ", "");

            int numValue  = Int32.Parse(value);

            String questionImageURL = reader.ReadLine();
            questionImageURL = questionImageURL.Replace("URL: ", "");


            MultipleChoice multipleChoice = new MultipleChoice(question, numValue, questionImageURL, new List<String> { answerChoiceOne, answerChoiceTwo, answerChoiceThree, answerChoiceFour }, correctAnswer);

            return multipleChoice;
        }

        public static TrueFalseQuestion generateTrueFalseQuestion(String line, StringReader reader)
        {

            String question = line.Remove(0, 8);
            question = question.Replace("(", "");
            question = question.Replace(")", "");

            //
            String correctAnswer = reader.ReadLine();
            correctAnswer = correctAnswer.Replace("ANSWER: ", "");

            Boolean correctBoolean = false;

            if (correctAnswer.Contains("true"))
            {
                correctBoolean = true;
            }

            String value = reader.ReadLine();
            value = value.Replace("VALUE: ", "");
            value = value.Replace(" ", "");

            int numValue = Int32.Parse(value);

            String questionImageURL = reader.ReadLine();
            questionImageURL = questionImageURL.Replace("URL: ", "");


            TrueFalseQuestion trueFalseQuestion = new TrueFalseQuestion(question, numValue, correctBoolean, questionImageURL);

            return trueFalseQuestion;
        }

        public static MultipleAnswer generateMultipleAnswerQuestion(String line, StringReader reader)
        {

            String question = line.Remove(0, 8);
            question = question.Replace("(", "");
            question = question.Replace(")", "");


            String answerChoiceOne = reader.ReadLine();
            answerChoiceOne = answerChoiceOne.Replace("a. ", "");

            String answerChoiceTwo = reader.ReadLine();
            answerChoiceTwo = answerChoiceTwo.Replace("b. ", "");

            String answerChoiceThree = reader.ReadLine();
            answerChoiceThree = answerChoiceThree.Replace("c. ", "");

            String answerChoiceFour = reader.ReadLine();
            answerChoiceFour = answerChoiceFour.Replace("d. ", "");

            //
            String correctAnswers = reader.ReadLine();
            correctAnswers = correctAnswers.Replace("ANSWER: ", "");

            List<String> correctAnsweredParsed = new List<String>();
            
            if (correctAnswers.Contains("a"))
            {
                correctAnsweredParsed.Add(answerChoiceOne);
            }

            if (correctAnswers.Contains("b"))
            {
                correctAnsweredParsed.Add(answerChoiceTwo);
            }

            if (correctAnswers.Contains("c"))
            {
                correctAnsweredParsed.Add(answerChoiceThree);
            }

            if (correctAnswers.Contains("d"))
            {
                correctAnsweredParsed.Add(answerChoiceFour);
            }

            String value = reader.ReadLine();
            value = value.Replace("VALUE: ", "");
            value = value.Replace(" ", "");

            int numValue = Int32.Parse(value);

            String questionImageURL = reader.ReadLine();
            questionImageURL = questionImageURL.Replace("URL: ", "");


            MultipleAnswer multipleAnswer = new MultipleAnswer(question, numValue, questionImageURL, new List<String> { answerChoiceOne, answerChoiceTwo, answerChoiceThree, answerChoiceFour }, correctAnsweredParsed);

            return multipleAnswer;
        }

        public static ShortResponse generateShortResponseQuestion(String line, StringReader reader)
        {

            String question = line.Remove(0, 8);
            question = question.Replace("(", "");
            question = question.Replace(")", "");

            String answer = reader.ReadLine();
            answer = answer.Replace("ANSWER: ", "");

            String[] keywords = answer.Split(' ');

            String value = reader.ReadLine();
            value = value.Replace("VALUE: ", "");
            value = value.Replace(" ", "");

            int numValue = Int32.Parse(value);

            String questionImageURL = reader.ReadLine();
            questionImageURL = questionImageURL.Replace("URL: ", "");

            ShortResponse shortResponse = new ShortResponse(question, numValue, keywords.ToList(), questionImageURL);

            return shortResponse;
        }
    }
}
