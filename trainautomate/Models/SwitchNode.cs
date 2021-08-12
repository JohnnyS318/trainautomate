using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainautomate.Models
{
    public class SwitchNode : ITrackNode
    {

        private Dictionary<ITrackNode, TrackEdgeBase> _edges;

        public int State { get; set; }
        public string ID { get; set; }
        public Position Position { get; set; }


        public List<ITrackNode> GetNeighbours()
        {
            throw new NotImplementedException();
        }

        public ITrackNode GetNeighbour()
        {
            throw new NotImplementedException();
        }

        public bool AddNode( node)
        {

        }
    }
}
