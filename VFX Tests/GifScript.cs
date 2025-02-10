using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Mono.Security.Authenticode;
using SimpleGif;
using SimpleGif.Data;
using UnityEngine;
using Debug = UnityEngine.Debug;
using Texture2D = UnityEngine.Texture2D;

namespace WildfrostHopeMod
{
    internal class Program
    {
        private const string Path = "Panda.gif";

        public static void Main()
        {
            //var gif = DecodeExample();
            //var binary = EncodeExample(gif);
            var gif = DecodeParallelExample();
            var binary = EncodeParallelExample(gif);
            var path = Path.Replace(".gif", "_.gif");

            File.WriteAllBytes(path, binary);
        }

        public static Gif DecodeExample()
        {
            var bytes = File.ReadAllBytes(Path);
            var stopwatch = new Stopwatch();

            stopwatch.Start();

            var gif = Gif.Decode(bytes);

            stopwatch.Stop();

            Debug.LogFormat("GIF loaded in {0:n2}s, size: {1}x{2}, frames: {3}.", stopwatch.Elapsed.TotalSeconds,
                gif.Frames[0].Texture.width, gif.Frames[0].Texture.height, gif.Frames.Count);

            return gif;
        }

        public static byte[] EncodeExample(Gif gif)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();

            var binary = gif.Encode();

            stopwatch.Stop();

            Debug.LogFormat("GIF encoded in {0:n2}s to binary.", stopwatch.Elapsed.TotalSeconds);

            return binary;
        }

        public static void EncodeDecodeSaveTest()
        {
            var gif = DecodeExample();
            var stopwatch = new Stopwatch();

            stopwatch.Start();

            var binary = gif.Encode();

            stopwatch.Stop();

            Debug.LogFormat("GIF encoded in {0:n2}s to binary.", stopwatch.Elapsed.TotalSeconds);

            stopwatch.Reset();
            stopwatch.Start();

            Gif.Decode(binary);

            Debug.LogFormat("GIF loaded from binary in {0:n2}s.", stopwatch.Elapsed.TotalSeconds);

            var path = Path.Replace(".gif", "_.gif");

            File.WriteAllBytes(path, binary);

            Debug.LogFormat("GIF saved as {0}.", path);
            Debug.LogFormat("Test passed!");
        }

        /// <summary>
        /// Iterator can be used for large GIF-files in order to display progress bar.
        /// </summary>
        public static Gif DecodeIteratorExample()
        {
            var bytes = File.ReadAllBytes(Path);
            var parts = Gif.DecodeIterator(bytes);
            var frames = new List<GifFrame>();
            var stopwatch = new Stopwatch();
            var index = 0;
            var time = 0d;

            stopwatch.Start();

            foreach (var frame in parts)
            {
                frames.Add(frame);
                stopwatch.Stop();
                time += stopwatch.Elapsed.TotalSeconds;

                Debug.LogFormat("GIF frame #{0} loaded in {1:n4}s", index++, stopwatch.Elapsed.TotalSeconds);

                stopwatch.Reset();
                stopwatch.Start();
            }

            Debug.LogFormat("GIF loaded with iterator in {0:n4}s", time);

            return new Gif(frames);
        }

        /// <summary>
        /// Iterator can be used for large GIF-files in order to display progress bar.
        /// </summary>
        public static byte[] EncodeIteratorExample(Gif gif)
        {
            var bytes = new List<byte>();
            var parts = gif.EncodeIterator();
            var iteratorSize = gif.GetEncodeIteratorSize();
            var stopwatch = new Stopwatch();
            var index = 0;
            var time = 0d;

            stopwatch.Start();

            foreach (var part in parts)
            {
                if (index == iteratorSize - 1) // GIF header should be placed to sequence start!
                {
                    bytes.InsertRange(0, part);
                }
                else
                {
                    bytes.AddRange(part);
                }

                stopwatch.Stop();
                time += stopwatch.Elapsed.TotalSeconds;

                Debug.LogFormat("GIF part #{0} encoded in {1:n4}s", index++, stopwatch.Elapsed.TotalSeconds);

                stopwatch.Reset();
                stopwatch.Start();
            }

            Debug.LogFormat("GIF encoded with iterator in {0:n4}s", time);

            return bytes.ToArray();
        }

        public static Gif DecodeParallelExample()
        {
            var bytes = File.ReadAllBytes(Path);
            var stopwatch = new Stopwatch();

            stopwatch.Start();

            var decodeProgress = new DecodeProgress();

            Gif.DecodeParallel(bytes, progress =>
            {
                Debug.LogFormat("Decode progress: {0}/{1}", progress.Progress, progress.FrameCount);
                decodeProgress = progress;
            });

            while (decodeProgress.Exception == null && !decodeProgress.Completed)
            {
                Thread.Sleep(100);
            }

            if (decodeProgress.Exception != null) throw decodeProgress.Exception;

            stopwatch.Stop();

            var gif = decodeProgress.Gif;

            if (gif != null)
            {
                Debug.LogFormat("GIF decoded in {0:n2}s, size: {1}x{2}, frames: {3}.", stopwatch.Elapsed.TotalSeconds,
                    gif.Frames[0].Texture.width, gif.Frames[0].Texture.height, gif.Frames.Count);
            }

            return gif;
        }

        public static byte[] EncodeParallelExample(Gif gif)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();

            var encodeProgress = new EncodeProgress();

            gif.EncodeParallel(progress =>
            {
                Debug.LogFormat("Encode progress: {0}/{1}", progress.Progress, progress.FrameCount);
                encodeProgress = progress;
            });

            while (!encodeProgress.Completed)
            {
                Thread.Sleep(100);
            }

            if (encodeProgress.Exception != null) throw encodeProgress.Exception;

            stopwatch.Stop();

            Debug.LogFormat("GIF encoded in {0:n2}s to binary.", stopwatch.Elapsed.TotalSeconds);

            return encodeProgress.Bytes;
        }
    }

    public class Hopetest : MonoBehaviour
    {
        public void Start()
        {
            Animator animator = GetComponent<Animator>();

            AnimationClip clip = new AnimationClip();
            clip.name = "TrialGIF";
        }

        public static void Main()
        {
            var path = Path.Combine(HopeMod.Paths.PluginPath, "point_vanish.gif");
            var gif = Gif.Decode(File.ReadAllBytes(path));


            
        }
    }

}