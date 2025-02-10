using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LibAPNG
{
    /// <summary>
    ///     Describe a single frame.
    /// </summary>
    public class Frame
    {
        public static byte[] Signature = {0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A};

        private List<IDATChunk> idatChunks = new List<IDATChunk>();
        private List<OtherChunk> otherChunks = new List<OtherChunk>();

        /// <summary>
        ///     Gets or Sets the acTL chunk
        /// </summary>
        public IHDRChunk IHDRChunk { get; set; }

        /// <summary>
        ///     Gets or Sets the fcTL chunk
        /// </summary>
        public fcTLChunk fcTLChunk { get; set; }

        /// <summary>
        ///     Gets or Sets the IEND chunk
        /// </summary>
        public IENDChunk IENDChunk { get; set; }

        /// <summary>
        ///     Gets or Sets the other chunks
        /// </summary>
        public List<OtherChunk> OtherChunks
        {
            get { return otherChunks; }
            set { otherChunks = value; }
        }

        /// <summary>
        ///     Gets or Sets the IDAT chunks
        /// </summary>
        public List<IDATChunk> IDATChunks
        {
            get { return idatChunks; }
            set { idatChunks = value; }
        }

        /// <summary>
        ///     Add an Chunk to end end of existing list.
        /// </summary>
        public void AddOtherChunk(OtherChunk chunk)
        {
            otherChunks.Add(chunk);
        }

        /// <summary>
        ///     Add an IDAT Chunk to end end of existing list.
        /// </summary>
        public void AddIDATChunk(IDATChunk chunk)
        {
            idatChunks.Add(chunk);
        }

        /// <summary>
        ///     Gets the frame as PNG FileStream.
        /// </summary>
        public MemoryStream GetStream(bool useFCTLChunk = false)
        {
            var ihdrChunk = new IHDRChunk(IHDRChunk);
            if (fcTLChunk != null && useFCTLChunk)
            {
                // Fix frame size with fcTL data.
                ihdrChunk.ModifyChunkData(0, Helper.ConvertEndian(fcTLChunk.Width));
                ihdrChunk.ModifyChunkData(4, Helper.ConvertEndian(fcTLChunk.Height));
            }

            // Write image data
            using (var ms = new MemoryStream())
            {
                ms.WriteBytes(Signature);
                ms.WriteBytes(ihdrChunk.RawData);
                otherChunks.ForEach(o => ms.WriteBytes(o.RawData));
                idatChunks.ForEach(i => ms.WriteBytes(i.RawData));
                ms.WriteBytes(IENDChunk.RawData);

                ms.Position = 0;
                return ms;
            }
        }
        /// <summary>
        ///     Gets the frame as PNG MemoryStream.
        /// </summary>
        /// <returns></returns>
        public MemoryStream GetStream2(bool useFCTLChunk = false)
        {
            using (var ms = new MemoryStream())
            {
                // Write the PNG signature
                ms.WriteBytes(Signature);

                // Write the IHDR chunk using the original dimensions
                ms.WriteBytes(IHDRChunk.RawData);

                // Write the other chunks
                otherChunks.ForEach(o => ms.WriteBytes(o.RawData));

                // Write the IDAT chunks
                if (fcTLChunk != null)
                {
                    // Use the fcTL chunk to determine the frame dimensions and offsets
                    int frameWidth = (int)fcTLChunk.Width;
                    int frameHeight = (int)fcTLChunk.Height;
                    int xOffset = (int)fcTLChunk.XOffset;
                    int yOffset = (int)fcTLChunk.YOffset;

                    // Create a new byte array to hold the frame data
                    byte[] frameData = new byte[frameWidth * frameHeight * 4];

                    // Create a new byte array to hold the original IDAT chunk bytes
                    byte[] idatBytes = idatChunks.SelectMany(i => i.RawData).ToArray();

                    // Copy the IDAT data into the frame, filling the padded areas with transparent pixels
                    int dataIndex = 0;
                    for (int y = 0; y < frameHeight; y++)
                    {
                        for (int x = 0; x < frameWidth; x++)
                        {
                            if (x >= xOffset && x < xOffset + IHDRChunk.Width && y >= yOffset && y < yOffset + IHDRChunk.Height)
                            {
                                // Copy the pixel data from the IDAT chunks
                                frameData[dataIndex++] = idatBytes[dataIndex];
                                frameData[dataIndex++] = idatBytes[dataIndex];
                                frameData[dataIndex++] = idatBytes[dataIndex];
                                frameData[dataIndex++] = idatBytes[dataIndex];
                            }
                            else
                            {
                                // Fill the padded area with transparent pixels
                                frameData[dataIndex++] = 0;
                                frameData[dataIndex++] = 0;
                                frameData[dataIndex++] = 0;
                                frameData[dataIndex++] = 0;
                            }
                        }
                    }

                    // Write the frame data to the IDAT chunk
                    var frameIDAT = new IDATChunk(frameData);
                    ms.WriteBytes(frameIDAT.RawData);
                }
                else
                {
                    // Write the original IDAT chunks
                    idatChunks.ForEach(i => ms.WriteBytes(i.RawData));
                }

                // Write the IEND chunk
                ms.WriteBytes(IENDChunk.RawData);

                // Reset the position to the beginning of the MemoryStream
                ms.Position = 0;
                return ms;
            }
        }
    }
}