using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Azure.CognitiveServices.Vision.Face;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;
using System.Threading;

namespace LayOut_Wall_i
{
    class GezichtsHerkenner
    {
        const string SubscriptionKey = "27dd6d32ac02424081821ce2bfd921d6";
        const string EndPoint = "https://workmatefaceapi.cognitiveservices.azure.com/";
        const string recognitionModel = RecognitionModel.Recognition04;
        public IFaceClient Client;
        public bool Verificatie { get; set; }
        private bool verificatie;
        public GezichtsHerkenner()
        {
            Verificatie = false;
        }
        public void Connect()
        {
            Client = new FaceClient(new ApiKeyServiceClientCredentials(SubscriptionKey)) { Endpoint = EndPoint };
        }

        private static async Task<List<DetectedFace>> DetectFaceRecognize(IFaceClient faceClient, string url, string recognition_model)
        {
            // Herken gezichten uit url.
            IList<DetectedFace> detectedFaces = await faceClient.Face.DetectWithUrlAsync(url, recognitionModel: recognition_model, detectionModel: DetectionModel.Detection03);
            Console.WriteLine($"{detectedFaces.Count} face(s) detected from image `{Path.GetFileName(url)}`");
            return detectedFaces.ToList();
        }

        public static async Task DetectFaceExtractFile(IFaceClient client, Stream image, string recognitionModel)
        {
            Console.WriteLine("========DETECTEER GEZICHTEN========");
            Console.WriteLine();

            //maak een lijst van foto's
            List<string> imageFileNames = new List<string>
                            {
                                "detection1.jpg",    // single female with glasses
								// "detection2.jpg", // (optional: single man)
								// "detection3.jpg", // (optional: single male construction worker)
								// "detection4.jpg", // (optional: 3 people at cafe, 1 is blurred)
								"detection5.jpg",    // family, woman child man
								"detection6.jpg"     // elderly couple, male female
							};

            foreach (var imageFileName in imageFileNames)
            {
                IList<DetectedFace> detectedFaces;

                //detecteer gezichten met attributen
                detectedFaces = await client.Face.DetectWithStreamAsync(image,
                    returnFaceAttributes: new List<FaceAttributeType> { FaceAttributeType.Accessories, FaceAttributeType.Age,
                        FaceAttributeType.Blur, FaceAttributeType.Emotion, FaceAttributeType.Exposure, FaceAttributeType.FacialHair,
                        FaceAttributeType.Gender, FaceAttributeType.Glasses, FaceAttributeType.Hair, FaceAttributeType.HeadPose,
                        FaceAttributeType.Makeup, FaceAttributeType.Noise, FaceAttributeType.Occlusion, FaceAttributeType.Smile },
                        detectionModel: DetectionModel.Detection01,
                        recognitionModel: recognitionModel);


                Console.WriteLine($"{detectedFaces.Count} face(s) detected from image `{imageFileName}`.");
                foreach (var face in detectedFaces)
                {
                    Console.WriteLine($"Face attributes for {imageFileName}:");
                    Console.WriteLine($"Rectangle(Left/Top/Width/Height) : {face.FaceRectangle.Left} {face.FaceRectangle.Top} {face.FaceRectangle.Width} {face.FaceRectangle.Height}");

                    // kijkt of er accesoires zijn in de foto
                    List<Accessory> accessoriesList = (List<Accessory>)face.FaceAttributes.Accessories;
                    int count = face.FaceAttributes.Accessories.Count;
                    string accessory; string[] accessoryArray = new string[count];
                    if (count == 0) { accessory = "NoAccessories"; }
                    else
                    {
                        for (int i = 0; i < count; ++i) { accessoryArray[i] = accessoriesList[i].Type.ToString(); }
                        accessory = string.Join(",", accessoryArray);
                    }
                    Console.WriteLine($"Accessories : {accessory}");

                    // ander gezichts eigenschappen
                    Console.WriteLine($"Age : {face.FaceAttributes.Age}");
                    Console.WriteLine($"Blur : {face.FaceAttributes.Blur.BlurLevel}");

                    //haalt emotie op
                    string emotionType = string.Empty;
                    double emotionValue = 0.0;
                    Emotion emotion = face.FaceAttributes.Emotion;
                    if (emotion.Anger > emotionValue) { emotionValue = emotion.Anger; emotionType = "Anger"; }
                    if (emotion.Contempt > emotionValue) { emotionValue = emotion.Contempt; emotionType = "Contempt"; }
                    if (emotion.Disgust > emotionValue) { emotionValue = emotion.Disgust; emotionType = "Disgust"; }
                    if (emotion.Fear > emotionValue) { emotionValue = emotion.Fear; emotionType = "Fear"; }
                    if (emotion.Happiness > emotionValue) { emotionValue = emotion.Happiness; emotionType = "Happiness"; }
                    if (emotion.Neutral > emotionValue) { emotionValue = emotion.Neutral; emotionType = "Neutral"; }
                    if (emotion.Sadness > emotionValue) { emotionValue = emotion.Sadness; emotionType = "Sadness"; }
                    if (emotion.Surprise > emotionValue) { emotionType = "Surprise"; }
                    Console.WriteLine($"Emotion : {emotionType}");

                    //nog meer gezichts eigenschappen ophalen
                    Console.WriteLine($"Exposure : {face.FaceAttributes.Exposure.ExposureLevel}");
                    Console.WriteLine($"FacialHair : {string.Format("{0}", face.FaceAttributes.FacialHair.Moustache + face.FaceAttributes.FacialHair.Beard + face.FaceAttributes.FacialHair.Sideburns > 0 ? "Yes" : "No")}");
                    Console.WriteLine($"Gender : {face.FaceAttributes.Gender}");
                    Console.WriteLine($"Glasses : {face.FaceAttributes.Glasses}");

                    //haarkleur ophalen
                    Hair hair = face.FaceAttributes.Hair;
                    string color = null;
                    if (hair.HairColor.Count == 0) { if (hair.Invisible) { color = "Invisible"; } else { color = "Bald"; } }
                    HairColorType returnColor = HairColorType.Unknown;
                    double maxConfidence = 0.0f;
                    foreach (HairColor hairColor in hair.HairColor)
                    {
                        if (hairColor.Confidence <= maxConfidence) { continue; }
                        maxConfidence = hairColor.Confidence; returnColor = hairColor.Color; color = returnColor.ToString();
                    }
                    Console.WriteLine($"Hair : {color}");

                    //laatste gezichts eigenschappen
                    Console.WriteLine($"HeadPose : {string.Format("Pitch: {0}, Roll: {1}, Yaw: {2}", Math.Round(face.FaceAttributes.HeadPose.Pitch, 2), Math.Round(face.FaceAttributes.HeadPose.Roll, 2), Math.Round(face.FaceAttributes.HeadPose.Yaw, 2))}");
                    Console.WriteLine($"Makeup : {string.Format("{0}", (face.FaceAttributes.Makeup.EyeMakeup || face.FaceAttributes.Makeup.LipMakeup) ? "Yes" : "No")}");
                    Console.WriteLine($"Noise : {face.FaceAttributes.Noise.NoiseLevel}");
                    Console.WriteLine($"Occlusion : {string.Format("EyeOccluded: {0}", face.FaceAttributes.Occlusion.EyeOccluded ? "Yes" : "No")} " +
                        $" {string.Format("ForeheadOccluded: {0}", face.FaceAttributes.Occlusion.ForeheadOccluded ? "Yes" : "No")}   {string.Format("MouthOccluded: {0}", face.FaceAttributes.Occlusion.MouthOccluded ? "Yes" : "No")}");
                    Console.WriteLine($"Smile : {face.FaceAttributes.Smile}");
                    Console.WriteLine();
                }
            }
        }

        public static async Task<bool> VergelijkGroep(IFaceClient faceClient, string persionPicPath, String[] picsPath, string naam)
        {
            bool verificatie = false;
            Random rnd = new Random();
            //maakt randomgroep naam aan, want je kan niet 2x dezelfde naam hebben
            string groupname = "z" + rnd.Next(1, 900000).ToString();

            //maakt een lege persongroup
            Console.WriteLine("voorbereiden...");
            string personGroupId = groupname;
            faceClient.PersonGroup.CreateAsync(personGroupId, groupname + " group").GetAwaiter().GetResult();



            var createPersonResult = faceClient.PersonGroupPerson.CreateAsync(
                //id persongroup
                personGroupId,
                //naam van de persoon
                naam
            ).GetAwaiter().GetResult();


            using (Stream s = File.OpenRead(persionPicPath))
            {
                //detecteer gezichten uit de foto's
                faceClient.PersonGroupPerson.AddFaceFromStreamAsync(
                    personGroupId, createPersonResult.PersonId, s).GetAwaiter().GetResult();
            }

            //train de persongroup
            Console.WriteLine("starten...");
            faceClient.PersonGroup.TrainAsync(personGroupId).GetAwaiter().GetResult();


            //check de training status
            TrainingStatus trainingStatus = null;
            while (true)
            {
                trainingStatus = faceClient.PersonGroup.GetTrainingStatusAsync(personGroupId).GetAwaiter().GetResult();

                if (trainingStatus.Status != TrainingStatusType.Running)
                {
                    break;
                }
                Thread.Sleep(1000);
            }


            foreach (var pic in picsPath)
            {
                //voor elke foto uit de groep kijken of hij overeen komt met persoon
                Console.WriteLine("Identificatie van:" + pic);

                using (Stream s = File.OpenRead(pic))
                {
                    var faces = faceClient.Face.DetectWithStreamAsync(s).GetAwaiter().GetResult();
                    var faceIds = faces.Select(face => (Guid)face.FaceId).ToList();

                    var results = faceClient.Face.IdentifyAsync(faceIds, personGroupId).GetAwaiter().GetResult();
                    foreach (var identifyResult in results)
                    {
                        //laat zien of de foto en de persoon overeenkomen
                        if (identifyResult.Candidates.Count == 0)
                        {
                            Console.WriteLine("Geen overeenkomst");
                        }
                        else
                        {
                            
                            var candidateId = identifyResult.Candidates[0].PersonId;
                            var person = faceClient.PersonGroupPerson.GetAsync(personGroupId, candidateId).GetAwaiter().GetResult();
                            Console.WriteLine("Gezichten komen overeen");
                            //als de persoon gelijk is aan de persoon in de foto zet verificatie op waar
                            verificatie = true;
                        }
                    }

                }

            }
            //als verificatie waar is, is de gezichts verificatie gelukt
            return verificatie;
            Console.ReadKey();
        }
    }
}
