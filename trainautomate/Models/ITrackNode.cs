using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainautomate.Models
{


    public struct TrackConnection
    {
        public ITrackNode Node { get; set; }

        public TrackEdgeBase Edge { get; set; }
    }


    public interface ITrackNode
    {
        public string ID { get; set; }

        public Position Position { get; set; }


        public List<ITrackNode> GetNeighbours();

        public ITrackNode GetNeighbour();

        public bool AddNode(ITrackNode node);

    }
}
