using System;
using Microsoft.ML;
using System.Collections.Generic;
using Microsoft.ML.Runtime.Data;
using Microsoft.ML.Runtime.Api;

namespace Machine_Learning
{
    class FeedBackTrainingData
    {
        [Column(ordinal: "0", name: "Label")]
        public bool IsGood { get; set; }                    
        [Column(ordinal:"1")]
        public string FeedBackText { get; set; }
    }
    class FeedBackPrediction
    {
        [ColumnName("PredictedLabel")]
        public bool IsGood { get; set; }
    }
    class Program
    {
        static List<FeedBackTrainingData> trainingData = new List<FeedBackTrainingData>();
        static void LoadTrainingData()
        {
            trainingData.Add(new FeedBackTrainingData
            {
                FeedBackText = "this is good",
                IsGood=true
            }) ;
            trainingData.Add(new FeedBackTrainingData
            {
                FeedBackText = "this is bad",
                IsGood = false
            });

            trainingData.Add(new FeedBackTrainingData
            {
                FeedBackText = "this is horrible",
                IsGood = false
            });
            trainingData.Add(new FeedBackTrainingData
            {
                FeedBackText = "average and ok",
                IsGood = true
            });
            trainingData.Add(new FeedBackTrainingData
            {
                FeedBackText = "bad and hell",
                IsGood = false
            });
            trainingData.Add(new FeedBackTrainingData
            {
                FeedBackText = "this is nice but better can be done",
                IsGood = true
            });
            trainingData.Add(new FeedBackTrainingData
            {
                FeedBackText = "bad bad",
                IsGood = false
            });
            trainingData.Add(new FeedBackTrainingData
            {
                FeedBackText = "till now it looks nice",
                IsGood = true
            });
            trainingData.Add(new FeedBackTrainingData
            {
                FeedBackText = "horrible terrible",
                IsGood = false
            });
            trainingData.Add(new FeedBackTrainingData
            {
                FeedBackText = "it was boring",
                IsGood = false
            });
        }

        static List<FeedBackTrainingData> testData = new List<FeedBackTrainingData>();
        static void LoadTestData()
        {
            testData.Add(new FeedBackTrainingData
            {
                FeedBackText = "good",
                IsGood = true
            });
            testData.Add(new FeedBackTrainingData
            {
                FeedBackText = "bad",
                IsGood = false
            });

            testData.Add(new FeedBackTrainingData
            {
                FeedBackText = "horrible",
                IsGood = false
            });
                   testData.Add(new FeedBackTrainingData
                   {
                       FeedBackText = "horrible terrible",
                       IsGood = false
                   });
            testData.Add(new FeedBackTrainingData
            {
                FeedBackText = "average and ok",
                IsGood = true
            });
            testData.Add(new FeedBackTrainingData
             {
                FeedBackText = "bad and hell",
                IsGood = false
            });
            //6 load the testdata and run the testdata
            //and check the model

            testData.Add(new FeedBackTrainingData
            {
                FeedBackText = "this is nice but better can be done",
                IsGood = true
            });
            testData.Add(new FeedBackTrainingData
            {
                FeedBackText = "bad bad",
                IsGood = false
            });
            testData.Add(new FeedBackTrainingData
            {
                FeedBackText = "till now it looks nice",
                IsGood = true
            });

            testData.Add(new FeedBackTrainingData
            {
                FeedBackText = "boring",
                IsGood = false
            });
        }
        static void Main(string[] args)
        {
            //1 - load training data
            LoadTrainingData();
            //2 - create object of mlcontext
            var mlContext = new MLContext();
            //3 - convert your data to idataview
            IDataView dataView = mlContext.CreateStreamingDataView<FeedBackTrainingData>(trainingData);
            //4- create the pipeline
            //define the workflow in it
            var pipeline = mlContext.Transforms.Text.FeaturizeText("FeedBackText", "Features")
                .Append(mlContext.BinaryClassification.Trainers.FastTree
                (numLeaves: 50, numTrees: 50, minDatapointsInLeaves: 1));
            //5 training the algorithm and we want the model out
            var model = pipeline.Fit(dataView);
            //6 load the test data to check model accuracy
            LoadTestData();
            IDataView dataView1 = mlContext.CreateStreamingDataView<FeedBackTrainingData>(testData);
            var predictions = model.Transform(dataView1);
            var metrics = mlContext.BinaryClassification.Evaluate(predictions, "Label");
            Console.WriteLine(metrics.Accuracy);

            //using the model
            string ans = "y";
            while (ans == "y")
            {
                Console.WriteLine("enter feedback string");
                string feedbackstring = Console.ReadLine();

                var predictionFunction = model.MakePredictionFunction<FeedBackTrainingData, FeedBackPrediction>(mlContext);
                var feedbackinput = new FeedBackTrainingData();
                feedbackinput.FeedBackText = feedbackstring;
                var feedbackpredicted = predictionFunction.Predict(feedbackinput);

                Console.WriteLine("predicted :-" + feedbackpredicted.IsGood);
                Console.WriteLine("do you want to continue press y");
                ans = Console.ReadLine();
            }

            Console.ReadLine();     
        }
    }
}
