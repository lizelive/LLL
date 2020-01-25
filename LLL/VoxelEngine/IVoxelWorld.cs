using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.Serialization;
using System.Text;

namespace LLL.VoxelEngine
{
    public class BlockRepo
    {
        IBlock block;
    }

    public struct WorldPos { }
    public interface IEntity { }


    public interface ITessalator
    {

    }


    public readonly ref struct BlockInstance{
        public readonly IVoxelWorld world;
        public readonly WorldPos positon;
        public readonly IBlockState state;
        public readonly ITiledata data;
    }

    public struct AABB { Vector3 min, max; }

    public interface IBlock {
        string[] Tags { get; }
        AABB Colider { get; }
        bool IsSolid { get; }
        bool HasTiledata { get; }
        void Tick(BlockInstance self);
        void Blockupdate(BlockInstance self);
        bool OnPlace(BlockInstance self, IEntity placer);
        void Render(BlockInstance self, ITessalator tessalator);
    }

    public interface WorldCords { }
    public interface BlockCords { }
    public interface IBlockState {
        IBlock Block { get; set; }
        int Light { get; set; }
        string AsString();
        void FromSting(string data);
        uint AsInt();
        dynamic Data { get; set; }
        string GetProp(string name);
        string SetProp(string name, string value);
    }
    public interface ITiledata { }
    public interface IVoxelWorld : ISerializable
    {
        IEnumerable<IEntity> ChunkLoaders { get; set; }
        IEnumerable<IEntity> Entities { get;  }
        IEnumerable<IEntity> GetNearby(WorldPos pos, float range);
        IBlockState SetBlock(WorldPos pos, IBlockState block);
        IBlockState GetBlock(WorldPos pos);
        ITiledata GetTiledata(WorldPos pos);

        bool Raycast(WorldPos from, Vector3 forward);

        bool IsChunkLoaded(WorldPos pos);
        void LoadChunk(WorldPos pos);
    }
}
