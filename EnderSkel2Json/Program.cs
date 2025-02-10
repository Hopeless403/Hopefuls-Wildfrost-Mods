using Spine;

using System;
using System.Collections.Generic;
using System.IO;
/*using System.Web.Script.Serialization;*/
using BinToJson;
using System.Diagnostics;
using System.Text.Json;
using System.Text;

namespace BIN2JSON
{
    class Program
    {
        // Change It as the Char Name.
        private static string _BoneName = "22";
        private static string fileName;
        private static string ext;

        private static void Test(params object[] args)
        {
            return;
        }

        private static bool ProcessSkel(string _BoneName)
        {
            
            // Creat SkelData
            SkeletonData skeletonData;
            try
            {
                Console.WriteLine("Trying to get textureloader");
                TextureLoader textureLoader = new DemoLoader();
                Console.WriteLine("Trying to get atlas");
                Atlas atlas = new Atlas(_BoneName + ".atlas", textureLoader);
                Console.WriteLine("Trying to get att");
                AtlasAttachmentLoader attachmentLoader = new AtlasAttachmentLoader(atlas);
                Console.WriteLine("Trying to get bin");
                SkeletonBinary skeletonBinary = new SkeletonBinary(attachmentLoader);
                Console.WriteLine("Trying to get data");
                skeletonData = skeletonBinary.ReadSkeletonData(_BoneName + ".skel");
                Console.WriteLine("Trying to get nothin");
            }
            catch (Exception)
            {
                Console.WriteLine("File Read Error.");
                Console.ReadKey();
                return false;
            }

            // Test the SkelData.
            Console.WriteLine("The spine version: \t" + skeletonData.Version);
            Console.WriteLine("The bones name: \t" + skeletonData.Name);


            foreach (var skin in skeletonData.Skins)
            {
                foreach (var slot in skeletonData.Slots)
                {
                    var attachment = skin.GetAttachments();
                    if (attachment is BoundingBoxAttachment boundingBoxAttachment)
                    {
                        float[] verts = boundingBoxAttachment.Vertices;
                        for (int i = 0; i < verts.Length; i++)
                        {
                            Console.WriteLine($"{skin.Name} {slot.Name} ({verts[i]},{verts[i + 1]}");
                        }
                    }
                }
            }

            Dictionary<string, object> jsonFile = SkelDataConverter.FromSkeletonData(skeletonData);
            //foreach (var pair in jsonFile)
            //    Console.WriteLine($"{pair.Key} goes with {pair.Value}");
            //Console.WriteLine(pair.Name + pair.Duration);

            /*#region JSON File Create
            // Takes the skeletonData and converts it into a serializable object
            Dictionary<string, object> jsonFile = SkelDataConverter.FromSkeletonData(skeletonData);

            //convert object to json string for storing
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            string json = jsonSerializer.Serialize(jsonFile);
            File.WriteAllText(_BoneName + ".json", json);
            #endregion*/
            string jsonString = JsonSerializer.Serialize(jsonFile);
            File.WriteAllText(_BoneName + ".json", jsonString);
            /*Console.WriteLine("Json File Create Successfully.");
            Console.ReadKey();*/
            return true;
        }

        static void Main(string[] args)
        {
            #region Copy With Args
            Console.WriteLine("Spine Binary to Json Start.");
            if (args.Length > 0)
            {
                foreach (var path in args)
                    General(path);
            }
            else
            {
                Console.WriteLine("No files provided! Closing program...");
                Console.ReadKey();
                return;
            }
            Console.ReadKey();
        }

        private static void General(string path)
        {
            ext = Path.GetExtension(path).Trim();
            fileName = Path.GetFileNameWithoutExtension(path);
            _BoneName = path.Replace($"{ext}", "");
            Console.WriteLine(path);

            Console.WriteLine($"this is a {ext} for {_BoneName}");
            switch (ext)
            {
                case ".skel":
                    if (ProcessSkel(_BoneName))
                        Console.WriteLine("done " + _BoneName);
                    break;
                case ".uasset":
                    FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(file);

                    var lines = File.ReadAllLines(path);
                    var atlasindex = Array.FindIndex(lines, l => l.Contains(".png"));
                    var skelindex = Array.FindLastIndex(lines, l => l.Contains("index:"));

                    var all = File.ReadAllBytes(path);
                    var version = Convert.ToHexString(all).IndexOf("332E382E3939") / 2;
                    var start = all[..version].ToList().FindLastIndex(b => Convert.ToHexString(new byte[1] { b }) == "1C");

                    Console.WriteLine(version);
                    Console.WriteLine(all[..version].ToList().FindLastIndex(b => Convert.ToHexString(new byte[1] { b }) == "1C"));

                    File.WriteAllBytes(_BoneName + ".skel", all[start..]);
                    File.WriteAllLines(_BoneName + ".atlas", lines[atlasindex..skelindex]);
                    break;
            }
        }
    }

    // False Class
    class DemoLoader : TextureLoader
    {
        public void Load(AtlasPage page, string path)
        {
            //throw new NotImplementedException();
            return;
        }

        public void Unload(object texture)
        {
            //throw new NotImplementedException();
            return;
        }
    }
}