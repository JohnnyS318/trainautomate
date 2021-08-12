using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainautomate.Models
{

    public class TrackNode : ITrackNode
    {

        private ITrackNode _neighbour;

        public string ID { get; set; }
        public Position Position { get; set; }


        public bool AddNode(ITrackNode node)
        {
            if(_neighbour != null)
            {
                _neighbour = node;
                return true;
            }

            return false;
        }

        public ITrackNode GetNeighbour()
        {
            return _neighbour;
        }

        public List<ITrackNode> GetNeighbours()
        {
            var list = new List<ITrackNode>();
            if (_neighbour != null)
            {
                list.Add(_neighbour);
            }
            return list;

        }
    }
}
