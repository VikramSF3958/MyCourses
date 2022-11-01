using System;
using System.Collections.Generic;
using System.Linq;


namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //You can get the trainee details from the GetTraineeDetails() method in TraineeData class
            Console.Clear();
            
            System.Console.WriteLine("Menu");
            System.Console.WriteLine();
            System.Console.WriteLine("1.Show the list of Trainee Id");
            System.Console.WriteLine("2.Show the first 3 Trainee Id using Take");
            System.Console.WriteLine("3.Show the last 2 Trainee Id using Skip");
            System.Console.WriteLine("4.Show the count of Trainee");
            System.Console.WriteLine("5.Show the Trainee Name who are all passed out 2019 or later");
            System.Console.WriteLine("6.Show the Trainee Id and Trainee Name by alphabetic order of the trainee name.");
            System.Console.WriteLine("7.Show the Trainee Id, Trainee Name, Topic Name, Exercise Name and Mark who are all scores the more than or equal to 4 mark");
            System.Console.WriteLine("8.Show the unique passed out year using distinct");
            System.Console.WriteLine("9.Show the total marks of single user (get the Trainee Id from User), if Trainee Id does not exist, show the invalid message");
            System.Console.WriteLine("10.Show the first Trainee Id and Trainee Name");
            System.Console.WriteLine("11.Show the last Trainee Id and Trainee Name");
            System.Console.WriteLine("12.Print the total score of each trainee");
            System.Console.WriteLine("13.Show the maximum total score");
            System.Console.WriteLine("14.Show the minimum total score");
            System.Console.WriteLine("15.Show the average of total score");
            System.Console.WriteLine("16.Show true or false if any one has the more than 40 score using any()");
            System.Console.WriteLine("17.Show true of false if all of them has the more than 20 using all()");
            System.Console.WriteLine("18.Show the Trainee Id, Trainee Name, Topic Name, Exercise Name and Mark by show the Trainee Name as descending order and then show the Mark as descending order.");
        
        
            System.Console.WriteLine();
            System.Console.Write("Enter your choice: ");
            int option = int.Parse(Console.ReadLine());


            switch(option)
            {
                case 1:
                {   
                    TraineeData data = new TraineeData();
                    List<TraineeDetails> traineeDataList = data.GetTraineeDetails();
                    IEnumerable<TraineeDetails> QueryResult = from data1 in  traineeDataList  select data1;
                    
                    foreach(var result in QueryResult)
                    {
                        System.Console.WriteLine(result.TraineeId);
                    }
                    break;
                }

                case 2:
                {   
                    TraineeData data = new TraineeData();
                    List<TraineeDetails> traineeDataList = data.GetTraineeDetails();
                    IEnumerable<string> QueryResult = from data1 in  traineeDataList select data1.TraineeId;

                    IEnumerable<string> QueryResult1 =  QueryResult.Take(3).ToList();
                    for(int i=0; i<QueryResult1.Count();i++)
                    {
                        System.Console.WriteLine(QueryResult1.ElementAt(i));
                    }
                    break;
                }

                case 3:
                {   
                    TraineeData data = new TraineeData();
                    List<TraineeDetails> traineeDataList = data.GetTraineeDetails();
                    IEnumerable<string> QueryResult = (from data1 in  traineeDataList select data1.TraineeId).Skip(3);
                    
                    for(int i=0; i<QueryResult.Count();i++)
                    {
                        System.Console.WriteLine(QueryResult.ElementAt(i));
                    }
                    break;
                }

                case 4:
                {   
                    TraineeData data = new TraineeData();
                    List<TraineeDetails> traineeDataList = data.GetTraineeDetails();
                    IEnumerable<string> QueryResult = from data1 in  traineeDataList select data1.TraineeId;
                    
                    System.Console.WriteLine($"Count of Trainee: {QueryResult.Count()}");
                    
                    break;
                }

                case 5:
                {   
                    TraineeData data = new TraineeData();
                    List<TraineeDetails> traineeDataList = data.GetTraineeDetails();
                    IEnumerable<string> QueryResult = from data1 in  traineeDataList where data1.YearPassedOut >=2019   select data1.TraineeName ;
                    
                    for(int i=0; i<QueryResult.Count();i++)
                    {
                        System.Console.WriteLine(QueryResult.ElementAt(i));
                    }
                    break;
                }

                case 6:
                {   
                    TraineeData data = new TraineeData();
                    List<TraineeDetails> traineeDataList = data.GetTraineeDetails();
                    IEnumerable<TraineeDetails> QueryResult = from data1 in  traineeDataList orderby data1.TraineeName ascending select data1;

                    foreach(var result in QueryResult)
                    {
                        System.Console.WriteLine(result.TraineeName);
                        System.Console.WriteLine(result.TraineeId);
                    }
                    break;
                }

                case 7:
                {   
                    TraineeData data = new TraineeData();
                    List<TraineeDetails> traineeDataList = data.GetTraineeDetails();

                    foreach(var details in traineeDataList)
                    {
                        var result = details.ScoreDetails.Where(x => x.Mark >= 4).Select(datas => new { Exercise = datas.ExerciseName, mark = datas.Mark, Topic = datas.TopicName});

                        System.Console.WriteLine("TRAINEE ID: {0} \nTRAINEE NAME: {1}",details.TraineeId, details.TraineeName);
                        foreach(var show in result)
                        {
                            System.Console.WriteLine(show.Exercise + "  "+ show.mark);
                        }
                        System.Console.WriteLine();
                    }

    
                    break;
                }

                case 8:
                {   
                    TraineeData data = new TraineeData();
                    List<TraineeDetails> traineeDataList = data.GetTraineeDetails();
                    
                    IEnumerable<int> result  = ( from d in traineeDataList select d.YearPassedOut ).Distinct();

                    foreach(int value in result)
                    {
                        System.Console.WriteLine(value);
                    }
                    break;
                }

                case 9:
                {   
                    TraineeData obj = new TraineeData();
                    List<TraineeDetails> traineeDataList = obj.GetTraineeDetails();
                    int sum = 0;

                    System.Console.Write("Enter Trainee ID: ");
                    string traineeid = Console.ReadLine();

                     List<int> result =  ( from data in traineeDataList 
                                    where data.TraineeId == traineeid 
                                    from value in data.ScoreDetails 
                                    select value.Mark ).ToList();                
                
                    sum = result.Sum();

                    System.Console.WriteLine($"Total Mark of {traineeid} is {sum}");
                    break;
                }

                case 10:
                {   
                    TraineeData obj = new TraineeData();
                    List<TraineeDetails> TraineeList = obj.GetTraineeDetails();

                    System.Console.WriteLine($"TraineeID: {TraineeList.First().TraineeId}");
                    System.Console.WriteLine($"TraineeName: {TraineeList.First().TraineeName}");
                    break;
                }

                case 11:
                {   
                    TraineeData obj = new TraineeData();
                    List<TraineeDetails> TraineeList = obj.GetTraineeDetails();

                    System.Console.WriteLine($"TraineeID: {TraineeList.Last().TraineeId}");
                    System.Console.WriteLine($"TraineeName: {TraineeList.Last().TraineeName}");
                    break;
                }

                case 12:
                {   
                    TraineeData obj = new TraineeData();
                    List<TraineeDetails> traineeDataList = obj.GetTraineeDetails();
                    
                    
                    IEnumerable<TraineeDetails> Query  = from data in traineeDataList select data;

                    foreach(var value in Query)
                    {   
                        int sum = 0;
                        foreach(var value1 in value.ScoreDetails)
                        {
                            sum += value1.Mark;
                        }
                        System.Console.WriteLine($"Total Mark of {value.TraineeId} is {sum}");
                        System.Console.WriteLine();
                    }

                    break;
                }

                case 13:
                {   
                    TraineeData obj = new TraineeData();
                    List<TraineeDetails> traineeDataList = obj.GetTraineeDetails();
                    
                    
                    IEnumerable<TraineeDetails> Query  = from data in traineeDataList select data;
                    int maxElement = 0;
                    foreach(var value in Query)
                    {   
                        int sum = 0;
                        foreach(var value1 in value.ScoreDetails)
                        {
                            sum += value1.Mark;
                        }
                        if(maxElement < sum)
                        {
                            maxElement = sum;
                        }
                    }

                    System.Console.WriteLine($"The Maximum Score is {maxElement}");
                    break;
                }

                case 14:
                {   
                    TraineeData obj = new TraineeData();
                    List<TraineeDetails> traineeDataList = obj.GetTraineeDetails();
                    
                    
                    IEnumerable<TraineeDetails> Query  = from data in traineeDataList select data;
                    List<int> minList = new List<int>();
                    foreach(var value in Query)
                    {   
                        int sum = 0;
                        foreach(var value1 in value.ScoreDetails)
                        {
                            sum += value1.Mark;
                        }
                        minList.Add(sum);
                       
                    }
                     int minElement = minList.Min();
                    System.Console.WriteLine($"The Minimum Score is {minElement}");
                    break;
                }

                case 15:
                {   

                    TraineeData obj = new TraineeData();
                    List<TraineeDetails> traineeDataList = obj.GetTraineeDetails();

                    IEnumerable<TraineeScore> result = ( from data in traineeDataList 
                                                        from data1 in data.ScoreDetails
                                                        select data1 );
                    double avg = result.Average(s => s.Mark);
                    
                    System.Console.WriteLine($"Average {avg}");
                    break;
                }

                case 16:
                {   
                    TraineeData obj = new TraineeData();
                    List<TraineeDetails> traineeDataList = obj.GetTraineeDetails();
                    
                    
                    IEnumerable<TraineeDetails> Query  = from data in traineeDataList select data;
                    List<int> traineeScoresList = new List<int>();

                    foreach(var value in Query)
                    {   
                        int sum = 0;
                        foreach(var value1 in value.ScoreDetails)
                        {
                            sum += value1.Mark;
                        }

                        traineeScoresList.Add(sum);
                    }
                    bool result = traineeScoresList.Any(s => s > 40);
                    System.Console.WriteLine($"If any one has more than 40 score: {result}");

                    break;
                }

                case 17:
                {   
                    TraineeData obj = new TraineeData();
                    List<TraineeDetails> traineeDataList = obj.GetTraineeDetails();
                    
                    
                    IEnumerable<TraineeDetails> Query  = from data in traineeDataList select data;
                    List<int> traineeScoresList = new List<int>();

                    foreach(var value in Query)
                    {   
                        int sum = 0;
                        foreach(var value1 in value.ScoreDetails)
                        {
                            sum += value1.Mark;
                        }

                        traineeScoresList.Add(sum);
                    }
                    bool result = traineeScoresList.All(s => s > 20);
                    System.Console.WriteLine($"If all of them have more than 20 score: {result}");
                    break;
                }

                case 18:
                {   
                    /* TraineeData data = new TraineeData();
                    TraineeDetails traineeData = new TraineeDetails();
                    List<TraineeDetails> traineeDataList = data.GetTraineeDetails();
                    List<TraineeScore> traineeScoreList = traineeData.ScoreDetails;

                    IEnumerable<TraineeDetails> QueryResult = (from data1 in  traineeDataList orderby data1.TraineeName ascending select data1);

                    for(int i=0; i<QueryResult.Count();i++)
                    {
                        System.Console.WriteLine($"TraineeName: {QueryResult.ElementAt(i).TraineeName}");
                        System.Console.WriteLine($"TraineeID: {QueryResult.ElementAt(i).TraineeId}");
                        for(int j =0; j<QueryResult.ElementAt(i).ScoreDetails.Count(); i++)
                        {
                            System.Console.WriteLine($"Topic Name: {QueryResult.ElementAt(i).ScoreDetails[j].TopicName}");
                            System.Console.WriteLine($"Exercise Name: {QueryResult.ElementAt(i).ScoreDetails[j].ExerciseName}");
                            System.Console.WriteLine($"Mark: {QueryResult.ElementAt(i).ScoreDetails[j].Mark}");
                        }
                    } */

                    TraineeData data = new TraineeData();
                    List<TraineeDetails> traineeDataList = data.GetTraineeDetails();

                   var result = from data1 in traineeDataList 
                                from data2 in data1.ScoreDetails
                                .OrderBy(s => data1.TraineeName).ThenBy(s => s.Mark)
                                select ( new 
                                {
                                    ID = data1.TraineeId, 
                                    name = data1.TraineeName,
                                    topic = data2.TopicName,
                                    exName = data2.ExerciseName,
                                    rMark = data2.Mark
                                });


                    foreach(var value in result)
                    {
                        System.Console.WriteLine($"{value.ID} {value.name} {value.topic} {value.exName} {value.rMark}");
                    }
                    break;


                }

                default:
                {   
                    System.Console.WriteLine("Invalid Option Selected");
                    break;
                }
            }

        }
    }
}
