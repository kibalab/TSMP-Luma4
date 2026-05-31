using UnityEngine;

namespace K13A.TSMP
{
    [AddComponentMenu("TSMP/Codecs/Luma4 Codec")]
    public sealed class TSMPCodecLuma4 : TSMPCodec
    {
        public Material byteDecodeMaterial;

#if !COMPILER_UDONSHARP
        public override int SymbolMode => (int)K13A.TSMP.SymbolMode.Luma4;
        public override int GetPayloadStartRow(int width, int blockSize) => Luma4Raster.PayloadStartRow;
        public override int GetPayloadCapacityBytes(int width, int height, int blockSize) => Luma4Raster.GetPayloadCapacityBytes(width, height, blockSize);
        public override int GetPayloadBlocksForBytes(int byteCount) => byteCount * 2;

        public override bool TryWriteFrame(Texture2D texture, int blockSize, byte[] headerBytes, byte[] payloadBytes, out string error)
        {
            return Luma4Raster.TryWriteFrame(texture, blockSize, headerBytes, payloadBytes, out error);
        }

        public override byte[] GetCodecOptionBytes() => null;
        public override int DecodeMaterialCount => byteDecodeMaterial != null ? 1 : 0;
        public override Material GetDecodeMaterial(int index) => index == 0 ? byteDecodeMaterial : null;
#endif

        public override void ApplyDecodeOptions()
        {
            selectedDecodeMaterial = byteDecodeMaterial;
            payloadStartRow = 5;
            payloadBlockCount = byteCount * 2;
        }
    }
}
